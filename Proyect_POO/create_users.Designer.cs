
namespace Proyect_POO
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
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_centro = new System.Windows.Forms.ComboBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(67, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 22);
            this.label9.TabIndex = 38;
            this.label9.Text = "Centro de vacunacion*";
            // 
            // cmb_centro
            // 
            this.cmb_centro.FormattingEnabled = true;
            this.cmb_centro.Items.AddRange(new object[] {
            "Megacentro de Vacunacion - HES",
            "La Gran Via",
            "Hospital San rafael",
            "Unidad de Salud Barrios "});
            this.cmb_centro.Location = new System.Drawing.Point(67, 443);
            this.cmb_centro.Name = "cmb_centro";
            this.cmb_centro.Size = new System.Drawing.Size(256, 30);
            this.cmb_centro.TabIndex = 37;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(67, 505);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(156, 42);
            this.btn_crear.TabIndex = 36;
            this.btn_crear.Text = "Crear Usuario";
            this.btn_crear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(110, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(559, 32);
            this.label7.TabIndex = 34;
            this.label7.Text = "Creacion de usuario para uso del sistema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(461, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tipo de usuario*";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Superadmin",
            "admin",
            "orientador",
            "vacunador"});
            this.cmb_tipo.Location = new System.Drawing.Point(461, 348);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(256, 30);
            this.cmb_tipo.TabIndex = 32;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(67, 348);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(317, 31);
            this.txt_correo.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(67, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Correo Institucional*";
            // 
            // txt_dui
            // 
            this.txt_dui.Location = new System.Drawing.Point(461, 258);
            this.txt_dui.Name = "txt_dui";
            this.txt_dui.Size = new System.Drawing.Size(256, 31);
            this.txt_dui.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(461, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "# DUI*";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(67, 258);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(317, 31);
            this.txt_nombre.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(67, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre Completo*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyect_POO.Properties.Resources.logo_covid;
            this.pictureBox1.Location = new System.Drawing.Point(303, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 116);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(798, 584);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_centro);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Crear Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_centro;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}