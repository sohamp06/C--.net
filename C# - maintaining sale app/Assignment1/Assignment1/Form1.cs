using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class salesCalculator : Form
    {
        //Storing sales for 7 days
        private readonly int[] dataOfEachDay = new int[7]; 
        private int totalSale = 0; 
        private int enteredDays = 0; 
        public salesCalculator()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(inputSale, "Add your sales here");
            toolTip.SetToolTip(listSales, "Your added sales for 7 days");
            toolTip.SetToolTip(result_sale, "Result of Average Calculated Sale");
            toolTip.SetToolTip(EnterButton, "Press to caalculate");
            toolTip.SetToolTip(ResetButton, "Press to reset all the data");
            toolTip.SetToolTip(ExitButton, "Press to close the application");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (enteredDays < 7)
            {
                if (int.TryParse(inputSale.Text, out int daySales))
                {
                    if (daySales >= 0 && daySales <= int.MaxValue)
                    {
                        dataOfEachDay[enteredDays] = daySales;
                        totalSale += daySales;
                        enteredDays++;

                        // Add the values from the input box to the listView
                        ListViewItem item = new ListViewItem($"{daySales}");
                        item.SubItems.Add(daySales.ToString());
                        listSales.Items.Add(item);

                        inputSale.Clear();

                        if (enteredDays == 7)
                        {
                            // Count the average and gives result
                            double averageSales = (double)totalSale / 7;
                            result_sale.Text = $"Average Sales for 7 days is: {averageSales:F2}";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input must be a positive(+) integer.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        inputSale.SelectAll();
                        inputSale.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputSale.SelectAll();
                    inputSale.Focus();
                }
            }
            else
            {
                MessageBox.Show("You cannot enter more than 7 days", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        { 
            inputSale.Clear();
            listSales.Clear();
            result_sale.Clear();
        }

        private void salesCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
