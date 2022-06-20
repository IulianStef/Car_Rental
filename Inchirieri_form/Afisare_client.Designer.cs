
namespace Inchirieri_form
{
    partial class Afisare_client
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClientDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administrareClientiFisierTextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrenumeClientTb = new System.Windows.Forms.TextBox();
            this.NumeClientTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CautareBtn = new MetroFramework.Controls.MetroButton();
            this.RezultatCautareClientlb = new System.Windows.Forms.ListBox();
            this.RefreshBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrareClientiFisierTextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientDGV
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Maroon;
            this.ClientDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClientDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientDGV.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ClientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientDGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.ClientDGV.EnableHeadersVisualStyles = false;
            this.ClientDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientDGV.Location = new System.Drawing.Point(32, 148);
            this.ClientDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientDGV.Name = "ClientDGV";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ClientDGV.RowHeadersWidth = 51;
            this.ClientDGV.RowTemplate.Height = 24;
            this.ClientDGV.Size = new System.Drawing.Size(1032, 400);
            this.ClientDGV.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idClient";
            this.Column1.HeaderText = "Id Client";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nume";
            this.Column2.HeaderText = "Nume";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "prenume";
            this.Column3.HeaderText = "Prenume";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cnp";
            this.Column4.HeaderText = "CNP";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "telefon";
            this.Column5.HeaderText = "Nr Telefon";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GenClient";
            this.Column6.HeaderText = "Gen";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // administrareClientiFisierTextBindingSource
            // 
            this.administrareClientiFisierTextBindingSource.DataSource = typeof(StocareDate.AdministrareClienti_FisierText);
            // 
            // PrenumeClientTb
            // 
            this.PrenumeClientTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.PrenumeClientTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenumeClientTb.Location = new System.Drawing.Point(181, 87);
            this.PrenumeClientTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrenumeClientTb.Name = "PrenumeClientTb";
            this.PrenumeClientTb.Size = new System.Drawing.Size(204, 28);
            this.PrenumeClientTb.TabIndex = 51;
            // 
            // NumeClientTb
            // 
            this.NumeClientTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.NumeClientTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeClientTb.Location = new System.Drawing.Point(181, 27);
            this.NumeClientTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumeClientTb.Name = "NumeClientTb";
            this.NumeClientTb.Size = new System.Drawing.Size(204, 28);
            this.NumeClientTb.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(96, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(96, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nume";
            // 
            // CautareBtn
            // 
            this.CautareBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CautareBtn.Location = new System.Drawing.Point(408, 87);
            this.CautareBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CautareBtn.Name = "CautareBtn";
            this.CautareBtn.Size = new System.Drawing.Size(102, 28);
            this.CautareBtn.TabIndex = 54;
            this.CautareBtn.Text = "Cauta";
            this.CautareBtn.UseSelectable = true;
            this.CautareBtn.Click += new System.EventHandler(this.CautareBtn_Click);
            // 
            // RezultatCautareClientlb
            // 
            this.RezultatCautareClientlb.FormattingEnabled = true;
            this.RezultatCautareClientlb.ItemHeight = 20;
            this.RezultatCautareClientlb.Location = new System.Drawing.Point(541, 31);
            this.RezultatCautareClientlb.Name = "RezultatCautareClientlb";
            this.RezultatCautareClientlb.Size = new System.Drawing.Size(444, 84);
            this.RezultatCautareClientlb.TabIndex = 55;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.RefreshBtn.Location = new System.Drawing.Point(473, 555);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(103, 39);
            this.RefreshBtn.TabIndex = 56;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseSelectable = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Inchirieri_form.Properties.Resources.png_transparent_computer_icons_symbol_arrow_left_arrow_miscellaneous_measurement_logo;
            this.pictureBox2.Location = new System.Drawing.Point(11, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(43, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "Inapoi";
            this.label6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label6_MouseClick);
            // 
            // Afisare_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1076, 605);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.RezultatCautareClientlb);
            this.Controls.Add(this.CautareBtn);
            this.Controls.Add(this.PrenumeClientTb);
            this.Controls.Add(this.NumeClientTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientDGV);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Afisare_client";
            this.Text = "Afisare_client";
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrareClientiFisierTextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource administrareClientiFisierTextBindingSource;
        private System.Windows.Forms.DataGridView ClientDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox PrenumeClientTb;
        private System.Windows.Forms.TextBox NumeClientTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton CautareBtn;
        private System.Windows.Forms.ListBox RezultatCautareClientlb;
        private MetroFramework.Controls.MetroButton RefreshBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}