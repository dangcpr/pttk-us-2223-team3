using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class LeTan_Room_Request : UserControl
    {
        public LeTan_Room_Request()
        {
            InitializeComponent();
        }

        private void quitRequestBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
