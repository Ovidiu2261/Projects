namespace Interfata_dbo_EUROPEDIRECT
{
    partial class frmVizite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelTipVizita = new System.Windows.Forms.Label();
            this.checkBoxDirecta = new System.Windows.Forms.CheckBox();
            this.checkBoxIndirecta = new System.Windows.Forms.CheckBox();
            this.checkBoxTelefon = new System.Windows.Forms.CheckBox();
            this.checkBoxMail = new System.Windows.Forms.CheckBox();
            this.checkBoxMesaj = new System.Windows.Forms.CheckBox();
            this.textBoxAltfel = new System.Windows.Forms.TextBox();
            this.labelAltfel = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelVasrta = new System.Windows.Forms.Label();
            this.checkBoxSub14A = new System.Windows.Forms.CheckBox();
            this.checkBox14o25 = new System.Windows.Forms.CheckBox();
            this.checkBox25o40 = new System.Windows.Forms.CheckBox();
            this.checkBox40o60 = new System.Windows.Forms.CheckBox();
            this.checkBoxPeste60 = new System.Windows.Forms.CheckBox();
            this.labelStudii = new System.Windows.Forms.Label();
            this.comboBoxStudii = new System.Windows.Forms.ComboBox();
            this.labelOcupatie = new System.Windows.Forms.Label();
            this.comboBoxOcupatie = new System.Windows.Forms.ComboBox();
            this.labelSubiect = new System.Windows.Forms.Label();
            this.comboBoxSubiect = new System.Windows.Forms.ComboBox();
            this.labelDomiciliu = new System.Windows.Forms.Label();
            this.checkBoxTgv = new System.Windows.Forms.CheckBox();
            this.checkBoxDB = new System.Windows.Forms.CheckBox();
            this.checkBoxAltJud = new System.Windows.Forms.CheckBox();
            this.checkBoxAltaTara = new System.Windows.Forms.CheckBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.checkBoxFeminin = new System.Windows.Forms.CheckBox();
            this.checkBoxAltceva = new System.Windows.Forms.CheckBox();
            this.checkBoxMasculin = new System.Windows.Forms.CheckBox();
            this.buttonSalveaza = new FontAwesome.Sharp.IconButton();
            this.buttonSterge = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitlu.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitlu.Location = new System.Drawing.Point(130, 14);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(255, 37);
            this.labelTitlu.TabIndex = 0;
            this.labelTitlu.Text = "Date Despre Vizite";
            // 
            // labelTipVizita
            // 
            this.labelTipVizita.AutoSize = true;
            this.labelTipVizita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTipVizita.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTipVizita.Location = new System.Drawing.Point(50, 100);
            this.labelTipVizita.Name = "labelTipVizita";
            this.labelTipVizita.Size = new System.Drawing.Size(80, 17);
            this.labelTipVizita.TabIndex = 2;
            this.labelTipVizita.Text = "Tipul Vizitei";
            // 
            // checkBoxDirecta
            // 
            this.checkBoxDirecta.AutoSize = true;
            this.checkBoxDirecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxDirecta.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxDirecta.Location = new System.Drawing.Point(139, 99);
            this.checkBoxDirecta.Name = "checkBoxDirecta";
            this.checkBoxDirecta.Size = new System.Drawing.Size(72, 21);
            this.checkBoxDirecta.TabIndex = 3;
            this.checkBoxDirecta.Text = "Directa";
            this.checkBoxDirecta.UseVisualStyleBackColor = true;
            this.checkBoxDirecta.CheckedChanged += new System.EventHandler(this.checkBoxDirecta_CheckedChanged);
            // 
            // checkBoxIndirecta
            // 
            this.checkBoxIndirecta.AutoSize = true;
            this.checkBoxIndirecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxIndirecta.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxIndirecta.Location = new System.Drawing.Point(217, 99);
            this.checkBoxIndirecta.Name = "checkBoxIndirecta";
            this.checkBoxIndirecta.Size = new System.Drawing.Size(81, 21);
            this.checkBoxIndirecta.TabIndex = 4;
            this.checkBoxIndirecta.Text = "Indirecta";
            this.checkBoxIndirecta.UseVisualStyleBackColor = true;
            this.checkBoxIndirecta.CheckedChanged += new System.EventHandler(this.checkBoxIndirecta_CheckedChanged);
            // 
            // checkBoxTelefon
            // 
            this.checkBoxTelefon.AutoSize = true;
            this.checkBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxTelefon.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxTelefon.Location = new System.Drawing.Point(317, 78);
            this.checkBoxTelefon.Name = "checkBoxTelefon";
            this.checkBoxTelefon.Size = new System.Drawing.Size(112, 21);
            this.checkBoxTelefon.TabIndex = 5;
            this.checkBoxTelefon.Text = "Apel telefonic";
            this.checkBoxTelefon.UseVisualStyleBackColor = true;
            this.checkBoxTelefon.Visible = false;
            this.checkBoxTelefon.CheckedChanged += new System.EventHandler(this.checkBoxTelefon_CheckedChanged);
            // 
            // checkBoxMail
            // 
            this.checkBoxMail.AutoSize = true;
            this.checkBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxMail.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxMail.Location = new System.Drawing.Point(317, 101);
            this.checkBoxMail.Name = "checkBoxMail";
            this.checkBoxMail.Size = new System.Drawing.Size(52, 21);
            this.checkBoxMail.TabIndex = 6;
            this.checkBoxMail.Text = "Mail";
            this.checkBoxMail.UseVisualStyleBackColor = true;
            this.checkBoxMail.Visible = false;
            this.checkBoxMail.CheckedChanged += new System.EventHandler(this.checkBoxMail_CheckedChanged);
            // 
            // checkBoxMesaj
            // 
            this.checkBoxMesaj.AutoSize = true;
            this.checkBoxMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxMesaj.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxMesaj.Location = new System.Drawing.Point(317, 124);
            this.checkBoxMesaj.Name = "checkBoxMesaj";
            this.checkBoxMesaj.Size = new System.Drawing.Size(106, 21);
            this.checkBoxMesaj.TabIndex = 7;
            this.checkBoxMesaj.Text = "Mesaj - SMS";
            this.checkBoxMesaj.UseVisualStyleBackColor = true;
            this.checkBoxMesaj.Visible = false;
            this.checkBoxMesaj.CheckedChanged += new System.EventHandler(this.checkBoxMesaj_CheckedChanged);
            // 
            // textBoxAltfel
            // 
            this.textBoxAltfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAltfel.Location = new System.Drawing.Point(429, 105);
            this.textBoxAltfel.Name = "textBoxAltfel";
            this.textBoxAltfel.Size = new System.Drawing.Size(100, 23);
            this.textBoxAltfel.TabIndex = 8;
            this.textBoxAltfel.Visible = false;
            this.textBoxAltfel.TextChanged += new System.EventHandler(this.textBoxAltele_TextChanged);
            // 
            // labelAltfel
            // 
            this.labelAltfel.AutoSize = true;
            this.labelAltfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAltfel.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAltfel.Location = new System.Drawing.Point(458, 83);
            this.labelAltfel.Name = "labelAltfel";
            this.labelAltfel.Size = new System.Drawing.Size(39, 17);
            this.labelAltfel.TabIndex = 9;
            this.labelAltfel.Text = "Altfel";
            this.labelAltfel.Visible = false;
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPrenume.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPrenume.Location = new System.Drawing.Point(50, 142);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(65, 17);
            this.labelPrenume.TabIndex = 10;
            this.labelPrenume.Text = "Prenume";
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPrenume.Location = new System.Drawing.Point(139, 139);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(120, 23);
            this.textBoxPrenume.TabIndex = 11;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNume.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNume.Location = new System.Drawing.Point(50, 182);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 12;
            this.labelNume.Text = "Nume";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNume.Location = new System.Drawing.Point(139, 179);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(120, 23);
            this.textBoxNume.TabIndex = 13;
            // 
            // labelVasrta
            // 
            this.labelVasrta.AutoSize = true;
            this.labelVasrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelVasrta.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelVasrta.Location = new System.Drawing.Point(50, 222);
            this.labelVasrta.Name = "labelVasrta";
            this.labelVasrta.Size = new System.Drawing.Size(49, 17);
            this.labelVasrta.TabIndex = 14;
            this.labelVasrta.Text = "Varsta";
            // 
            // checkBoxSub14A
            // 
            this.checkBoxSub14A.AutoSize = true;
            this.checkBoxSub14A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxSub14A.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxSub14A.Location = new System.Drawing.Point(139, 219);
            this.checkBoxSub14A.Name = "checkBoxSub14A";
            this.checkBoxSub14A.Size = new System.Drawing.Size(95, 21);
            this.checkBoxSub14A.TabIndex = 15;
            this.checkBoxSub14A.Text = "Sub 14 ani";
            this.checkBoxSub14A.UseVisualStyleBackColor = true;
            this.checkBoxSub14A.CheckedChanged += new System.EventHandler(this.checkBoxSub14A_CheckedChanged);
            // 
            // checkBox14o25
            // 
            this.checkBox14o25.AutoSize = true;
            this.checkBox14o25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox14o25.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox14o25.Location = new System.Drawing.Point(240, 221);
            this.checkBox14o25.Name = "checkBox14o25";
            this.checkBox14o25.Size = new System.Drawing.Size(104, 21);
            this.checkBox14o25.TabIndex = 16;
            this.checkBox14o25.Text = "Intre 14 - 25";
            this.checkBox14o25.UseVisualStyleBackColor = true;
            this.checkBox14o25.CheckedChanged += new System.EventHandler(this.checkBox14o25_CheckedChanged);
            // 
            // checkBox25o40
            // 
            this.checkBox25o40.AutoSize = true;
            this.checkBox25o40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox25o40.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox25o40.Location = new System.Drawing.Point(139, 244);
            this.checkBox25o40.Name = "checkBox25o40";
            this.checkBox25o40.Size = new System.Drawing.Size(104, 21);
            this.checkBox25o40.TabIndex = 17;
            this.checkBox25o40.Text = "Intre 25 - 40";
            this.checkBox25o40.UseVisualStyleBackColor = true;
            this.checkBox25o40.CheckedChanged += new System.EventHandler(this.checkBox25o40_CheckedChanged);
            // 
            // checkBox40o60
            // 
            this.checkBox40o60.AutoSize = true;
            this.checkBox40o60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox40o60.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox40o60.Location = new System.Drawing.Point(240, 246);
            this.checkBox40o60.Name = "checkBox40o60";
            this.checkBox40o60.Size = new System.Drawing.Size(104, 21);
            this.checkBox40o60.TabIndex = 18;
            this.checkBox40o60.Text = "Intre 40 - 60";
            this.checkBox40o60.UseVisualStyleBackColor = true;
            this.checkBox40o60.CheckedChanged += new System.EventHandler(this.checkBox40o60_CheckedChanged);
            // 
            // checkBoxPeste60
            // 
            this.checkBoxPeste60.AutoSize = true;
            this.checkBoxPeste60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxPeste60.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxPeste60.Location = new System.Drawing.Point(350, 221);
            this.checkBoxPeste60.Name = "checkBoxPeste60";
            this.checkBoxPeste60.Size = new System.Drawing.Size(83, 21);
            this.checkBoxPeste60.TabIndex = 19;
            this.checkBoxPeste60.Text = "Peste 60";
            this.checkBoxPeste60.UseVisualStyleBackColor = true;
            this.checkBoxPeste60.CheckedChanged += new System.EventHandler(this.checkBoxPeste60_CheckedChanged);
            // 
            // labelStudii
            // 
            this.labelStudii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStudii.AutoSize = true;
            this.labelStudii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStudii.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelStudii.Location = new System.Drawing.Point(50, 287);
            this.labelStudii.Name = "labelStudii";
            this.labelStudii.Size = new System.Drawing.Size(43, 17);
            this.labelStudii.TabIndex = 20;
            this.labelStudii.Text = "Studii";
            // 
            // comboBoxStudii
            // 
            this.comboBoxStudii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxStudii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxStudii.FormattingEnabled = true;
            this.comboBoxStudii.Items.AddRange(new object[] {
            "Fara Studii",
            "Studii in Curs",
            "Studii Profesionale",
            "Studii Liceal",
            "Studii Postliceale",
            "Studii Universitare",
            "Studii Postuniversitare"});
            this.comboBoxStudii.Location = new System.Drawing.Point(139, 284);
            this.comboBoxStudii.Name = "comboBoxStudii";
            this.comboBoxStudii.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStudii.TabIndex = 21;
            // 
            // labelOcupatie
            // 
            this.labelOcupatie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOcupatie.AutoSize = true;
            this.labelOcupatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOcupatie.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelOcupatie.Location = new System.Drawing.Point(50, 327);
            this.labelOcupatie.Name = "labelOcupatie";
            this.labelOcupatie.Size = new System.Drawing.Size(65, 17);
            this.labelOcupatie.TabIndex = 22;
            this.labelOcupatie.Text = "Ocupatie";
            // 
            // comboBoxOcupatie
            // 
            this.comboBoxOcupatie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxOcupatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxOcupatie.FormattingEnabled = true;
            this.comboBoxOcupatie.Items.AddRange(new object[] {
            "Muncitor",
            "Tehnician Maistru",
            "Functionar",
            "Profesii Intelectuale",
            "Agricultor",
            "Elev",
            "Student",
            "Pensionar",
            "Casnic/Casnica",
            "Somer",
            "Altele"});
            this.comboBoxOcupatie.Location = new System.Drawing.Point(139, 324);
            this.comboBoxOcupatie.Name = "comboBoxOcupatie";
            this.comboBoxOcupatie.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOcupatie.TabIndex = 23;
            // 
            // labelSubiect
            // 
            this.labelSubiect.AutoSize = true;
            this.labelSubiect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSubiect.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSubiect.Location = new System.Drawing.Point(50, 367);
            this.labelSubiect.Name = "labelSubiect";
            this.labelSubiect.Size = new System.Drawing.Size(55, 17);
            this.labelSubiect.TabIndex = 24;
            this.labelSubiect.Text = "Subiect";
            // 
            // comboBoxSubiect
            // 
            this.comboBoxSubiect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSubiect.FormattingEnabled = true;
            this.comboBoxSubiect.Items.AddRange(new object[] {
            "Materiale informative",
            "Institutii UE si afaceri bugetare",
            "Tineri",
            "Educatie/Pregatire profesionala",
            "Apeluri de propuneri, cereri de finantare",
            "Calatorii, miscare libera",
            "Cultura",
            "Cetatenie europeana, drepturile omului",
            "Afaceri generale UE",
            "Pactul verde european",
            "O europa pregatita pentru era digitala",
            "Altele"});
            this.comboBoxSubiect.Location = new System.Drawing.Point(139, 367);
            this.comboBoxSubiect.Name = "comboBoxSubiect";
            this.comboBoxSubiect.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSubiect.TabIndex = 25;
            // 
            // labelDomiciliu
            // 
            this.labelDomiciliu.AutoSize = true;
            this.labelDomiciliu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDomiciliu.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDomiciliu.Location = new System.Drawing.Point(50, 408);
            this.labelDomiciliu.Name = "labelDomiciliu";
            this.labelDomiciliu.Size = new System.Drawing.Size(64, 17);
            this.labelDomiciliu.TabIndex = 26;
            this.labelDomiciliu.Text = "Domiciliu";
            // 
            // checkBoxTgv
            // 
            this.checkBoxTgv.AutoSize = true;
            this.checkBoxTgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxTgv.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxTgv.Location = new System.Drawing.Point(139, 404);
            this.checkBoxTgv.Name = "checkBoxTgv";
            this.checkBoxTgv.Size = new System.Drawing.Size(94, 21);
            this.checkBoxTgv.TabIndex = 27;
            this.checkBoxTgv.Text = "Targoviste";
            this.checkBoxTgv.UseVisualStyleBackColor = true;
            this.checkBoxTgv.CheckedChanged += new System.EventHandler(this.checkBoxTgv_CheckedChanged);
            // 
            // checkBoxDB
            // 
            this.checkBoxDB.AutoSize = true;
            this.checkBoxDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxDB.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxDB.Location = new System.Drawing.Point(239, 404);
            this.checkBoxDB.Name = "checkBoxDB";
            this.checkBoxDB.Size = new System.Drawing.Size(94, 21);
            this.checkBoxDB.TabIndex = 28;
            this.checkBoxDB.Text = "Dambovita";
            this.checkBoxDB.UseVisualStyleBackColor = true;
            this.checkBoxDB.CheckedChanged += new System.EventHandler(this.checkBoxDB_CheckedChanged);
            // 
            // checkBoxAltJud
            // 
            this.checkBoxAltJud.AutoSize = true;
            this.checkBoxAltJud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxAltJud.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxAltJud.Location = new System.Drawing.Point(139, 427);
            this.checkBoxAltJud.Name = "checkBoxAltJud";
            this.checkBoxAltJud.Size = new System.Drawing.Size(78, 21);
            this.checkBoxAltJud.TabIndex = 29;
            this.checkBoxAltJud.Text = "Alt judet";
            this.checkBoxAltJud.UseVisualStyleBackColor = true;
            this.checkBoxAltJud.CheckedChanged += new System.EventHandler(this.checkBoxAltJud_CheckedChanged);
            // 
            // checkBoxAltaTara
            // 
            this.checkBoxAltaTara.AutoSize = true;
            this.checkBoxAltaTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxAltaTara.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxAltaTara.Location = new System.Drawing.Point(239, 427);
            this.checkBoxAltaTara.Name = "checkBoxAltaTara";
            this.checkBoxAltaTara.Size = new System.Drawing.Size(80, 21);
            this.checkBoxAltaTara.TabIndex = 30;
            this.checkBoxAltaTara.Text = "Alta tara";
            this.checkBoxAltaTara.UseVisualStyleBackColor = true;
            this.checkBoxAltaTara.CheckedChanged += new System.EventHandler(this.checkBoxAltaTara_CheckedChanged);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSex.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSex.Location = new System.Drawing.Point(50, 473);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(31, 17);
            this.labelSex.TabIndex = 31;
            this.labelSex.Text = "Sex";
            // 
            // checkBoxFeminin
            // 
            this.checkBoxFeminin.AutoSize = true;
            this.checkBoxFeminin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxFeminin.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxFeminin.Location = new System.Drawing.Point(139, 469);
            this.checkBoxFeminin.Name = "checkBoxFeminin";
            this.checkBoxFeminin.Size = new System.Drawing.Size(76, 21);
            this.checkBoxFeminin.TabIndex = 32;
            this.checkBoxFeminin.Text = "Feminin";
            this.checkBoxFeminin.UseVisualStyleBackColor = true;
            this.checkBoxFeminin.CheckedChanged += new System.EventHandler(this.checkBoxFeminin_CheckedChanged);
            // 
            // checkBoxAltceva
            // 
            this.checkBoxAltceva.AutoSize = true;
            this.checkBoxAltceva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxAltceva.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxAltceva.Location = new System.Drawing.Point(221, 469);
            this.checkBoxAltceva.Name = "checkBoxAltceva";
            this.checkBoxAltceva.Size = new System.Drawing.Size(62, 21);
            this.checkBoxAltceva.TabIndex = 33;
            this.checkBoxAltceva.Text = "Altele";
            this.checkBoxAltceva.UseVisualStyleBackColor = true;
            this.checkBoxAltceva.CheckedChanged += new System.EventHandler(this.checkBoxAltceva_CheckedChanged);
            // 
            // checkBoxMasculin
            // 
            this.checkBoxMasculin.AutoSize = true;
            this.checkBoxMasculin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxMasculin.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxMasculin.Location = new System.Drawing.Point(139, 494);
            this.checkBoxMasculin.Name = "checkBoxMasculin";
            this.checkBoxMasculin.Size = new System.Drawing.Size(82, 21);
            this.checkBoxMasculin.TabIndex = 34;
            this.checkBoxMasculin.Text = "Masculin";
            this.checkBoxMasculin.UseVisualStyleBackColor = true;
            this.checkBoxMasculin.CheckedChanged += new System.EventHandler(this.checkBoxMasculin_CheckedChanged);
            // 
            // buttonSalveaza
            // 
            this.buttonSalveaza.FlatAppearance.BorderSize = 0;
            this.buttonSalveaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalveaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSalveaza.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSalveaza.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.buttonSalveaza.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSalveaza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSalveaza.IconSize = 40;
            this.buttonSalveaza.Location = new System.Drawing.Point(67, 542);
            this.buttonSalveaza.Name = "buttonSalveaza";
            this.buttonSalveaza.Size = new System.Drawing.Size(130, 50);
            this.buttonSalveaza.TabIndex = 35;
            this.buttonSalveaza.Text = "Salveaza";
            this.buttonSalveaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalveaza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalveaza.UseVisualStyleBackColor = true;
            this.buttonSalveaza.Click += new System.EventHandler(this.buttonSalveaza_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.FlatAppearance.BorderSize = 0;
            this.buttonSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSterge.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSterge.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.buttonSterge.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSterge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSterge.IconSize = 40;
            this.buttonSterge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSterge.Location = new System.Drawing.Point(429, 542);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(115, 50);
            this.buttonSterge.TabIndex = 36;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSterge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // frmVizite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonSalveaza);
            this.Controls.Add(this.checkBoxMasculin);
            this.Controls.Add(this.checkBoxAltceva);
            this.Controls.Add(this.checkBoxFeminin);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.checkBoxAltaTara);
            this.Controls.Add(this.checkBoxAltJud);
            this.Controls.Add(this.checkBoxDB);
            this.Controls.Add(this.checkBoxTgv);
            this.Controls.Add(this.labelDomiciliu);
            this.Controls.Add(this.comboBoxSubiect);
            this.Controls.Add(this.labelSubiect);
            this.Controls.Add(this.comboBoxOcupatie);
            this.Controls.Add(this.labelOcupatie);
            this.Controls.Add(this.comboBoxStudii);
            this.Controls.Add(this.labelStudii);
            this.Controls.Add(this.checkBoxPeste60);
            this.Controls.Add(this.checkBox40o60);
            this.Controls.Add(this.checkBox25o40);
            this.Controls.Add(this.checkBox14o25);
            this.Controls.Add(this.checkBoxSub14A);
            this.Controls.Add(this.labelVasrta);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelAltfel);
            this.Controls.Add(this.textBoxAltfel);
            this.Controls.Add(this.checkBoxMesaj);
            this.Controls.Add(this.checkBoxMail);
            this.Controls.Add(this.checkBoxTelefon);
            this.Controls.Add(this.checkBoxIndirecta);
            this.Controls.Add(this.checkBoxDirecta);
            this.Controls.Add(this.labelTipVizita);
            this.Controls.Add(this.labelTitlu);
            this.Name = "frmVizite";
            this.Text = "Vizite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelTipVizita;
        private System.Windows.Forms.CheckBox checkBoxDirecta;
        private System.Windows.Forms.CheckBox checkBoxIndirecta;
        private System.Windows.Forms.CheckBox checkBoxTelefon;
        private System.Windows.Forms.CheckBox checkBoxMail;
        private System.Windows.Forms.CheckBox checkBoxMesaj;
        private System.Windows.Forms.TextBox textBoxAltfel;
        private System.Windows.Forms.Label labelAltfel;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelVasrta;
        private System.Windows.Forms.CheckBox checkBoxSub14A;
        private System.Windows.Forms.CheckBox checkBox14o25;
        private System.Windows.Forms.CheckBox checkBox25o40;
        private System.Windows.Forms.CheckBox checkBox40o60;
        private System.Windows.Forms.CheckBox checkBoxPeste60;
        private System.Windows.Forms.Label labelStudii;
        private System.Windows.Forms.ComboBox comboBoxStudii;
        private System.Windows.Forms.Label labelOcupatie;
        private System.Windows.Forms.ComboBox comboBoxOcupatie;
        private System.Windows.Forms.Label labelSubiect;
        private System.Windows.Forms.ComboBox comboBoxSubiect;
        private System.Windows.Forms.Label labelDomiciliu;
        private System.Windows.Forms.CheckBox checkBoxTgv;
        private System.Windows.Forms.CheckBox checkBoxDB;
        private System.Windows.Forms.CheckBox checkBoxAltJud;
        private System.Windows.Forms.CheckBox checkBoxAltaTara;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.CheckBox checkBoxFeminin;
        private System.Windows.Forms.CheckBox checkBoxAltceva;
        private System.Windows.Forms.CheckBox checkBoxMasculin;
        private FontAwesome.Sharp.IconButton buttonSalveaza;
        private FontAwesome.Sharp.IconButton buttonSterge;
    }
}