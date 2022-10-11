using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Interfata_dbo_EUROPEDIRECT
{
    public partial class frmVizite : Form
    {
        private string tipVizita = string.Empty;
        private string varsta = string.Empty;
        private string domiciliu = string.Empty;
        private string sex = string.Empty;
        private string titlu = string.Empty;

        public frmVizite()
        {
            InitializeComponent();
        }

        void Clear()
        {
            checkBoxDirecta.Checked = checkBoxIndirecta.Checked = checkBoxTelefon.Checked = checkBoxMail.Checked = checkBoxMesaj.Checked = false;    //CheckBox-urile pentru tipul vizitei
            textBoxAltfel.Text = string.Empty;      //TextBox-ul pentru al tip de vizita
            textBoxPrenume.Text = textBoxNume.Text = string.Empty;     //ComboBox-urile pentru nume si prenume
            checkBoxSub14A.Checked = checkBox14o25.Checked = checkBox25o40.Checked = checkBox40o60.Checked = checkBoxPeste60.Checked = false;   //CheckBox-urile pentru Varsta
            comboBoxStudii.Text = comboBoxOcupatie.Text = comboBoxSubiect.Text = string.Empty;     //ComboBox-urile pentru Studii, Ocupatie si Subiect
            checkBoxTgv.Checked = checkBoxDB.Checked = checkBoxAltJud.Checked = checkBoxAltaTara.Checked = false;   //Checkbox-urile pentru domiciliu
            checkBoxFeminin.Checked = checkBoxMasculin.Checked = checkBoxAltceva.Checked = false;   //CheckBox-urile pentru sex
            varsta = domiciliu = sex = string.Empty;      //String-uri pentru CheckBpx-uri
        }

        private void checkBoxSub14A_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSub14A.Checked == true)
            {
                checkBox14o25.Checked = checkBox25o40.Checked = checkBox40o60.Checked = checkBoxPeste60.Checked = false;
                varsta = "Sub 14 ani";
            }
        }

        private void checkBox14o25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14o25.Checked == true)
            {
                checkBoxSub14A.Checked = checkBox25o40.Checked = checkBox40o60.Checked = checkBoxPeste60.Checked = false;
                varsta = "Intre 14 si 25 de ani";
            }
        }

        private void checkBox25o40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25o40.Checked == true)
            {
                checkBoxSub14A.Checked = checkBox14o25.Checked = checkBox40o60.Checked = checkBoxPeste60.Checked = false;
                varsta = "Intre 25 si 40 de ani";
            }
        }

        private void checkBox40o60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40o60.Checked == true)
            {
                checkBoxSub14A.Checked = checkBox14o25.Checked = checkBox25o40.Checked = checkBoxPeste60.Checked = false;
                varsta = "Intre 40 si 60 de ani";
            }
        }

        private void checkBoxPeste60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPeste60.Checked == true)
            {
                checkBoxSub14A.Checked = checkBox14o25.Checked = checkBox25o40.Checked = checkBox40o60.Checked = false;
                varsta = "Peste 60 de ani";
            }
        }

        private void checkBoxTgv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTgv.Checked == true)
            {
                checkBoxDB.Checked = checkBoxAltJud.Checked = checkBoxAltaTara.Checked = false;
                domiciliu = "Targoviste";
            }
        }

        private void checkBoxDB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDB.Checked == true)
            {
                checkBoxTgv.Checked = checkBoxAltJud.Checked = checkBoxAltaTara.Checked = false;
                domiciliu = "Dambovita";
            }
        }

        private void checkBoxAltJud_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAltJud.Checked == true)
            {
                checkBoxTgv.Checked = checkBoxDB.Checked = checkBoxAltaTara.Checked = false;
                domiciliu = "Alt judet";
            }
        }

        private void checkBoxAltaTara_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAltaTara.Checked == true)
            {
                checkBoxTgv.Checked = checkBoxDB.Checked = checkBoxAltJud.Checked = false;
                domiciliu = "Alta tara";
            }
        }

        private void checkBoxFeminin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFeminin.Checked == true)
            {
                checkBoxMasculin.Checked = checkBoxAltceva.Checked = false;
                sex = "Feminin";
            }
        }

        private void checkBoxMasculin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMasculin.Checked == true)
            {
                checkBoxFeminin.Checked = checkBoxAltceva.Checked = false;
                sex = "Masculin";
            }
        }

        private void checkBoxAltceva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAltceva.Checked == true)
            {
                checkBoxFeminin.Checked = checkBoxMasculin.Checked = false;
                sex = "Altceva";
            }
        }

        private void checkBoxDirecta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDirecta.Checked == true)
            {
                checkBoxIndirecta.Checked = false;
                checkBoxTelefon.Visible = checkBoxMail.Visible = checkBoxMesaj.Visible = labelAltfel.Visible = textBoxAltfel.Visible = false;
                checkBoxTelefon.Checked = checkBoxMail.Checked = checkBoxMesaj.Checked = false;
                textBoxAltfel.Text = string.Empty;
                tipVizita = "Directa";
            }
        }

        private void checkBoxIndirecta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIndirecta.Checked == true)
            {
                checkBoxDirecta.Checked = false;
                checkBoxTelefon.Visible = checkBoxMail.Visible = checkBoxMesaj.Visible = labelAltfel.Visible = textBoxAltfel.Visible = true;
            }
            else if (checkBoxIndirecta.Checked == false)
            {
                checkBoxTelefon.Visible = checkBoxMail.Visible = checkBoxMesaj.Visible = labelAltfel.Visible = textBoxAltfel.Visible = false;
            }
        }

        private void checkBoxTelefon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTelefon.Checked == true)
            {
                checkBoxMail.Checked = checkBoxMesaj.Checked = false;
                textBoxAltfel.Text = string.Empty;
                tipVizita = "Apel Telefonic";
            }
        }

        private void checkBoxMail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMail.Checked == true)
            {
                checkBoxTelefon.Checked = checkBoxMesaj.Checked = false;
                textBoxAltfel.Text = string.Empty;
                tipVizita = "Mail";
            }
        }

        private void checkBoxMesaj_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMesaj.Checked == true)
            {
                checkBoxTelefon.Checked = checkBoxMail.Checked = false;
                textBoxAltfel.Text = string.Empty;
                tipVizita = "Mesaj";
            }
        }

        private void textBoxAltele_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAltfel.Text != string.Empty)
            {
                checkBoxTelefon.Checked = checkBoxMail.Checked = checkBoxMesaj.Checked = false;
                tipVizita = textBoxAltfel.Text;
            }
        }

        private bool GetListaPersVechi()
        {
            titlu = "Persoane Vechi";
            DataTable dtListaPersNoi = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
            using (SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' AND [PersoaneUnice] = '" + titlu + "'; ", sqlcon))
            {
                sqlcon.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                dtListaPersNoi.Load(reader);
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
            using (SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [dbo].[PersNoi] WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' AND [PersoaneUnice] = '" + titlu + "'; ", sqlcon))
            {
                sqlcon.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                dtListaPersNoi.Load(reader);
            }
            if (dtListaPersNoi.Rows.Count == 0)
                return false;
            else
                return true;
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            if (checkBoxDirecta.Checked == false && checkBoxIndirecta.Checked == false)
                MessageBox.Show("Selectati tipul vizitei");
            else if (checkBoxIndirecta.Checked == true && checkBoxTelefon.Checked == false && checkBoxMail.Checked == false && checkBoxMesaj.Checked == false && textBoxAltfel.Text == string.Empty)
                MessageBox.Show("Selectati tipul vizitei indirecte");
            else if (textBoxPrenume.Text == string.Empty)
                MessageBox.Show("Introduceti un prenume");
            else if (textBoxNume.Text == string.Empty)
                MessageBox.Show("Introduceti un nume");
            else if (checkBoxSub14A.Checked == false && checkBox14o25.Checked == false && checkBox25o40.Checked == false && checkBox40o60.Checked == false && checkBoxPeste60.Checked == false)
                MessageBox.Show("Selectati o varsta");
            else if (comboBoxStudii.Text == string.Empty)
                MessageBox.Show("Selectati studiile");
            else if (comboBoxOcupatie.Text == string.Empty)
                MessageBox.Show("Selectati o ocupatie");
            else if (comboBoxSubiect.Text == string.Empty)
                MessageBox.Show("Selectati un subiect");
            else if (checkBoxTgv.Checked == false && checkBoxDB.Checked == false && checkBoxAltJud.Checked == false && checkBoxAltaTara.Checked == false)
                MessageBox.Show("Selectati un Domiciliu");
            else if (checkBoxFeminin.Checked == false && checkBoxMasculin.Checked == false && checkBoxAltceva.Checked == false)
                MessageBox.Show("Selectati sexul");
            else
            {
                if (GetListaPersNoi() == false && GetListaPersVechi() == false)
                {
                    titlu = "Persoane Unice";
                    using (SqlConnection sqlcon = new SqlConnection())
                    {
                        sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                        sqlcon.Open();
                        SqlCommand addPersNoi = new SqlCommand("PersNoiADD", sqlcon);
                        addPersNoi.CommandType = CommandType.StoredProcedure;
                        addPersNoi.Parameters.AddWithValue("@NumePers", textBoxPrenume.Text.Trim() + " " + textBoxNume.Text.Trim());
                        addPersNoi.Parameters.AddWithValue("@Titlu", titlu);
                        addPersNoi.Parameters.AddWithValue("@Sex", sex);
                        addPersNoi.ExecuteNonQuery();
                    }
                }
                else if (GetListaPersNoi() == true && GetListaPersVechi() == false)
                {
                    titlu = "Persoane Vechi";
                    using (SqlConnection sqlcon = new SqlConnection())
                    {
                        sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                        sqlcon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UPDATE [dbo].[PersNoi] SET [PersoaneUnice] = '" + titlu + "' WHERE [Prenume-Nume] = '" + textBoxPrenume.Text + " " + textBoxNume.Text + "' AND [Sex] = '" + sex + "' ", sqlcon);
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                using (SqlConnection sqlcon = new SqlConnection())
                {
                    sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                    sqlcon.Open();
                    SqlCommand sqlCmd = new SqlCommand("ViziteADD", sqlcon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@TipulVizitei", tipVizita);
                    sqlCmd.Parameters.AddWithValue("@Prenume", textBoxPrenume.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Nume", textBoxNume.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Varsta", varsta);
                    sqlCmd.Parameters.AddWithValue("@Studii", comboBoxStudii.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Ocupatie", comboBoxOcupatie.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Subiect", comboBoxSubiect.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Domiciliu", domiciliu);
                    sqlCmd.Parameters.AddWithValue("@Sex", sex);
                    sqlCmd.ExecuteNonQuery();
                    Clear();
                }
            }
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
