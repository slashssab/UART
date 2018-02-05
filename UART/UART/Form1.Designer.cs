namespace UART
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetSerialPorts_Click = new System.Windows.Forms.Button();
            this.rtbIncoming = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetSerialPorts_Click
            // 
            this.btnGetSerialPorts_Click.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGetSerialPorts_Click.Location = new System.Drawing.Point(12, 12);
            this.btnGetSerialPorts_Click.Name = "btnGetSerialPorts_Click";
            this.btnGetSerialPorts_Click.Size = new System.Drawing.Size(95, 38);
            this.btnGetSerialPorts_Click.TabIndex = 0;
            this.btnGetSerialPorts_Click.Text = "Ports";
            this.btnGetSerialPorts_Click.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts_Click.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Location = new System.Drawing.Point(12, 151);
            this.rtbIncoming.Multiline = true;
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new System.Drawing.Size(258, 98);
            this.rtbIncoming.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rtbIncoming);
            this.Controls.Add(this.btnGetSerialPorts_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSerialPorts_Click;
        private System.Windows.Forms.TextBox rtbIncoming;
    }
}

