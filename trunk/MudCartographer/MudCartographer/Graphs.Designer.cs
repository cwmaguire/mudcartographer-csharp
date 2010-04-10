namespace MudCartographer
{
    partial class Graphs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphs));
            this.mapPanel = new MudCartographer.FlickerFreePanel(this.components);
            this.toolStripMC = new System.Windows.Forms.ToolStrip();
            this.toolStripClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mapPanel.SuspendLayout();
            this.toolStripMC.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPanel
            // 
            this.mapPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mapPanel.Controls.Add(this.toolStripMC);
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Location = new System.Drawing.Point(0, 0);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(584, 362);
            this.mapPanel.TabIndex = 0;
            this.mapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mapPanel_Paint);
            this.mapPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapPanel_MouseDown);
            // 
            // toolStripMC
            // 
            this.toolStripMC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClear,
            this.toolStripSeparator1});
            this.toolStripMC.Location = new System.Drawing.Point(0, 0);
            this.toolStripMC.Name = "toolStripMC";
            this.toolStripMC.Size = new System.Drawing.Size(584, 25);
            this.toolStripMC.TabIndex = 0;
            this.toolStripMC.Text = "toolStrip1";
            // 
            // toolStripClear
            // 
            this.toolStripClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripClear.Image")));
            this.toolStripClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClear.Name = "toolStripClear";
            this.toolStripClear.Size = new System.Drawing.Size(23, 22);
            this.toolStripClear.Text = "Clear the current map to create a new one";
            this.toolStripClear.Click += new System.EventHandler(this.toolStripClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.mapPanel);
            this.Name = "Graphs";
            this.Text = "MudCartographer";
            this.mapPanel.ResumeLayout(false);
            this.mapPanel.PerformLayout();
            this.toolStripMC.ResumeLayout(false);
            this.toolStripMC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlickerFreePanel mapPanel;
        private System.Windows.Forms.ToolStrip toolStripMC;
        private System.Windows.Forms.ToolStripButton toolStripClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

