
namespace Project_POO
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.img_LogoLogin = new System.Windows.Forms.PictureBox();
            this.lbl_Title_Login = new System.Windows.Forms.Label();
            this.lbl_Center = new System.Windows.Forms.Label();
            this.cmb_Center = new System.Windows.Forms.ComboBox();
            this.btn_Create_Appointment = new System.Windows.Forms.Button();
            this.btn_Clean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_LogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Email.Location = new System.Drawing.Point(60, 225);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(186, 22);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "Correo Institucional";
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.Location = new System.Drawing.Point(60, 250);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(460, 28);
            this.txt_Email.TabIndex = 2;
            // 
            // txt_Pass
            // 
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pass.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Pass.Location = new System.Drawing.Point(60, 339);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(460, 28);
            this.txt_Pass.TabIndex = 4;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Pass.Location = new System.Drawing.Point(60, 314);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(119, 22);
            this.lbl_Pass.TabIndex = 3;
            this.lbl_Pass.Text = "Contraseña";
            // 
            // img_LogoLogin
            // 
            this.img_LogoLogin.Image = global::Project_POO.Properties.Resources.IMG_4042;
            this.img_LogoLogin.Location = new System.Drawing.Point(211, 12);
            this.img_LogoLogin.Name = "img_LogoLogin";
            this.img_LogoLogin.Size = new System.Drawing.Size(164, 145);
            this.img_LogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_LogoLogin.TabIndex = 7;
            this.img_LogoLogin.TabStop = false;
            // 
            // lbl_Title_Login
            // 
            this.lbl_Title_Login.AutoSize = true;
            this.lbl_Title_Login.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title_Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Title_Login.Location = new System.Drawing.Point(184, 160);
            this.lbl_Title_Login.Name = "lbl_Title_Login";
            this.lbl_Title_Login.Size = new System.Drawing.Size(217, 32);
            this.lbl_Title_Login.TabIndex = 6;
            this.lbl_Title_Login.Text = "Inicio de Sesión";
            // 
            // lbl_Center
            // 
            this.lbl_Center.AutoSize = true;
            this.lbl_Center.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Center.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Center.Location = new System.Drawing.Point(60, 405);
            this.lbl_Center.Name = "lbl_Center";
            this.lbl_Center.Size = new System.Drawing.Size(74, 22);
            this.lbl_Center.TabIndex = 8;
            this.lbl_Center.Text = "Centro";
            this.lbl_Center.Visible = false;
            // 
            // cmb_Center
            // 
            this.cmb_Center.BackColor = System.Drawing.Color.MintCream;
            this.cmb_Center.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Center.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Center.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Center.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Center.FormattingEnabled = true;
            this.cmb_Center.Location = new System.Drawing.Point(60, 430);
            this.cmb_Center.Name = "cmb_Center";
            this.cmb_Center.Size = new System.Drawing.Size(460, 29);
            this.cmb_Center.TabIndex = 9;
            this.cmb_Center.Visible = false;
            // 
            // btn_Create_Appointment
            // 
            this.btn_Create_Appointment.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Create_Appointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create_Appointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create_Appointment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Create_Appointment.Location = new System.Drawing.Point(394, 509);
            this.btn_Create_Appointment.Name = "btn_Create_Appointment";
            this.btn_Create_Appointment.Size = new System.Drawing.Size(126, 42);
            this.btn_Create_Appointment.TabIndex = 16;
            this.btn_Create_Appointment.Text = "Iniciar";
            this.btn_Create_Appointment.UseVisualStyleBackColor = false;
            this.btn_Create_Appointment.Click += new System.EventHandler(this.btn_Create_Appointment_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clean.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clean.ForeColor = System.Drawing.Color.White;
            this.btn_Clean.Location = new System.Drawing.Point(60, 509);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(130, 42);
            this.btn_Clean.TabIndex = 17;
            this.btn_Clean.Text = "Limpiar";
            this.btn_Clean.UseVisualStyleBackColor = false;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(574, 588);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.btn_Create_Appointment);
            this.Controls.Add(this.cmb_Center);
            this.Controls.Add(this.lbl_Center);
            this.Controls.Add(this.lbl_Title_Login);
            this.Controls.Add(this.img_LogoLogin);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_LogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.PictureBox img_LogoLogin;
        private System.Windows.Forms.Label lbl_Title_Login;
        private System.Windows.Forms.Label lbl_Center;
        private System.Windows.Forms.ComboBox cmb_Center;
        private System.Windows.Forms.Button btn_Create_Appointment;
        private System.Windows.Forms.Button btn_Clean;
    }
}

