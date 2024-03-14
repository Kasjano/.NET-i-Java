namespace Graficzny_Interfejs_Uzytkownika
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textNumber = new TextBox();
            textSeed = new TextBox();
            textCapacity = new TextBox();
            label4 = new Label();
            textResult = new TextBox();
            label5 = new Label();
            textInstance = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 223);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 17);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "number of items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 84);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 147);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "capacity";
            // 
            // textNumber
            // 
            textNumber.Location = new Point(33, 35);
            textNumber.Name = "textNumber";
            textNumber.Size = new Size(100, 23);
            textNumber.TabIndex = 4;
            textNumber.TextChanged += textBox1_TextChanged;
            // 
            // textSeed
            // 
            textSeed.Location = new Point(33, 102);
            textSeed.Name = "textSeed";
            textSeed.Size = new Size(100, 23);
            textSeed.TabIndex = 5;
            textSeed.TextChanged += textBox2_TextChanged;
            // 
            // textCapacity
            // 
            textCapacity.Location = new Point(31, 165);
            textCapacity.Name = "textCapacity";
            textCapacity.Size = new Size(100, 23);
            textCapacity.TabIndex = 6;
            textCapacity.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(714, 9);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "instance";
            // 
            // textResult
            // 
            textResult.Location = new Point(33, 269);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.Size = new Size(359, 158);
            textResult.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 251);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "results";
            // 
            // textInstance
            // 
            textInstance.Location = new Point(409, 27);
            textInstance.Multiline = true;
            textInstance.Name = "textInstance";
            textInstance.Size = new Size(356, 400);
            textInstance.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textInstance);
            Controls.Add(label5);
            Controls.Add(textResult);
            Controls.Add(label4);
            Controls.Add(textCapacity);
            Controls.Add(textSeed);
            Controls.Add(textNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textNumber;
        private TextBox textSeed;
        private TextBox textCapacity;
        private Label label4;
        private TextBox textResult;
        private Label label5;
        private TextBox textInstance;
    }
}
