
namespace Project_POO
{
    partial class Seguimiento
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
            this.btn_Create = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Conf_Pass = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Conf_Pass = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.btn_Clean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Create.Location = new System.Drawing.Point(622, 493);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(156, 42);
            this.btn_Create.TabIndex = 36;
            this.btn_Create.Text = "Crear Usuario";
            this.btn_Create.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(110, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(595, 32);
            this.label7.TabIndex = 34;
            this.label7.Text = "Registro de empleados para uso del sistema";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Type.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Type.Location = new System.Drawing.Point(461, 390);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(155, 22);
            this.lbl_Type.TabIndex = 33;
            this.lbl_Type.Text = "Tipo de usuario*";
            // 
            // cmb_Type
            // 
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "Superadmin",
            "admin",
            "orientador",
            "vacunador"});
            this.cmb_Type.Location = new System.Drawing.Point(461, 415);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(317, 30);
            this.cmb_Type.TabIndex = 32;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Email.Location = new System.Drawing.Point(461, 223);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(195, 22);
            this.lbl_Email.TabIndex = 28;
            this.lbl_Email.Text = "Correo Institucional*";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(461, 248);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(317, 31);
            this.txt_Email.TabIndex = 25;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(67, 248);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(317, 31);
            this.txt_Name.TabIndex = 22;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Name.Location = new System.Drawing.Point(67, 223);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(189, 22);
            this.lbl_Name.TabIndex = 21;
            this.lbl_Name.Text = "Nombre Completo*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(382, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Pass.Location = new System.Drawing.Point(67, 308);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(128, 22);
            this.lbl_Pass.TabIndex = 40;
            this.lbl_Pass.Text = "Contraseña*";
            // 
            // lbl_Conf_Pass
            // 
            this.lbl_Conf_Pass.AutoSize = true;
            this.lbl_Conf_Pass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Conf_Pass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Conf_Pass.Location = new System.Drawing.Point(67, 390);
            this.lbl_Conf_Pass.Name = "lbl_Conf_Pass";
            this.lbl_Conf_Pass.Size = new System.Drawing.Size(220, 22);
            this.lbl_Conf_Pass.TabIndex = 41;
            this.lbl_Conf_Pass.Text = "Confirmar contraseña*";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(67, 333);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(317, 31);
            this.txt_Pass.TabIndex = 42;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // txt_Conf_Pass
            // 
            this.txt_Conf_Pass.Location = new System.Drawing.Point(67, 415);
            this.txt_Conf_Pass.Name = "txt_Conf_Pass";
            this.txt_Conf_Pass.Size = new System.Drawing.Size(317, 31);
            this.txt_Conf_Pass.TabIndex = 43;
            this.txt_Conf_Pass.UseSystemPasswordChar = true;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Address.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Address.Location = new System.Drawing.Point(461, 308);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(105, 22);
            this.lbl_Address.TabIndex = 23;
            this.lbl_Address.Text = "Dirección*";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(461, 333);
            this.txt_Address.MaxLength = 100;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(317, 31);
            this.txt_Address.TabIndex = 29;
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clean.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clean.ForeColor = System.Drawing.Color.White;
            this.btn_Clean.Location = new System.Drawing.Point(67, 493);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(130, 42);
            this.btn_Clean.TabIndex = 44;
            this.btn_Clean.Text = "Limpiar";
            this.btn_Clean.UseVisualStyleBackColor = false;
            // 
            // Seguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(872, 584);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.txt_Conf_Pass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.lbl_Conf_Pass);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Seguimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Conf_Pass;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Conf_Pass;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Button btn_Clean;
    }
}