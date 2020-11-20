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
using System.IO;

namespace WitcherForm
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Karakter_nev.Font = new Font(textBox_Karakter_nev.Font.FontFamily, textBox_Karakter_nev.Font.Size * 1.3f, FontStyle.Bold);
            numericUpDown_Ero.Minimum = 0;
            numericUpDown_Ero.Maximum = 50000;
            //-- adatbázis kapcsolat kialakítása
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "witcher";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            listbox_Karakterek_update();
        }

        private void listbox_Karakterek_update()
        {
            listBox_Karakterek.Items.Clear();
            sql.CommandText = "SELECT `id`,`nev`,`ero`,`nem`,`gyengeseg`,`kep` FROM `wkarakterek` ;";
            
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    listBox_Karakterek.Items.Add(new Karakter(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDecimal("ero"), dr.GetString("nem"), dr.IsDBNull(dr.GetOrdinal("gyengeseg"))?"":dr.GetString("gyengeseg"), dr.IsDBNull(dr.GetOrdinal("kep"))?"":dr.GetString("kep")));
                }
            }
        }

        private void listBox_Karakterek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Karakterek.SelectedIndex < 0)
            {
                return;
            }
            Karakter k = (Karakter)listBox_Karakterek.SelectedItem;
            textBox_Karakter_nev.Text = k.Nev;
            textBox_Karakter_gyengeseg.Text = k.Gyengeseg;
            numericUpDown_Ero.Value = k.Ero;
            radioButton_Ferfi.Checked = k.Nem.Equals("férfi");
            radioButton_No.Checked = k.Nem.Equals("nő");
            if (k.Kep != "" && File.Exists(@"images\"+k.Kep))
            {
                pictureBox_Karakter.Image = Image.FromFile(@"images\" + k.Kep);
            }
            else
            {
                pictureBox_Karakter.Image = null;
            }
        }
    }
}
