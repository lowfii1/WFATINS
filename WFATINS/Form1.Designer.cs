namespace WFATINS
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
            textBox1 = new TextBox();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            button1 = new Button();
            cmbOperacao = new ComboBox();
            btnCalcular = new Button();
            Valor1 = new Label();
            Valor2 = new Label();
            label3 = new Label();
            lstResultado = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.DoubleClick += textBox1_DoubleClick;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(84, 88);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(172, 23);
            txtValor1.TabIndex = 1;
            txtValor1.TextChanged += txtValor1_TextChanged;
            txtValor1.MouseDoubleClick += txtValor1_MouseDoubleClick;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(84, 125);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(172, 23);
            txtValor2.TabIndex = 2;
            txtValor2.MouseHover += txtValor2_MouseHover;
            // 
            // button1
            // 
            button1.Location = new Point(290, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbOperacao
            // 
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { " + - Adição", " - - Subtração", " / - Divisão", " * - Multiplicação" });
            cmbOperacao.Location = new Point(84, 167);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(172, 23);
            cmbOperacao.TabIndex = 4;
            cmbOperacao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(290, 167);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button2_Click;
            btnCalcular.MouseDown += btnCalcular_MouseDown;
            // 
            // Valor1
            // 
            Valor1.AutoSize = true;
            Valor1.Location = new Point(23, 91);
            Valor1.Name = "Valor1";
            Valor1.Size = new Size(42, 15);
            Valor1.TabIndex = 6;
            Valor1.Text = "Valor 1";
            // 
            // Valor2
            // 
            Valor2.AutoSize = true;
            Valor2.Location = new Point(23, 133);
            Valor2.Name = "Valor2";
            Valor2.Size = new Size(42, 15);
            Valor2.TabIndex = 7;
            Valor2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 170);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Operação";
            // 
            // lstResultado
            // 
            lstResultado.BackColor = Color.White;
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(290, 208);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(137, 169);
            lstResultado.TabIndex = 9;
            lstResultado.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 593);
            Controls.Add(lstResultado);
            Controls.Add(label3);
            Controls.Add(Valor2);
            Controls.Add(Valor1);
            Controls.Add(btnCalcular);
            Controls.Add(cmbOperacao);
            Controls.Add(button1);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Button button1;
        private ComboBox cmbOperacao;
        private Button btnCalcular;
        private Label Valor1;
        private Label Valor2;
        private Label label3;
        private ListBox lstResultado;
    }
}
