namespace ICSharpCode.SideBar.Test
{
    partial class Form1
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
            ICSharpCode.SideBar.DefaultSideTabFactory defaultSideTabFactory1 = new ICSharpCode.SideBar.DefaultSideTabFactory();
            ICSharpCode.SideBar.DefaultSideTabItemFactory defaultSideTabItemFactory1 = new ICSharpCode.SideBar.DefaultSideTabItemFactory();
            this.sideBarControl1 = new ICSharpCode.SideBar.SideBarControl();
            this.SuspendLayout();
            // 
            // sideBarControl1
            // 
            this.sideBarControl1.ActiveTab = null;
            this.sideBarControl1.AllowDrop = true;
            this.sideBarControl1.BackColor = System.Drawing.SystemColors.Control;
            this.sideBarControl1.DoAddTab = false;
            this.sideBarControl1.Location = new System.Drawing.Point(263, 61);
            this.sideBarControl1.Name = "sideBarControl1";
            this.sideBarControl1.SideTabFactory = defaultSideTabFactory1;
            this.sideBarControl1.SideTabItemFactory = defaultSideTabItemFactory1;
            this.sideBarControl1.Size = new System.Drawing.Size(406, 268);
            this.sideBarControl1.TabIndex = 0;
            this.sideBarControl1.Load += new System.EventHandler(this.sideBarControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sideBarControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SideBarControl sideBarControl1;
    }
}

