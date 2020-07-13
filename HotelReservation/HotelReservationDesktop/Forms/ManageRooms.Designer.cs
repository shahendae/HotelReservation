namespace HotelReservationDesktop.Forms
{
    partial class ManageRooms
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
            this.RoomViewcomboBox = new System.Windows.Forms.ComboBox();
            this.RoomFloortextBox = new System.Windows.Forms.TextBox();
            this.RoomNumbertextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomPricetextBox = new System.Windows.Forms.TextBox();
            this.RoomDescriptiontextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.RoomTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RoomsGridView = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RoomNametextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomViewcomboBox
            // 
            this.RoomViewcomboBox.FormattingEnabled = true;
            this.RoomViewcomboBox.Items.AddRange(new object[] {
            "City",
            "Sea"});
            this.RoomViewcomboBox.Location = new System.Drawing.Point(175, 177);
            this.RoomViewcomboBox.Name = "RoomViewcomboBox";
            this.RoomViewcomboBox.Size = new System.Drawing.Size(180, 21);
            this.RoomViewcomboBox.TabIndex = 38;
            // 
            // RoomFloortextBox
            // 
            this.RoomFloortextBox.Location = new System.Drawing.Point(463, 65);
            this.RoomFloortextBox.Name = "RoomFloortextBox";
            this.RoomFloortextBox.Size = new System.Drawing.Size(139, 20);
            this.RoomFloortextBox.TabIndex = 36;
            // 
            // RoomNumbertextBox
            // 
            this.RoomNumbertextBox.Location = new System.Drawing.Point(175, 67);
            this.RoomNumbertextBox.Name = "RoomNumbertextBox";
            this.RoomNumbertextBox.Size = new System.Drawing.Size(154, 20);
            this.RoomNumbertextBox.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Room Number";
            // 
            // RoomPricetextBox
            // 
            this.RoomPricetextBox.Location = new System.Drawing.Point(175, 257);
            this.RoomPricetextBox.Name = "RoomPricetextBox";
            this.RoomPricetextBox.Size = new System.Drawing.Size(180, 20);
            this.RoomPricetextBox.TabIndex = 33;
            // 
            // RoomDescriptiontextBox
            // 
            this.RoomDescriptiontextBox.Location = new System.Drawing.Point(175, 215);
            this.RoomDescriptiontextBox.Name = "RoomDescriptiontextBox";
            this.RoomDescriptiontextBox.Size = new System.Drawing.Size(180, 20);
            this.RoomDescriptiontextBox.TabIndex = 32;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DeleteButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DeleteButton.IconColor = System.Drawing.Color.Black;
            this.DeleteButton.IconSize = 16;
            this.DeleteButton.Location = new System.Drawing.Point(431, 241);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Rotation = 0D;
            this.DeleteButton.Size = new System.Drawing.Size(141, 42);
            this.DeleteButton.TabIndex = 31;
            this.DeleteButton.Text = "Delete Room";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EditButton.IconColor = System.Drawing.Color.Black;
            this.EditButton.IconSize = 16;
            this.EditButton.Location = new System.Drawing.Point(431, 177);
            this.EditButton.Name = "EditButton";
            this.EditButton.Rotation = 0D;
            this.EditButton.Size = new System.Drawing.Size(141, 42);
            this.EditButton.TabIndex = 30;
            this.EditButton.Text = "Edit Room";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RoomTypecomboBox
            // 
            this.RoomTypecomboBox.FormattingEnabled = true;
            this.RoomTypecomboBox.Location = new System.Drawing.Point(175, 139);
            this.RoomTypecomboBox.Name = "RoomTypecomboBox";
            this.RoomTypecomboBox.Size = new System.Drawing.Size(180, 21);
            this.RoomTypecomboBox.TabIndex = 29;
            this.RoomTypecomboBox.Text = "select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "View";
            // 
            // RoomsGridView
            // 
            this.RoomsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RoomsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.RoomName,
            this.FloorNumber,
            this.RoomType,
            this.View,
            this.Price});
            this.RoomsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RoomsGridView.Location = new System.Drawing.Point(0, 298);
            this.RoomsGridView.Name = "RoomsGridView";
            this.RoomsGridView.Size = new System.Drawing.Size(629, 182);
            this.RoomsGridView.TabIndex = 28;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.Name = "RoomNumber";
            // 
            // RoomName
            // 
            this.RoomName.HeaderText = "RoomName";
            this.RoomName.Name = "RoomName";
            // 
            // FloorNumber
            // 
            this.FloorNumber.HeaderText = "FloorNumber";
            this.FloorNumber.Name = "FloorNumber";
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "RoomType";
            this.RoomType.Name = "RoomType";
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SearchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.SearchButton.IconColor = System.Drawing.Color.DimGray;
            this.SearchButton.IconSize = 30;
            this.SearchButton.Location = new System.Drawing.Point(510, 21);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Rotation = 0D;
            this.SearchButton.Size = new System.Drawing.Size(62, 30);
            this.SearchButton.TabIndex = 27;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Room Number";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.BackColor = System.Drawing.Color.White;
            this.SearchtextBox.Location = new System.Drawing.Point(158, 27);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(328, 20);
            this.SearchtextBox.TabIndex = 25;
            // 
            // AddButton
            // 
            this.AddButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddButton.IconColor = System.Drawing.Color.Black;
            this.AddButton.IconSize = 16;
            this.AddButton.Location = new System.Drawing.Point(431, 118);
            this.AddButton.Name = "AddButton";
            this.AddButton.Rotation = 0D;
            this.AddButton.Size = new System.Drawing.Size(141, 42);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Add New Room";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Floor Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Room Name";
            // 
            // RoomNametextBox
            // 
            this.RoomNametextBox.Location = new System.Drawing.Point(175, 103);
            this.RoomNametextBox.Name = "RoomNametextBox";
            this.RoomNametextBox.Size = new System.Drawing.Size(180, 20);
            this.RoomNametextBox.TabIndex = 40;
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 480);
            this.Controls.Add(this.RoomNametextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RoomViewcomboBox);
            this.Controls.Add(this.RoomFloortextBox);
            this.Controls.Add(this.RoomNumbertextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RoomPricetextBox);
            this.Controls.Add(this.RoomDescriptiontextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RoomTypecomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RoomsGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageRooms";
            this.Text = "ManageRooms";
            this.Load += new System.EventHandler(this.ManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RoomViewcomboBox;
        private System.Windows.Forms.TextBox RoomFloortextBox;
        private System.Windows.Forms.TextBox RoomNumbertextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RoomPricetextBox;
        private System.Windows.Forms.TextBox RoomDescriptiontextBox;
        private FontAwesome.Sharp.IconButton DeleteButton;
        private FontAwesome.Sharp.IconButton EditButton;
        private System.Windows.Forms.ComboBox RoomTypecomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView RoomsGridView;
        private FontAwesome.Sharp.IconButton SearchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchtextBox;
        private FontAwesome.Sharp.IconButton AddButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RoomNametextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}