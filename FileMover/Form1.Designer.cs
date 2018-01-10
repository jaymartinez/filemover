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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.btnClearDest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFileTypesSrc = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFileTypesDest = new System.Windows.Forms.Panel();
            this.btnFileTypesAdd = new System.Windows.Forms.Button();
            this.btnFileTypesRemove = new System.Windows.Forms.Button();
            this.treeViewSrc = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelNetworkPath = new System.Windows.Forms.Panel();
            this.btnSearchNetworkPath = new System.Windows.Forms.Button();
            this.tbNetworkPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drivesComboBox = new System.Windows.Forms.ComboBox();
            this.selectedItemsList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.destFolderLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFileTypesSrc.SuspendLayout();
            this.panelNetworkPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(258, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(258, 307);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(55, 31);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnMoveFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFiles.Location = new System.Drawing.Point(561, 625);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(74, 30);
            this.btnMoveFiles.TabIndex = 3;
            this.btnMoveFiles.Text = "Start";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // btnClearDest
            // 
            this.btnClearDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDest.Location = new System.Drawing.Point(442, 625);
            this.btnClearDest.Name = "btnClearDest";
            this.btnClearDest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClearDest.Size = new System.Drawing.Size(113, 30);
            this.btnClearDest.TabIndex = 3;
            this.btnClearDest.Text = "Clear";
            this.btnClearDest.UseVisualStyleBackColor = true;
            this.btnClearDest.Click += new System.EventHandler(this.btnClearDest_Click);
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
            this.panelFileTypesSrc.Controls.Add(this.listBox1);
            this.panelFileTypesSrc.Controls.Add(this.label2);
            this.panelFileTypesSrc.Location = new System.Drawing.Point(12, 497);
            this.panelFileTypesSrc.Name = "panelFileTypesSrc";
            this.panelFileTypesSrc.Size = new System.Drawing.Size(156, 169);
            this.panelFileTypesSrc.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.Items.AddRange(new object[] {
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
            this.listBox1.Location = new System.Drawing.Point(6, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 134);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // panelFileTypesDest
            // 
            this.panelFileTypesDest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFileTypesDest.Location = new System.Drawing.Point(259, 521);
            this.panelFileTypesDest.Name = "panelFileTypesDest";
            this.panelFileTypesDest.Size = new System.Drawing.Size(153, 134);
            this.panelFileTypesDest.TabIndex = 6;
            // 
            // btnFileTypesAdd
            // 
            this.btnFileTypesAdd.Enabled = false;
            this.btnFileTypesAdd.Location = new System.Drawing.Point(175, 530);
            this.btnFileTypesAdd.Name = "btnFileTypesAdd";
            this.btnFileTypesAdd.Size = new System.Drawing.Size(78, 23);
            this.btnFileTypesAdd.TabIndex = 7;
            this.btnFileTypesAdd.Text = ">>";
            this.btnFileTypesAdd.UseVisualStyleBackColor = true;
            // 
            // btnFileTypesRemove
            // 
            this.btnFileTypesRemove.Enabled = false;
            this.btnFileTypesRemove.Location = new System.Drawing.Point(175, 559);
            this.btnFileTypesRemove.Name = "btnFileTypesRemove";
            this.btnFileTypesRemove.Size = new System.Drawing.Size(78, 23);
            this.btnFileTypesRemove.TabIndex = 7;
            this.btnFileTypesRemove.Text = "<<";
            this.btnFileTypesRemove.UseVisualStyleBackColor = true;
            // 
            // treeViewSrc
            // 
            this.treeViewSrc.FullRowSelect = true;
            this.treeViewSrc.Location = new System.Drawing.Point(12, 83);
            this.treeViewSrc.Name = "treeViewSrc";
            this.treeViewSrc.Size = new System.Drawing.Size(240, 395);
            this.treeViewSrc.TabIndex = 10;
            this.treeViewSrc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSrc_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 503);
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
            this.panelNetworkPath.Controls.Add(this.tbNetworkPath);
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
            // tbNetworkPath
            // 
            this.tbNetworkPath.Location = new System.Drawing.Point(83, 5);
            this.tbNetworkPath.Name = "tbNetworkPath";
            this.tbNetworkPath.Size = new System.Drawing.Size(452, 20);
            this.tbNetworkPath.TabIndex = 1;
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
            this.drivesComboBox.SelectedIndexChanged += new System.EventHandler(this.drivesComboBox_SelectedIndexChanged);
            // 
            // selectedItemsList
            // 
            this.selectedItemsList.FormattingEnabled = true;
            this.selectedItemsList.Location = new System.Drawing.Point(319, 83);
            this.selectedItemsList.Name = "selectedItemsList";
            this.selectedItemsList.Size = new System.Drawing.Size(240, 394);
            this.selectedItemsList.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Choose folder to copy to";
            // 
            // btnBrowseDest
            // 
            this.btnBrowseDest.Location = new System.Drawing.Point(441, 539);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDest.TabIndex = 18;
            this.btnBrowseDest.Text = "Browse...";
            this.btnBrowseDest.UseVisualStyleBackColor = true;
            // 
            // destFolderLabel
            // 
            this.destFolderLabel.AutoSize = true;
            this.destFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destFolderLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.destFolderLabel.Location = new System.Drawing.Point(437, 569);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 670);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.destFolderLabel);
            this.Controls.Add(this.btnBrowseDest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectedItemsList);
            this.Controls.Add(this.drivesComboBox);
            this.Controls.Add(this.panelNetworkPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeViewSrc);
            this.Controls.Add(this.btnFileTypesRemove);
            this.Controls.Add(this.btnFileTypesAdd);
            this.Controls.Add(this.panelFileTypesDest);
            this.Controls.Add(this.panelFileTypesSrc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearDest);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "FileMover 1000";
            this.panelFileTypesSrc.ResumeLayout(false);
            this.panelFileTypesSrc.PerformLayout();
            this.panelNetworkPath.ResumeLayout(false);
            this.panelNetworkPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Button btnClearDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFileTypesSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFileTypesDest;
        private System.Windows.Forms.Button btnFileTypesAdd;
        private System.Windows.Forms.Button btnFileTypesRemove;
        private System.Windows.Forms.TreeView treeViewSrc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelNetworkPath;
        private System.Windows.Forms.TextBox tbNetworkPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drivesComboBox;
        private System.Windows.Forms.Button btnSearchNetworkPath;
        private System.Windows.Forms.ListBox selectedItemsList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseDest;
        private System.Windows.Forms.Label destFolderLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

