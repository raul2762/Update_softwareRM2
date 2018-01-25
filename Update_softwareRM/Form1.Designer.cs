namespace Update_softwareRM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.status = new MetroFramework.Controls.MetroLabel();
            this.status_speed = new MetroFramework.Controls.MetroLabel();
            this.status_porcent = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.status_count = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(102, 130);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(269, 23);
            this.metroProgressBar1.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(203, 72);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 27);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Descargar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.status.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.status.Location = new System.Drawing.Point(102, 102);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(38, 25);
            this.status.TabIndex = 2;
            this.status.Text = "0%";
            // 
            // status_speed
            // 
            this.status_speed.AutoSize = true;
            this.status_speed.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.status_speed.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.status_speed.Location = new System.Drawing.Point(102, 156);
            this.status_speed.Name = "status_speed";
            this.status_speed.Size = new System.Drawing.Size(22, 25);
            this.status_speed.TabIndex = 3;
            this.status_speed.Text = "0";
            this.status_speed.Visible = false;
            // 
            // status_porcent
            // 
            this.status_porcent.AutoSize = true;
            this.status_porcent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.status_porcent.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.status_porcent.Location = new System.Drawing.Point(377, 130);
            this.status_porcent.Name = "status_porcent";
            this.status_porcent.Size = new System.Drawing.Size(38, 25);
            this.status_porcent.TabIndex = 4;
            this.status_porcent.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // status_count
            // 
            this.status_count.AutoSize = true;
            this.status_count.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.status_count.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.status_count.Location = new System.Drawing.Point(23, 190);
            this.status_count.Name = "status_count";
            this.status_count.Size = new System.Drawing.Size(17, 25);
            this.status_count.TabIndex = 5;
            this.status_count.Text = ".";
            this.status_count.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 221);
            this.Controls.Add(this.status_count);
            this.Controls.Add(this.status_porcent);
            this.Controls.Add(this.status_speed);
            this.Controls.Add(this.status);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroProgressBar1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Actualización de Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel status;
        private MetroFramework.Controls.MetroLabel status_speed;
        private MetroFramework.Controls.MetroLabel status_porcent;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel status_count;
    }
}

