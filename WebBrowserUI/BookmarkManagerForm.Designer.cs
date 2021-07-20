namespace WebBrowserUI
{
    partial class BookmarkManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkManagerForm));
            this.bookmarkListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BookmarkSearchText = new System.Windows.Forms.ToolStripTextBox();
            this.BookmarkSearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BookmarkDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookmarkListBox
            // 
            this.bookmarkListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkListBox.FormattingEnabled = true;
            this.bookmarkListBox.Location = new System.Drawing.Point(0, 25);
            this.bookmarkListBox.Name = "bookmarkListBox";
            this.bookmarkListBox.Size = new System.Drawing.Size(800, 425);
            this.bookmarkListBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookmarkSearchText,
            this.BookmarkSearchButton,
            this.toolStripSeparator1,
            this.BookmarkDeleteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BookmarkSearchText
            // 
            this.BookmarkSearchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BookmarkSearchText.Name = "BookmarkSearchText";
            this.BookmarkSearchText.Size = new System.Drawing.Size(200, 25);
            // 
            // BookmarkSearchButton
            // 
            this.BookmarkSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BookmarkSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("BookmarkSearchButton.Image")));
            this.BookmarkSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookmarkSearchButton.Name = "BookmarkSearchButton";
            this.BookmarkSearchButton.Size = new System.Drawing.Size(46, 22);
            this.BookmarkSearchButton.Text = "Search";
            this.BookmarkSearchButton.ToolTipText = "Search";
            this.BookmarkSearchButton.Click += new System.EventHandler(this.BookmarkSearchButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BookmarkDeleteButton
            // 
            this.BookmarkDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BookmarkDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("BookmarkDeleteButton.Image")));
            this.BookmarkDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookmarkDeleteButton.Name = "BookmarkDeleteButton";
            this.BookmarkDeleteButton.Size = new System.Drawing.Size(44, 22);
            this.BookmarkDeleteButton.Text = "Delete";
            this.BookmarkDeleteButton.Click += new System.EventHandler(this.BookmarkDeleteButton_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarkListBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BookmarkManagerForm";
            this.Text = "Bookmark Manager Form";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkListBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox BookmarkSearchText;
        private System.Windows.Forms.ToolStripButton BookmarkSearchButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BookmarkDeleteButton;
    }
}