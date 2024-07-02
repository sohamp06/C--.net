/*
 * SOHAM PATEL
 * November 4, 2023
 * Assignment 3
 * Making an application for car service
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment__3
{
    public partial class Service : Form
    {
        private List<ServiceInformation> serviceList = new List<ServiceInformation>();
        // Constructor to Service form
        public Service()
        {
            InitializeComponent();
            InitializeServiceSummary_List();
            InitializeMake_List();
            // set tooltips
            ToolTip toolTip = new ToolTip();

            // set the tooltips for each fields
            toolTip.SetToolTip(add_button, "Press this button to calculate cost and generate report.");
            toolTip.SetToolTip(new_button, "Press this button to add new services.");
            toolTip.SetToolTip(update_button, "Press this button to update previous sevice report.");
            toolTip.SetToolTip(Remove_button, "Press this button to remove selected service from the report.");
            toolTip.SetToolTip(removeAll_button, "Press this button to remove all from the report.");
            toolTip.SetToolTip(exit_button, "Press this button to close the application.");
            toolTip.SetToolTip(firstName, "Enter customer's First name.");
            toolTip.SetToolTip(lastName, "Enter customer's Last name.");
            toolTip.SetToolTip(phoneNumber, "Enter customer's phone number.");
            toolTip.SetToolTip(Make, "Select your car manufacturer.");
            toolTip.SetToolTip(Model, " Enter your car's model.");
            toolTip.SetToolTip(Year, "Enter your car's year.");
            toolTip.SetToolTip(Colour, " Enter your car's colour.");
            toolTip.SetToolTip(EngineOilChange, "Select if you want this service.");
            toolTip.SetToolTip(TransOilChange, " Select if you want this service.");
            toolTip.SetToolTip(AirFilterChange, "Select if you want this service.");
            toolTip.SetToolTip(cost_label, "Your expected cost.");
            toolTip.SetToolTip(ServiceSummary, "Report of services done.");
        }

        //Initializing manufacturer list
        private void InitializeMake_List()
        {



            //List of car manufactures
            List<string> carManufacturer = new List<string>
                {
                    "Acura", "Audi", "BMW", "Chevrolet", "Ford", "Honda", "Hyundai", "Toyota", "Volkswagen", "Volvo", "GMC",
                    "Tesla", "Dodge", "Chrysler", "Jeep", "Ram", "Buick", "Cadillac", "Lincoln",
                    "Chevrolet (Chevy)", "Ram Trucks", "Chrysler (FCA US LLC)", "Jeep (Jeep Division of Stellantis)",
                    "Alfa Romeo (Stellantis)", "Aston Martin Lagonda (Aston Martin)", "Karma Automotive",
                    "Lucid Motors", "Rivian", "Saleen", "Bollinger Motors", "Fisker", "Local Motors",
                    "Elio Motors", "Vanderhall", "Rezvani Motors", "Hennessey Performance Engineering (HPE)"
                };


            // Adding list to the combobox
            Make.Items.AddRange(carManufacturer.ToArray());

           
            this.Controls.Add(Make);
        }
        // Initializing Service Summary 
        private void InitializeServiceSummary_List()
        {
            ServiceSummary.View = View.Details;
            ServiceSummary.FullRowSelect = true;
            ServiceSummary.Columns.Add("ID", 35);
            ServiceSummary.Columns.Add("First Name", 100);
            ServiceSummary.Columns.Add("Last Name", 100);
            ServiceSummary.Columns.Add("Phone", 100);
            ServiceSummary.Columns.Add("Make", 100);
            ServiceSummary.Columns.Add("Model", 100);
            ServiceSummary.Columns.Add("Year", 70);
            ServiceSummary.Columns.Add("Colour", 100);
            ServiceSummary.Columns.Add("Services", 150);
            ServiceSummary.Columns.Add("Cost", 70);
        }

       
        
            
            //Making objects
            private ServiceInformation GenerateServicesObjects()
            {
                int id = serviceList.Count + 1;
                string firstNameValue = firstName.Text;
                string lastNameValue = lastName.Text;
                string phoneNumberValue = phoneNumber.Text;
                string makeValue = Make.SelectedItem.ToString();
                string modelValue = Model.Text;
                int yearValue = (int)Year.Value;
                string colourValue = Colour.Text;
                decimal cost = ServiceCost();
                ServiceInformation newService = new ServiceInformation(id, firstNameValue, lastNameValue, phoneNumberValue, makeValue, modelValue, yearValue, colourValue, EngineOilChange.Checked, TransOilChange.Checked, AirFilterChange.Checked, cost);
                return newService;
            }

            //Cost Calculations
            private decimal ServiceCost()
            {
                decimal price = 0;

                if (EngineOilChange.Checked)
                    price += 60m;

                if (TransOilChange.Checked)
                    price += 120m;

                if (AirFilterChange.Checked)
                    price += 40.5m;

                // 13% Tax 
                decimal taxRate = 0.13m;
                decimal tax = price * taxRate;
                price += tax;

                return price;
            }


            private List<string> GetServices(ServiceInformation service)
            {
                List<string> ServiceWanted = new List<string>();

                if (service.EngineOilChange)
                    ServiceWanted.Add("Engine Oil Change");

                if (service.TransOilChange)
                    ServiceWanted.Add("Transmission Oil Change");

                if (service.AirFilterChange)
                    ServiceWanted.Add("Air Filter Change");

                return ServiceWanted;
            }

        //Validations function for the inputs
        private bool Validation_For_Form()
        {
            if (string.IsNullOrWhiteSpace(firstName.Text) || string.IsNullOrWhiteSpace(lastName.Text) || string.IsNullOrWhiteSpace(phoneNumber.Text))
            {
                MessageBox.Show("You must fill in all the details of customer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Make.SelectedIndex < 0)
            {
                MessageBox.Show("Please select your car manufacturer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Model.Text))
            {
                MessageBox.Show("Please enter your car's model.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Year.Value == 0)
            {
                MessageBox.Show("Please select a Year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Colour.Text))
            {
                MessageBox.Show("Please enter your car's colour.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!EngineOilChange.Checked && !TransOilChange.Checked && !AirFilterChange.Checked)
            {
                MessageBox.Show("You must select at least 1 service.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Adding all the details to the list
        private void AddToSummary(ServiceInformation service)
            {
                ListViewItem item = new ListViewItem(service.ID.ToString());
                item.SubItems.Add(service.FirstName);
                item.SubItems.Add(service.LastName);
                item.SubItems.Add(service.PhoneNumber);
                item.SubItems.Add(service.Make);
                item.SubItems.Add(service.Model);
                item.SubItems.Add(service.Year.ToString());
                item.SubItems.Add(service.Colour);
                string services = string.Join(", ", GetServices(service));
                item.SubItems.Add(services);
                item.SubItems.Add(service.Cost.ToString("C")); // Display cost as currency

                ServiceSummary.Items.Add(item);
            }

           


         
        //Exit button
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Add button
        private void add_button_Click(object sender, EventArgs e)
        {
            if (Validation_For_Form())
            {
                ServiceInformation newService = GenerateServicesObjects();
                AddToSummary(newService);
                serviceList.Add(newService);

                // Calculate the total cost and display it in the label
                decimal totalCost = serviceList.Sum(service => service.Cost);
                Price.Text = totalCost.ToString("C"); // Display cost as currency
            }
        }
        //New button
        private void new_button_Click(object sender, EventArgs e)
        {
            // Clear inputs
            firstName.Text = string.Empty;
            lastName.Text = string.Empty;
            phoneNumber.Text = string.Empty;
            Make.SelectedIndex = -1; 
            Model.Text = string.Empty;
            Year.Value = 0; 
            Colour.Text = string.Empty;
            EngineOilChange.Checked = false;
            TransOilChange.Checked = false;
            AirFilterChange.Checked = false;

            // Clear  List
            if (ServiceSummary.SelectedItems.Count > 0)
            {
                ServiceSummary.SelectedItems[0].Selected = false;
            }
        }


        //Update button

        private void update_button_Click(object sender, EventArgs e)
        {
            if (ServiceSummary.SelectedItems.Count > 0)
            {
                
                ListViewItem selectedCar = ServiceSummary.SelectedItems[0];

                firstName.Text = selectedCar.SubItems[1].Text;
                lastName.Text = selectedCar.SubItems[2].Text;
                phoneNumber.Text = selectedCar.SubItems[3].Text;
                Make.SelectedItem = selectedCar.SubItems[4].Text;
                Model.Text = selectedCar.SubItems[5].Text;
                Year.Value = int.Parse(selectedCar.SubItems[6].Text);
                Colour.Text = selectedCar.SubItems[7].Text;

                // Clear checkboxes
                EngineOilChange.Checked = false;
                TransOilChange.Checked = false;
                AirFilterChange.Checked = false;

                string[] services = selectedCar.SubItems[8].Text.Split(new string[] { ", " }, StringSplitOptions.None);
                foreach (string service in services)
                {
                    if (service == "Engine Oil Change")
                    {
                        EngineOilChange.Checked = true;
                    }
                    else if (service == "Transmission Oil Change")
                    {
                        TransOilChange.Checked = true;
                    }
                    else if (service == "Air Filter Change")
                    {
                        AirFilterChange.Checked = true;
                    }
                }

                // Remove the selected item 
                ServiceSummary.Items.Remove(selectedCar);
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (ServiceSummary.SelectedItems.Count > 0)
            {
                ServiceSummary.Items.Remove(ServiceSummary.SelectedItems[0]);
            }

            // Clear input 
            new_button_Click(sender, e);
        }


        //Removing all details button
        private void removeAll_button_Click(object sender, EventArgs e)
        {
            // Remove all items from list
            ServiceSummary.Items.Clear();

            // Clear inputs
            new_button_Click(sender, e);
        }
    }
    }
