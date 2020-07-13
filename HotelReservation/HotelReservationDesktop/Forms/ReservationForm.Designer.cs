namespace HotelReservationDesktop.Forms
{
    partial class ReservationForm
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
            this.FloortextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ViewtextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ReservationButton = new FontAwesome.Sharp.IconButton();
            this.SearchButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RoomNumbercomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RoomTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckOutTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ChecKInTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FloortextBox
            // 
            this.FloortextBox.Location = new System.Drawing.Point(139, 54);
            this.FloortextBox.Name = "FloortextBox";
            this.FloortextBox.ReadOnly = true;
            this.FloortextBox.Size = new System.Drawing.Size(129, 20);
            this.FloortextBox.TabIndex = 16;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(139, 129);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.ReadOnly = true;
            this.PricetextBox.Size = new System.Drawing.Size(129, 20);
            this.PricetextBox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(89, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Room Information";
            // 
            // ViewtextBox
            // 
            this.ViewtextBox.Location = new System.Drawing.Point(139, 89);
            this.ViewtextBox.Name = "ViewtextBox";
            this.ViewtextBox.ReadOnly = true;
            this.ViewtextBox.Size = new System.Drawing.Size(129, 20);
            this.ViewtextBox.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Price";
            // 
            // ReservationButton
            // 
            this.ReservationButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ReservationButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ReservationButton.IconColor = System.Drawing.Color.Black;
            this.ReservationButton.IconSize = 20;
            this.ReservationButton.Location = new System.Drawing.Point(48, 394);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Rotation = 0D;
            this.ReservationButton.Size = new System.Drawing.Size(219, 55);
            this.ReservationButton.TabIndex = 14;
            this.ReservationButton.Text = "    RESERVATION";
            this.ReservationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReservationButton.UseVisualStyleBackColor = true;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SearchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.SearchButton.IconColor = System.Drawing.Color.DimGray;
            this.SearchButton.IconSize = 30;
            this.SearchButton.Location = new System.Drawing.Point(516, 31);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Rotation = 0D;
            this.SearchButton.Size = new System.Drawing.Size(62, 30);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Guest National ID";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.BackColor = System.Drawing.Color.White;
            this.SearchtextBox.Location = new System.Drawing.Point(182, 35);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(328, 20);
            this.SearchtextBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Floor Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "View";
            // 
            // RoomNumbercomboBox
            // 
            this.RoomNumbercomboBox.FormattingEnabled = true;
            this.RoomNumbercomboBox.Location = new System.Drawing.Point(128, 176);
            this.RoomNumbercomboBox.Name = "RoomNumbercomboBox";
            this.RoomNumbercomboBox.Size = new System.Drawing.Size(164, 21);
            this.RoomNumbercomboBox.TabIndex = 10;
            this.RoomNumbercomboBox.SelectionChangeCommitted += new System.EventHandler(this.RoomNumbercomboBox_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Available Rooms";
            // 
            // RoomTypecomboBox
            // 
            this.RoomTypecomboBox.FormattingEnabled = true;
            this.RoomTypecomboBox.Location = new System.Drawing.Point(92, 127);
            this.RoomTypecomboBox.Name = "RoomTypecomboBox";
            this.RoomTypecomboBox.Size = new System.Drawing.Size(200, 21);
            this.RoomTypecomboBox.TabIndex = 7;
            this.RoomTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.RoomTypecomboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Room Type";
            // 
            // CheckOutTimePicker
            // 
            this.CheckOutTimePicker.Location = new System.Drawing.Point(92, 80);
            this.CheckOutTimePicker.Name = "CheckOutTimePicker";
            this.CheckOutTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CheckOutTimePicker.TabIndex = 4;
            // 
            // ChecKInTimePicker
            // 
            this.ChecKInTimePicker.Location = new System.Drawing.Point(92, 36);
            this.ChecKInTimePicker.Name = "ChecKInTimePicker";
            this.ChecKInTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ChecKInTimePicker.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Check-IN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Check-OUT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.RoomNumbercomboBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.RoomTypecomboBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CheckOutTimePicker);
            this.panel2.Controls.Add(this.ChecKInTimePicker);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(314, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 219);
            this.panel2.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Guest Information";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(108, 208);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(172, 20);
            this.EmailtextBox.TabIndex = 7;
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(109, 163);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(171, 20);
            this.PhonetextBox.TabIndex = 6;
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.Location = new System.Drawing.Point(110, 111);
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(171, 20);
            this.LastNametextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(109, 65);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(172, 20);
            this.FirstNametextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.FloortextBox);
            this.panel4.Controls.Add(this.PricetextBox);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.ViewtextBox);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(314, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 165);
            this.panel4.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.EmailtextBox);
            this.panel1.Controls.Add(this.PhonetextBox);
            this.panel1.Controls.Add(this.LastNametextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FirstNametextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 278);
            this.panel1.TabIndex = 9;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 474);
            this.Controls.Add(this.ReservationButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FloortextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ViewtextBox;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton ReservationButton;
        private FontAwesome.Sharp.IconButton SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RoomNumbercomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox RoomTypecomboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker CheckOutTimePicker;
        private System.Windows.Forms.DateTimePicker ChecKInTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.TextBox LastNametextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}