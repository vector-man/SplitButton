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
            this.splitButtonFruit = new Sce.Atf.Controls.SplitButton();
            this.splitButton1 = new Sce.Atf.Controls.SplitButton();
            this.labelSplitButton = new System.Windows.Forms.Label();
            this.labelDropDownButton = new System.Windows.Forms.Label();
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
            // splitButtonFruit
            // 
            this.splitButtonFruit.AutoSize = true;
            this.splitButtonFruit.ContextMenuStrip = this.contextMenuStrip1;
            this.splitButtonFruit.DropDownButton = true;
            this.splitButtonFruit.Location = new System.Drawing.Point(110, 38);
            this.splitButtonFruit.Name = "splitButtonFruit";
            this.splitButtonFruit.Size = new System.Drawing.Size(69, 23);
            this.splitButtonFruit.TabIndex = 0;
            this.splitButtonFruit.Text = "Fruiit";
            this.splitButtonFruit.UseVisualStyleBackColor = true;
            // 
            // splitButton1
            // 
            this.splitButton1.AutoSize = true;
            this.splitButton1.ContextMenuStrip = this.contextMenuStrip1;
            this.splitButton1.Location = new System.Drawing.Point(110, 9);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Size = new System.Drawing.Size(69, 23);
            this.splitButton1.TabIndex = 2;
            this.splitButton1.Text = "Fruiit";
            this.splitButton1.UseVisualStyleBackColor = true;
            // 
            // labelSplitButton
            // 
            this.labelSplitButton.AutoSize = true;
            this.labelSplitButton.Location = new System.Drawing.Point(12, 14);
            this.labelSplitButton.Name = "labelSplitButton";
            this.labelSplitButton.Size = new System.Drawing.Size(63, 13);
            this.labelSplitButton.TabIndex = 3;
            this.labelSplitButton.Text = "Split button:";
            // 
            // labelDropDownButton
            // 
            this.labelDropDownButton.AutoSize = true;
            this.labelDropDownButton.Location = new System.Drawing.Point(12, 43);
            this.labelDropDownButton.Name = "labelDropDownButton";
            this.labelDropDownButton.Size = new System.Drawing.Size(92, 13);
            this.labelDropDownButton.TabIndex = 4;
            this.labelDropDownButton.Text = "Dropdown button:";
            // 
            // FormSplitButtonDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 146);
            this.Controls.Add(this.labelDropDownButton);
            this.Controls.Add(this.labelSplitButton);
            this.Controls.Add(this.splitButton1);
            this.Controls.Add(this.splitButtonFruit);
            this.Name = "FormSplitButtonDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplitButton Demo";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sce.Atf.Controls.SplitButton splitButtonFruit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grapesToolStripMenuItem;
        private Sce.Atf.Controls.SplitButton splitButton1;
        private System.Windows.Forms.Label labelSplitButton;
        private System.Windows.Forms.Label labelDropDownButton;
    }
}

