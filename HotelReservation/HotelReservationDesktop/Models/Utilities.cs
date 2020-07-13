using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationDesktop.Models
{
    public class Utilities
    {
        public static void FormatGridView(DataGridView gridView)
        {
            gridView.AllowUserToAddRows = false;
            gridView.BorderStyle = BorderStyle.None;
            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.EnableHeadersVisualStyles = false;
            gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(153, 51, 102);
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            gridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 179, 179);
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        public static void ClearControls(Control form)
        {
            if (form.HasChildren)
            {
                foreach (Control child in form.Controls)
                {
                    ClearControls(child);
                }
            }
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Value = DateTime.Now;
                }
            }

        }
    }
}
