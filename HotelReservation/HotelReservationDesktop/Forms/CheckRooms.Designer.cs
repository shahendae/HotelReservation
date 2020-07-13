namespace HotelReservationDesktop.Forms
{
    partial class CheckRooms
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
            this.RoomsGridView = new System.Windows.Forms.DataGridView();
            this.checkAvailability = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckOutPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.CheckInPicker = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomsGridView
            // 
            this.RoomsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.RoomName,
            this.Column2,
            this.RoomType,
            this.Column3,
            this.Column4});
            this.RoomsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RoomsGridView.Location = new System.Drawing.Point(0, 275);
            this.RoomsGridView.Name = "RoomsGridView";
            this.RoomsGridView.Size = new System.Drawing.Size(623, 199);
            this.RoomsGridView.TabIndex = 14;
            // 
            // checkAvailability
            // 
            this.checkAvailability.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.checkAvailability.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAvailability.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.checkAvailability.IconColor = System.Drawing.Color.Black;
            this.checkAvailability.IconSize = 20;
            this.checkAvailability.Location = new System.Drawing.Point(193, 204);
            this.checkAvailability.Name = "checkAvailability";
            this.checkAvailability.Rotation = 0D;
            this.checkAvailability.Size = new System.Drawing.Size(229, 55);
            this.checkAvailability.TabIndex = 13;
            this.checkAvailability.Text = "    Check Availability ";
            this.checkAvailability.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkAvailability.UseVisualStyleBackColor = true;
            this.checkAvailability.Click += new System.EventHandler(this.checkAvailability_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "CHECK-OUT Date";
            // 
            // CheckOutPicker
            // 
            this.CheckOutPicker.Location = new System.Drawing.Point(250, 146);
            this.CheckOutPicker.Name = "CheckOutPicker";
            this.CheckOutPicker.Size = new System.Drawing.Size(200, 20);
            this.CheckOutPicker.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "CHECK-IN Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(218, 189);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(0, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // CheckInPicker
            // 
            this.CheckInPicker.Location = new System.Drawing.Point(250, 79);
            this.CheckInPicker.Name = "CheckInPicker";
            this.CheckInPicker.Size = new System.Drawing.Size(200, 20);
            this.CheckInPicker.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RoomNumber";
            this.Column1.Name = "Column1";
            // 
            // RoomName
            // 
            this.RoomName.HeaderText = "RoomName";
            this.RoomName.Name = "RoomName";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FloorNumber";
            this.Column2.Name = "Column2";
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "RoomType";
            this.RoomType.Name = "RoomType";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "View";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // CheckRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 474);
            this.Controls.Add(this.RoomsGridView);
            this.Controls.Add(this.checkAvailability);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckOutPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.CheckInPicker);
            this.Name = "CheckRooms";
            this.Text = "CheckRooms";
            this.Load += new System.EventHandler(this.CheckRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomsGridView;
        private FontAwesome.Sharp.IconButton checkAvailability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker CheckOutPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker CheckInPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}