namespace HelloWindowsForms
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            lblCategoria = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 0;
            label1.Text = "Sistema IMC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(281, 171);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 1;
            label2.Text = "Altura:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(299, 116);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 2;
            label3.Text = "Peso:";
            label3.Click += label3_Click;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtAltura.Location = new Point(367, 164);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(150, 39);
            txtAltura.TabIndex = 3;
            txtAltura.TextChanged += textBox1_TextChanged;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtPeso.Location = new Point(367, 109);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(150, 39);
            txtPeso.TabIndex = 4;
            txtPeso.TextChanged += textBox2_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCalcular.Location = new Point(336, 245);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(142, 42);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblResultado.Location = new Point(239, 308);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(134, 32);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCategoria.Location = new Point(239, 350);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(138, 32);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria: ";
            lblCategoria.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCategoria);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Button btnCalcular;
        private Label lblResultado;
        private Label lblCategoria;
    }
}
