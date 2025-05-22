namespace Lab3.Task3
{
    partial class Task3
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
            listBoxBooks = new ListBox();
            buttonShowBook = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(326, 91);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(462, 259);
            listBoxBooks.TabIndex = 0;
            // 
            // buttonShowBook
            // 
            buttonShowBook.Location = new Point(164, 151);
            buttonShowBook.Name = "buttonShowBook";
            buttonShowBook.Size = new Size(137, 52);
            buttonShowBook.TabIndex = 1;
            buttonShowBook.Text = "Show Type books";
            buttonShowBook.UseVisualStyleBackColor = true;
            buttonShowBook.Click += buttonShowBook_Click;
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowBook);
            Controls.Add(listBoxBooks);
            Name = "Task3";
            Text = "Task3 Student Challenge";
            Load += Task3_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooks;
        private Button buttonShowBook;
    }
}
