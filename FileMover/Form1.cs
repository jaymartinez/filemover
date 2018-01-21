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
            string[] drives = Directory.GetLogicalDrives();

            // see if they are valid drives (not a DVD rom drive)
            drivesComboBox.Items.Clear();
            if (drives?.Length > 0)
            {
                foreach (string s in drives)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(s);
                    string attrs = directoryInfo.Attributes.ToString();
                    if (attrs != "-1")
                    {
                        drivesComboBox.Items.Add(s);
                    }
                }
            }
            drivesComboBox.Items.Add("Network");
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
        private void BtnSearchNetworkPath_Click(object sender, EventArgs e)
        {
            string networkPath = NetworkPathTextbox.Text;

            DirectoryInfo dirInfo = new DirectoryInfo($"{networkPath}\\");
            ProcessDirectory(dirInfo.GetDirectories());
            
        }

        /// <summary>
        /// Click handler for the button that adds items to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                Label selectedItem = new Label
                {
                    Text = _selectedItem.DirInfo.Name,
                    Height = 15,
                    Width = DestPanel.Width - 5
                };
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
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ResultsBox.Items.Clear();
            var items = Items.Where(x => x.IsChosen && x.TreeObjType == TreeObjectType.DESTINATION).ToArray();

            foreach (var y in items)
            {
                y.SearchResults.Clear();
            }

            if (items == null || items.Length == 0) return;

            if (_fileTypes.Count == 0)
            {
                Console.WriteLine("No filetypes were selected");
                return;
            }

            // lazy way of excluding duplicates!
            HashSet<string> fileTypeSet = new HashSet<string>(_fileTypes);

            foreach (TreeViewObject i in items)
            {
                foreach (string ft in fileTypeSet)
                {
                    var res = i.DirInfo.GetFiles($"*.{ft}", SearchOption.AllDirectories);
                    if (res.Length > 0)
                    {
                        if (i.SearchResults.ContainsKey(ft))
                        {
                            i.SearchResults[ft].Concat(res);
                        }
                        else
                        {
                            i.SearchResults.Add(ft, res);
                        }
                    }
                }
            }


            var results = items.Select(x => x.SearchResults).ToArray();
            var count = 0;
            List<FileInfo> fileInfoList = new List<FileInfo>();
            foreach (var p in results)
            {
                foreach (var i in p)
                {
                    fileInfoList.AddRange(i.Value);
                    count += i.Value.Length;
                }
            }

            ResultsBox.Items.AddRange(fileInfoList.OrderByDescending(x => x.CreationTime).ToArray());
            ResultsLabel.Text = $"Found {count.ToString()} files";
        }



        private void BtnStart_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = ""; 
            var foundItems = ResultsBox.Items;
            int numItems = foundItems.Count;
            if (numItems == 0 || string.IsNullOrEmpty(_destinationPath)) return;

            Console.WriteLine($"Preparing to copy {foundItems} files to {_destinationPath}");

            List<string> messages = new List<string>();
            int filesSucceeded = 0;
            progressBar1.Visible = true;
            string copyMove = MoveRadio.Checked ? "Moving" : "Copying";
            StatusLabel.Visible = true;
            StatusLabel.Text = $"{copyMove} {numItems}. Please wait..";
            foreach (var file in foundItems)
            {
                if (file is FileInfo f)
                {
                    string path = $"{_destinationPath}\\{f.Name}";
                    if (MoveRadio.Checked)
                    {
                        try
                        {
                            f.MoveTo(path);
                            progressBar1.Value = (int)Math.Ceiling(((float)++filesSucceeded / numItems) * 100);
                        }
                        catch (IOException ioex)
                        {
                            messages.Add($"\n{ioex.Message}. Path: {f.FullName}");
                            continue;
                        }
                    }
                    else
                    {
                        f.CopyTo(path, true);
                        progressBar1.Value = (int)Math.Ceiling(((float)++filesSucceeded / numItems) * 100);
                    }
                }
            }

            copyMove = MoveRadio.Checked ? "moved" : "copied";
            StatusLabel.ForeColor = Color.Blue;
            if (messages.Count > 0)
            {
                if (filesSucceeded > 0)
                {
                    StatusLabel.Text = $"{filesSucceeded} files were {copyMove}, but some files could not be moved! See error.log for details";
                }
                else
                {
                    StatusLabel.ForeColor = Color.Red;
                    StatusLabel.Text = $"Error! no files were {copyMove}. See error.log for details";
                }

                using (StreamWriter file = new StreamWriter(@"D:\Development\Visual Studio\FileMover\FileMover\bin\error.log"))
                {
                    foreach (string s in messages)
                    {
                        file.WriteLine(s);
                    }
                }
            }
            else
            {
                StatusLabel.Text = $"Successfully {copyMove} {foundItems.Count} files!";
            }

        }

        /// <summary>
        /// Clears all the selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            DestPanel.Controls.Clear();
            ResultsBox.Items.Clear();
            foreach(var item in Items)
            {
                item.IsChosen = false;
            }
        }

        private void BtnFileTypesAdd_Click(object sender, EventArgs e)
        {
            var selectedItems = FileTypesBox.SelectedItems;

            if (selectedItems.Count > 0)
            {
                foreach (var si in selectedItems)
                {
                    _fileTypes.Add(si.ToString());
                    ChosenFileTypes.Items.Add(si.ToString());
                }
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
                    ProcessDirectory(dirInfo.GetDirectories());
                }
            }
        }

        private void ProcessDirectory(DirectoryInfo[] dirs, TreeNode node = null)
        {
            TreeViewSrc.Nodes.Clear();

            if (dirs.Length > 0)
            {
                foreach (DirectoryInfo dir in dirs)
                {
                    // Don't include hidden or system folders
                    string attrs = dir.Attributes.ToString();
                    if (attrs.Contains("Hidden") || attrs.Contains("System"))
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
