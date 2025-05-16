namespace Proyecto_Hotel
{
    partial class MenuPrincipal
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
            this.btnReservaHabitacion = new System.Windows.Forms.Button();
            this.btnImprecionFactura = new System.Windows.Forms.Button();
            this.btnSlidaHuesped = new System.Windows.Forms.Button();
            this.btnConsultaHitacion = new System.Windows.Forms.Button();
            this.btnGestionHbitacion = new System.Windows.Forms.Button();
            this.btnSlir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReservaHabitacion
            // 
            this.btnReservaHabitacion.Location = new System.Drawing.Point(32, 76);
            this.btnReservaHabitacion.Name = "btnReservaHabitacion";
            this.btnReservaHabitacion.Size = new System.Drawing.Size(190, 55);
            this.btnReservaHabitacion.TabIndex = 0;
            this.btnReservaHabitacion.Text = "Reserva de haitacion";
            this.btnReservaHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnImprecionFactura
            // 
            this.btnImprecionFactura.Location = new System.Drawing.Point(277, 81);
            this.btnImprecionFactura.Name = "btnImprecionFactura";
            this.btnImprecionFactura.Size = new System.Drawing.Size(175, 50);
            this.btnImprecionFactura.TabIndex = 1;
            this.btnImprecionFactura.Text = "Imprecion de factura";
            this.btnImprecionFactura.UseVisualStyleBackColor = true;
            // 
            // btnSlidaHuesped
            // 
            this.btnSlidaHuesped.Location = new System.Drawing.Point(32, 159);
            this.btnSlidaHuesped.Name = "btnSlidaHuesped";
            this.btnSlidaHuesped.Size = new System.Drawing.Size(190, 56);
            this.btnSlidaHuesped.TabIndex = 2;
            this.btnSlidaHuesped.Text = "Salida de huesped";
            this.btnSlidaHuesped.UseVisualStyleBackColor = true;
            // 
            // btnConsultaHitacion
            // 
            this.btnConsultaHitacion.Location = new System.Drawing.Point(277, 159);
            this.btnConsultaHitacion.Name = "btnConsultaHitacion";
            this.btnConsultaHitacion.Size = new System.Drawing.Size(175, 56);
            this.btnConsultaHitacion.TabIndex = 3;
            this.btnConsultaHitacion.Text = "Consultar habitacion";
            this.btnConsultaHitacion.UseVisualStyleBackColor = true;
            // 
            // btnGestionHbitacion
            // 
            this.btnGestionHbitacion.Location = new System.Drawing.Point(167, 243);
            this.btnGestionHbitacion.Name = "btnGestionHbitacion";
            this.btnGestionHbitacion.Size = new System.Drawing.Size(190, 51);
            this.btnGestionHbitacion.TabIndex = 4;
            this.btnGestionHbitacion.Text = "Gestion de haitacion";
            this.btnGestionHbitacion.UseVisualStyleBackColor = true;
            // 
            // btnSlir
            // 
            this.btnSlir.Location = new System.Drawing.Point(406, 312);
            this.btnSlir.Name = "btnSlir";
            this.btnSlir.Size = new System.Drawing.Size(95, 32);
            this.btnSlir.TabIndex = 5;
            this.btnSlir.Text = "Salir";
            this.btnSlir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hotel \"El Sol\"";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSlir);
            this.Controls.Add(this.btnGestionHbitacion);
            this.Controls.Add(this.btnConsultaHitacion);
            this.Controls.Add(this.btnSlidaHuesped);
            this.Controls.Add(this.btnImprecionFactura);
            this.Controls.Add(this.btnReservaHabitacion);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservaHabitacion;
        private System.Windows.Forms.Button btnImprecionFactura;
        private System.Windows.Forms.Button btnSlidaHuesped;
        private System.Windows.Forms.Button btnConsultaHitacion;
        private System.Windows.Forms.Button btnGestionHbitacion;
        private System.Windows.Forms.Button btnSlir;
        private System.Windows.Forms.Label label1;
    }
}