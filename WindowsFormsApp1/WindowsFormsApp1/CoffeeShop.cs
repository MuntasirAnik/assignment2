using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CoffeeShop_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string contact = contactTextBox.Text;
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            string invoice = "\t INVOICE\n\nName : " + name + "\n\nContact no : " + contact + "\n\nAddress : "+ address +"\n\nOrder : " + order +"\n\nQuantity : " + quantityTextBox.Text + "\n\nPrice : ";
            
            if(orderComboBox.Text== "Select item")
            {
                MessageBox.Show("Please, Select an item !!!");      
            }
            else
            {
                if (quantityTextBox.Text == "")
                {
                    MessageBox.Show("please enter quantity !!!");
                }
                else
                {
                    int quantity = Convert.ToInt32(quantityTextBox.Text);

                    string price;
                    if (orderComboBox.Text == "Black-120")
                    {
                        price = (120 * quantity).ToString();
                        orderInfoRichTextBox.Text = invoice + price;
                    }
                    else if (orderComboBox.Text == "Cold-100")
                    {
                        price = (100 * quantity).ToString();
                        orderInfoRichTextBox.Text = invoice + price;
                    }
                    else if (orderComboBox.Text == "Hot-90")
                    {
                        price = (90 * quantity).ToString();
                        orderInfoRichTextBox.Text = invoice + price;
                    }
                    else if (orderComboBox.Text == "Regular-60")
                    {
                        price = (60 * quantity).ToString();
                        orderInfoRichTextBox.Text = invoice + price;

                    }                  
                }
            }
        }
    }
}
