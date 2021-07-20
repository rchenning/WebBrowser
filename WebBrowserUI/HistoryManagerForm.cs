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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyListBox.Items.Clear();

            foreach( var item in items)
            {
                historyListBox.Items.Add(String.Format("[{0}] {1} ({2}) ", item.Date, item.Title, item.URL));
            }
        }

        private void HistorySearchButton_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyListBox.Items.Clear();

            foreach (var item in items)
            {
                if (item.URL.ToLower().Contains(HistorySearchText.Text.ToLower()))
                {
                    historyListBox.Items.Add(String.Format("[{0}] {1} ({2}) ", item.Date, item.Title, item.URL));
                }

            }
        }

        private void HistoryClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!historyListBox.Equals(null))
                {
                    HistoryManager.RemoveAll();
                    var items = HistoryManager.GetItems();
                    historyListBox.Items.Clear();

                    foreach (var item in items)
                    {
                        historyListBox.Items.Add(String.Format("[{0}] {1} ({2}) ", item.Date, item.Title, item.URL));
                    }
                }
            }
            catch { }
        }

        private void HistoryDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!historyListBox.Equals(null))
                {
                    HistoryManager.RemoveItem(historyListBox.SelectedItem.ToString());
                    var items = HistoryManager.GetItems();
                    historyListBox.Items.Clear();

                    foreach (var item in items)
                    {
                        historyListBox.Items.Add(String.Format("[{0}] {1} ({2}) ", item.Date, item.Title, item.URL));
                    }
                }
            }
            catch { }
        }
    }
}
