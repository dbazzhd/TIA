namespace TIA_App {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label_projectName = new System.Windows.Forms.Label();
            this.label_projectPath = new System.Windows.Forms.Label();
            this.value_projectName = new System.Windows.Forms.Label();
            this.value_projectPath = new System.Windows.Forms.Label();
            this.panel_projectInfo = new System.Windows.Forms.Panel();
            this.combobox_hwDevices = new System.Windows.Forms.ComboBox();
            this.panel_hwDevices = new System.Windows.Forms.Panel();
            this.button_refreshTreeView = new System.Windows.Forms.Button();
            this.treeview_cpuDeviceItem = new System.Windows.Forms.TreeView();
            this.button_refreshCPUDeviceItems = new System.Windows.Forms.Button();
            this.combobox_cpuDeviceItems = new System.Windows.Forms.ComboBox();
            this.button_refreshHWDevices = new System.Windows.Forms.Button();
            this.label_hwDevices = new System.Windows.Forms.Label();
            this.imagelist_treeView = new System.Windows.Forms.ImageList(this.components);
            this.panel_projectInfo.SuspendLayout();
            this.panel_hwDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_projectName
            // 
            this.label_projectName.AutoSize = true;
            this.label_projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectName.Location = new System.Drawing.Point(6, 6);
            this.label_projectName.Margin = new System.Windows.Forms.Padding(3);
            this.label_projectName.Name = "label_projectName";
            this.label_projectName.Size = new System.Drawing.Size(85, 13);
            this.label_projectName.TabIndex = 0;
            this.label_projectName.Text = "Project name:";
            this.label_projectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_projectPath
            // 
            this.label_projectPath.AutoSize = true;
            this.label_projectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectPath.Location = new System.Drawing.Point(6, 25);
            this.label_projectPath.Margin = new System.Windows.Forms.Padding(3);
            this.label_projectPath.Name = "label_projectPath";
            this.label_projectPath.Size = new System.Drawing.Size(80, 13);
            this.label_projectPath.TabIndex = 3;
            this.label_projectPath.Text = "Project path:";
            this.label_projectPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // value_projectName
            // 
            this.value_projectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value_projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_projectName.Location = new System.Drawing.Point(97, 6);
            this.value_projectName.Margin = new System.Windows.Forms.Padding(3);
            this.value_projectName.Name = "value_projectName";
            this.value_projectName.Size = new System.Drawing.Size(673, 13);
            this.value_projectName.TabIndex = 4;
            this.value_projectName.Text = "PROJECT_NAME";
            this.value_projectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // value_projectPath
            // 
            this.value_projectPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value_projectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_projectPath.Location = new System.Drawing.Point(97, 25);
            this.value_projectPath.Margin = new System.Windows.Forms.Padding(3);
            this.value_projectPath.Name = "value_projectPath";
            this.value_projectPath.Size = new System.Drawing.Size(673, 13);
            this.value_projectPath.TabIndex = 5;
            this.value_projectPath.Text = "PROJECT_PATH";
            this.value_projectPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_projectInfo
            // 
            this.panel_projectInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_projectInfo.Controls.Add(this.label_projectName);
            this.panel_projectInfo.Controls.Add(this.value_projectPath);
            this.panel_projectInfo.Controls.Add(this.label_projectPath);
            this.panel_projectInfo.Controls.Add(this.value_projectName);
            this.panel_projectInfo.Location = new System.Drawing.Point(12, 12);
            this.panel_projectInfo.Name = "panel_projectInfo";
            this.panel_projectInfo.Padding = new System.Windows.Forms.Padding(3);
            this.panel_projectInfo.Size = new System.Drawing.Size(776, 44);
            this.panel_projectInfo.TabIndex = 6;
            // 
            // combobox_hwDevices
            // 
            this.combobox_hwDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_hwDevices.FormattingEnabled = true;
            this.combobox_hwDevices.Location = new System.Drawing.Point(6, 25);
            this.combobox_hwDevices.Name = "combobox_hwDevices";
            this.combobox_hwDevices.Size = new System.Drawing.Size(162, 21);
            this.combobox_hwDevices.TabIndex = 7;
            // 
            // panel_hwDevices
            // 
            this.panel_hwDevices.Controls.Add(this.button_refreshTreeView);
            this.panel_hwDevices.Controls.Add(this.treeview_cpuDeviceItem);
            this.panel_hwDevices.Controls.Add(this.button_refreshCPUDeviceItems);
            this.panel_hwDevices.Controls.Add(this.combobox_cpuDeviceItems);
            this.panel_hwDevices.Controls.Add(this.button_refreshHWDevices);
            this.panel_hwDevices.Controls.Add(this.label_hwDevices);
            this.panel_hwDevices.Controls.Add(this.combobox_hwDevices);
            this.panel_hwDevices.Location = new System.Drawing.Point(12, 62);
            this.panel_hwDevices.Name = "panel_hwDevices";
            this.panel_hwDevices.Padding = new System.Windows.Forms.Padding(3);
            this.panel_hwDevices.Size = new System.Drawing.Size(776, 376);
            this.panel_hwDevices.TabIndex = 8;
            // 
            // button_refreshTreeView
            // 
            this.button_refreshTreeView.Location = new System.Drawing.Point(749, 52);
            this.button_refreshTreeView.Name = "button_refreshTreeView";
            this.button_refreshTreeView.Size = new System.Drawing.Size(21, 21);
            this.button_refreshTreeView.TabIndex = 13;
            this.button_refreshTreeView.TabStop = false;
            this.button_refreshTreeView.Text = "R";
            this.button_refreshTreeView.UseVisualStyleBackColor = true;
            // 
            // treeview_cpuDeviceItem
            // 
            this.treeview_cpuDeviceItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeview_cpuDeviceItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeview_cpuDeviceItem.ImageIndex = 0;
            this.treeview_cpuDeviceItem.ImageList = this.imagelist_treeView;
            this.treeview_cpuDeviceItem.Location = new System.Drawing.Point(6, 79);
            this.treeview_cpuDeviceItem.Name = "treeview_cpuDeviceItem";
            this.treeview_cpuDeviceItem.SelectedImageIndex = 0;
            this.treeview_cpuDeviceItem.Size = new System.Drawing.Size(764, 291);
            this.treeview_cpuDeviceItem.TabIndex = 12;
            this.treeview_cpuDeviceItem.TabStop = false;
            // 
            // button_refreshCPUDeviceItems
            // 
            this.button_refreshCPUDeviceItems.Location = new System.Drawing.Point(174, 52);
            this.button_refreshCPUDeviceItems.Name = "button_refreshCPUDeviceItems";
            this.button_refreshCPUDeviceItems.Size = new System.Drawing.Size(21, 21);
            this.button_refreshCPUDeviceItems.TabIndex = 11;
            this.button_refreshCPUDeviceItems.TabStop = false;
            this.button_refreshCPUDeviceItems.Text = "R";
            this.button_refreshCPUDeviceItems.UseVisualStyleBackColor = true;
            // 
            // combobox_cpuDeviceItems
            // 
            this.combobox_cpuDeviceItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_cpuDeviceItems.FormattingEnabled = true;
            this.combobox_cpuDeviceItems.Location = new System.Drawing.Point(6, 52);
            this.combobox_cpuDeviceItems.Name = "combobox_cpuDeviceItems";
            this.combobox_cpuDeviceItems.Size = new System.Drawing.Size(162, 21);
            this.combobox_cpuDeviceItems.TabIndex = 10;
            // 
            // button_refreshHWDevices
            // 
            this.button_refreshHWDevices.Location = new System.Drawing.Point(174, 25);
            this.button_refreshHWDevices.Name = "button_refreshHWDevices";
            this.button_refreshHWDevices.Size = new System.Drawing.Size(21, 21);
            this.button_refreshHWDevices.TabIndex = 9;
            this.button_refreshHWDevices.TabStop = false;
            this.button_refreshHWDevices.Text = "R";
            this.button_refreshHWDevices.UseVisualStyleBackColor = true;
            // 
            // label_hwDevices
            // 
            this.label_hwDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hwDevices.Location = new System.Drawing.Point(6, 6);
            this.label_hwDevices.Margin = new System.Windows.Forms.Padding(3);
            this.label_hwDevices.Name = "label_hwDevices";
            this.label_hwDevices.Size = new System.Drawing.Size(162, 13);
            this.label_hwDevices.TabIndex = 6;
            this.label_hwDevices.Text = "HW Devices";
            this.label_hwDevices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imagelist_treeView
            // 
            this.imagelist_treeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist_treeView.ImageStream")));
            this.imagelist_treeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist_treeView.Images.SetKeyName(0, "DB");
            this.imagelist_treeView.Images.SetKeyName(1, "FB");
            this.imagelist_treeView.Images.SetKeyName(2, "FC");
            this.imagelist_treeView.Images.SetKeyName(3, "G");
            this.imagelist_treeView.Images.SetKeyName(4, "NEW");
            this.imagelist_treeView.Images.SetKeyName(5, "OB");
            this.imagelist_treeView.Images.SetKeyName(6, "PB");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_hwDevices);
            this.Controls.Add(this.panel_projectInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIA App";
            this.panel_projectInfo.ResumeLayout(false);
            this.panel_projectInfo.PerformLayout();
            this.panel_hwDevices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_projectName;
        private System.Windows.Forms.Label label_projectPath;
        private System.Windows.Forms.Label value_projectName;
        private System.Windows.Forms.Label value_projectPath;
        private System.Windows.Forms.Panel panel_projectInfo;
        private System.Windows.Forms.ComboBox combobox_hwDevices;
        private System.Windows.Forms.Panel panel_hwDevices;
        private System.Windows.Forms.Label label_hwDevices;
        private System.Windows.Forms.Button button_refreshHWDevices;
        private System.Windows.Forms.Button button_refreshCPUDeviceItems;
        private System.Windows.Forms.ComboBox combobox_cpuDeviceItems;
        private System.Windows.Forms.TreeView treeview_cpuDeviceItem;
        private System.Windows.Forms.Button button_refreshTreeView;
        private System.Windows.Forms.ImageList imagelist_treeView;
    }
}