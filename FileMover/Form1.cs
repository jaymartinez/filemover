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
        private TreeViewObject _selectedItem;
        private List<string> _fileTypes = new List<string>();
        private string _destinationPath = "";

        private TreeViewItems _items;
        private TreeViewItems Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new TreeViewItems();
                }

                return _items;
            }
        }
        private void Form1_Load(object sender, EventArgs e) { }

        public Form1()
        {
            InitializeComponent();
            //DirectoryInfo di = new DirectoryInfo(@"\\192.168.0.1\volume1");
        }

        private void TreeViewSrc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var item = Items.FirstOrDefault(x => x.Node.Equals(e.Node));
            if (item != null)
            {
                BtnAdd.Enabled = true;
                _selectedItem = item;
            }
        }

        #region Button Clicks
        /// <summary>
        /// Click handler for the button that adds items to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                Label selectedItem = new Label();
                selectedItem.Text = _selectedItem.DirInfo.Name;
                selectedItem.Height = 15;
                _selectedItem.IsChosen = true;
                _selectedItem.TreeObjType = TreeObjectType.DESTINATION;

                var controls = DestPanel.Controls;
                if (controls?.Count == 0)
                {
                    DestPanel.Controls.Add(selectedItem);
                }
                else
                {
                    int y = controls[controls.Count - 1].Bounds.Y;
                    selectedItem.Bounds = new Rectangle(0, y + 15, DestPanel.Bounds.Width, 15);
                    DestPanel.Controls.Add(selectedItem);
                }

            }
        }

        /// <summary>
        /// Click handler for the Start button. This initiates the copy operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            var items = Items.Where(x => x.IsChosen && x.TreeObjType == TreeObjectType.DESTINATION).ToArray();
            var files = items[0].DirInfo.GetFiles("*.jpg");
            Console.WriteLine(items.Length);
        }

        /// <summary>
        /// Clears all the selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            DestPanel.Controls.Clear();
            foreach(var item in Items)
            {
                item.IsChosen = false;
            }
        }

        private void BtnFileTypesAdd_Click(object sender, EventArgs e)
        {
            if (!_fileTypes.Contains(FileTypesBox.SelectedItem.ToString()))
            {
                _fileTypes.Add(FileTypesBox.SelectedItem.ToString());

                ChosenFileTypes.Items.Add(FileTypesBox.SelectedItem.ToString());

                /*
                Label selectedItem = new Label();
                selectedItem.Text = FileTypesBox.SelectedItem.ToString();
                selectedItem.Height = 15;

                var controls = FileTypesPanel.Controls;
                if (controls?.Count == 0)
                {
                    FileTypesPanel.Controls.Add(selectedItem);
                }
                else
                {
                    int y = controls[controls.Count - 1].Bounds.Y;
                    selectedItem.Bounds = new Rectangle(0, y + 15, FileTypesPanel.Bounds.Width, 15);
                    FileTypesPanel.Controls.Add(selectedItem);
                }
                */

            }
        }

        private void BtnClearFileTypes_Click(object sender, EventArgs e)
        {
            _fileTypes = new List<string>(FileTypesBox.Items.Count);
            ChosenFileTypes.Items.Clear();
        }

        /// <summary>
        /// Browse a destination folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowseDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "Choose the directory you want the files to be copied to"
            };

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _destinationPath = dialog.SelectedPath;
                destFolderLabel.Text = _destinationPath;
            }
        }
        #endregion

        #region Dropdown Events
        private void DrivesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox dropdown = sender as ComboBox;
            if (dropdown != null)
            {
                if (dropdown.Text == "Network")
                {
                    panelNetworkPath.Visible = true;
                    TreeViewSrc.Nodes.Clear();
                }
                else
                {
                    panelNetworkPath.Visible = false;
                    DirectoryInfo dirInfo = new DirectoryInfo($"{dropdown.Text}\\");
                    List<DirectoryInfo> dirs = dirInfo.GetDirectories().ToList();
                    ProcessDirectory(dirs);
                }
            }
        }

        private void ProcessDirectory(List<DirectoryInfo> dirs, TreeNode node = null)
        {
            TreeViewSrc.Nodes.Clear();

            if (dirs?.Count > 0)
            {
                foreach (DirectoryInfo dir in dirs)
                {
                    // Don't include hidden or system folders
                    string attrs = dir.Attributes.ToString();
                    bool pass = attrs.Contains("Hidden") || attrs.Contains("System");
                    if (pass)
                    {
                        continue;
                    }

                    try
                    {
                        TreeNode n = TreeViewSrc.Nodes.Add(dir.Name);

                        var childDirs = dir.GetDirectories();

                        Guid id = Guid.NewGuid();
                        Items.Add(new TreeViewObject
                        {
                            DirInfo = dir,
                            Id = id,
                            TreeNodeIndex = n.Index,
                            NumberOfChildren = childDirs.Length,
                            Node = n,
                            TreeObjType = TreeObjectType.SOURCE
                        });

                        if (childDirs.Length == 0) continue;

                        // just do one level for now
                        foreach (DirectoryInfo child in childDirs)
                        {
                            TreeNode newNode = new TreeNode(child.Name);
                            TreeViewSrc.Nodes[n.Index].Nodes.Add(newNode);
                            Items.Add(new TreeViewObject
                            {
                                DirInfo = child,
                                Id = Guid.NewGuid(),
                                ParentId = id,
                                Node = newNode,
                                TreeObjType = TreeObjectType.SOURCE
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        using (StreamWriter file = new StreamWriter(@"D:\Development\Visual Studio\FileMover\FileMover\bin\error.log"))
                        {
                            file.WriteLine(ex.Message + "\n");
                            file.WriteLine(ex.StackTrace + "\n");
                        }
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                }
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnFileTypesAdd.Enabled = true;
        }
        #endregion

        
        internal class TreeViewItems : ObservableCollection<TreeViewObject>
        {
            public TreeViewItems()
            {
            }

            protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
            {
                base.OnCollectionChanged(e);
            }
        }

    }
}
