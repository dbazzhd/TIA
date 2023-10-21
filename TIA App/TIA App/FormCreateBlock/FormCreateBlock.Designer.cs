namespace TIA_App {
    partial class FormCreateBlock {
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
            this.label_blockName = new System.Windows.Forms.Label();
            this.textbox_blockName = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.combobox_masterCopies = new System.Windows.Forms.ComboBox();
            this.label_masterCopy = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_blockName
            // 
            this.label_blockName.AutoSize = true;
            this.label_blockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_blockName.Location = new System.Drawing.Point(12, 15);
            this.label_blockName.Margin = new System.Windows.Forms.Padding(3);
            this.label_blockName.Name = "label_blockName";
            this.label_blockName.Size = new System.Drawing.Size(77, 13);
            this.label_blockName.TabIndex = 2;
            this.label_blockName.Text = "Block name:";
            this.label_blockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_blockName
            // 
            this.textbox_blockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_blockName.Location = new System.Drawing.Point(98, 12);
            this.textbox_blockName.Name = "textbox_blockName";
            this.textbox_blockName.Size = new System.Drawing.Size(290, 20);
            this.textbox_blockName.TabIndex = 3;
            // 
            // button_create
            // 
            this.button_create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_create.Enabled = false;
            this.button_create.Location = new System.Drawing.Point(127, 65);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(162, 23);
            this.button_create.TabIndex = 4;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            // 
            // combobox_masterCopies
            // 
            this.combobox_masterCopies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_masterCopies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_masterCopies.FormattingEnabled = true;
            this.combobox_masterCopies.Location = new System.Drawing.Point(98, 38);
            this.combobox_masterCopies.Name = "combobox_masterCopies";
            this.combobox_masterCopies.Size = new System.Drawing.Size(263, 21);
            this.combobox_masterCopies.TabIndex = 5;
            // 
            // label_masterCopy
            // 
            this.label_masterCopy.AutoSize = true;
            this.label_masterCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_masterCopy.Location = new System.Drawing.Point(12, 41);
            this.label_masterCopy.Margin = new System.Windows.Forms.Padding(3);
            this.label_masterCopy.Name = "label_masterCopy";
            this.label_masterCopy.Size = new System.Drawing.Size(80, 13);
            this.label_masterCopy.TabIndex = 6;
            this.label_masterCopy.Text = "Master copy:";
            this.label_masterCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Location = new System.Drawing.Point(367, 38);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(21, 21);
            this.button_refresh.TabIndex = 7;
            this.button_refresh.TabStop = false;
            this.button_refresh.Text = "R";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // FormCreateBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_masterCopy);
            this.Controls.Add(this.combobox_masterCopies);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textbox_blockName);
            this.Controls.Add(this.label_blockName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCreateBlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new Block";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_blockName;
        private System.Windows.Forms.TextBox textbox_blockName;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.ComboBox combobox_masterCopies;
        private System.Windows.Forms.Label label_masterCopy;
        private System.Windows.Forms.Button button_refresh;
    }
}