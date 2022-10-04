namespace Interfata_dbo_EUROPEDIRECT
{
    partial class frmModificari
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
            this.labelColumn = new System.Windows.Forms.Label();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.labelValoare = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.checkBoxAllTime = new System.Windows.Forms.CheckBox();
            this.checkBoxYday = new System.Windows.Forms.CheckBox();
            this.checkBoxTday = new System.Windows.Forms.CheckBox();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.labelNumeIntreg = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.dataGridViewVizite = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new FontAwesome.Sharp.IconButton();
            this.checkBoxFeminin = new System.Windows.Forms.CheckBox();
            this.checkBoxMasculin = new System.Windows.Forms.CheckBox();
            this.checkBoxAltele = new System.Windows.Forms.CheckBox();
            this.labelSex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVizite)).BeginInit();
            this.SuspendLayout();
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelColumn.Location = new System.Drawing.Point(10, 30);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(58, 16);
            this.labelColumn.TabIndex = 3;
            this.labelColumn.Text = "Coloana";
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Items.AddRange(new object[] {
            "TipulVizitei",
            "Prenume",
            "Nume",
            "Varsta",
            "Studii",
            "Ocupatie",
            "Subiect",
            "Domiciliu",
            "Sex",
            "DataInregistrari"});
            this.comboBoxColumn.Location = new System.Drawing.Point(13, 60);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(121, 24);
            this.comboBoxColumn.TabIndex = 22;
            // 
            // labelValoare
            // 
            this.labelValoare.AutoSize = true;
            this.labelValoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoare.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelValoare.Location = new System.Drawing.Point(140, 30);
            this.labelValoare.Name = "labelValoare";
            this.labelValoare.Size = new System.Drawing.Size(118, 16);
            this.labelValoare.TabIndex = 23;
            this.labelValoare.Text = "Valoarea coloanei";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(143, 60);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(120, 22);
            this.textBoxValue.TabIndex = 24;
            // 
            // checkBoxAllTime
            // 
            this.checkBoxAllTime.AutoSize = true;
            this.checkBoxAllTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxAllTime.Location = new System.Drawing.Point(280, 106);
            this.checkBoxAllTime.Name = "checkBoxAllTime";
            this.checkBoxAllTime.Size = new System.Drawing.Size(106, 20);
            this.checkBoxAllTime.TabIndex = 27;
            this.checkBoxAllTime.Text = "Toate vizitele";
            this.checkBoxAllTime.UseVisualStyleBackColor = true;
            this.checkBoxAllTime.CheckedChanged += new System.EventHandler(this.checkBoxAllTime_CheckedChanged);
            // 
            // checkBoxYday
            // 
            this.checkBoxYday.AutoSize = true;
            this.checkBoxYday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxYday.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxYday.Location = new System.Drawing.Point(280, 83);
            this.checkBoxYday.Name = "checkBoxYday";
            this.checkBoxYday.Size = new System.Drawing.Size(44, 20);
            this.checkBoxYday.TabIndex = 26;
            this.checkBoxYday.Text = "Ieri";
            this.checkBoxYday.UseVisualStyleBackColor = true;
            this.checkBoxYday.CheckedChanged += new System.EventHandler(this.checkBoxYday_CheckedChanged);
            // 
            // checkBoxTday
            // 
            this.checkBoxTday.AutoSize = true;
            this.checkBoxTday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTday.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxTday.Location = new System.Drawing.Point(280, 60);
            this.checkBoxTday.Name = "checkBoxTday";
            this.checkBoxTday.Size = new System.Drawing.Size(62, 20);
            this.checkBoxTday.TabIndex = 25;
            this.checkBoxTday.Text = "Astazi";
            this.checkBoxTday.UseVisualStyleBackColor = true;
            this.checkBoxTday.CheckedChanged += new System.EventHandler(this.checkBoxTday_CheckedChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelData.Location = new System.Drawing.Point(275, 30);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(36, 16);
            this.labelData.TabIndex = 28;
            this.labelData.Text = "Data";
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenume.Location = new System.Drawing.Point(390, 60);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(120, 22);
            this.textBoxPrenume.TabIndex = 29;
            // 
            // labelNumeIntreg
            // 
            this.labelNumeIntreg.AutoSize = true;
            this.labelNumeIntreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeIntreg.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNumeIntreg.Location = new System.Drawing.Point(390, 30);
            this.labelNumeIntreg.Name = "labelNumeIntreg";
            this.labelNumeIntreg.Size = new System.Drawing.Size(113, 16);
            this.labelNumeIntreg.TabIndex = 30;
            this.labelNumeIntreg.Text = "Prenume si Nume";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNume.Location = new System.Drawing.Point(390, 100);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(120, 22);
            this.textBoxNume.TabIndex = 31;
            // 
            // dataGridViewVizite
            // 
            this.dataGridViewVizite.AllowUserToAddRows = false;
            this.dataGridViewVizite.AllowUserToDeleteRows = false;
            this.dataGridViewVizite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVizite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridViewVizite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVizite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVizite.Location = new System.Drawing.Point(0, 206);
            this.dataGridViewVizite.Name = "dataGridViewVizite";
            this.dataGridViewVizite.ReadOnly = true;
            this.dataGridViewVizite.RowHeadersWidth = 30;
            this.dataGridViewVizite.Size = new System.Drawing.Size(1044, 150);
            this.dataGridViewVizite.TabIndex = 32;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUpdate.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.buttonUpdate.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUpdate.IconSize = 40;
            this.buttonUpdate.Location = new System.Drawing.Point(645, 65);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 50);
            this.buttonUpdate.TabIndex = 33;
            this.buttonUpdate.Text = "Modifica";
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // checkBoxFeminin
            // 
            this.checkBoxFeminin.AutoSize = true;
            this.checkBoxFeminin.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxFeminin.Location = new System.Drawing.Point(545, 59);
            this.checkBoxFeminin.Name = "checkBoxFeminin";
            this.checkBoxFeminin.Size = new System.Drawing.Size(62, 17);
            this.checkBoxFeminin.TabIndex = 34;
            this.checkBoxFeminin.Text = "Feminin";
            this.checkBoxFeminin.UseVisualStyleBackColor = true;
            this.checkBoxFeminin.CheckedChanged += new System.EventHandler(this.checkBoxFeminin_CheckedChanged);
            // 
            // checkBoxMasculin
            // 
            this.checkBoxMasculin.AutoSize = true;
            this.checkBoxMasculin.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxMasculin.Location = new System.Drawing.Point(545, 83);
            this.checkBoxMasculin.Name = "checkBoxMasculin";
            this.checkBoxMasculin.Size = new System.Drawing.Size(68, 17);
            this.checkBoxMasculin.TabIndex = 35;
            this.checkBoxMasculin.Text = "Masculin";
            this.checkBoxMasculin.UseVisualStyleBackColor = true;
            this.checkBoxMasculin.CheckedChanged += new System.EventHandler(this.checkBoxMasculin_CheckedChanged);
            // 
            // checkBoxAltele
            // 
            this.checkBoxAltele.AutoSize = true;
            this.checkBoxAltele.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxAltele.Location = new System.Drawing.Point(545, 107);
            this.checkBoxAltele.Name = "checkBoxAltele";
            this.checkBoxAltele.Size = new System.Drawing.Size(52, 17);
            this.checkBoxAltele.TabIndex = 36;
            this.checkBoxAltele.Text = "Altele";
            this.checkBoxAltele.UseVisualStyleBackColor = true;
            this.checkBoxAltele.CheckedChanged += new System.EventHandler(this.checkBoxAltele_CheckedChanged);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSex.Location = new System.Drawing.Point(566, 32);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(25, 13);
            this.labelSex.TabIndex = 37;
            this.labelSex.Text = "Sex";
            // 
            // frmModificari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.checkBoxAltele);
            this.Controls.Add(this.checkBoxMasculin);
            this.Controls.Add(this.checkBoxFeminin);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewVizite);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNumeIntreg);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.checkBoxAllTime);
            this.Controls.Add(this.checkBoxYday);
            this.Controls.Add(this.checkBoxTday);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelValoare);
            this.Controls.Add(this.comboBoxColumn);
            this.Controls.Add(this.labelColumn);
            this.Name = "frmModificari";
            this.Text = "Modificari";
            this.Load += new System.EventHandler(this.frmModificari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVizite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private System.Windows.Forms.Label labelValoare;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.CheckBox checkBoxAllTime;
        private System.Windows.Forms.CheckBox checkBoxYday;
        private System.Windows.Forms.CheckBox checkBoxTday;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.Label labelNumeIntreg;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.DataGridView dataGridViewVizite;
        private FontAwesome.Sharp.IconButton buttonUpdate;
        private System.Windows.Forms.CheckBox checkBoxFeminin;
        private System.Windows.Forms.CheckBox checkBoxMasculin;
        private System.Windows.Forms.CheckBox checkBoxAltele;
        private System.Windows.Forms.Label labelSex;
    }
}