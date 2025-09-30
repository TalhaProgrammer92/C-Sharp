namespace InventoryManagement
{
    partial class Dashboard
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
            this.exitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maximizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.activityPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.salesButton = new Guna.UI2.WinForms.Guna2Button();
            this.customersButton = new Guna.UI2.WinForms.Guna2Button();
            this.purchasesButton = new Guna.UI2.WinForms.Guna2Button();
            this.productsButton = new Guna.UI2.WinForms.Guna2Button();
            this.categoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.homeButton = new Guna.UI2.WinForms.Guna2Button();
            this.userPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.AutoRoundedCorners = true;
            this.exitButton.FillColor = System.Drawing.Color.Blue;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(877, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 29);
            this.exitButton.TabIndex = 0;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.AutoRoundedCorners = true;
            this.maximizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.maximizeButton.IconColor = System.Drawing.Color.White;
            this.maximizeButton.Location = new System.Drawing.Point(826, 12);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(45, 29);
            this.maximizeButton.TabIndex = 1;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.AutoRoundedCorners = true;
            this.minimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeButton.FillColor = System.Drawing.Color.Fuchsia;
            this.minimizeButton.IconColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(775, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(45, 29);
            this.minimizeButton.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.maximizeButton);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(933, 55);
            this.topPanel.TabIndex = 3;
            // 
            // activityPanel
            // 
            this.activityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activityPanel.Location = new System.Drawing.Point(174, 61);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(759, 458);
            this.activityPanel.TabIndex = 4;
            // 
            // sidePanel
            // 
            this.sidePanel.AutoRoundedCorners = true;
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.BorderColor = System.Drawing.Color.Black;
            this.sidePanel.BorderThickness = 1;
            this.sidePanel.Controls.Add(this.salesButton);
            this.sidePanel.Controls.Add(this.customersButton);
            this.sidePanel.Controls.Add(this.purchasesButton);
            this.sidePanel.Controls.Add(this.productsButton);
            this.sidePanel.Controls.Add(this.categoryButton);
            this.sidePanel.Controls.Add(this.usernameLabel);
            this.sidePanel.Controls.Add(this.homeButton);
            this.sidePanel.Controls.Add(this.userPicture);
            this.sidePanel.CustomizableEdges.BottomLeft = false;
            this.sidePanel.CustomizableEdges.BottomRight = false;
            this.sidePanel.CustomizableEdges.TopLeft = false;
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.FillColor = System.Drawing.Color.RoyalBlue;
            this.sidePanel.Location = new System.Drawing.Point(0, 55);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(168, 464);
            this.sidePanel.TabIndex = 5;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(33, 89);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(69, 17);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // salesButton
            // 
            this.salesButton.AutoRoundedCorners = true;
            this.salesButton.BackColor = System.Drawing.Color.Transparent;
            this.salesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.salesButton.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.salesButton.CustomizableEdges.BottomRight = false;
            this.salesButton.CustomizableEdges.TopRight = false;
            this.salesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salesButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.salesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.salesButton.ForeColor = System.Drawing.Color.LightGray;
            this.salesButton.Image = global::InventoryManagement.Properties.Resources.increase;
            this.salesButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.salesButton.Location = new System.Drawing.Point(23, 313);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(145, 31);
            this.salesButton.TabIndex = 5;
            this.salesButton.Text = "Sales";
            // 
            // customersButton
            // 
            this.customersButton.AutoRoundedCorners = true;
            this.customersButton.BackColor = System.Drawing.Color.Transparent;
            this.customersButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customersButton.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.customersButton.CustomizableEdges.BottomRight = false;
            this.customersButton.CustomizableEdges.TopRight = false;
            this.customersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customersButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.customersButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.customersButton.ForeColor = System.Drawing.Color.LightGray;
            this.customersButton.Image = global::InventoryManagement.Properties.Resources.group;
            this.customersButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customersButton.Location = new System.Drawing.Point(23, 276);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(145, 31);
            this.customersButton.TabIndex = 4;
            this.customersButton.Text = "Customers";
            // 
            // purchasesButton
            // 
            this.purchasesButton.AutoRoundedCorners = true;
            this.purchasesButton.BackColor = System.Drawing.Color.Transparent;
            this.purchasesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.purchasesButton.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.purchasesButton.CustomizableEdges.BottomRight = false;
            this.purchasesButton.CustomizableEdges.TopRight = false;
            this.purchasesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.purchasesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.purchasesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.purchasesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.purchasesButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.purchasesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.purchasesButton.ForeColor = System.Drawing.Color.LightGray;
            this.purchasesButton.Image = global::InventoryManagement.Properties.Resources.shopping_bag;
            this.purchasesButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.purchasesButton.Location = new System.Drawing.Point(23, 239);
            this.purchasesButton.Name = "purchasesButton";
            this.purchasesButton.Size = new System.Drawing.Size(145, 31);
            this.purchasesButton.TabIndex = 3;
            this.purchasesButton.Text = "Purchases";
            // 
            // productsButton
            // 
            this.productsButton.AutoRoundedCorners = true;
            this.productsButton.BackColor = System.Drawing.Color.Transparent;
            this.productsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.productsButton.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.productsButton.CustomizableEdges.BottomRight = false;
            this.productsButton.CustomizableEdges.TopRight = false;
            this.productsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productsButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.productsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.productsButton.ForeColor = System.Drawing.Color.LightGray;
            this.productsButton.Image = global::InventoryManagement.Properties.Resources.box;
            this.productsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.productsButton.Location = new System.Drawing.Point(23, 202);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(145, 31);
            this.productsButton.TabIndex = 2;
            this.productsButton.Text = "Products";
            // 
            // categoryButton
            // 
            this.categoryButton.AutoRoundedCorners = true;
            this.categoryButton.BackColor = System.Drawing.Color.Transparent;
            this.categoryButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.categoryButton.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.categoryButton.CustomizableEdges.BottomRight = false;
            this.categoryButton.CustomizableEdges.TopRight = false;
            this.categoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.categoryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.categoryButton.ForeColor = System.Drawing.Color.LightGray;
            this.categoryButton.Image = global::InventoryManagement.Properties.Resources.menu;
            this.categoryButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.categoryButton.Location = new System.Drawing.Point(23, 165);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(145, 31);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "Category";
            // 
            // homeButton
            // 
            this.homeButton.AutoRoundedCorners = true;
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homeButton.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.homeButton.CustomizableEdges.BottomRight = false;
            this.homeButton.CustomizableEdges.TopRight = false;
            this.homeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.homeButton.ForeColor = System.Drawing.Color.LightGray;
            this.homeButton.Image = global::InventoryManagement.Properties.Resources.home;
            this.homeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeButton.Location = new System.Drawing.Point(23, 128);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(145, 31);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.userPicture.ImageRotate = 0F;
            this.userPicture.Location = new System.Drawing.Point(36, 6);
            this.userPicture.Name = "userPicture";
            this.userPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userPicture.Size = new System.Drawing.Size(80, 80);
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            this.userPicture.UseTransparentBackground = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.activityPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox exitButton;
        private Guna.UI2.WinForms.Guna2ControlBox maximizeButton;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeButton;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2Panel activityPanel;
        private Guna.UI2.WinForms.Guna2Panel sidePanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPicture;
        private Guna.UI2.WinForms.Guna2Button homeButton;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2Button customersButton;
        private Guna.UI2.WinForms.Guna2Button purchasesButton;
        private Guna.UI2.WinForms.Guna2Button productsButton;
        private Guna.UI2.WinForms.Guna2Button categoryButton;
        private Guna.UI2.WinForms.Guna2Button salesButton;
    }
}