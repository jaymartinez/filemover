namespace FileMover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFileTypesSrc = new System.Windows.Forms.Panel();
            this.FileTypesBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFileTypesAdd = new System.Windows.Forms.Button();
            this.TreeViewSrc = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelNetworkPath = new System.Windows.Forms.Panel();
            this.BtnSearchNetworkPath = new System.Windows.Forms.Button();
            this.NetworkPathTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drivesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBrowseDest = new System.Windows.Forms.Button();
            this.destFolderLabel = new System.Windows.Forms.Label();
            this.DestPanel = new System.Windows.Forms.Panel();
            this.BtnClearFileTypes = new System.Windows.Forms.Button();
            this.ChosenFileTypes = new System.Windows.Forms.ListBox();
            this.ResultsBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BtnStart = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CopyRadio = new System.Windows.Forms.RadioButton();
            this.MoveRadio = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelFileTypesSrc.SuspendLayout();
            this.panelNetworkPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(258, 270);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(55, 31);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = ">>";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(738, 398);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(114, 30);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(423, 392);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnClear.Size = new System.Drawing.Size(113, 30);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Folders to Search";
            // 
            // panelFileTypesSrc
            // 
            this.panelFileTypesSrc.BackColor = System.Drawing.SystemColors.Control;
            this.panelFileTypesSrc.Controls.Add(this.FileTypesBox);
            this.panelFileTypesSrc.Controls.Add(this.label2);
            this.panelFileTypesSrc.Location = new System.Drawing.Point(34, 489);
            this.panelFileTypesSrc.Name = "panelFileTypesSrc";
            this.panelFileTypesSrc.Size = new System.Drawing.Size(135, 169);
            this.panelFileTypesSrc.TabIndex = 5;
            // 
            // FileTypesBox
            // 
            this.FileTypesBox.Items.AddRange(new object[] {
            "gif",
            "jpg",
            "jpeg",
            "png",
            "mp4",
            "mpeg",
            "avi",
            "wmv",
            "flv",
            "h264",
            "mov",
            "aiff",
            "wav",
            "mp3",
            "docx",
            "doc",
            "txt"});
            this.FileTypesBox.Location = new System.Drawing.Point(6, 23);
            this.FileTypesBox.Name = "FileTypesBox";
            this.FileTypesBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FileTypesBox.Size = new System.Drawing.Size(122, 134);
            this.FileTypesBox.TabIndex = 0;
            this.FileTypesBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose File Types";
            // 
            // BtnFileTypesAdd
            // 
            this.BtnFileTypesAdd.Enabled = false;
            this.BtnFileTypesAdd.Location = new System.Drawing.Point(174, 566);
            this.BtnFileTypesAdd.Name = "BtnFileTypesAdd";
            this.BtnFileTypesAdd.Size = new System.Drawing.Size(78, 23);
            this.BtnFileTypesAdd.TabIndex = 7;
            this.BtnFileTypesAdd.Text = ">>";
            this.BtnFileTypesAdd.UseVisualStyleBackColor = true;
            this.BtnFileTypesAdd.Click += new System.EventHandler(this.BtnFileTypesAdd_Click);
            // 
            // TreeViewSrc
            // 
            this.TreeViewSrc.FullRowSelect = true;
            this.TreeViewSrc.Location = new System.Drawing.Point(12, 83);
            this.TreeViewSrc.Name = "TreeViewSrc";
            this.TreeViewSrc.Size = new System.Drawing.Size(240, 303);
            this.TreeViewSrc.TabIndex = 10;
            this.TreeViewSrc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewSrc_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chosen File Types";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Drive:";
            // 
            // panelNetworkPath
            // 
            this.panelNetworkPath.Controls.Add(this.BtnSearchNetworkPath);
            this.panelNetworkPath.Controls.Add(this.NetworkPathTextbox);
            this.panelNetworkPath.Controls.Add(this.label5);
            this.panelNetworkPath.Location = new System.Drawing.Point(197, 10);
            this.panelNetworkPath.Name = "panelNetworkPath";
            this.panelNetworkPath.Size = new System.Drawing.Size(630, 33);
            this.panelNetworkPath.TabIndex = 14;
            this.panelNetworkPath.Visible = false;
            // 
            // BtnSearchNetworkPath
            // 
            this.BtnSearchNetworkPath.Location = new System.Drawing.Point(541, 3);
            this.BtnSearchNetworkPath.Name = "BtnSearchNetworkPath";
            this.BtnSearchNetworkPath.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchNetworkPath.TabIndex = 2;
            this.BtnSearchNetworkPath.Text = "Search";
            this.BtnSearchNetworkPath.UseVisualStyleBackColor = true;
            this.BtnSearchNetworkPath.Click += new System.EventHandler(this.BtnSearchNetworkPath_Click);
            // 
            // NetworkPathTextbox
            // 
            this.NetworkPathTextbox.Location = new System.Drawing.Point(83, 5);
            this.NetworkPathTextbox.Name = "NetworkPathTextbox";
            this.NetworkPathTextbox.Size = new System.Drawing.Size(452, 20);
            this.NetworkPathTextbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter Path:";
            // 
            // drivesComboBox
            // 
            this.drivesComboBox.FormattingEnabled = true;
            this.drivesComboBox.Items.AddRange(new object[] {
            "C:",
            "D:",
            "Network"});
            this.drivesComboBox.Location = new System.Drawing.Point(52, 13);
            this.drivesComboBox.Name = "drivesComboBox";
            this.drivesComboBox.Size = new System.Drawing.Size(121, 21);
            this.drivesComboBox.TabIndex = 15;
            this.drivesComboBox.SelectedIndexChanged += new System.EventHandler(this.DrivesComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Choose folder to copy to";
            // 
            // BtnBrowseDest
            // 
            this.BtnBrowseDest.Location = new System.Drawing.Point(560, 515);
            this.BtnBrowseDest.Name = "BtnBrowseDest";
            this.BtnBrowseDest.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowseDest.TabIndex = 18;
            this.BtnBrowseDest.Text = "Browse...";
            this.BtnBrowseDest.UseVisualStyleBackColor = true;
            this.BtnBrowseDest.Click += new System.EventHandler(this.BtnBrowseDest_Click);
            // 
            // destFolderLabel
            // 
            this.destFolderLabel.AutoSize = true;
            this.destFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destFolderLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.destFolderLabel.Location = new System.Drawing.Point(556, 545);
            this.destFolderLabel.Name = "destFolderLabel";
            this.destFolderLabel.Size = new System.Drawing.Size(79, 13);
            this.destFolderLabel.TabIndex = 19;
            this.destFolderLabel.Text = "[Destination]";
            // 
            // DestPanel
            // 
            this.DestPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DestPanel.Location = new System.Drawing.Point(319, 83);
            this.DestPanel.Name = "DestPanel";
            this.DestPanel.Size = new System.Drawing.Size(217, 303);
            this.DestPanel.TabIndex = 22;
            // 
            // BtnClearFileTypes
            // 
            this.BtnClearFileTypes.Location = new System.Drawing.Point(380, 634);
            this.BtnClearFileTypes.Name = "BtnClearFileTypes";
            this.BtnClearFileTypes.Size = new System.Drawing.Size(75, 23);
            this.BtnClearFileTypes.TabIndex = 24;
            this.BtnClearFileTypes.Text = "Clear";
            this.BtnClearFileTypes.UseVisualStyleBackColor = true;
            this.BtnClearFileTypes.Click += new System.EventHandler(this.BtnClearFileTypes_Click);
            // 
            // ChosenFileTypes
            // 
            this.ChosenFileTypes.FormattingEnabled = true;
            this.ChosenFileTypes.Location = new System.Drawing.Point(259, 512);
            this.ChosenFileTypes.Name = "ChosenFileTypes";
            this.ChosenFileTypes.Size = new System.Drawing.Size(115, 147);
            this.ChosenFileTypes.TabIndex = 25;
            // 
            // ResultsBox
            // 
            this.ResultsBox.FormattingEnabled = true;
            this.ResultsBox.Location = new System.Drawing.Point(560, 89);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ResultsBox.Size = new System.Drawing.Size(292, 303);
            this.ResultsBox.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 144);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(557, 62);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(40, 13);
            this.ResultsLabel.TabIndex = 28;
            this.ResultsLabel.Text = "0 items";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 670);
            this.splitter1.TabIndex = 29;
            this.splitter1.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(738, 604);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(114, 42);
            this.BtnStart.TabIndex = 30;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.StatusLabel.Location = new System.Drawing.Point(19, 42);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 31;
            // 
            // CopyRadio
            // 
            this.CopyRadio.AutoSize = true;
            this.CopyRadio.Checked = true;
            this.CopyRadio.Location = new System.Drawing.Point(738, 573);
            this.CopyRadio.Name = "CopyRadio";
            this.CopyRadio.Size = new System.Drawing.Size(49, 17);
            this.CopyRadio.TabIndex = 32;
            this.CopyRadio.TabStop = true;
            this.CopyRadio.Text = "Copy";
            this.CopyRadio.UseVisualStyleBackColor = true;
            // 
            // MoveRadio
            // 
            this.MoveRadio.AutoSize = true;
            this.MoveRadio.Location = new System.Drawing.Point(793, 573);
            this.MoveRadio.Name = "MoveRadio";
            this.MoveRadio.Size = new System.Drawing.Size(52, 17);
            this.MoveRadio.TabIndex = 33;
            this.MoveRadio.Text = "Move";
            this.MoveRadio.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(135, 438);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 23);
            this.progressBar1.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 670);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MoveRadio);
            this.Controls.Add(this.CopyRadio);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.ChosenFileTypes);
            this.Controls.Add(this.BtnClearFileTypes);
            this.Controls.Add(this.DestPanel);
            this.Controls.Add(this.destFolderLabel);
            this.Controls.Add(this.BtnBrowseDest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drivesComboBox);
            this.Controls.Add(this.panelNetworkPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TreeViewSrc);
            this.Controls.Add(this.BtnFileTypesAdd);
            this.Controls.Add(this.panelFileTypesSrc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnAdd);
            this.Name = "Form1";
            this.Text = "FileMover 1000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelFileTypesSrc.ResumeLayout(false);
            this.panelFileTypesSrc.PerformLayout();
            this.panelNetworkPath.ResumeLayout(false);
            this.panelNetworkPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFileTypesSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFileTypesAdd;
        private System.Windows.Forms.TreeView TreeViewSrc;
        private System.Windows.Forms.ListBox FileTypesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelNetworkPath;
        private System.Windows.Forms.TextBox NetworkPathTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drivesComboBox;
        private System.Windows.Forms.Button BtnSearchNetworkPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBrowseDest;
        private System.Windows.Forms.Label destFolderLabel;
        private System.Windows.Forms.Panel DestPanel;
        private System.Windows.Forms.Button BtnClearFileTypes;
        private System.Windows.Forms.ListBox ChosenFileTypes;
        private System.Windows.Forms.ListBox ResultsBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.RadioButton CopyRadio;
        private System.Windows.Forms.RadioButton MoveRadio;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

