
namespace Proyect_POO
{
    partial class FrmCreateAppointment
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
            this.lbl_TitleCreate = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_DUI = new System.Windows.Forms.Label();
            this.txt_DUI = new System.Windows.Forms.TextBox();
            this.lbl_TypeDoc = new System.Windows.Forms.Label();
            this.cmb_TypeDoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.clb_CD = new System.Windows.Forms.CheckedListBox();
            this.btn_Create_Appointment = new System.Windows.Forms.Button();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.gpb_CD = new System.Windows.Forms.GroupBox();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.img_Logo_CreateAppointment = new System.Windows.Forms.PictureBox();
            this.gpb_CD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo_CreateAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TitleCreate
            // 
            this.lbl_TitleCreate.AutoSize = true;
            this.lbl_TitleCreate.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TitleCreate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_TitleCreate.Location = new System.Drawing.Point(237, 58);
            this.lbl_TitleCreate.Name = "lbl_TitleCreate";
            this.lbl_TitleCreate.Size = new System.Drawing.Size(470, 32);
            this.lbl_TitleCreate.TabIndex = 13;
            this.lbl_TitleCreate.Text = "Creación de cita para vacunacion";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Name.Location = new System.Drawing.Point(121, 122);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(191, 23);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Nombre Completo*";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Name.Location = new System.Drawing.Point(121, 147);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(348, 27);
            this.txt_Name.TabIndex = 2;
            // 
            // lbl_DUI
            // 
            this.lbl_DUI.AutoSize = true;
            this.lbl_DUI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DUI.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_DUI.Location = new System.Drawing.Point(549, 312);
            this.lbl_DUI.Name = "lbl_DUI";
            this.lbl_DUI.Size = new System.Drawing.Size(49, 23);
            this.lbl_DUI.TabIndex = 3;
            this.lbl_DUI.Text = "DUI*";
            // 
            // txt_DUI
            // 
            this.txt_DUI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DUI.Location = new System.Drawing.Point(549, 337);
            this.txt_DUI.MaxLength = 10;
            this.txt_DUI.Name = "txt_DUI";
            this.txt_DUI.PlaceholderText = "########-#";
            this.txt_DUI.Size = new System.Drawing.Size(348, 27);
            this.txt_DUI.TabIndex = 4;
            // 
            // lbl_TypeDoc
            // 
            this.lbl_TypeDoc.AutoSize = true;
            this.lbl_TypeDoc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TypeDoc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_TypeDoc.Location = new System.Drawing.Point(546, 122);
            this.lbl_TypeDoc.Name = "lbl_TypeDoc";
            this.lbl_TypeDoc.Size = new System.Drawing.Size(198, 23);
            this.lbl_TypeDoc.TabIndex = 5;
            this.lbl_TypeDoc.Text = "Tipo de documento*";
            // 
            // cmb_TypeDoc
            // 
            this.cmb_TypeDoc.BackColor = System.Drawing.Color.MintCream;
            this.cmb_TypeDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_TypeDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TypeDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_TypeDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_TypeDoc.FormattingEnabled = true;
            this.cmb_TypeDoc.Items.AddRange(new object[] {
            "DUI",
            "NIT",
            "Pasaporte",
            "Carnet de Residente",
            "Otro"});
            this.cmb_TypeDoc.Location = new System.Drawing.Point(546, 145);
            this.cmb_TypeDoc.Name = "cmb_TypeDoc";
            this.cmb_TypeDoc.Size = new System.Drawing.Size(348, 29);
            this.cmb_TypeDoc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(121, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo*";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.Location = new System.Drawing.Point(121, 247);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(348, 27);
            this.txt_Email.TabIndex = 8;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Checked = false;
            this.dtp_BirthDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_BirthDate.Location = new System.Drawing.Point(121, 430);
            this.dtp_BirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.ShowCheckBox = true;
            this.dtp_BirthDate.Size = new System.Drawing.Size(348, 27);
            this.dtp_BirthDate.TabIndex = 9;
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BirthDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_BirthDate.Location = new System.Drawing.Point(121, 405);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(207, 23);
            this.lbl_BirthDate.TabIndex = 10;
            this.lbl_BirthDate.Text = "Fecha de nacimiento";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Address.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Address.Location = new System.Drawing.Point(546, 222);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(106, 23);
            this.lbl_Address.TabIndex = 12;
            this.lbl_Address.Text = "Dirección*";
            // 
            // clb_CD
            // 
            this.clb_CD.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clb_CD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_CD.ColumnWidth = 225;
            this.clb_CD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_CD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clb_CD.ForeColor = System.Drawing.Color.White;
            this.clb_CD.FormattingEnabled = true;
            this.clb_CD.Items.AddRange(new object[] {
            "Diabetes",
            "Asma",
            "EPOC",
            "Obesidad",
            "Enfermedad Cardiovascular",
            "Hipertensión arterial",
            "Hepatopatías crónicas",
            "Enfermedad renal crónica",
            "VIH",
            "Cáncer",
            "Transplante de órganos"});
            this.clb_CD.Location = new System.Drawing.Point(3, 23);
            this.clb_CD.MultiColumn = true;
            this.clb_CD.Name = "clb_CD";
            this.clb_CD.Size = new System.Drawing.Size(418, 247);
            this.clb_CD.TabIndex = 3;
            // 
            // btn_Create_Appointment
            // 
            this.btn_Create_Appointment.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Create_Appointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create_Appointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create_Appointment.Location = new System.Drawing.Point(336, 584);
            this.btn_Create_Appointment.Name = "btn_Create_Appointment";
            this.btn_Create_Appointment.Size = new System.Drawing.Size(133, 42);
            this.btn_Create_Appointment.TabIndex = 15;
            this.btn_Create_Appointment.Text = "Crear Cita";
            this.btn_Create_Appointment.UseVisualStyleBackColor = false;
            this.btn_Create_Appointment.Click += new System.EventHandler(this.btn_Create_Appointment_Click);
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Address.Location = new System.Drawing.Point(549, 247);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(348, 27);
            this.txt_Address.TabIndex = 20;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Tel.Location = new System.Drawing.Point(121, 312);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(95, 23);
            this.lbl_Tel.TabIndex = 21;
            this.lbl_Tel.Text = "Teléfono*";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Tel.Location = new System.Drawing.Point(121, 337);
            this.txt_Tel.MaxLength = 9;
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.PlaceholderText = "####-####";
            this.txt_Tel.Size = new System.Drawing.Size(348, 27);
            this.txt_Tel.TabIndex = 22;
            // 
            // gpb_CD
            // 
            this.gpb_CD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_CD.Controls.Add(this.clb_CD);
            this.gpb_CD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_CD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpb_CD.ForeColor = System.Drawing.Color.White;
            this.gpb_CD.Location = new System.Drawing.Point(546, 393);
            this.gpb_CD.Name = "gpb_CD";
            this.gpb_CD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpb_CD.Size = new System.Drawing.Size(424, 273);
            this.gpb_CD.TabIndex = 23;
            this.gpb_CD.TabStop = false;
            this.gpb_CD.Text = "Seleccionar enfermedades crónicas";
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clean.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clean.ForeColor = System.Drawing.Color.White;
            this.btn_Clean.Location = new System.Drawing.Point(121, 584);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(130, 42);
            this.btn_Clean.TabIndex = 24;
            this.btn_Clean.Text = "Limpiar";
            this.btn_Clean.UseVisualStyleBackColor = false;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // img_Logo_CreateAppointment
            // 
            this.img_Logo_CreateAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_Logo_CreateAppointment.Image = global::Project_POO.Properties.Resources.IMG_4042;
            this.img_Logo_CreateAppointment.Location = new System.Drawing.Point(12, 8);
            this.img_Logo_CreateAppointment.Name = "img_Logo_CreateAppointment";
            this.img_Logo_CreateAppointment.Size = new System.Drawing.Size(126, 111);
            this.img_Logo_CreateAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Logo_CreateAppointment.TabIndex = 25;
            this.img_Logo_CreateAppointment.TabStop = false;
            // 
            // FrmCreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1006, 694);
            this.Controls.Add(this.img_Logo_CreateAppointment);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.gpb_CD);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.btn_Create_Appointment);
            this.Controls.Add(this.lbl_TitleCreate);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.dtp_BirthDate);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_TypeDoc);
            this.Controls.Add(this.lbl_TypeDoc);
            this.Controls.Add(this.txt_DUI);
            this.Controls.Add(this.lbl_DUI);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCreateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear cita";
            this.Load += new System.EventHandler(this.Create_Load);
            this.gpb_CD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo_CreateAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TitleCreate;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_DUI;
        private System.Windows.Forms.Label lbl_TypeDoc;
        private System.Windows.Forms.ComboBox cmb_TypeDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.Label lbl_BirthDate;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.CheckedListBox clb_CD;
        private System.Windows.Forms.Button btn_Create_Appointment;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_DUI;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.TextBox txt_Tel;
        internal System.Windows.Forms.GroupBox gpb_CD;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.PictureBox img_Logo_CreateAppointment;
    }
}