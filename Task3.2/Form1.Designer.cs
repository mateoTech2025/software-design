namespace Task3._2
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
            textBoxBase = new TextBox();
            textBoxExpo = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxBase
            // 
            textBoxBase.Location = new Point(265, 163);
            textBoxBase.Name = "textBoxBase";
            textBoxBase.Size = new Size(100, 23);
            textBoxBase.TabIndex = 0;
            textBoxBase.TextChanged += textBox1_TextChanged;
            // 
            // textBoxExpo
            // 
            textBoxExpo.Location = new Point(401, 163);
            textBoxExpo.Name = "textBoxExpo";
            textBoxExpo.Size = new Size(100, 23);
            textBoxExpo.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(345, 192);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 145);
            label1.Name = "label1";
            label1.Size = new Size(31, 18);
            label1.TabIndex = 3;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(425, 145);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 4;
            label2.Text = "Exponent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(242, 103);
            label3.Name = "label3";
            label3.Size = new Size(299, 20);
            label3.TabIndex = 5;
            label3.Text = "Enter the Number of your Choice";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxExpo);
            Controls.Add(textBoxBase);
            Name = "Form1";
            Text = "Task3.2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBase;
        private TextBox textBoxExpo;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
