namespace ProcessManager
{
    partial class MainForm
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
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.colImgName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMemWrkingSet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colImgName,
            this.colDescription,
            this.colPID,
            this.colMemWrkingSet});
            this.listViewProcesses.FullRowSelect = true;
            this.listViewProcesses.Location = new System.Drawing.Point(0, 39);
            this.listViewProcesses.MultiSelect = false;
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(592, 285);
            this.listViewProcesses.TabIndex = 0;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.View = System.Windows.Forms.View.Details;
            // 
            // colImgName
            // 
            this.colImgName.Text = "Image Name";
            this.colImgName.Width = 100;
            // 
            // colPID
            // 
            this.colPID.Text = "PID";
            this.colPID.Width = 80;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.btnSchedule);
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(592, 39);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSchedule.Location = new System.Drawing.Point(3, 3);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(75, 30);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 180;
            // 
            // colMemWrkingSet
            // 
            this.colMemWrkingSet.Text = "Memory (Working Set)";
            this.colMemWrkingSet.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 325);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.listViewProcesses);
            this.Name = "MainForm";
            this.Text = "Process Manager";
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.ColumnHeader colImgName;
        private System.Windows.Forms.ColumnHeader colPID;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colMemWrkingSet;
    }
}

