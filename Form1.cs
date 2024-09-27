/*
Program Author: Jakayla Greenwood
Assignment: My Pizza Place
Description: A program that allows user to choose a pizza and sides and calculates their total.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace My_Pizza_Place
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;

            // Calculate price based on pizza size
            if (radioButtonSmall.Checked)
                totalPrice += 7.00; // Small pizza price
            else if (radioButtonMedium.Checked)
                totalPrice += 10.00; // Medium pizza price
            else if (radioButtonLarge.Checked)
                totalPrice += 12.00; // Large pizza price
            else if (radioButtonXL.Checked)
                totalPrice += 14.00; // XLarge pizza price

            // Add price for selected sides
            if (checkBoxBreadSticks.Checked)
                totalPrice += 6.99; // Bread Sticks price
            if (checkBoxWings.Checked)
                totalPrice += 12.00; // Wings price
            if (checkBoxCaesarSalad.Checked)
                totalPrice += 10.99; // Salad price
            if (checkBoxOvenBakedPasta.Checked)
                totalPrice += 10.99; // Oven-Baked Pasta price

            string selectedCheese = comboBoxCheese.SelectedItem?.ToString() ?? "Regular"; // Default to 'Regular' if not selected
            string selectedSauce = comboBoxSauce.SelectedItem?.ToString() ?? "Tomato";   // Default to 'Tomato' if not selected

            textBoxTotalPrice.Text = $"Total: ${totalPrice:F2}";

            MessageBox.Show($"Your total price is: ${totalPrice:F2}", "Order Total");
        }
    }
}
