using HotelReservationDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationDesktop.Forms
{
    public partial class ManageRooms : Form
    {
        HotelReservationEntities db;
        public ManageRooms()
        {
            InitializeComponent();
            db = new HotelReservationEntities();
        }
        private void ManageRooms_Load(object sender, EventArgs e)
        {
            GetRooms();
            //fill Room Types comboBox
            RoomTypecomboBox.DataSource = db.RoomTypes.ToList();
            RoomTypecomboBox.ValueMember = "TypeId";
            RoomTypecomboBox.DisplayMember = "TypeName";
            RoomViewcomboBox.SelectedIndex = 0;
        }
        private void GetRooms()
        {
            RoomsGridView.Rows.Clear();
            var rooms = db.Rooms.Include(r => r.RoomType).ToList();
            foreach (Room room in rooms)
            {
                RoomsGridView.Rows.Add(room.RoomId, room.RoomName, room.FloorNo,
                    room.RoomType.TypeName, room.View, room.Price);
            }
           Utilities.FormatGridView(RoomsGridView);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Check if all values entered then add it in database
            if (RoomNumbertextBox.Text != "" && RoomNametextBox.Text != ""
                && RoomFloortextBox.Text != "" && RoomDescriptiontextBox.Text != ""
                && RoomPricetextBox.Text != "" && RoomViewcomboBox.SelectedIndex != -1)
            {
                Room newRoom = new Room()
                {
                    RoomId = Convert.ToInt32(RoomNumbertextBox.Text),
                    RoomName = RoomNametextBox.Text,
                    FloorNo = Convert.ToInt32(RoomFloortextBox.Text),
                    Description = RoomDescriptiontextBox.Text,
                    Price = Convert.ToDecimal(RoomPricetextBox.Text),
                    TypeId = Convert.ToInt32(RoomTypecomboBox.SelectedValue),
                    View = RoomViewcomboBox.SelectedItem.ToString()
                };
                if (db.Rooms.Find(newRoom.RoomId) == null)
                {
                    db.Rooms.Add(newRoom);
                    db.SaveChanges();
                    MessageBox.Show("Room Added Successfully", "Add New Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utilities.ClearControls(this);
                    GetRooms();
                }
                else
                {
                    MessageBox.Show("Room Number Exists before", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Cannot Add Empty Values", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (SearchtextBox.Text != "")
            {
                int RoomNumber = Convert.ToInt32(SearchtextBox.Text);
                Room findRoom = db.Rooms.Find(RoomNumber);
                if (RoomFloortextBox.Text != "" && RoomNametextBox.Text != "" && RoomDescriptiontextBox.Text != ""
                    && RoomPricetextBox.Text != "" && RoomViewcomboBox.SelectedIndex != -1)
                {
                    findRoom.FloorNo = Convert.ToInt32(RoomFloortextBox.Text);
                    findRoom.RoomName = RoomNametextBox.Text;
                    findRoom.Description = RoomDescriptiontextBox.Text;
                    findRoom.Price = Convert.ToDecimal(RoomPricetextBox.Text);
                    findRoom.TypeId = Convert.ToInt32(RoomTypecomboBox.SelectedValue);
                    findRoom.View = RoomViewcomboBox.SelectedItem.ToString();

                    db.SaveChanges();
                    MessageBox.Show("Room Changed Successfully", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utilities.ClearControls(this);
                    GetRooms();
                }

                else
                {
                    MessageBox.Show("Cannot Add Empty Values", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("you MUST Search for the Room Number first", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (SearchtextBox.Text != "")
            {
                int RoomNumber = Convert.ToInt32(SearchtextBox.Text);
                Room findRoom = db.Rooms.Find(RoomNumber);
                db.Rooms.Remove(findRoom);
                db.SaveChanges();
                MessageBox.Show("Room Deleted Successfully!", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utilities.ClearControls(this);
                GetRooms();
            }
            else
            {
                MessageBox.Show("you MUST Search for the Room Number first", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RoomNumbertextBox.ReadOnly = true;
            if (SearchtextBox.Text != "")
            {
                int RoomNumber = Convert.ToInt32(SearchtextBox.Text);
                Room findRoom = db.Rooms.Find(RoomNumber);
                if (findRoom != null)
                {
                    RoomNumbertextBox.Text = findRoom.RoomId.ToString();
                    RoomNametextBox.Text = findRoom.RoomName;
                    RoomFloortextBox.Text = findRoom.FloorNo.ToString();
                    RoomPricetextBox.Text = findRoom.Price.ToString();
                    RoomDescriptiontextBox.Text = findRoom.Description;
                    RoomTypecomboBox.SelectedValue = findRoom.TypeId;
                    RoomViewcomboBox.SelectedItem = findRoom.View;
                }
                else
                {
                    MessageBox.Show("There is no Room with that number", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RoomNumbertextBox.ReadOnly = false;

                }
            }

            else
            {
                MessageBox.Show("you MUST enter Room Number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
