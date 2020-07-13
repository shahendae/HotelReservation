namespace HotelReservationDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menupanel = new System.Windows.Forms.Panel();
            this.ManageTypesButton = new FontAwesome.Sharp.IconButton();
            this.AllReservationButton = new FontAwesome.Sharp.IconButton();
            this.ManageRoomsButton = new FontAwesome.Sharp.IconButton();
            this.ReservationButton = new FontAwesome.Sharp.IconButton();
            this.CheckRoomsButton = new FontAwesome.Sharp.IconButton();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.panelCurrentForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.Menupanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelCurrentForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menupanel
            // 
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Menupanel.Controls.Add(this.ManageTypesButton);
            this.Menupanel.Controls.Add(this.AllReservationButton);
            this.Menupanel.Controls.Add(this.ManageRoomsButton);
            this.Menupanel.Controls.Add(this.ReservationButton);
            this.Menupanel.Controls.Add(this.CheckRoomsButton);
            this.Menupanel.Controls.Add(this.Sidepanel);
            this.Menupanel.Controls.Add(this.HomeButton);
            this.Menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanel.Location = new System.Drawing.Point(0, 0);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(204, 541);
            this.Menupanel.TabIndex = 0;
            // 
            // ManageTypesButton
            // 
            this.ManageTypesButton.FlatAppearance.BorderSize = 0;
            this.ManageTypesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageTypesButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ManageTypesButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageTypesButton.ForeColor = System.Drawing.Color.White;
            this.ManageTypesButton.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.ManageTypesButton.IconColor = System.Drawing.Color.White;
            this.ManageTypesButton.IconSize = 25;
            this.ManageTypesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageTypesButton.Location = new System.Drawing.Point(12, 446);
            this.ManageTypesButton.Name = "ManageTypesButton";
            this.ManageTypesButton.Rotation = 0D;
            this.ManageTypesButton.Size = new System.Drawing.Size(192, 54);
            this.ManageTypesButton.TabIndex = 7;
            this.ManageTypesButton.Text = "   Manage Type of Rooms";
            this.ManageTypesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageTypesButton.UseVisualStyleBackColor = true;
            this.ManageTypesButton.Click += new System.EventHandler(this.ManageTypesButton_Click);
            // 
            // AllReservationButton
            // 
            this.AllReservationButton.FlatAppearance.BorderSize = 0;
            this.AllReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllReservationButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AllReservationButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllReservationButton.ForeColor = System.Drawing.Color.White;
            this.AllReservationButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.AllReservationButton.IconColor = System.Drawing.Color.White;
            this.AllReservationButton.IconSize = 25;
            this.AllReservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllReservationButton.Location = new System.Drawing.Point(12, 289);
            this.AllReservationButton.Name = "AllReservationButton";
            this.AllReservationButton.Rotation = 0D;
            this.AllReservationButton.Size = new System.Drawing.Size(192, 54);
            this.AllReservationButton.TabIndex = 6;
            this.AllReservationButton.Text = "   Hotel Reservations";
            this.AllReservationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AllReservationButton.UseVisualStyleBackColor = true;
            this.AllReservationButton.Click += new System.EventHandler(this.AllReservationButton_Click);
            // 
            // ManageRoomsButton
            // 
            this.ManageRoomsButton.FlatAppearance.BorderSize = 0;
            this.ManageRoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageRoomsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ManageRoomsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageRoomsButton.ForeColor = System.Drawing.Color.White;
            this.ManageRoomsButton.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ManageRoomsButton.IconColor = System.Drawing.Color.White;
            this.ManageRoomsButton.IconSize = 25;
            this.ManageRoomsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageRoomsButton.Location = new System.Drawing.Point(12, 367);
            this.ManageRoomsButton.Name = "ManageRoomsButton";
            this.ManageRoomsButton.Rotation = 0D;
            this.ManageRoomsButton.Size = new System.Drawing.Size(192, 54);
            this.ManageRoomsButton.TabIndex = 5;
            this.ManageRoomsButton.Text = "   Manage Rooms";
            this.ManageRoomsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageRoomsButton.UseVisualStyleBackColor = true;
            this.ManageRoomsButton.Click += new System.EventHandler(this.ManageRoomsButton_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.FlatAppearance.BorderSize = 0;
            this.ReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ReservationButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationButton.ForeColor = System.Drawing.Color.White;
            this.ReservationButton.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            this.ReservationButton.IconColor = System.Drawing.Color.White;
            this.ReservationButton.IconSize = 25;
            this.ReservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservationButton.Location = new System.Drawing.Point(12, 208);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Rotation = 0D;
            this.ReservationButton.Size = new System.Drawing.Size(192, 54);
            this.ReservationButton.TabIndex = 4;
            this.ReservationButton.Text = "   New Reservation";
            this.ReservationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReservationButton.UseVisualStyleBackColor = true;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // CheckRoomsButton
            // 
            this.CheckRoomsButton.FlatAppearance.BorderSize = 0;
            this.CheckRoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckRoomsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CheckRoomsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRoomsButton.ForeColor = System.Drawing.Color.White;
            this.CheckRoomsButton.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.CheckRoomsButton.IconColor = System.Drawing.Color.White;
            this.CheckRoomsButton.IconSize = 25;
            this.CheckRoomsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckRoomsButton.Location = new System.Drawing.Point(12, 127);
            this.CheckRoomsButton.Name = "CheckRoomsButton";
            this.CheckRoomsButton.Rotation = 0D;
            this.CheckRoomsButton.Size = new System.Drawing.Size(192, 54);
            this.CheckRoomsButton.TabIndex = 3;
            this.CheckRoomsButton.Text = "   Check Available Rooms";
            this.CheckRoomsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CheckRoomsButton.UseVisualStyleBackColor = true;
            this.CheckRoomsButton.Click += new System.EventHandler(this.CheckRoomsButton_Click);
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Sidepanel.Location = new System.Drawing.Point(0, 44);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 54);
            this.Sidepanel.TabIndex = 2;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeButton.IconColor = System.Drawing.Color.White;
            this.HomeButton.IconSize = 25;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(12, 44);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Rotation = 0D;
            this.HomeButton.Size = new System.Drawing.Size(192, 54);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "       Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 10);
            this.panel2.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(114, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(171, 22);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Hotel Reservation";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(22, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(86, 49);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.panel4.Controls.Add(this.iconButton3);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Controls.Add(this.MinimizeButton);
            this.panel4.Controls.Add(this.CloseButton);
            this.panel4.Controls.Add(this.labelTitle);
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(204, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(639, 54);
            this.panel4.TabIndex = 4;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.Black;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinimizeButton.IconSize = 25;
            this.MinimizeButton.Location = new System.Drawing.Point(559, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Rotation = 0D;
            this.MinimizeButton.Size = new System.Drawing.Size(28, 40);
            this.MinimizeButton.TabIndex = 5;
            this.MinimizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButton.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseButton.IconSize = 25;
            this.CloseButton.Location = new System.Drawing.Point(593, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0D;
            this.CloseButton.Size = new System.Drawing.Size(38, 49);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panelCurrentForm
            // 
            this.panelCurrentForm.Controls.Add(this.pictureBox1);
            this.panelCurrentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrentForm.Location = new System.Drawing.Point(204, 64);
            this.panelCurrentForm.Name = "panelCurrentForm";
            this.panelCurrentForm.Size = new System.Drawing.Size(639, 477);
            this.panelCurrentForm.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 477);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(593, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(38, 49);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Black;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton3.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(559, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(28, 40);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 541);
            this.Controls.Add(this.panelCurrentForm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Menupanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Menupanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelCurrentForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menupanel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton HomeButton;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton CheckRoomsButton;
        private FontAwesome.Sharp.IconButton ReservationButton;
        private FontAwesome.Sharp.IconButton ManageRoomsButton;
        private FontAwesome.Sharp.IconButton AllReservationButton;
        private System.Windows.Forms.Panel panelCurrentForm;
        private FontAwesome.Sharp.IconButton ManageTypesButton;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

