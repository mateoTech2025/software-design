namespace Lab1.Task5
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
            buttonAscend = new Button();
            listBoxView = new ListBox();
            buttonDescend = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonAscend
            // 
            buttonAscend.Location = new Point(205, 165);
            buttonAscend.Name = "buttonAscend";
            buttonAscend.Size = new Size(96, 45);
            buttonAscend.TabIndex = 0;
            buttonAscend.Text = "Ascending Sort";
            buttonAscend.UseVisualStyleBackColor = true;
            buttonAscend.Click += buttonAscend_Click;
            // 
            // listBoxView
            // 
            listBoxView.FormattingEnabled = true;
            listBoxView.ItemHeight = 15;
            listBoxView.Location = new Point(362, 142);
            listBoxView.Name = "listBoxView";
            listBoxView.Size = new Size(268, 199);
            listBoxView.TabIndex = 1;
            // 
            // buttonDescend
            // 
            buttonDescend.Location = new Point(205, 216);
            buttonDescend.Name = "buttonDescend";
            buttonDescend.Size = new Size(96, 49);
            buttonDescend.TabIndex = 2;
            buttonDescend.Text = "Descending Sort";
            buttonDescend.UseVisualStyleBackColor = true;
            buttonDescend.Click += buttonDescend_Click;
            // 
            // button1
            // 
            button1.Location = new Point(205, 124);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 3;
            button1.Text = "Show Numbers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonDescend);
            Controls.Add(listBoxView);
            Controls.Add(buttonAscend);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAscend;
        private ListBox listBoxView;
        private Button buttonDescend;
        private Button button1;
    }
}
