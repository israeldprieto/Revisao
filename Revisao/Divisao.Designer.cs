namespace Revisao
{
    partial class Divisao
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
            tx_valor1 = new TextBox();
            tx_valor2 = new TextBox();
            bt_calcular = new Button();
            lb_resultado = new Label();
            SuspendLayout();
            // 
            // tx_valor1
            // 
            tx_valor1.Location = new Point(115, 75);
            tx_valor1.Name = "tx_valor1";
            tx_valor1.Size = new Size(100, 23);
            tx_valor1.TabIndex = 0;
            // 
            // tx_valor2
            // 
            tx_valor2.Location = new Point(115, 158);
            tx_valor2.Name = "tx_valor2";
            tx_valor2.Size = new Size(100, 23);
            tx_valor2.TabIndex = 1;
            // 
            // bt_calcular
            // 
            bt_calcular.Location = new Point(124, 237);
            bt_calcular.Name = "bt_calcular";
            bt_calcular.Size = new Size(75, 23);
            bt_calcular.TabIndex = 2;
            bt_calcular.Text = "calcular";
            bt_calcular.UseVisualStyleBackColor = true;
            bt_calcular.Click += bt_calcular_Click;
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(106, 207);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(38, 15);
            lb_resultado.TabIndex = 3;
            lb_resultado.Text = "label1";
            // 
            // Divisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 331);
            Controls.Add(lb_resultado);
            Controls.Add(bt_calcular);
            Controls.Add(tx_valor2);
            Controls.Add(tx_valor1);
            Name = "Divisao";
            Text = "Divisao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_valor1;
        private TextBox tx_valor2;
        private Button bt_calcular;
        private Label lb_resultado;
    }
}