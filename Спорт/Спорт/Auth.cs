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
    public partial class Auth : Form
    {
        Order_form order_form = new Order_form();

        public Auth()
        {
            InitializeComponent();
        }
        bool checkbox = false;

        private void button_log_in_Click(object sender, EventArgs e)
        {
            // Если checkbox равен true, то Открываем форму order_form
            if (checkbox)
            {
                Visible = false;

                order_form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы не прошли captcha. Нажмите на кнпоку на форме!");
            }
        }


        private void checkBox_captcha_CheckedChanged(object sender, EventArgs e)
        {
            // Проверка на капчу
            if (sender == checkBox_captcha)
                checkbox = true;    
        }
    }
}
