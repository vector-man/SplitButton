namespace SplitButtonDemo
{
    partial class FormSplitButtonDemo
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitButton1 = new Sce.Atf.Controls.SplitButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applesToolStripMenuItem,
            this.orangesToolStripMenuItem,
            this.grapesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 70);
            // 
            // applesToolStripMenuItem
            // 
            this.applesToolStripMenuItem.Name = "applesToolStripMenuItem";
            this.applesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.applesToolStripMenuItem.Text = "Apples";
            // 
            // grapesToolStripMenuItem
            // 
            this.grapesToolStripMenuItem.Name = "grapesToolStripMenuItem";
            this.grapesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.grapesToolStripMenuItem.Text = "Grapes";
            // 
            // orangesToolStripMenuItem
            // 
            this.orangesToolStripMenuItem.Name = "orangesToolStripMenuItem";
            this.orangesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.orangesToolStripMenuItem.Text = "Oranges";
            // 
            // splitButton1
            // 
            this.splitButton1.AutoSize = true;
            this.splitButton1.ContextMenuStrip = this.contextMenuStrip1;
            this.splitButton1.DropDownButton = true;
            this.splitButton1.Location = new System.Drawing.Point(89, 145);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Size = new System.Drawing.Size(97, 23);
            this.splitButton1.TabIndex = 0;
            this.splitButton1.Text = "splitButton1";
            this.splitButton1.UseVisualStyleBackColor = true;
            // 
            // FormSplitButtonDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.splitButton1);
            this.Name = "FormSplitButtonDemo";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sce.Atf.Controls.SplitButton splitButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grapesToolStripMenuItem;
    }
}

