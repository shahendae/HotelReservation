using HotelReservationDesktop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationDesktop
{
    public partial class Form1 : Form
    {
        private Form currentForm;
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenCurrentForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCurrentForm.Controls.Add(childForm);
            panelCurrentForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = HomeButton.Height;
            Sidepanel.Top = HomeButton.Top;
        }

        private void CheckRoomsButton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = CheckRoomsButton.Height;
            Sidepanel.Top = CheckRoomsButton.Top;
            OpenCurrentForm(new CheckRooms());
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = ReservationButton.Height;
            Sidepanel.Top = ReservationButton.Top;
            //reservationForm1.BringToFront();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ManageRoomsButton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = ManageRoomsButton.Height;
            Sidepanel.Top = ManageRoomsButton.Top;
            OpenCurrentForm(new ManageRooms());
        }

        private void AllReservationButton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = AllReservationButton.Height;
            Sidepanel.Top = AllReservationButton.Top;
            //AllReservationsForm.BringToFront();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
