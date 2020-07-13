using HotelReservationDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationDesktop.Forms
{
    public partial class ManageTypes : Form
    {
        HotelReservationEntities db;
        public ManageTypes()
        {
            InitializeComponent();
            db = new HotelReservationEntities();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TypeNametextBox.Text != "" && GuestnumericUpDown.Value != 0)
            {
                RoomType type = new RoomType()
                {
                    TypeName = TypeNametextBox.Text,
                    MaxGuestNo = Convert.ToInt32(GuestnumericUpDown.Value)
                };
                db.RoomTypes.Add(type);
                db.SaveChanges();
                MessageBox.Show("Room Type Added Successfully", "Add New Room Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utilities.ClearControls(this);
                GetTypes();
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
                int TypeNumber = Convert.ToInt32(SearchtextBox.Text);
                RoomType type = db.RoomTypes.Find(TypeNumber);
                if (TypeNametextBox.Text != "" && GuestnumericUpDown.Value != 0)
                {
                    type.TypeName = TypeNametextBox.Text;
                    type.MaxGuestNo = Convert.ToInt32(GuestnumericUpDown.Value);
                    db.SaveChanges();
                    MessageBox.Show("Room Type Changed Successfully", "Edit Room Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utilities.ClearControls(this);
                    GetTypes();
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
                int TypeNumber = Convert.ToInt32(SearchtextBox.Text);
                RoomType type = db.RoomTypes.Find(TypeNumber);
                db.RoomTypes.Remove(type);
                db.SaveChanges();
                MessageBox.Show("Room Type Deleted Successfully!", "Delete Room Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utilities.ClearControls(this);
                GetTypes();
            }
            else
            {
                MessageBox.Show("you MUST Search for the Room Number first", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchtextBox.Text != "")
            {
                int TypeNumber = Convert.ToInt32(SearchtextBox.Text);
                RoomType findType = db.RoomTypes.Find(TypeNumber);
                if (findType != null)
                {
                    TypeNametextBox.Text = findType.TypeName;
                    GuestnumericUpDown.Value = findType.MaxGuestNo;
                }
                else
                {
                    MessageBox.Show("There is no Room Type with that number", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("you MUST enter Room Number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ManageTypes_Load(object sender, EventArgs e)
        {
            GetTypes();
        }
        private void GetTypes()
        {
            dataGridView1.Rows.Clear();
            var roomTypes = db.RoomTypes.ToList();
            foreach(var type in roomTypes)
            {
                dataGridView1.Rows.Add(type.TypeId, type.TypeName, type.MaxGuestNo);
            }
            Utilities.FormatGridView(dataGridView1);
        }
    }
}
