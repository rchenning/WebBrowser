using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowserUI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            bookmarkListBox.Items.Clear();

            foreach (var item in items)
            {
                bookmarkListBox.Items.Add(String.Format("{0} ({1}) ", item.Title, item.URL));
            }
        }

        private void BookmarkSearchButton_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            bookmarkListBox.Items.Clear();

            foreach (var item in items)
            {
                if (item.URL.ToLower().Contains(BookmarkSearchText.Text.ToLower()))
                {
                    bookmarkListBox.Items.Add(String.Format("{0} ({1}) ", item.Title, item.URL));
                }

            }
        }

        private void BookmarkDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bookmarkListBox.Equals(null))
                {
                    BookmarkManager.RemoveItem(bookmarkListBox.SelectedItem.ToString());
                    var items = BookmarkManager.GetItems();
                    bookmarkListBox.Items.Clear();

                    foreach (var item in items)
                    {
                        bookmarkListBox.Items.Add(String.Format("{0} ({1}) ", item.Title, item.URL));
                    }
                }
            }
            catch { }
        }
    }
}
