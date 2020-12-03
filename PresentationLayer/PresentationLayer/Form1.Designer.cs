
namespace PresentationLayer
{
    partial class Form1
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
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumberOfPages = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfPages = new System.Windows.Forms.TextBox();
            this.buttonInsertBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(20, 78);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(768, 303);
            this.listBoxBooks.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Naslov:";
            // 
            // labelNumberOfPages
            // 
            this.labelNumberOfPages.AutoSize = true;
            this.labelNumberOfPages.Location = new System.Drawing.Point(328, 37);
            this.labelNumberOfPages.Name = "labelNumberOfPages";
            this.labelNumberOfPages.Size = new System.Drawing.Size(68, 13);
            this.labelNumberOfPages.TabIndex = 2;
            this.labelNumberOfPages.Text = "Broj stranica:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(62, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(248, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxNumberOfPages
            // 
            this.textBoxNumberOfPages.Location = new System.Drawing.Point(392, 34);
            this.textBoxNumberOfPages.Name = "textBoxNumberOfPages";
            this.textBoxNumberOfPages.Size = new System.Drawing.Size(93, 20);
            this.textBoxNumberOfPages.TabIndex = 4;
            // 
            // buttonInsertBook
            // 
            this.buttonInsertBook.Location = new System.Drawing.Point(550, 27);
            this.buttonInsertBook.Name = "buttonInsertBook";
            this.buttonInsertBook.Size = new System.Drawing.Size(238, 26);
            this.buttonInsertBook.TabIndex = 5;
            this.buttonInsertBook.Text = "Kreiraj novu knjigu";
            this.buttonInsertBook.UseVisualStyleBackColor = true;
            this.buttonInsertBook.Click += new System.EventHandler(this.buttonInsertBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.buttonInsertBook);
            this.Controls.Add(this.textBoxNumberOfPages);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNumberOfPages);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxBooks);
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumberOfPages;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNumberOfPages;
        private System.Windows.Forms.Button buttonInsertBook;
    }
}

