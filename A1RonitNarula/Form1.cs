using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1RonitNarula
{
    public partial class formRestaurantBillCalculator : Form
    {
        /*
         * Double Variable to store the sub total amount of the bill
         */
        private double subtotal = 0;

        /*
         * Constant Double Variable that stores the Tax 
         */
        private const double tax = 0.13;

        /*
         * Double Variable to store the total amount of the bill
         */
        private double total = 0;
        public formRestaurantBillCalculator()
        {
            InitializeComponent();
        }

        /*
         * Method Called When the Form is loaded and setups the default values
         */
        private void FormRestaurantBillCalculator_Load(object sender, EventArgs e)
        {
            // Beverages Combo-Box
            string[] beverages = {"Soda - $1.95", "Tea - $1.50", "Coffee - $1.25", "Mineral Water - $2.95",
                "Juice - $2.50", "Milk - $1.50" };
            cmbBeverages.Items.AddRange(beverages);
            cmbBeverages.Items.Insert(0, "Select a Beverage");
            this.cmbBeverages.SelectedIndexChanged -= new System.EventHandler(this.CmbBeverages_SelectedIndexChanged);
            cmbBeverages.SelectedIndex = 0;
            this.cmbBeverages.SelectedIndexChanged += new System.EventHandler(this.CmbBeverages_SelectedIndexChanged);
            
            // Appetizer Combo-Box
            string[] appetizers = { "Buffalo Wings - $5.95", "Buffalo Fingers - $6.95", "Potato Skins - $8.95",
            "Nachos - $8.95","Mushroom Caps - $10.95", "Shrimp Cocktail - $12.95","Chips and Salsa - $6.95"};
            cmbAppetizers.Items.AddRange(appetizers);
            cmbAppetizers.Items.Insert(0, "Select Appetizer");
            this.cmbAppetizers.SelectedIndexChanged -= new System.EventHandler(this.CmbAppetizers_SelectedIndexChanged);
            cmbAppetizers.SelectedIndex = 0;
            this.cmbAppetizers.SelectedIndexChanged += new System.EventHandler(this.CmbAppetizers_SelectedIndexChanged);

            // MainCourse Combo-Box
            string[] mainCourses = {"Seafood Alfredo - $15.95", "Chicken Alfredo - $13.95","Chicken Picatta - $13.95",
            "Turkey Club - $11.95", "Lobster Pie - $19.95", "Prime Rib - $20.95","Shrimp Scampi - $18.95",
            "Turkey Dinner - $13.95", "Stuffed Chicken - $14.95"};
            cmbMainCourses.Items.AddRange(mainCourses);
            cmbMainCourses.Items.Insert(0, "Select Main Course");
            this.cmbMainCourses.SelectedIndexChanged -= new System.EventHandler(this.CmbMainCourses_SelectedIndexChanged);
            cmbMainCourses.SelectedIndex = 0;
            this.cmbMainCourses.SelectedIndexChanged += new System.EventHandler(this.CmbMainCourses_SelectedIndexChanged);

            // Desserts Combo_Box
            string[] desserts = { "Apple Pie - $5.95", "Sundae - $3.95", "Carrot Cake - $5.95", "Mud Pie - $4.95",
            "Apple Crisp - $5.95" };
            cmbDesserts.Items.AddRange(desserts);
            cmbDesserts.Items.Insert(0, "Select Dessert");
            this.cmbDesserts.SelectedIndexChanged -= new System.EventHandler(this.CmbDesserts_SelectedIndexChanged);
            cmbDesserts.SelectedIndex = 0;
            this.cmbDesserts.SelectedIndexChanged += new System.EventHandler(this.CmbDesserts_SelectedIndexChanged);

            // Setting up Load values for SubTotal, Tax and Total text boxes
            txtSubTotal.Text = subtotal.ToString("C");
            txtTax.Text = (subtotal * 0.13).ToString("C");
            txtTotal.Text = total.ToString("C");
        }

        /*
         * Method is called when a Beverage is selected
         * Method also calculates subtotal and total and displays them
         */
        private void CmbBeverages_SelectedIndexChanged(object sender, EventArgs e)
        {
                switch (cmbBeverages.SelectedIndex)
                {
                    case 1:
                        subtotal += 1.95;
                        listBoxItems.Items.Add(cmbBeverages.SelectedItem);
                        break;
                    case 2:
                        subtotal += 1.50;
                        listBoxItems.Items.Add(cmbBeverages.SelectedItem);
                        break;
                    case 3:
                        subtotal += 1.25;
                        listBoxItems.Items.Add(cmbBeverages.SelectedItem);
                        break;
                    case 4:
                        subtotal += 2.95;
                        listBoxItems.Items.Add(cmbBeverages.SelectedItem);
                        break;
                    case 5:
                        subtotal += 2.50;
                        listBoxItems.Items.Add(cmbBeverages.SelectedItem);
                        break;
                    case 6:
                        subtotal += 1.50;
                        listBoxItems.Items.Add(cmbBeverages.SelectedItem);
                        break;
                }
                txtSubTotal.Text = subtotal.ToString("C");
                txtTax.Text = (subtotal * 0.13).ToString("C");
                total = subtotal + subtotal * 0.13;
                txtTotal.Text = total.ToString("C");
        }

        /*
         * Method is called when an Appetizer is selected
         * Method also calculates subtotal and total and displays them
         */
        private void CmbAppetizers_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbAppetizers.SelectedIndex)
            {
                case 1:
                    subtotal += 5.95;
                    listBoxItems.Items.Add(cmbAppetizers.SelectedItem);
                    break;
                case 2:
                    subtotal += 6.95;
                    listBoxItems.Items.Add(cmbAppetizers.SelectedItem);
                    break;
                case 3:
                    subtotal += 8.95;
                    listBoxItems.Items.Add(cmbAppetizers.SelectedItem);
                    break;
                case 4:
                    subtotal += 8.95;
                    listBoxItems.Items.Add(cmbAppetizers.SelectedItem);
                    break;
                case 5:
                    subtotal += 10.95;
                    listBoxItems.Items.Add(cmbAppetizers.SelectedItem);
                    break;
                case 6:
                    subtotal += 12.95;
                    listBoxItems.Items.Add(cmbAppetizers.SelectedItem);
                    break;
                case 7:
                    subtotal += 6.95;
                    listBoxItems.Items.Add(cmbAppetizers.SelectedItem);
                    break;
            }
            txtSubTotal.Text = subtotal.ToString("C");
            txtTax.Text = (subtotal * 0.13).ToString("C");
            total = subtotal + subtotal * 0.13;
            txtTotal.Text = total.ToString("C");
        }

        /*
         * Method is called when a Main Course item is selected
         * Method also calculates subtotal and total and displays them
         */
        private void CmbMainCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMainCourses.SelectedIndex)
            {
                case 1:
                    subtotal += 15.95;
                    listBoxItems.Items.Add(cmbMainCourses.SelectedItem);
                    break;
                case 2:
                    subtotal += 13.95;
                    listBoxItems.Items.Add(cmbMainCourses.SelectedItem);
                    break;
                case 3:
                    subtotal += 13.95;
                    listBoxItems.Items.Add(cmbMainCourses.SelectedItem);
                    break;
                case 4:
                    subtotal += 11.95;
                    listBoxItems.Items.Add(cmbMainCourses.SelectedItem);
                    break;
                case 5:
                    subtotal += 19.95;
                    listBoxItems.Items.Add(cmbMainCourses.SelectedItem);
                    break;
                case 6:
                    subtotal += 20.95;
                    listBoxItems.Items.Add(cmbMainCourses.SelectedItem);
                    break;
                case 7:
                    subtotal += 18.95;
                    listBoxItems.Items.Add(cmbMainCourses.SelectedItem);
                    break;
                case 8:
                    subtotal += 13.95;
                    listBoxItems.Items.Add(cmbMainCourses.SelectedItem);
                    break;
                case 9:
                    subtotal += 14.95;
                    listBoxItems.Items.Add(cmbMainCourses.SelectedItem);
                    break;
            }
            txtSubTotal.Text = subtotal.ToString("C");
            txtTax.Text = (subtotal * 0.13).ToString("C");
            total = subtotal + subtotal * 0.13;
            txtTotal.Text = total.ToString("C");
        }

        /*
         * Method is called when a dessert is selected
         * Method also calculates subtotal and total and displays them
         */
        private void CmbDesserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDesserts.SelectedIndex)
            {
                case 1:
                    subtotal += 5.95;
                    listBoxItems.Items.Add(cmbDesserts.SelectedItem);
                    break;
                case 2:
                    subtotal += 3.95;
                    listBoxItems.Items.Add(cmbDesserts.SelectedItem);
                    break;
                case 3:
                    subtotal += 5.95;
                    listBoxItems.Items.Add(cmbDesserts.SelectedItem);
                    break;
                case 4:
                    subtotal += 4.95;
                    listBoxItems.Items.Add(cmbDesserts.SelectedItem);
                    break;
                case 5:
                    subtotal += 5.95;
                    listBoxItems.Items.Add(cmbDesserts.SelectedItem);
                    break;
            }
            txtSubTotal.Text = subtotal.ToString("C");
            txtTax.Text = (subtotal * 0.13).ToString("C");
            total = subtotal + subtotal * 0.13;
            txtTotal.Text = total.ToString("C");
        }

        /*
         * The Method id called when the user clicks the button Clear Bill
         * Method then clears the bill and sets everything to the same state as when the form was loaded
         */
        private void BtnClearBill_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Clear();
            subtotal = 0;
            total = 0;
            cmbBeverages.SelectedIndex = 0;
            cmbAppetizers.SelectedIndex = 0;
            cmbMainCourses.SelectedIndex = 0;
            cmbDesserts.SelectedIndex = 0;
        }
    }
}