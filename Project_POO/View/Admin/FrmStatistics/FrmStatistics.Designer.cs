
namespace Project_POO.View
{
    partial class FrmStatistics
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
            this.tlp_Stats = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_SE_Stats = new System.Windows.Forms.Label();
            this.sts_Admin = new System.Windows.Forms.StatusStrip();
            this.lbl_AdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Admin = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpb_EFS = new System.Windows.Forms.GroupBox();
            this.gpb_Efficiency = new System.Windows.Forms.GroupBox();
            this.gpb_VaccinatedPeople = new System.Windows.Forms.GroupBox();
            this.tlp_VaccinatedPeople = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Title_Vaccinated1 = new System.Windows.Forms.Label();
            this.lbl_Title_Vaccinated2 = new System.Windows.Forms.Label();
            this.lbl_NumVaccinated1 = new System.Windows.Forms.Label();
            this.lbl_Title_VaccinatedTotal = new System.Windows.Forms.Label();
            this.lbl_NumVaccinated2 = new System.Windows.Forms.Label();
            this.lbl_NumVaccinatedTotal = new System.Windows.Forms.Label();
            this.tlp_Stats.SuspendLayout();
            this.sts_Admin.SuspendLayout();
            this.gpb_VaccinatedPeople.SuspendLayout();
            this.tlp_VaccinatedPeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Stats
            // 
            this.tlp_Stats.ColumnCount = 7;
            this.tlp_Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.785602F));
            this.tlp_Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9108F));
            this.tlp_Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9108F));
            this.tlp_Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.785602F));
            this.tlp_Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9108F));
            this.tlp_Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9108F));
            this.tlp_Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.785602F));
            this.tlp_Stats.Controls.Add(this.label2, 4, 2);
            this.tlp_Stats.Controls.Add(this.gpb_Efficiency, 4, 3);
            this.tlp_Stats.Controls.Add(this.lbl_SE_Stats, 1, 2);
            this.tlp_Stats.Controls.Add(this.sts_Admin, 0, 6);
            this.tlp_Stats.Controls.Add(this.gpb_EFS, 1, 3);
            this.tlp_Stats.Controls.Add(this.gpb_VaccinatedPeople, 1, 1);
            this.tlp_Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Stats.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tlp_Stats.Location = new System.Drawing.Point(0, 0);
            this.tlp_Stats.Name = "tlp_Stats";
            this.tlp_Stats.RowCount = 7;
            this.tlp_Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.859155F));
            this.tlp_Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60563F));
            this.tlp_Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.859155F));
            this.tlp_Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60563F));
            this.tlp_Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60563F));
            this.tlp_Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60563F));
            this.tlp_Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.859155F));
            this.tlp_Stats.Size = new System.Drawing.Size(866, 515);
            this.tlp_Stats.TabIndex = 1;
            // 
            // lbl_SE_Stats
            // 
            this.lbl_SE_Stats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SE_Stats.AutoSize = true;
            this.tlp_Stats.SetColumnSpan(this.lbl_SE_Stats, 2);
            this.lbl_SE_Stats.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_SE_Stats.Location = new System.Drawing.Point(61, 140);
            this.lbl_SE_Stats.Name = "lbl_SE_Stats";
            this.lbl_SE_Stats.Size = new System.Drawing.Size(338, 50);
            this.lbl_SE_Stats.TabIndex = 0;
            this.lbl_SE_Stats.Text = "Estadísticas de los efectos secundarios";
            this.lbl_SE_Stats.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // sts_Admin
            // 
            this.sts_Admin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tlp_Stats.SetColumnSpan(this.sts_Admin, 7);
            this.sts_Admin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sts_Admin.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.sts_Admin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sts_Admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_AdminName,
            this.lbl_Admin});
            this.sts_Admin.Location = new System.Drawing.Point(0, 488);
            this.sts_Admin.Name = "sts_Admin";
            this.sts_Admin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sts_Admin.Size = new System.Drawing.Size(800, 27);
            this.sts_Admin.TabIndex = 41;
            this.sts_Admin.Text = "Bienvenido:";
            // 
            // lbl_AdminName
            // 
            this.lbl_AdminName.ForeColor = System.Drawing.Color.White;
            this.lbl_AdminName.Name = "lbl_AdminName";
            this.lbl_AdminName.Size = new System.Drawing.Size(182, 22);
            this.lbl_AdminName.Text = "Nombre del Admin";
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Admin.ForeColor = System.Drawing.Color.White;
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(130, 22);
            this.lbl_Admin.Text = "-Administrador-";
            // 
            // gpb_EFS
            // 
            this.gpb_EFS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_EFS.BackColor = System.Drawing.Color.MintCream;
            this.tlp_Stats.SetColumnSpan(this.gpb_EFS, 2);
            this.gpb_EFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpb_EFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_EFS.Location = new System.Drawing.Point(61, 193);
            this.gpb_EFS.Name = "gpb_EFS";
            this.tlp_Stats.SetRowSpan(this.gpb_EFS, 3);
            this.gpb_EFS.Size = new System.Drawing.Size(338, 264);
            this.gpb_EFS.TabIndex = 1;
            this.gpb_EFS.TabStop = false;
            // 
            // gpb_Efficiency
            // 
            this.gpb_Efficiency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_Efficiency.BackColor = System.Drawing.Color.MintCream;
            this.tlp_Stats.SetColumnSpan(this.gpb_Efficiency, 2);
            this.gpb_Efficiency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpb_Efficiency.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_Efficiency.Location = new System.Drawing.Point(463, 193);
            this.gpb_Efficiency.Name = "gpb_Efficiency";
            this.tlp_Stats.SetRowSpan(this.gpb_Efficiency, 3);
            this.gpb_Efficiency.Size = new System.Drawing.Size(338, 264);
            this.gpb_Efficiency.TabIndex = 2;
            this.gpb_Efficiency.TabStop = false;
            // 
            // gpb_VaccinatedPeople
            // 
            this.gpb_VaccinatedPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_VaccinatedPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tlp_Stats.SetColumnSpan(this.gpb_VaccinatedPeople, 5);
            this.gpb_VaccinatedPeople.Controls.Add(this.tlp_VaccinatedPeople);
            this.gpb_VaccinatedPeople.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_VaccinatedPeople.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpb_VaccinatedPeople.ForeColor = System.Drawing.Color.White;
            this.gpb_VaccinatedPeople.Location = new System.Drawing.Point(61, 53);
            this.gpb_VaccinatedPeople.Name = "gpb_VaccinatedPeople";
            this.gpb_VaccinatedPeople.Size = new System.Drawing.Size(740, 84);
            this.gpb_VaccinatedPeople.TabIndex = 42;
            this.gpb_VaccinatedPeople.TabStop = false;
            this.gpb_VaccinatedPeople.Text = "Estadística de personas vacunadas según el número de dosis";
            // 
            // tlp_VaccinatedPeople
            // 
            this.tlp_VaccinatedPeople.ColumnCount = 3;
            this.tlp_VaccinatedPeople.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_VaccinatedPeople.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_VaccinatedPeople.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_VaccinatedPeople.Controls.Add(this.lbl_NumVaccinatedTotal, 2, 1);
            this.tlp_VaccinatedPeople.Controls.Add(this.lbl_NumVaccinated2, 1, 1);
            this.tlp_VaccinatedPeople.Controls.Add(this.lbl_Title_VaccinatedTotal, 2, 0);
            this.tlp_VaccinatedPeople.Controls.Add(this.lbl_NumVaccinated1, 0, 1);
            this.tlp_VaccinatedPeople.Controls.Add(this.lbl_Title_Vaccinated2, 1, 0);
            this.tlp_VaccinatedPeople.Controls.Add(this.lbl_Title_Vaccinated1, 0, 0);
            this.tlp_VaccinatedPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_VaccinatedPeople.Location = new System.Drawing.Point(3, 18);
            this.tlp_VaccinatedPeople.Name = "tlp_VaccinatedPeople";
            this.tlp_VaccinatedPeople.RowCount = 2;
            this.tlp_VaccinatedPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_VaccinatedPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_VaccinatedPeople.Size = new System.Drawing.Size(734, 63);
            this.tlp_VaccinatedPeople.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.tlp_Stats.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(463, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eficiencia del proceso de vacunación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_Title_Vaccinated1
            // 
            this.lbl_Title_Vaccinated1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title_Vaccinated1.AutoSize = true;
            this.lbl_Title_Vaccinated1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title_Vaccinated1.Location = new System.Drawing.Point(3, 0);
            this.lbl_Title_Vaccinated1.Name = "lbl_Title_Vaccinated1";
            this.lbl_Title_Vaccinated1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Title_Vaccinated1.Size = new System.Drawing.Size(238, 31);
            this.lbl_Title_Vaccinated1.TabIndex = 0;
            this.lbl_Title_Vaccinated1.Text = "Vacunadas en primera cita";
            this.lbl_Title_Vaccinated1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Title_Vaccinated1.Click += new System.EventHandler(this.lbl_Title_Vaccinated1_Click);
            // 
            // lbl_Title_Vaccinated2
            // 
            this.lbl_Title_Vaccinated2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title_Vaccinated2.AutoSize = true;
            this.lbl_Title_Vaccinated2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title_Vaccinated2.Location = new System.Drawing.Point(247, 0);
            this.lbl_Title_Vaccinated2.Name = "lbl_Title_Vaccinated2";
            this.lbl_Title_Vaccinated2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Title_Vaccinated2.Size = new System.Drawing.Size(238, 31);
            this.lbl_Title_Vaccinated2.TabIndex = 1;
            this.lbl_Title_Vaccinated2.Text = "Vacunadas en segunda cita";
            this.lbl_Title_Vaccinated2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_NumVaccinated1
            // 
            this.lbl_NumVaccinated1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NumVaccinated1.AutoSize = true;
            this.lbl_NumVaccinated1.Location = new System.Drawing.Point(3, 31);
            this.lbl_NumVaccinated1.Name = "lbl_NumVaccinated1";
            this.lbl_NumVaccinated1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_NumVaccinated1.Size = new System.Drawing.Size(238, 32);
            this.lbl_NumVaccinated1.TabIndex = 1;
            this.lbl_NumVaccinated1.Text = "Numero1";
            this.lbl_NumVaccinated1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Title_VaccinatedTotal
            // 
            this.lbl_Title_VaccinatedTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title_VaccinatedTotal.AutoSize = true;
            this.lbl_Title_VaccinatedTotal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title_VaccinatedTotal.Location = new System.Drawing.Point(491, 0);
            this.lbl_Title_VaccinatedTotal.Name = "lbl_Title_VaccinatedTotal";
            this.lbl_Title_VaccinatedTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Title_VaccinatedTotal.Size = new System.Drawing.Size(240, 31);
            this.lbl_Title_VaccinatedTotal.TabIndex = 2;
            this.lbl_Title_VaccinatedTotal.Text = "Total de vacunaciones";
            this.lbl_Title_VaccinatedTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_NumVaccinated2
            // 
            this.lbl_NumVaccinated2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NumVaccinated2.AutoSize = true;
            this.lbl_NumVaccinated2.Location = new System.Drawing.Point(247, 31);
            this.lbl_NumVaccinated2.Name = "lbl_NumVaccinated2";
            this.lbl_NumVaccinated2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_NumVaccinated2.Size = new System.Drawing.Size(238, 32);
            this.lbl_NumVaccinated2.TabIndex = 2;
            this.lbl_NumVaccinated2.Text = "Numero2";
            this.lbl_NumVaccinated2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NumVaccinatedTotal
            // 
            this.lbl_NumVaccinatedTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NumVaccinatedTotal.AutoSize = true;
            this.lbl_NumVaccinatedTotal.Location = new System.Drawing.Point(491, 31);
            this.lbl_NumVaccinatedTotal.Name = "lbl_NumVaccinatedTotal";
            this.lbl_NumVaccinatedTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_NumVaccinatedTotal.Size = new System.Drawing.Size(240, 32);
            this.lbl_NumVaccinatedTotal.TabIndex = 2;
            this.lbl_NumVaccinatedTotal.Text = "Numero3";
            this.lbl_NumVaccinatedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(866, 515);
            this.Controls.Add(this.tlp_Stats);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmStatistics";
            this.Text = "Estadísticas";
            this.tlp_Stats.ResumeLayout(false);
            this.tlp_Stats.PerformLayout();
            this.sts_Admin.ResumeLayout(false);
            this.sts_Admin.PerformLayout();
            this.gpb_VaccinatedPeople.ResumeLayout(false);
            this.tlp_VaccinatedPeople.ResumeLayout(false);
            this.tlp_VaccinatedPeople.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Stats;
        private System.Windows.Forms.Label lbl_SE_Stats;
        private System.Windows.Forms.GroupBox gpb_EFS;
        private System.Windows.Forms.StatusStrip sts_Admin;
        private System.Windows.Forms.ToolStripStatusLabel lbl_AdminName;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Admin;
        private System.Windows.Forms.GroupBox gpb_Efficiency;
        private System.Windows.Forms.GroupBox gpb_VaccinatedPeople;
        private System.Windows.Forms.TableLayoutPanel tlp_VaccinatedPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Title_Vaccinated1;
        private System.Windows.Forms.Label lbl_Title_Vaccinated2;
        private System.Windows.Forms.Label lbl_NumVaccinated1;
        private System.Windows.Forms.Label lbl_Title_VaccinatedTotal;
        private System.Windows.Forms.Label lbl_NumVaccinated2;
        private System.Windows.Forms.Label lbl_NumVaccinatedTotal;
    }
}