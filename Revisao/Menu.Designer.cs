namespace Revisao
{
    partial class Menu
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
            bt_dividir = new Button();
            SuspendLayout();
            // 
            // bt_dividir
            // 
            bt_dividir.Location = new Point(98, 112);
            bt_dividir.Name = "bt_dividir";
            bt_dividir.Size = new Size(85, 45);
            bt_dividir.TabIndex = 0;
            bt_dividir.Text = "dividir";
            bt_dividir.UseVisualStyleBackColor = true;
            bt_dividir.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_dividir);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_dividir;
    }
}