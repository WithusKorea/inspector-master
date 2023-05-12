namespace Inspector.Forms
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
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_Viewer = new System.Windows.Forms.Panel();
            this.panel_SystemMessage = new System.Windows.Forms.Panel();
            this.panel_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Container
            // 
            this.panel_Container.Controls.Add(this.panel_Viewer);
            this.panel_Container.Controls.Add(this.panel_SystemMessage);
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(0, 0);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(1086, 615);
            this.panel_Container.TabIndex = 0;
            // 
            // panel_Viewer
            // 
            this.panel_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Viewer.Location = new System.Drawing.Point(0, 0);
            this.panel_Viewer.Name = "panel_Viewer";
            this.panel_Viewer.Size = new System.Drawing.Size(1086, 501);
            this.panel_Viewer.TabIndex = 0;
            // 
            // panel_SystemMessage
            // 
            this.panel_SystemMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_SystemMessage.Location = new System.Drawing.Point(0, 501);
            this.panel_SystemMessage.Name = "panel_SystemMessage";
            this.panel_SystemMessage.Size = new System.Drawing.Size(1086, 114);
            this.panel_SystemMessage.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 615);
            this.Controls.Add(this.panel_Container);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Panel panel_Viewer;
        private System.Windows.Forms.Panel panel_SystemMessage;
    }
}