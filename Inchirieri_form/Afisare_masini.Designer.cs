
namespace Inchirieri_form
{
    partial class Afisare_masini
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MasinaDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezultatCautareMasinalb = new System.Windows.Forms.ListBox();
            this.CautareBtn = new MetroFramework.Controls.MetroButton();
            this.ModelMasinaTb = new System.Windows.Forms.TextBox();
            this.MarcaMasinaTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RefreshBtn = new MetroFramework.Controls.MetroButton();
            this.CloseBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MasinaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MasinaDGV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            this.MasinaDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MasinaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MasinaDGV.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MasinaDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MasinaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasinaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MasinaDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.MasinaDGV.EnableHeadersVisualStyles = false;
            this.MasinaDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MasinaDGV.Location = new System.Drawing.Point(39, 130);
            this.MasinaDGV.Name = "MasinaDGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MasinaDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MasinaDGV.RowHeadersWidth = 51;
            this.MasinaDGV.RowTemplate.Height = 24;
            this.MasinaDGV.Size = new System.Drawing.Size(1085, 334);
            this.MasinaDGV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idMasina";
            this.Column1.HeaderText = "Id Masina";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "firma";
            this.Column2.HeaderText = "Firma";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "model";
            this.Column3.HeaderText = "Model";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "an_fabricatie";
            this.Column4.HeaderText = "An Fabricatie";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CuloriDisponibile";
            this.Column5.HeaderText = "Culoare";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MotorizariDisponibile";
            this.Column7.HeaderText = "Motorizare";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TransmisieDisponibila";
            this.Column8.HeaderText = "Transmisie";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OptiuniDisponibile";
            this.Column6.HeaderText = "Optiuni";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // RezultatCautareMasinalb
            // 
            this.RezultatCautareMasinalb.FormattingEnabled = true;
            this.RezultatCautareMasinalb.ItemHeight = 16;
            this.RezultatCautareMasinalb.Location = new System.Drawing.Point(604, 17);
            this.RezultatCautareMasinalb.Name = "RezultatCautareMasinalb";
            this.RezultatCautareMasinalb.Size = new System.Drawing.Size(444, 84);
            this.RezultatCautareMasinalb.TabIndex = 61;
            // 
            // CautareBtn
            // 
            this.CautareBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CautareBtn.Location = new System.Drawing.Point(471, 73);
            this.CautareBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CautareBtn.Name = "CautareBtn";
            this.CautareBtn.Size = new System.Drawing.Size(102, 28);
            this.CautareBtn.TabIndex = 60;
            this.CautareBtn.Text = "Cauta";
            this.CautareBtn.UseSelectable = true;
            this.CautareBtn.Click += new System.EventHandler(this.CautareBtn_Click);
            // 
            // ModelMasinaTb
            // 
            this.ModelMasinaTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ModelMasinaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelMasinaTb.Location = new System.Drawing.Point(244, 73);
            this.ModelMasinaTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModelMasinaTb.Name = "ModelMasinaTb";
            this.ModelMasinaTb.Size = new System.Drawing.Size(204, 28);
            this.ModelMasinaTb.TabIndex = 57;
            // 
            // MarcaMasinaTb
            // 
            this.MarcaMasinaTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.MarcaMasinaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaMasinaTb.Location = new System.Drawing.Point(244, 13);
            this.MarcaMasinaTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MarcaMasinaTb.Name = "MarcaMasinaTb";
            this.MarcaMasinaTb.Size = new System.Drawing.Size(204, 28);
            this.MarcaMasinaTb.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(123, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "Model masina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(123, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "Marca masina";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.RefreshBtn.Location = new System.Drawing.Point(618, 477);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(103, 39);
            this.RefreshBtn.TabIndex = 62;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseSelectable = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CloseBtn.Location = new System.Drawing.Point(476, 478);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(107, 38);
            this.CloseBtn.TabIndex = 63;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseSelectable = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Inchirieri_form.Properties.Resources.png_transparent_computer_icons_symbol_arrow_left_arrow_miscellaneous_measurement_logo;
            this.pictureBox2.Location = new System.Drawing.Point(22, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(54, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "Inapoi";
            this.label6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label6_MouseClick);
            // 
            // Afisare_masini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1153, 528);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.RezultatCautareMasinalb);
            this.Controls.Add(this.CautareBtn);
            this.Controls.Add(this.ModelMasinaTb);
            this.Controls.Add(this.MarcaMasinaTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MasinaDGV);
            this.Name = "Afisare_masini";
            this.Text = "Afisare masini";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.MasinaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MasinaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ListBox RezultatCautareMasinalb;
        private MetroFramework.Controls.MetroButton CautareBtn;
        private System.Windows.Forms.TextBox ModelMasinaTb;
        private System.Windows.Forms.TextBox MarcaMasinaTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton RefreshBtn;
        private MetroFramework.Controls.MetroButton CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}