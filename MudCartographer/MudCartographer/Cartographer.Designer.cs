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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripControl
            // 
            this.toolStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClear,
            this.toolStripSeparator1});
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Cartographer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStripControl);
            this.Name = "Cartographer";
            this.Text = "Cartographer";
            this.Load += new System.EventHandler(this.Cartographer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Cartographer_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cartographer_MouseDown);
            this.Resize += new System.EventHandler(this.Cartographer_Resize);
            this.toolStripControl.ResumeLayout(false);
            this.toolStripControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripControl;
        private System.Windows.Forms.ToolStripButton toolStripClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}