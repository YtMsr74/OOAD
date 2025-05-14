using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace patlab4
{
    public partial class Form1 : Form
    {
        IdentityMap _identityMap;
        SQLiteConnection _connection;
        public Form1()
        {
            InitializeComponent();
            InitializeDB();
            _identityMap = new IdentityMap();
            flowLayoutPanel1.Margin = new Padding(100);
        }

        private void InitializeDB()
        {
            _connection = new SQLiteConnection("Data Source=:memory:");
            _connection.Open();
            using (SQLiteCommand com = new SQLiteCommand("CREATE TABLE IF NOT EXISTS vehicles (id INTEGER PRIMARY KEY, name TEXT, year INTEGER, country TEXT, engine TEXT, layout TEXT, weight TEXT, image TEXT)", _connection))
            {
                com.ExecuteNonQuery();
            }
            using (SQLiteCommand com = new SQLiteCommand("INSERT INTO vehicles (name, year, country, engine, layout, weight, image) VALUES " +
                "('Land Rover Defender 90', 1997, 'Великобритания', '3.9Л атмосферный V8 (182 л.с., 315 Н•м)', 'Передний двигатель, полный привод, 4-ступенчатая трансмиссия', '1770 кг, 52%F/48%R, 0.077 кВт/кг', './/Images//Land Rover Defender 90')," +
                "('Volkswagen Golf R', 2021, 'Германия', '2.0Л турбированный I4 (288 л.с., 380 Н•м)', 'Передний двигатель, полный привод, 6-ступенчатая трансмиссия', '1497 кг, 59%F/41%R, 0.143 кВт/кг', './/Images//Volkswagen Golf R')," +
                "('Mitsubishi GTO', 1997, 'Япония', '3.0Л V6 с двойным турбонаддувом (320 л.с., 427 Н•м)', 'Передний двигатель, полный привод, 6-ступенчатая трансмиссия', '1680 кг, 61%F/39%R, 0.142 кВт/кг', './/Images//Mitsubishi GTO')," +
                "('Ford Mustang GT', 2018, 'США', '5.0Л атмосферный V8 (460 л.с., 569 Н•м)', 'Передний двигатель, задний привод, 6-ступенчатая трансмиссия', '1681 кг, 53%F/47%R, 0.204 кВт/кг', './/Images//Ford Mustang GT')," +
                "('Ferrari 599 GTO', 2010, 'Италия', '6.0Л атмосферный V12 (661 л.с., 620 Н•м)', 'Передний двигатель, задний привод, 6-ступенчатая трансмиссия', '1605 кг, 47%F/53%R, 0.307 кВт/кг', './/Images//Ferrari 599 GTO')," +
                "('Peugeot 205 Turbo 16', 1984, 'Франция', '1.8Л турбированный I4 (200 л.с., 255 Н•м)', 'Среднемоторный, полный привод, 5-ступенчатая трансмиссия', '1145 кг, 45%F/55%R, 0.13 кВт/кг', './/Images//Peugeot 205 Turbo 16')"
                , _connection))
            {
                com.ExecuteNonQuery();
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Vehicle selected = _identityMap.GetVehicle(Convert.ToInt32(pictureBox.Tag), _connection);
            txtCarName.Text = selected.name;
            picCar.Image = selected.image;
            txtCarYear.Text = selected.year.ToString();
            txtCarCountry.Text = selected.country;
            txtCarEngine.Text = selected.engine;
            txtCarLayout.Text = selected.layout;
            txtCarWeight.Text = selected.weight;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process currentProcess = Process.GetCurrentProcess();
            long memoryUsed = currentProcess.WorkingSet64 / 1024;
            tsMem.Text = "Память: " + memoryUsed + "КБ";
        }
    }
}
