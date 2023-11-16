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
    public partial class Order_form : Form
    {
        OrderProduct OrderProduct = new OrderProduct();
        public Order_form()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Visible = false;

            OrderProduct.ShowDialog();
        }
    }
}
