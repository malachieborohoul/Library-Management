namespace GestionBibiothèque
{
    partial class EmpruntLivre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idEmprunt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.etuCB = new System.Windows.Forms.ComboBox();
            this.EmpruntLivreDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label9 = new System.Windows.Forms.Label();
            this.etuPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.etuEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.etuPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.etuNom = new System.Windows.Forms.TextBox();
            this.dateEmprunt = new Bunifu.Framework.UI.BunifuDatepicker();
            this.livreCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpruntLivreDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Matricule";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "N°";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idEmprunt
            // 
            this.idEmprunt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idEmprunt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEmprunt.Location = new System.Drawing.Point(196, 158);
            this.idEmprunt.Name = "idEmprunt";
            this.idEmprunt.Size = new System.Drawing.Size(207, 19);
            this.idEmprunt.TabIndex = 22;
            this.idEmprunt.TextChanged += new System.EventHandler(this.idEmprunt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(680, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPRUNTER LIVRES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1554, 99);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GestionBibiothèque.Properties.Resources.diagram_06_24511;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1180, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestionBibiothèque.Properties.Resources.exit_close_error_15565_1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1318, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // etuCB
            // 
            this.etuCB.FormattingEnabled = true;
            this.etuCB.Location = new System.Drawing.Point(198, 213);
            this.etuCB.Name = "etuCB";
            this.etuCB.Size = new System.Drawing.Size(205, 24);
            this.etuCB.TabIndex = 38;
            this.etuCB.SelectedIndexChanged += new System.EventHandler(this.etuCB_SelectedIndexChanged);
            this.etuCB.SelectionChangeCommitted += new System.EventHandler(this.etuCB_SelectionChangeCommitted);
            // 
            // EmpruntLivreDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmpruntLivreDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpruntLivreDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.EmpruntLivreDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpruntLivreDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpruntLivreDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpruntLivreDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpruntLivreDGV.DoubleBuffered = true;
            this.EmpruntLivreDGV.EnableHeadersVisualStyles = false;
            this.EmpruntLivreDGV.HeaderBgColor = System.Drawing.Color.Maroon;
            this.EmpruntLivreDGV.HeaderForeColor = System.Drawing.Color.White;
            this.EmpruntLivreDGV.Location = new System.Drawing.Point(430, 142);
            this.EmpruntLivreDGV.Name = "EmpruntLivreDGV";
            this.EmpruntLivreDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpruntLivreDGV.RowTemplate.Height = 24;
            this.EmpruntLivreDGV.Size = new System.Drawing.Size(1066, 570);
            this.EmpruntLivreDGV.TabIndex = 40;
            this.EmpruntLivreDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpruntLivreDGV_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(18, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 67;
            this.label9.Text = "Téléphone";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // etuPhone
            // 
            this.etuPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.etuPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etuPhone.Location = new System.Drawing.Point(198, 413);
            this.etuPhone.Name = "etuPhone";
            this.etuPhone.Size = new System.Drawing.Size(207, 19);
            this.etuPhone.TabIndex = 68;
            this.etuPhone.TextChanged += new System.EventHandler(this.etuPhone_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 65;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // etuEmail
            // 
            this.etuEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.etuEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etuEmail.Location = new System.Drawing.Point(198, 369);
            this.etuEmail.Name = "etuEmail";
            this.etuEmail.Size = new System.Drawing.Size(207, 19);
            this.etuEmail.TabIndex = 66;
            this.etuEmail.TextChanged += new System.EventHandler(this.etuEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 63;
            this.label7.Text = "Prenom";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // etuPrenom
            // 
            this.etuPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.etuPrenom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etuPrenom.Location = new System.Drawing.Point(198, 323);
            this.etuPrenom.Name = "etuPrenom";
            this.etuPrenom.Size = new System.Drawing.Size(207, 19);
            this.etuPrenom.TabIndex = 64;
            this.etuPrenom.TextChanged += new System.EventHandler(this.etuPrenom_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 61;
            this.label5.Text = "Nom";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // etuNom
            // 
            this.etuNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.etuNom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etuNom.Location = new System.Drawing.Point(198, 273);
            this.etuNom.Name = "etuNom";
            this.etuNom.Size = new System.Drawing.Size(207, 19);
            this.etuNom.TabIndex = 62;
            this.etuNom.TextChanged += new System.EventHandler(this.etuNom_TextChanged);
            // 
            // dateEmprunt
            // 
            this.dateEmprunt.BackColor = System.Drawing.Color.Maroon;
            this.dateEmprunt.BorderRadius = 0;
            this.dateEmprunt.ForeColor = System.Drawing.Color.White;
            this.dateEmprunt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateEmprunt.FormatCustom = null;
            this.dateEmprunt.Location = new System.Drawing.Point(196, 512);
            this.dateEmprunt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateEmprunt.Name = "dateEmprunt";
            this.dateEmprunt.Size = new System.Drawing.Size(207, 23);
            this.dateEmprunt.TabIndex = 60;
            this.dateEmprunt.Value = new System.DateTime(2022, 5, 10, 17, 50, 47, 232);
            this.dateEmprunt.onValueChanged += new System.EventHandler(this.dateEmprunt_onValueChanged);
            // 
            // livreCb
            // 
            this.livreCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livreCb.FormattingEnabled = true;
            this.livreCb.Location = new System.Drawing.Point(198, 455);
            this.livreCb.Name = "livreCb";
            this.livreCb.Size = new System.Drawing.Size(207, 33);
            this.livreCb.TabIndex = 59;
            this.livreCb.SelectedIndexChanged += new System.EventHandler(this.livreCb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 53;
            this.label6.Text = "Date";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Livre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::GestionBibiothèque.Properties.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(309, 632);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 39);
            this.pictureBox5.TabIndex = 58;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::GestionBibiothèque.Properties.Resources.flat_style_circle_edit_icon_icons_com_66939;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(178, 632);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 39);
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GestionBibiothèque.Properties.Resources.flat_style_circle_add_icon_icons_com_66944;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(48, 632);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 39);
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // EmpruntLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 767);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.etuPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.etuEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.etuPrenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.etuNom);
            this.Controls.Add(this.dateEmprunt);
            this.Controls.Add(this.livreCb);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmpruntLivreDGV);
            this.Controls.Add(this.etuCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idEmprunt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpruntLivre";
            this.Text = "EmpruntLivre";
            this.Load += new System.EventHandler(this.EmpruntLivre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpruntLivreDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idEmprunt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox etuCB;
        private Bunifu.Framework.UI.BunifuCustomDataGrid EmpruntLivreDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox livreCb;
        private Bunifu.Framework.UI.BunifuDatepicker dateEmprunt;
        private System.Windows.Forms.TextBox etuNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox etuPrenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox etuEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox etuPhone;
        private System.Windows.Forms.Label label9;
    }
}