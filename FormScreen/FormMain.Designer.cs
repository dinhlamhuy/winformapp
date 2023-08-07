namespace winformapp.FormScreen
{
    partial class FormMain
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
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MaximunBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.bodyPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.navbarPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(112)))));
            this.navbarPanel.Controls.Add(this.MinimizeBtn);
            this.navbarPanel.Controls.Add(this.MaximunBtn);
            this.navbarPanel.Controls.Add(this.ExitBtn);
            this.navbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarPanel.Location = new System.Drawing.Point(0, 0);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(800, 48);
            this.navbarPanel.TabIndex = 1;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.BorderColor = System.Drawing.Color.White;
            this.MinimizeBtn.BorderThickness = 3;
            this.MinimizeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeBtn.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(695, 13);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MinimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MinimizeBtn.TabIndex = 4;
            this.MinimizeBtn.Text = "guna2CircleButton3";
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // MaximunBtn
            // 
            this.MaximunBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximunBtn.BorderColor = System.Drawing.Color.White;
            this.MaximunBtn.BorderThickness = 3;
            this.MaximunBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MaximunBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MaximunBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MaximunBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MaximunBtn.FillColor = System.Drawing.Color.Transparent;
            this.MaximunBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximunBtn.ForeColor = System.Drawing.Color.White;
            this.MaximunBtn.Location = new System.Drawing.Point(733, 13);
            this.MaximunBtn.Name = "MaximunBtn";
            this.MaximunBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MaximunBtn.Size = new System.Drawing.Size(20, 20);
            this.MaximunBtn.TabIndex = 4;
            this.MaximunBtn.Text = "guna2CircleButton2";
            this.MaximunBtn.Click += new System.EventHandler(this.MaximunBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BorderColor = System.Drawing.Color.White;
            this.ExitBtn.BorderThickness = 3;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 3F);
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(768, 13);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.Size = new System.Drawing.Size(20, 20);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(112)))));
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 48);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(174, 402);
            this.sidebarPanel.TabIndex = 2;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.guna2Panel2);
            this.bodyPanel.Controls.Add(this.guna2Panel1);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(174, 48);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(626, 402);
            this.bodyPanel.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 338);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(626, 64);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(626, 338);
            this.guna2Panel2.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.navbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.navbarPanel.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2CircleButton MinimizeBtn;
        private Guna.UI2.WinForms.Guna2CircleButton MaximunBtn;
        private Guna.UI2.WinForms.Guna2CircleButton ExitBtn;
        private Guna.UI2.WinForms.Guna2Panel bodyPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}