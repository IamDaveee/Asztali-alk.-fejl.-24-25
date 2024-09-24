from flask import Flask, render_template, request, redirect, url_for
import sqlite3
from datetime import datetime

app = Flask(__name__)

# Initialize SQLite database if not already created
def init_db():
    conn = sqlite3.connect('fuel.db')
    c = conn.cursor()
    c.execute('''
        CREATE TABLE IF NOT EXISTS tankolas (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            datum TEXT,
            liter REAL,
            osszeg REAL,
            kilometer INTEGER
        )
    ''')
    conn.commit()
    conn.close()

# Route for the main page: displays all refuel records and allows new entry
@app.route('/', methods=['GET', 'POST'])
def index():
    if request.method == 'POST':
        # Get input data from the form
        datum = request.form['datum']
        liter = float(request.form['liter'])
        osszeg = float(request.form['osszeg'])
        kilometer = int(request.form['kilometer'])
        
        # Insert the data into SQLite database
        conn = sqlite3.connect('fuel.db')
        c = conn.cursor()
        c.execute('INSERT INTO tankolas (datum, liter, osszeg, kilometer) VALUES (?, ?, ?, ?)', (datum, liter, osszeg, kilometer))
        conn.commit()
        conn.close()
        return redirect(url_for('index'))
    
    # Fetch all refuel records to display on the homepage
    conn = sqlite3.connect('fuel.db')
    c = conn.cursor()
    c.execute('SELECT * FROM tankolas ORDER BY datum DESC')
    tankolasok = c.fetchall()
    conn.close()

    return render_template('index.html', tankolasok=tankolasok)

# Route for showing total expenses per month
@app.route('/stat')
def stat():
    conn = sqlite3.connect('fuel.db')
    c = conn.cursor()
    # Group data by month and calculate total cost per month
    c.execute('''
        SELECT strftime('%Y-%m', datum) AS honap, SUM(osszeg) AS koltseg
        FROM tankolas
        GROUP BY honap
        ORDER BY honap DESC
    ''')
    statisztika = c.fetchall()
    conn.close()
    
    return render_template('stat.html', statisztika=statisztika)

# Route for filtering refuel records between two dates
@app.route('/filter', methods=['GET', 'POST'])
def filter():
    if request.method == 'POST':
        # Get the selected date range from the form
        start_date = request.form['start_date']
        end_date = request.form['end_date']
        
        # Filter records based on the date range
        conn = sqlite3.connect('fuel.db')
        c = conn.cursor()
        c.execute('''
            SELECT * FROM tankolas
            WHERE datum BETWEEN ? AND ?
            ORDER BY datum DESC
        ''', (start_date, end_date))
        filtered_tankolasok = c.fetchall()
        conn.close()
        
        return render_template('filter.html', tankolasok=filtered_tankolasok)
    
    return render_template('filter.html', tankolasok=[])

# Route for calculating efficiency between consecutive refuels
@app.route('/efficiency')
def efficiency():
    conn = sqlite3.connect('fuel.db')
    c = conn.cursor()
    # Fetch all refuel records in ascending order of date
    c.execute('SELECT * FROM tankolas ORDER BY datum ASC')
    tankolasok = c.fetchall()
    efficiency_data = []
    
    for i in range(1, len(tankolasok)):
        # Calculate distance between consecutive refuels
        prev_kilometer = tankolasok[i-1][4]
        curr_kilometer = tankolasok[i][4]
        distance = curr_kilometer - prev_kilometer
        fuel_used = tankolasok[i][2]  # Liters filled during the current refuel
        # Calculate fuel consumption (liters per 100 km)
        consumption = (fuel_used / distance * 100) if distance > 0 else 0
        efficiency_data.append((tankolasok[i][1], distance, consumption))
    
    conn.close()
    
    # Render the efficiency page with calculated data
    return render_template('efficiency.html', efficiency_data=efficiency_data)

if __name__ == '__main__':
    init_db()  # Initialize the database on app start
    app.run(debug=True)
