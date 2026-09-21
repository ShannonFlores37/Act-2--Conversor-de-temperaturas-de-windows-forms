namespace Act_2__Conversor_de_temperaturas_de_windows_forms
{
    partial class Form1
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
            txtcen = new TextBox();
            txtfa = new TextBox();
            lblcentigrados = new Label();
            Lblfa = new Label();
            btnaceptar = new Button();
            SuspendLayout();
            // 
            // txtcen
            // 
            txtcen.Location = new Point(272, 58);
            txtcen.Name = "txtcen";
            txtcen.Size = new Size(379, 23);
            txtcen.TabIndex = 0;
            txtcen.KeyPress += txtcen_KeyPress;
            // 
            // txtfa
            // 
            txtfa.Location = new Point(272, 168);
            txtfa.Name = "txtfa";
            txtfa.Size = new Size(379, 23);
            txtfa.TabIndex = 1;
            txtfa.KeyPress += txtfa_KeyPress;
            // 
            // lblcentigrados
            // 
            lblcentigrados.AutoSize = true;
            lblcentigrados.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcentigrados.Location = new Point(57, 58);
            lblcentigrados.Name = "lblcentigrados";
            lblcentigrados.Size = new Size(192, 30);
            lblcentigrados.TabIndex = 2;
            lblcentigrados.Text = "Grados centigrados";
            // 
            // Lblfa
            // 
            Lblfa.AutoSize = true;
            Lblfa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lblfa.Location = new Point(57, 159);
            Lblfa.Name = "Lblfa";
            Lblfa.Size = new Size(192, 30);
            Lblfa.TabIndex = 3;
            Lblfa.Text = "Grados Faherenheit";
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(584, 334);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(146, 65);
            btnaceptar.TabIndex = 4;
            btnaceptar.Text = "Aceptar";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnaceptar);
            Controls.Add(Lblfa);
            Controls.Add(lblcentigrados);
            Controls.Add(txtfa);
            Controls.Add(txtcen);
            Name = "Form1";
            Text = "Conversor de temperatura";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcen;
        private TextBox txtfa;
        private Label lblcentigrados;
        private Label Lblfa;
        private Button btnaceptar;
    }
}
