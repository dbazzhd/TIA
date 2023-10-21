namespace TIA_App {
    partial class FormConnect {
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
            this.combobox_processes = new System.Windows.Forms.ComboBox();
            this.label_processes = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_headline = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox_processes
            // 
            this.combobox_processes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_processes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_processes.FormattingEnabled = true;
            this.combobox_processes.Location = new System.Drawing.Point(12, 64);
            this.combobox_processes.Name = "combobox_processes";
            this.combobox_processes.Size = new System.Drawing.Size(162, 21);
            this.combobox_processes.TabIndex = 1;
            // 
            // label_processes
            // 
            this.label_processes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_processes.Location = new System.Drawing.Point(12, 48);
            this.label_processes.Name = "label_processes";
            this.label_processes.Size = new System.Drawing.Size(162, 13);
            this.label_processes.TabIndex = 0;
            this.label_processes.Text = "Processes";
            this.label_processes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_connect
            // 
            this.button_connect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_connect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_connect.Location = new System.Drawing.Point(12, 91);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(162, 23);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Location = new System.Drawing.Point(180, 64);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(21, 21);
            this.button_refresh.TabIndex = 4;
            this.button_refresh.TabStop = false;
            this.button_refresh.Text = "R";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // label_headline
            // 
            this.label_headline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_headline.Location = new System.Drawing.Point(12, 12);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(162, 21);
            this.label_headline.TabIndex = 5;
            this.label_headline.Text = "Connect to TIA Portal";
            this.label_headline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.ForeColor = System.Drawing.Color.Red;
            this.button_cancel.Location = new System.Drawing.Point(180, 12);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(21, 21);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.TabStop = false;
            this.button_cancel.Text = "X";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // FormConnect
            // 
            this.AcceptButton = this.button_connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(213, 126);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_headline);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label_processes);
            this.Controls.Add(this.combobox_processes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(213, 126);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(213, 126);
            this.Name = "FormConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to TIA Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_processes;
        private System.Windows.Forms.Label label_processes;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Button button_cancel;
    }
}