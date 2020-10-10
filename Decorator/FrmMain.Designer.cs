namespace Decorator
{
    partial class FrmMain
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
            this.btnFabricar = new System.Windows.Forms.Button();
            this.linkCerrar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnFabricar
            // 
            this.btnFabricar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFabricar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnFabricar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFabricar.Location = new System.Drawing.Point(80, 85);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(202, 87);
            this.btnFabricar.TabIndex = 0;
            this.btnFabricar.Text = "Fabricar Auto";
            this.btnFabricar.UseVisualStyleBackColor = false;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // linkCerrar
            // 
            this.linkCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCerrar.Location = new System.Drawing.Point(287, 218);
            this.linkCerrar.Name = "linkCerrar";
            this.linkCerrar.Size = new System.Drawing.Size(62, 28);
            this.linkCerrar.TabIndex = 0;
            this.linkCerrar.TabStop = true;
            this.linkCerrar.Text = "Cerrar";
            this.linkCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(361, 262);
            this.Controls.Add(this.linkCerrar);
            this.Controls.Add(this.btnFabricar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.LinkLabel linkCerrar;
    }
}