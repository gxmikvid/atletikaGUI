using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atletikaGUI
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        public MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=atletikavb2017;port=3306;password=");

        public void ReadFromDB(MySqlConnection connection, string command, Action<MySqlDataReader> MethodName) {
            try {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(command, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                MethodName(dr);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void StoreCountries(MySqlDataReader dr) {
            while (dr.Read())
            {
                OrszagokListBox.Items.Add(dr.GetString("Nemzet"));
            }
        }
        public void StoreRaces(MySqlDataReader dr) {
            while (dr.Read())
            {
                szamokListBox.Items.Add(dr.GetString("Versenyszam"));
            }
        }
        public void StoreResults(MySqlDataReader dr) {
            dr.Read();
            nevLabel.Text = $"neve: {dr.GetString("VersenyzoNev")}";
            eredmenyLabel.Text = $"eredménye: {dr.GetString("Eredmeny")}";
            nemzetLabel.Text = $"nemzete: {dr.GetString("Nemzet")}";
        }

        private void button2_Click(object sender, EventArgs e) {
            if (OrszagokListBox.SelectedIndex > 0 && szamokListBox.SelectedIndex > 0 && versenyszamNUD.Value > 0 && versenyszamNUD.Value < 4) {
                ReadFromDB(conn, $"SELECT VersenyzoNev, Eredmeny, Nemzet FROM nemzetek JOIN versenyekszamok ON NemzetId WHERE Nemzet = '{OrszagokListBox.Text}' AND Versenyszam = '{szamokListBox.Text}' AND Helyezes = '{versenyszamNUD.Value}'", StoreResults);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadFromDB(conn, "SELECT Nemzet FROM nemzetek;", StoreCountries);
            ReadFromDB(conn, "SELECT DISTINCT Versenyszam FROM versenyekszamok;", StoreRaces);
            button1.Visible = false;
        }
    }
}
