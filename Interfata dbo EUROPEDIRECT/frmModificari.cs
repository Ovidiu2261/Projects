using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Interfata_dbo_EUROPEDIRECT
{
    public partial class frmModificari : Form
    {
        public frmModificari()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            comboBoxColumn.Text = string.Empty;
            textBoxValue.Text = textBoxPrenume.Text = textBoxNume.Text = string.Empty;
            checkBoxTday.Checked = checkBoxYday.Checked = checkBoxAllTime.Checked = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxColumn.Text == string.Empty)
            {
                MessageBox.Show("Selectati o coloana");
            }
            else if (textBoxValue.Text == string.Empty)
            {
                MessageBox.Show("Adaugati o valoarea care urmeaza sa fie introdusa in baza de date");
            }
            else if (checkBoxTday.Checked == false && checkBoxYday.Checked == false && checkBoxAllTime.Checked == false)
            {
                MessageBox.Show("Selectati data");
            }
            else if (textBoxPrenume.Text == string.Empty || textBoxNume.Text == string.Empty)
            {
                MessageBox.Show("Introduceti un Prenume si un Nume");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection())
                {
                    sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                    sqlcon.Open();
                    if (checkBoxTday.Checked == true)
                    {
                        SqlCommand sqlcmd = new SqlCommand("UPDATE [dbo].[Vizite] SET [" + comboBoxColumn.Text + "] = '" + textBoxValue.Text + "' WHERE [Prenume] = '" + textBoxPrenume.Text + "' AND [Nume] = '" + textBoxNume.Text + "' AND DATEPART(d, [DataInregistrari]) = DATEPART(d, DATEADD(d, 0, getdate()));", sqlcon);
                        sqlcmd.ExecuteNonQuery();
                        sqlcon.Close();
                        Clear();
                        dataGridViewVizite.DataSource = GetListaVizite();
                    }
                    else if (checkBoxYday.Checked == true)
                    {
                        SqlCommand sqlcmd = new SqlCommand("UPDATE [dbo].[Vizite] SET [" + comboBoxColumn.Text + "] = '" + textBoxValue.Text + "' WHERE [Prenume] = '" + textBoxPrenume.Text + "' AND [Nume] = '" + textBoxNume.Text + "' AND DATEPART(d, [DataInregistrari]) = DATEPART(d, DATEADD(d, -1, getdate()));", sqlcon);
                        sqlcmd.ExecuteNonQuery();
                        sqlcon.Close();
                        Clear();
                        dataGridViewVizite.DataSource = GetListaVizite();
                    }
                    else if (checkBoxAllTime.Checked == true)
                    {
                        SqlCommand sqlcmd = new SqlCommand("UPDATE [dbo].[Vizite] SET [" + comboBoxColumn.Text + "] = '" + textBoxValue.Text + "' WHERE [Prenume] = '" + textBoxPrenume.Text + "' AND [Nume] = '" + textBoxNume.Text + "'", sqlcon);
                        sqlcmd.ExecuteNonQuery();
                        sqlcon.Close();
                        Clear();
                        dataGridViewVizite.DataSource = GetListaVizite();
                    }
                }
            }
        }

        private void frmModificari_Load(object sender, EventArgs e)
        {
            dataGridViewVizite.DataSource = GetListaVizite();
        }

        private DataTable GetListaVizite()
        {
            DataTable dtListaVizite = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
            using (SqlCommand sqlcmd = new SqlCommand("SELECT TOP 5 * FROM [dbo].[Vizite] ORDER BY [ID] DESC", sqlcon))
            {
                sqlcon.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                dtListaVizite.Load(reader);
            }
            return dtListaVizite;
        }

        private void checkBoxTday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTday.Checked == true)
            {
                checkBoxAllTime.Checked = false;
                checkBoxYday.Checked = false;
            }
        }

        private void checkBoxAllTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllTime.Checked == true)
            {
                checkBoxTday.Checked = false;
                checkBoxYday.Checked = false;
            }
        }

        private void checkBoxYday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYday.Checked == true)
            {
                checkBoxTday.Checked = false;
                checkBoxAllTime.Checked = false;
            }
        }

    }
}
