namespace HotelReservationDesktop.Forms
{
    partial class ManageTypes
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
            this.TypeNametextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.GuestnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GuestnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeNametextBox
            // 
            this.TypeNametextBox.Location = new System.Drawing.Point(202, 133);
            this.TypeNametextBox.Name = "TypeNametextBox";
            this.TypeNametextBox.Size = new System.Drawing.Size(180, 20);
            this.TypeNametextBox.TabIndex = 61;
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SearchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.SearchButton.IconColor = System.Drawing.Color.DimGray;
            this.SearchButton.IconSize = 30;
            this.SearchButton.Location = new System.Drawing.Point(510, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Rotation = 0D;
            this.SearchButton.Size = new System.Drawing.Size(62, 30);
            this.SearchButton.TabIndex = 48;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Room Type Id";
            // 
            // AddButton
            // 
            this.AddButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddButton.IconColor = System.Drawing.Color.Black;
            this.AddButton.IconSize = 16;
            this.AddButton.Location = new System.Drawing.Point(431, 108);
            this.AddButton.Name = "AddButton";
            this.AddButton.Rotation = 0D;
            this.AddButton.Size = new System.Drawing.Size(141, 42);
            this.AddButton.TabIndex = 45;
            this.AddButton.Text = "New Room Type";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Max Number of Guests";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Room Type Name";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DeleteButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DeleteButton.IconColor = System.Drawing.Color.Black;
            this.DeleteButton.IconSize = 16;
            this.DeleteButton.Location = new System.Drawing.Point(431, 231);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Rotation = 0D;
            this.DeleteButton.Size = new System.Drawing.Size(141, 42);
            this.DeleteButton.TabIndex = 52;
            this.DeleteButton.Text = "Delete Room Type";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EditButton.IconColor = System.Drawing.Color.Black;
            this.EditButton.IconSize = 16;
            this.EditButton.Location = new System.Drawing.Point(431, 167);
            this.EditButton.Name = "EditButton";
            this.EditButton.Rotation = 0D;
            this.EditButton.Size = new System.Drawing.Size(141, 42);
            this.EditButton.TabIndex = 51;
            this.EditButton.Text = "Edit Room Type";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.BackColor = System.Drawing.Color.White;
            this.SearchtextBox.Location = new System.Drawing.Point(158, 57);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(328, 20);
            this.SearchtextBox.TabIndex = 46;
            // 
            // GuestnumericUpDown
            // 
            this.GuestnumericUpDown.Location = new System.Drawing.Point(202, 189);
            this.GuestnumericUpDown.Name = "GuestnumericUpDown";
            this.GuestnumericUpDown.Size = new System.Drawing.Size(180, 20);
            this.GuestnumericUpDown.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(67, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 186);
            this.dataGridView1.TabIndex = 63;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TypeId";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Max Number of Guests";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // ManageTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GuestnumericUpDown);
            this.Controls.Add(this.TypeNametextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchtextBox);
            this.Name = "ManageTypes";
            this.Text = "Manage Type of Rooms";
            this.Load += new System.EventHandler(this.ManageTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GuestnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TypeNametextBox;
        private FontAwesome.Sharp.IconButton SearchButton;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton DeleteButton;
        private FontAwesome.Sharp.IconButton EditButton;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.NumericUpDown GuestnumericUpDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}