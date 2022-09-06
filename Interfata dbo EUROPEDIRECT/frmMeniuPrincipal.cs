using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Interfata_dbo_EUROPEDIRECT
{
    public partial class frmMeniuPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel panouStangaBtn;
        private Form currentChildForm;
        private string currentForm = string.Empty;

        public frmMeniuPrincipal()
        {
            InitializeComponent();

            panouStangaBtn = new Panel();
            panouStangaBtn.Size = new Size(7, 60);
            panelMeniu.Controls.Add(panouStangaBtn);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct Culori
        {
            public static Color culoarea1 = Color.FromArgb(172, 126, 241);
            public static Color culoarea2 = Color.FromArgb(249, 118, 176);
            public static Color culoarea3 = Color.FromArgb(253, 138, 114);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                panouStangaBtn.BackColor = color;
                panouStangaBtn.Location = new Point(0, currentBtn.Location.Y);
                panouStangaBtn.Visible = true;
                panouStangaBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
        }

        private void buttonVizite_Click(object sender, EventArgs e)
        {
            if (currentForm != "Vizite")
            {
                currentForm = "Vizite";
                ActivateButton(sender, Culori.culoarea1);
                OpenChildForm(new frmVizite());
            }
        }

        private void buttonModificari_Click(object sender, EventArgs e)
        {
            if (currentForm != "Modificari")
            {
                currentForm = "Modificari";
                ActivateButton(sender, Culori.culoarea2);
                OpenChildForm(new frmModificari());
            }
        }

        private void buttonArataRaport_Click(object sender, EventArgs e)
        {
            if (currentForm != "Raport")
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                    currentChildForm = null;
                }
                Reset();
                currentForm = "Raport";
                ActivateButton(sender, Culori.culoarea3);
                if (currentChildForm == null)
                {
                    buttonRaport.Visible = true;
                    checkBoxRaportVechi.Visible = true;
                }
                else if (currentChildForm != null)
                {
                    buttonRaport.Visible = false;
                    checkBoxRaportVechi.Visible = false;
                }
            }
        }

        private void ButtonMeniu_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            currentForm = string.Empty;
            buttonRaport.Visible = false;
            checkBoxRaportVechi.Visible = false;
            panouStangaBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTitleChildForm.Text = "Meniu Principal";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void checkBoxRaportVechi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRaportVechi.Checked == true)
            {
                labelRaport.Visible = true;
                numericRaport.Visible = true;
            }
            else
            {
                labelRaport.Visible = false;
                numericRaport.Visible = false;
            }
        }

        private void buttonRaport_Click(object sender, EventArgs e)
        {
            string numeFisier = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
            ReadOrderData(sqlcon.ToString());
            MessageBox.Show("Raportul " + numeFisier + " a fost creat");
        }

        private void ReadOrderData(string connectionString)
        {
            string numeFisier = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
            string[] stringArr = new string[7];
            stringArr[0] = "TipulVizitei";
            stringArr[1] = "Varsta";
            stringArr[2] = "Studii";
            stringArr[3] = "Ocupatie";
            stringArr[4] = "Subiect";
            stringArr[5] = "Domiciliu";
            stringArr[6] = "Sex";
            string queryPersNoi = "SELECT COUNT(*) ,[PersoaneUnice] FROM [dbo].[PersNoi] WHERE DATEPART(m, [DataInregistrari]) = DATEPART(m, DATEADD(m, -" + numericRaport.Value.ToString() + ", getdate())) group by [PersoaneUnice];";
            using (SqlConnection sqlcon = new SqlConnection())
            {
                sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                SqlCommand sqlCmd = new SqlCommand(queryPersNoi, sqlcon);
                sqlcon.Open();
                using (SqlDataReader reader = sqlCmd.ExecuteReader())
                {
                    StreamWriter titlu = new StreamWriter("C:\\Raport\\" + numeFisier + ".docx", true);
                    titlu.WriteLine(" Vizite noi ");
                    titlu.Close();
                    while (reader.Read())
                    {
                        StreamWriter sw = new StreamWriter("C:\\Raport\\" + numeFisier + ".docx", true);
                        sw.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                        sw.Close();
                    }
                    StreamWriter spatiu = new StreamWriter("C:\\Raport\\" + numeFisier + ".docx", true);
                    spatiu.WriteLine(" ");
                    spatiu.Close();
                }
            }
            for (int i = 0; i < 7; i++)
            {
                string queryVizite = "SELECT COUNT(*) AS Counter ,[" + stringArr[i] + "] FROM [dbo].[Vizite] WHERE DATEPART(m, [DataInregistrari]) = DATEPART(m, DATEADD(m, -" + numericRaport.Value.ToString() + ", getdate())) group by [" + stringArr[i] + "];";
                using (SqlConnection sqlcon = new SqlConnection())
                {
                    sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["ConexiuneDBO"].ToString();
                    SqlCommand sqlCmd = new SqlCommand(queryVizite, sqlcon);
                    sqlcon.Open();
                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        StreamWriter titlu = new StreamWriter("C:\\Raport\\" + numeFisier + ".docx", true);
                        titlu.WriteLine(" " + stringArr[i] + " ");
                        titlu.Close();
                        while (reader.Read())
                        {
                            StreamWriter sw = new StreamWriter("C:\\Raport\\" + numeFisier + ".docx", true);
                            sw.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                            sw.Close();
                        }
                        StreamWriter spatiu = new StreamWriter("C:\\Raport\\" + numeFisier + ".docx", true);
                        spatiu.WriteLine(" ");
                        spatiu.Close();
                    }
                }
            }
        }
    }
}
