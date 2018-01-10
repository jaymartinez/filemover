using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //DirectoryInfo di = new DirectoryInfo(@"\\192.168.0.1\volume1");
        }

        private void PopulateTreeView(DirectoryInfo dirInfo = null)
        {
            if (dirInfo == null)
            {

            }
            else
            {

            }

            var dirs = dirInfo.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
            }

            string s = "";
        }

        #region Button Clicks
        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
        }

        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
        }

        private void btnClearDest_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void treeViewSrc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string s = e.ToString();
        }

        #region Dropdown Events
        private void drivesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox dropdown = sender as ComboBox;
            if (dropdown != null)
            {
                if (dropdown.Text == "Network")
                {
                    panelNetworkPath.Visible = true;
                }
                else
                {
                    panelNetworkPath.Visible = false;
                    DirectoryInfo dirInfo = new DirectoryInfo($"{dropdown.Text}\\");
                    DirectoryInfo[] dirs = dirInfo.GetDirectories();
                    if (dirs?.Length > 0)
                    {
                        var items = new TreeViewItems();
                        items.Add(dirs);

                        ArrayList tempDirs = new ArrayList(dirs);
                        foreach (DirectoryInfo di in tempDirs)
                        {
                            treeViewSrc.Nodes.Add(di.Name);
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFileTypesAdd.Enabled = true;
        }
        #endregion

        
        class TreeViewItems : ObservableCollection<TreeViewObject>
        {
            public TreeViewItems()
            {
            }

            protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
            {
                base.OnCollectionChanged(e);
            }
        }

        class TreeViewObject
        {
            
        }
    }
}
