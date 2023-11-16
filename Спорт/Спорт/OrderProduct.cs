using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Спорт
{
    public partial class OrderProduct : Form
    {
        //Order_form Order_Form = new Order_form();
        public OrderProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            //Order_Form.ShowDialog();
        }
    }
}
