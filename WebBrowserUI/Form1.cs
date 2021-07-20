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
    public partial class IceDogBrowser : Form
    {
        public IceDogBrowser()
        {
            InitializeComponent();
        }

        private void exitKimberlatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This browser is created to simplify the browsing experience.\n" + "Created by: Robert Henning\n" + "ID Number: 904110056\n");
        }

        private void newTabItem_Click(object sender, EventArgs e)
        {
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
            IceDogUserControl newControl = new IceDogUserControl();
            newControl.Name = "newControl" + title;
            newControl.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(newControl);
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManagerForm form = new HistoryManagerForm();
            form.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkManagerForm form = new BookmarkManagerForm();
            form.ShowDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.RemoveAll();
        }
    }
}
