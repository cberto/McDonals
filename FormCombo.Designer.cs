namespace Mc_Donalds
{
    partial class FormCombo
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
            this.btnBorrarCupon = new System.Windows.Forms.Button();
            this.btnModificarCupon = new System.Windows.Forms.Button();
            this.btnAgregarCupon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorrarCupon
            // 
            this.btnBorrarCupon.BackColor = System.Drawing.Color.Yellow;
            this.btnBorrarCupon.FlatAppearance.BorderSize = 0;
            this.btnBorrarCupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarCupon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCupon.Location = new System.Drawing.Point(174, 12);
            this.btnBorrarCupon.Name = "btnBorrarCupon";
            this.btnBorrarCupon.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCupon.TabIndex = 5;
            this.btnBorrarCupon.Text = "BORRAR";
            this.btnBorrarCupon.UseVisualStyleBackColor = false;
            // 
            // btnModificarCupon
            // 
            this.btnModificarCupon.BackColor = System.Drawing.Color.Yellow;
            this.btnModificarCupon.FlatAppearance.BorderSize = 0;
            this.btnModificarCupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCupon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCupon.Location = new System.Drawing.Point(93, 12);
            this.btnModificarCupon.Name = "btnModificarCupon";
            this.btnModificarCupon.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCupon.TabIndex = 4;
            this.btnModificarCupon.Text = "MODIFICAR";
            this.btnModificarCupon.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCupon
            // 
            this.btnAgregarCupon.BackColor = System.Drawing.Color.Yellow;
            this.btnAgregarCupon.FlatAppearance.BorderSize = 0;
            this.btnAgregarCupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCupon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCupon.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarCupon.Name = "btnAgregarCupon";
            this.btnAgregarCupon.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCupon.TabIndex = 3;
            this.btnAgregarCupon.Text = "AGREGAR";
            this.btnAgregarCupon.UseVisualStyleBackColor = false;
            this.btnAgregarCupon.Click += new System.EventHandler(this.btnAgregarCupon_Click);
            // 
            // FormCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(463, 272);
            this.Controls.Add(this.btnBorrarCupon);
            this.Controls.Add(this.btnModificarCupon);
            this.Controls.Add(this.btnAgregarCupon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCombo";
            this.Text = "FormCombo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBorrarCupon;
        private System.Windows.Forms.Button btnModificarCupon;
        private System.Windows.Forms.Button btnAgregarCupon;
    }
}