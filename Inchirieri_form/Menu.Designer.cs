
namespace Inchirieri_form
{
    partial class Menu
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
            this.ClientBtn = new MetroFramework.Controls.MetroButton();
            this.MasiniBtn = new MetroFramework.Controls.MetroButton();
            this.InchirieriBtn = new MetroFramework.Controls.MetroButton();
            this.CloseBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientBtn
            // 
            this.ClientBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ClientBtn.Location = new System.Drawing.Point(176, 102);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(110, 45);
            this.ClientBtn.TabIndex = 1;
            this.ClientBtn.Text = "Clienti";
            this.ClientBtn.UseSelectable = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // MasiniBtn
            // 
            this.MasiniBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MasiniBtn.Location = new System.Drawing.Point(176, 162);
            this.MasiniBtn.Name = "MasiniBtn";
            this.MasiniBtn.Size = new System.Drawing.Size(110, 45);
            this.MasiniBtn.TabIndex = 2;
            this.MasiniBtn.Text = "Masini";
            this.MasiniBtn.UseSelectable = true;
            this.MasiniBtn.Click += new System.EventHandler(this.MasiniBtn_Click);
            // 
            // InchirieriBtn
            // 
            this.InchirieriBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.InchirieriBtn.Location = new System.Drawing.Point(176, 220);
            this.InchirieriBtn.Name = "InchirieriBtn";
            this.InchirieriBtn.Size = new System.Drawing.Size(110, 45);
            this.InchirieriBtn.TabIndex = 3;
            this.InchirieriBtn.Text = "Inchirieri";
            this.InchirieriBtn.UseSelectable = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CloseBtn.Location = new System.Drawing.Point(176, 280);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(110, 45);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseSelectable = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inchirieri_form.Properties.Resources.depositphotos_268023170_stock_illustration_vector_logo_for_car_rental;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(452, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MasiniBtn);
            this.Controls.Add(this.InchirieriBtn);
            this.Controls.Add(this.ClientBtn);
            this.Name = "Menu";
            this.Text = "Meniu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton ClientBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton MasiniBtn;
        private MetroFramework.Controls.MetroButton InchirieriBtn;
        private MetroFramework.Controls.MetroButton CloseBtn;
    }
}