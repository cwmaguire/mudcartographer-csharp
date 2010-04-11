namespace MudCartographer
{
    partial class Cartographer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartographer));
            this.toolStripControl = new System.Windows.Forms.ToolStrip();
            this.toolStripClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdition = new System.Windows.Forms.ToolStrip();
            this.toolStripSelection = new System.Windows.Forms.ToolStripButton();
            this.toolStripCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteNode = new System.Windows.Forms.ToolStripButton();
            this.toolStripControl.SuspendLayout();
            this.toolStripEdition.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripControl
            // 
            this.toolStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClear});
            this.toolStripControl.Location = new System.Drawing.Point(0, 0);
            this.toolStripControl.Name = "toolStripControl";
            this.toolStripControl.Size = new System.Drawing.Size(284, 25);
            this.toolStripControl.TabIndex = 0;
            this.toolStripControl.Text = "toolStrip1";
            // 
            // toolStripClear
            // 
            this.toolStripClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripClear.Image")));
            this.toolStripClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClear.Name = "toolStripClear";
            this.toolStripClear.Size = new System.Drawing.Size(23, 22);
            this.toolStripClear.Text = "Clear map";
            this.toolStripClear.Click += new System.EventHandler(this.toolStripClear_Click);
            // 
            // toolStripEdition
            // 
            this.toolStripEdition.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSelection,
            this.toolStripCreate,
            this.toolStripDeleteNode});
            this.toolStripEdition.Location = new System.Drawing.Point(0, 25);
            this.toolStripEdition.Name = "toolStripEdition";
            this.toolStripEdition.Size = new System.Drawing.Size(284, 25);
            this.toolStripEdition.TabIndex = 1;
            this.toolStripEdition.Text = "toolStrip1";
            // 
            // toolStripSelection
            // 
            this.toolStripSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSelection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSelection.Image")));
            this.toolStripSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSelection.Name = "toolStripSelection";
            this.toolStripSelection.Size = new System.Drawing.Size(23, 22);
            this.toolStripSelection.Text = "Select node";
            this.toolStripSelection.Click += new System.EventHandler(this.toolStripSelection_Click);
            // 
            // toolStripCreate
            // 
            this.toolStripCreate.CheckOnClick = true;
            this.toolStripCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCreate.Image")));
            this.toolStripCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCreate.Name = "toolStripCreate";
            this.toolStripCreate.Size = new System.Drawing.Size(23, 22);
            this.toolStripCreate.Text = "Create Rooms";
            this.toolStripCreate.Click += new System.EventHandler(this.toolStripCreate_Click);
            // 
            // toolStripDeleteNode
            // 
            this.toolStripDeleteNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeleteNode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDeleteNode.Image")));
            this.toolStripDeleteNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteNode.Name = "toolStripDeleteNode";
            this.toolStripDeleteNode.Size = new System.Drawing.Size(23, 22);
            this.toolStripDeleteNode.Text = "Delete Node";
            this.toolStripDeleteNode.Click += new System.EventHandler(this.toolStripDeleteNote_Click);
            // 
            // Cartographer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStripEdition);
            this.Controls.Add(this.toolStripControl);
            this.Name = "Cartographer";
            this.Text = "Cartographer";
            this.Load += new System.EventHandler(this.Cartographer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Cartographer_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cartographer_MouseDown);
            this.Resize += new System.EventHandler(this.Cartographer_Resize);
            this.toolStripControl.ResumeLayout(false);
            this.toolStripControl.PerformLayout();
            this.toolStripEdition.ResumeLayout(false);
            this.toolStripEdition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripControl;
        private System.Windows.Forms.ToolStripButton toolStripClear;
        private System.Windows.Forms.ToolStrip toolStripEdition;
        private System.Windows.Forms.ToolStripButton toolStripCreate;
        private System.Windows.Forms.ToolStripButton toolStripSelection;
        private System.Windows.Forms.ToolStripButton toolStripDeleteNode;
    }
}