namespace POOVentas
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
            btnVentaCredito = new Button();
            btnVentaContado = new Button();
            btnVentaCortesia = new Button();
            SuspendLayout();
            // 
            // btnVentaCredito
            // 
            btnVentaCredito.BackColor = SystemColors.ScrollBar;
            btnVentaCredito.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentaCredito.ForeColor = SystemColors.Desktop;
            btnVentaCredito.Location = new Point(29, 199);
            btnVentaCredito.Name = "btnVentaCredito";
            btnVentaCredito.Size = new Size(193, 137);
            btnVentaCredito.TabIndex = 0;
            btnVentaCredito.Text = "Venta Crédito";
            btnVentaCredito.UseVisualStyleBackColor = false;
            btnVentaCredito.Click += btnVentaCredito_Click;
            // 
            // btnVentaContado
            // 
            btnVentaContado.BackColor = SystemColors.ScrollBar;
            btnVentaContado.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentaContado.Location = new Point(258, 199);
            btnVentaContado.Name = "btnVentaContado";
            btnVentaContado.Size = new Size(199, 137);
            btnVentaContado.TabIndex = 1;
            btnVentaContado.Text = "Venta Contado";
            btnVentaContado.UseVisualStyleBackColor = false;
            btnVentaContado.Click += btnVentaContado_Click;
            // 
            // btnVentaCortesia
            // 
            btnVentaCortesia.BackColor = SystemColors.ScrollBar;
            btnVentaCortesia.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentaCortesia.Location = new Point(494, 199);
            btnVentaCortesia.Name = "btnVentaCortesia";
            btnVentaCortesia.Size = new Size(193, 137);
            btnVentaCortesia.TabIndex = 2;
            btnVentaCortesia.Text = "Venta Cortesía";
            btnVentaCortesia.UseVisualStyleBackColor = false;
            btnVentaCortesia.Click += btnVentaCortesia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 466);
            Controls.Add(btnVentaCortesia);
            Controls.Add(btnVentaContado);
            Controls.Add(btnVentaCredito);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVentaCredito;
        private Button btnVentaContado;
        private Button btnVentaCortesia;
    }
}
