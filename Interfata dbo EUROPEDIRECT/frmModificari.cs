using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Interfata_dbo_EUROPEDIRECT
{
    public partial class frmModificari : Form
    {
        private string sex = string.Empty;
        private string titlu = string.Empty;
        public frmModificari()
        {
            InitializeComponent();
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

        private void checkBoxFeminin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFeminin.Checked == true)
            {
                checkBoxMasculin.Checked = checkBoxAltele.Checked = false;
                sex = "Feminin";
            }
        }

        private void checkBoxMasculin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMasculin.Checked == true)
            {
                checkBoxFeminin.Checked = checkBoxAltele.Checked = false;
                sex = "Masculin";
            }
        }

        private void checkBoxAltele_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAltele.Checked == true)
            {
                checkBoxFeminin.Checked = checkBoxMasculin.Checked = false;
                sex = "Altceva";
            }
        }

        private void Clear()
        {
            comboBoxColumn.Text = string.Empty;
            textBoxValue.Text = textBoxPrenume.Text = textBoxNume.Text = string.Empty;
            checkBoxTday.Checked = checkBoxYday.Checked = checkBoxAllTime.Checked = false;
        }

        private bool GetListaPersVechi()
        {
            titlu = "Persoane Vechi";
            DataTable dtListaPersNoi = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
            if (comboBoxColumn.Text == "Prenume")
            {
                using (SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxValue.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' AND [PersoaneUnice] = '" + titlu + "'; ", sqlcon))
                {
                    sqlcon.Open();
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    dtListaPersNoi.Load(reader);
                }
            }
            else if (comboBoxColumn.Text == "Nume")
            {
                using (SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxValue.Text + "' AND [Sex] = '" + sex + "' AND [PersoaneUnice] = '" + titlu + "'; ", sqlcon))
                {
                    sqlcon.Open();
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    dtListaPersNoi.Load(reader);
                }
            }
            else if (comboBoxColumn.Text == "Sex")
            {
                using (SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + textBoxValue.Text + "' AND [PersoaneUnice] = '" + titlu + "'; ", sqlcon))
                {
                    sqlcon.Open();
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    dtListaPersNoi.Load(reader);
                }
            }
            if (dtListaPersNoi.Rows.Count == 0)
                return false;
            else
                return true;
        }

        private bool GetListaPersNoi()
        {
            titlu = "Persoane Unice";
            DataTable dtListaPersNoi = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
            if (comboBoxColumn.Text == "Prenume")
            {
                using (SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxValue.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' AND [PersoaneUnice] = '" + titlu + "'; ", sqlcon))
                {
                    sqlcon.Open();
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    dtListaPersNoi.Load(reader);
                }
            }
            else if (comboBoxColumn.Text == "Nume")
            {
                using (SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxValue.Text + "' AND [Sex] = '" + sex + "' AND [PersoaneUnice] = '" + titlu + "'; ", sqlcon))
                {
                    sqlcon.Open();
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    dtListaPersNoi.Load(reader);
                }
            }
            else if (comboBoxColumn.Text == "Sex")
            {
                using (SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + textBoxValue.Text + "' AND [PersoaneUnice] = '" + titlu + "'; ", sqlcon))
                {
                    sqlcon.Open();
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    dtListaPersNoi.Load(reader);
                }
            }
            if (dtListaPersNoi.Rows.Count == 0)
                return false;
            else
                return true;
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
            else if (checkBoxFeminin.Checked == false && checkBoxMasculin.Checked == false && checkBoxAltele.Checked == false)
            {
                MessageBox.Show("Selectati sexul");
            }
            else
            {
                if (comboBoxColumn.Text == "Prenume")
                {
                    if (GetListaPersVechi() == false && GetListaPersNoi() == false)
                    {
                        using (SqlConnection sqlcon = new SqlConnection())
                        {
                            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                            sqlcon.Open();
                            SqlCommand updatePersNoi = new SqlCommand("UPDATE [dbo].[PersNoi] SET [Prenume-Nume] = '" + textBoxValue.Text + " " + textBoxNume.Text + "' WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            updatePersNoi.ExecuteNonQuery();
                        }
                    }
                    else if (GetListaPersVechi() == false && GetListaPersNoi() == true)
                    {
                        titlu = "Persoane Vechi";
                        using (SqlConnection sqlcon = new SqlConnection())
                        {
                            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                            sqlcon.Open();
                            SqlCommand updatePersNoi = new SqlCommand("UPDATE [dbo].[PersNoi] SET [PersoaneUnice] = '" + titlu + "' WHERE [Prenume-Nume] = '" + textBoxValue.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            updatePersNoi.ExecuteNonQuery();
                            SqlCommand deletePersNoi = new SqlCommand("DELETE FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            deletePersNoi.ExecuteNonQuery();
                        }
                    }
                    else if (GetListaPersVechi() == true && GetListaPersNoi() == false)
                    {
                        using (SqlConnection sqlcon = new SqlConnection())
                        {
                            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                            sqlcon.Open();
                            SqlCommand deletePersNoi = new SqlCommand("DELETE FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            deletePersNoi.ExecuteNonQuery();
                        }
                    }
                }
                else if (comboBoxColumn.Text == "Nume")
                {
                    if (GetListaPersVechi() == false && GetListaPersNoi() == false)
                    {
                        using (SqlConnection sqlcon = new SqlConnection())
                        {
                            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                            sqlcon.Open();
                            SqlCommand updatePersNoi = new SqlCommand("UPDATE [dbo].[PersNoi] SET [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxValue.Text + "' WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            updatePersNoi.ExecuteNonQuery();
                        }
                    }
                    else if (GetListaPersVechi() == false && GetListaPersNoi() == true)
                    {
                        titlu = "Persoane Vechi";
                        using (SqlConnection sqlcon = new SqlConnection())
                        {
                            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                            sqlcon.Open();
                            SqlCommand updatePersNoi = new SqlCommand("UPDATE [dbo].[PersNoi] SET [PersoaneUnice] = '" + titlu + "' WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxValue.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            updatePersNoi.ExecuteNonQuery();
                            SqlCommand deletePersNoi = new SqlCommand("DELETE FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            deletePersNoi.ExecuteNonQuery();
                        }
                    }
                    else if (GetListaPersVechi() == true && GetListaPersNoi() == false)
                    {
                        using (SqlConnection sqlcon = new SqlConnection())
                        {
                            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                            sqlcon.Open();
                            SqlCommand deletePersNoi = new SqlCommand("DELETE FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            deletePersNoi.ExecuteNonQuery();
                        }
                    }
                }
                else if (comboBoxColumn.Text == "Sex")
                {
                    if (GetListaPersVechi() == false && GetListaPersNoi() == false)
                    {
                        using (SqlConnection sqlcon = new SqlConnection())
                        {
                            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                            sqlcon.Open();
                            SqlCommand updatePersNoi = new SqlCommand("UPDATE [dbo].[PersNoi] SET [Sex] = '" + textBoxValue.Text + "' WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            updatePersNoi.ExecuteNonQuery();
                        }
                    }
                    else if (GetListaPersVechi() == false && GetListaPersNoi() == true)
                    {
                        titlu = "Persoane Vechi";
                        using (SqlConnection sqlcon = new SqlConnection())
                        {
                            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                            sqlcon.Open();
                            SqlCommand updatePersNoi = new SqlCommand("UPDATE [dbo].[PersNoi] SET [PersoaneUnice] = '" + titlu + "' WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + textBoxValue.Text + "' ", sqlcon);
                            updatePersNoi.ExecuteNonQuery();
                            SqlCommand deletePersNoi = new SqlCommand("DELETE FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            deletePersNoi.ExecuteNonQuery();
                        }
                    }
                    else if (GetListaPersVechi() == true && GetListaPersNoi() == false)
                    {
                        using (SqlConnection sqlcon = new SqlConnection())
                        {
                            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                            sqlcon.Open();
                            SqlCommand deletePersNoi = new SqlCommand("DELETE FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                            deletePersNoi.ExecuteNonQuery();
                        }
                    }
                }
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
    }
}
