namespace TIA_App {
    partial class FormCreateGroup {
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
            this.label_groupName = new System.Windows.Forms.Label();
            this.textbox_groupName = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_groupName
            // 
            this.label_groupName.AutoSize = true;
            this.label_groupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_groupName.Location = new System.Drawing.Point(12, 15);
            this.label_groupName.Margin = new System.Windows.Forms.Padding(3);
            this.label_groupName.Name = "label_groupName";
            this.label_groupName.Size = new System.Drawing.Size(79, 13);
            this.label_groupName.TabIndex = 1;
            this.label_groupName.Text = "Group name:";
            this.label_groupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_groupName
            // 
            this.textbox_groupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_groupName.Location = new System.Drawing.Point(97, 12);
            this.textbox_groupName.Name = "textbox_groupName";
            this.textbox_groupName.Size = new System.Drawing.Size(291, 20);
            this.textbox_groupName.TabIndex = 2;
            // 
            // button_create
            // 
            this.button_create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_create.Enabled = false;
            this.button_create.Location = new System.Drawing.Point(127, 38);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(162, 23);
            this.button_create.TabIndex = 3;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            // 
            // FormCreateGroup
            // 
            this.AcceptButton = this.button_create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 73);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textbox_groupName);
            this.Controls.Add(this.label_groupName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCreateGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCreateGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_groupName;
        private System.Windows.Forms.TextBox textbox_groupName;
        private System.Windows.Forms.Button button_create;
    }
}