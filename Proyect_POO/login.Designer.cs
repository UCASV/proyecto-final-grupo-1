
namespace Proyect_POO
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(158, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DUI/Email";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_user.Location = new System.Drawing.Point(158, 252);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(262, 31);
            this.txt_user.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pass.Location = new System.Drawing.Point(158, 339);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(262, 31);
            this.txt_pass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(158, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // img1
            // 
            this.img1.Image = global::Proyect_POO.Properties.Resources.logo_covid;
            this.img1.Location = new System.Drawing.Point(212, 31);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(164, 116);
            this.img1.TabIndex = 5;
            this.img1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(184, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inicio de Sesion";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(583, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Label label3;
    }
}

