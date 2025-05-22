namespace Lab3.Task2
{
    partial class Task2
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
            listBox1 = new ListBox();
            buttonShowBehavior = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(355, 121);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(354, 244);
            listBox1.TabIndex = 0;
            // 
            // buttonShowBehavior
            // 
            buttonShowBehavior.Location = new Point(206, 121);
            buttonShowBehavior.Name = "buttonShowBehavior";
            buttonShowBehavior.Size = new Size(117, 59);
            buttonShowBehavior.TabIndex = 1;
            buttonShowBehavior.Text = "Show Behavior";
            buttonShowBehavior.UseVisualStyleBackColor = true;
            buttonShowBehavior.Click += buttonShowBehavior_Click;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowBehavior);
            Controls.Add(listBox1);
            Name = "Task2";
            Text = "Task2Polymorph";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button buttonShowBehavior;
    }
}
