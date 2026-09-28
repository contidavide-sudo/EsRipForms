namespace EsRipForms
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
            txtCel = new TextBox();
            button1 = new Button();
            n1 = new TextBox();
            n2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ris3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 25);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Celsius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 47);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // txtCel
            // 
            txtCel.Location = new Point(33, 44);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(100, 23);
            txtCel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(235, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // n1
            // 
            n1.Location = new Point(33, 127);
            n1.Name = "n1";
            n1.Size = new Size(100, 23);
            n1.TabIndex = 5;
            // 
            // n2
            // 
            n2.Location = new Point(159, 128);
            n2.Name = "n2";
            n2.Size = new Size(100, 23);
            n2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(275, 127);
            button2.Name = "button2";
            button2.Size = new Size(35, 23);
            button2.TabIndex = 7;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(316, 128);
            button3.Name = "button3";
            button3.Size = new Size(35, 23);
            button3.TabIndex = 8;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(357, 128);
            button4.Name = "button4";
            button4.Size = new Size(35, 23);
            button4.TabIndex = 9;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(398, 128);
            button5.Name = "button5";
            button5.Size = new Size(35, 23);
            button5.TabIndex = 10;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ris3
            // 
            ris3.AutoSize = true;
            ris3.Location = new Point(466, 132);
            ris3.Name = "ris3";
            ris3.Size = new Size(0, 15);
            ris3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ris3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(button1);
            Controls.Add(txtCel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCel;
        private Button button1;
        private TextBox n1;
        private TextBox n2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label ris3;
    }
}
