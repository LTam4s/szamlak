using MySql.Data.MySqlClient;
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

namespace szamlak
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownEgyenleg.Maximum = int.MaxValue;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "szamlak";
            builder.ConvertZeroDateTime = true;
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
                throw;
            }
            adatok();
        }

        private void adatok()
        {
            
            listBox1.Items.Clear();
            cmd.CommandText = "SELECT `id`, `tulajdonosNeve`, `egyenleg`, `nyitasdatum` FROM `szamlak` WHERE 1";
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    szamla uj = new szamla(dr.GetInt32("id"), dr.GetString("tulajdonosNeve"), dr.GetDecimal("egyenleg"), dr.GetDateTime("nyitasdatum"));
                    listBox1.Items.Add(uj);
                }
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO `szamlak`(`tulajdonosNeve`, `egyenleg`, `nyitasdatum`) VALUES (@tnev, @egyenleg, @opdate)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tnev", textBoxNev.Text);
            cmd.Parameters.AddWithValue("@egyenleg", numericUpDownEgyenleg.Value.ToString());
            cmd.Parameters.AddWithValue("@opdate", dateTimePicker1.Value);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve!");
                    textBoxId.Text = "";
                    numericUpDownEgyenleg.Value = numericUpDownEgyenleg.Minimum;
                    dateTimePicker1.Text = DateTime.Now.ToString();
                    textBoxNev.Text = "";

                }
                else
                {
                    MessageBox.Show("sikertelen rögzítés!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            adatok();
    }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            szamla kivalasztott_szamla = (szamla)listBox1.SelectedItem;
            textBoxId.Text = kivalasztott_szamla.Id.ToString();
            textBoxNev.Text = kivalasztott_szamla.TulajdonosNeve.ToString();
            numericUpDownEgyenleg.Value = kivalasztott_szamla.Egyenleg;
            dateTimePicker1.Value = kivalasztott_szamla.Nyitasdatum;
        }

        private void update_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            szamla kivalasztott_szamla = (szamla)listBox1.SelectedItem;
            cmd.CommandText = "UPDATE `szamlak` SET `tulajdonosNeve`= @tnev,`egyenleg`= @egyenleg,`nyitasdatum`= @opdate WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", kivalasztott_szamla.Id);
            cmd.Parameters.AddWithValue("@tnev", textBoxNev.Text);
            cmd.Parameters.AddWithValue("@egyenleg", numericUpDownEgyenleg.Value.ToString());
            cmd.Parameters.AddWithValue("@opdate", dateTimePicker1.Value);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres votl!");
                textBoxId.Text = "";
                numericUpDownEgyenleg.Value = numericUpDownEgyenleg.Minimum;
                dateTimePicker1.Text = DateTime.Now.ToString();
                textBoxNev.Text = "";
                adatok();
            }
            else
            {
                MessageBox.Show("Az adatok módosítása sikertelen!");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM `szamlak` WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Törlés sikeres");
                textBoxId.Text = "";
                numericUpDownEgyenleg.Value = numericUpDownEgyenleg.Minimum;
                dateTimePicker1.Text = DateTime.Now.ToString();
                textBoxNev.Text = "";
                adatok();
            }
            else
            {
                MessageBox.Show("Törlés sikertelen");
            }
        }
    }
}
