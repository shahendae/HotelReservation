﻿namespace HotelReservationDesktop.Forms
{
    partial class AllReservations
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
            this.ReservationsGridView = new System.Windows.Forms.DataGridView();
            this.BookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationsGridView
            // 
            this.ReservationsGridView.AllowUserToAddRows = false;
            this.ReservationsGridView.ColumnHeadersHeight = 40;
            this.ReservationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ReservationsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingId,
            this.GuestName,
            this.CheckIN,
            this.Column1,
            this.Column2,
            this.Cancel});
            this.ReservationsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservationsGridView.Location = new System.Drawing.Point(0, 0);
            this.ReservationsGridView.Name = "ReservationsGridView";
            this.ReservationsGridView.ReadOnly = true;
            this.ReservationsGridView.Size = new System.Drawing.Size(623, 474);
            this.ReservationsGridView.TabIndex = 1;
            this.ReservationsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationsGridView_CellClick);
            // 
            // BookingId
            // 
            this.BookingId.HeaderText = "BookingId";
            this.BookingId.Name = "BookingId";
            this.BookingId.ReadOnly = true;
            // 
            // GuestName
            // 
            this.GuestName.HeaderText = "Guest Name";
            this.GuestName.Name = "GuestName";
            this.GuestName.ReadOnly = true;
            // 
            // CheckIN
            // 
            this.CheckIN.HeaderText = "Check-IN";
            this.CheckIN.Name = "CheckIN";
            this.CheckIN.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Check-OUT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 98;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Cancel Reservation";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Text = "Cancel";
            // 
            // AllReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 474);
            this.Controls.Add(this.ReservationsGridView);
            this.Name = "AllReservations";
            this.Text = "All Reservations";
            this.Load += new System.EventHandler(this.AllReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReservationsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
    }
}