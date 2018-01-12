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
            this.BtnStart = new System.Windows.Forms.Button();
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
            this.btnSearchNetworkPath = new System.Windows.Forms.Button();
            this.NetworkPathTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drivesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBrowseDest = new System.Windows.Forms.Button();
            this.destFolderLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DestPanel = new System.Windows.Forms.Panel();
            this.BtnClearFileTypes = new System.Windows.Forms.Button();
            this.ChosenFileTypes = new System.Windows.Forms.ListBox();
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
            // BtnStart
            // 
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(676, 593);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(137, 53);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(456, 450);
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
            "h264",
            "mov",
            "docx",
            "doc",
            "txt",
            "avi",
            "wmv",
            "flv"});
            this.FileTypesBox.Location = new System.Drawing.Point(6, 23);
            this.FileTypesBox.Name = "FileTypesBox";
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
            this.TreeViewSrc.Size = new System.Drawing.Size(240, 395);
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
            this.panelNetworkPath.Controls.Add(this.btnSearchNetworkPath);
            this.panelNetworkPath.Controls.Add(this.NetworkPathTextbox);
            this.panelNetworkPath.Controls.Add(this.label5);
            this.panelNetworkPath.Location = new System.Drawing.Point(197, 10);
            this.panelNetworkPath.Name = "panelNetworkPath";
            this.panelNetworkPath.Size = new System.Drawing.Size(630, 33);
            this.panelNetworkPath.TabIndex = 14;
            this.panelNetworkPath.Visible = false;
            // 
            // btnSearchNetworkPath
            // 
            this.btnSearchNetworkPath.Location = new System.Drawing.Point(541, 3);
            this.btnSearchNetworkPath.Name = "btnSearchNetworkPath";
            this.btnSearchNetworkPath.Size = new System.Drawing.Size(75, 23);
            this.btnSearchNetworkPath.TabIndex = 2;
            this.btnSearchNetworkPath.Text = "Search";
            this.btnSearchNetworkPath.UseVisualStyleBackColor = true;
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
            this.label6.Location = new System.Drawing.Point(507, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Choose folder to copy to";
            // 
            // BtnBrowseDest
            // 
            this.BtnBrowseDest.Location = new System.Drawing.Point(510, 536);
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
            this.destFolderLabel.Location = new System.Drawing.Point(506, 566);
            this.destFolderLabel.Name = "destFolderLabel";
            this.destFolderLabel.Size = new System.Drawing.Size(79, 13);
            this.destFolderLabel.TabIndex = 19;
            this.destFolderLabel.Text = "[Destination]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(606, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 224);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // DestPanel
            // 
            this.DestPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DestPanel.Location = new System.Drawing.Point(319, 83);
            this.DestPanel.Name = "DestPanel";
            this.DestPanel.Size = new System.Drawing.Size(237, 361);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 670);
            this.Controls.Add(this.ChosenFileTypes);
            this.Controls.Add(this.BtnClearFileTypes);
            this.Controls.Add(this.DestPanel);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.BtnStart);
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
        private System.Windows.Forms.Button BtnStart;
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
        private System.Windows.Forms.Button btnSearchNetworkPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBrowseDest;
        private System.Windows.Forms.Label destFolderLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DestPanel;
        private System.Windows.Forms.Button BtnClearFileTypes;
        private System.Windows.Forms.ListBox ChosenFileTypes;
    }
}

