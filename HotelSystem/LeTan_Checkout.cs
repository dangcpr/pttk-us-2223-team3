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
    public partial class LeTan_Checkout : UserControl
    {
        LeTan_Checkout_Card leTan_Checkout_Card = new LeTan_Checkout_Card();
        LeTan_Checkout_Driver leTan_Checkout_Driver = new LeTan_Checkout_Driver();
        LeTan_Invoice_Search leTan_Invoice_Search = new LeTan_Invoice_Search();

        public LeTan_Checkout()
        {
            InitializeComponent();
        }
    }
}
