using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EricSP2026AnimalShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //ICA 3
            //Declare Variables
            // going to come from the user
            double animalHeight;
            double animalWeight;
            string animalName;
            double animalBMI;
            //ICA 4
            bool heightGood;
            bool weightGood;
            bool nameGood;

            //For string var just set var to text property
            animalName = txtAnimalName.Text;

            //For numerics you must convert a string to a number
            //animalHeight = double.Parse(txtAnimalHeight.Text);
            //animalWeight = double.Parse(txtAnimalWeight.Text);
            heightGood = double.TryParse(txtAnimalHeight.Text, out animalHeight);
            weightGood = double.TryParse(txtAnimalWeight.Text, out animalWeight);

            if (animalName == "")            
            {
                nameGood = false;
            }
            else
            {
                nameGood = true;
            }
            //alternate way 
            //nameGood = animalName != ""

            if (nameGood && heightGood && weightGood)
            {
                //do calculation
                //for me that is price of service (walk) multiplied by number of times per time
                //output to list box and make sure it is formatted
                animalBMI = animalWeight / (animalHeight * animalHeight);
                lstOut.Items.Add("The Animal's Name is: " + animalName);
                //lstOut.Items.Add("The Animal's Height is: " + animalHeight.ToString("N0"));
                //lstOut.Items.Add("The Animal's Weight is: " + animalWeight.ToString("N0"));
                lstOut.Items.Add("The Animal's Height is: " + animalHeight.ToString("N1"));
                lstOut.Items.Add("The Animal's Weight is: " + animalWeight.ToString("N1"));

                //lstOut.Items.Add("The Animal's BMI is: " + animalBMI.ToString("C"));
                //lstOut.Items.Add("The Animal's BMI is: " + animalBMI.ToString("C3"));
                lstOut.Items.Add("The Animal's BMI is: " + animalBMI.ToString("N2"));
                //This gaves fouce to the clear button
                btnClear.Focus();
            }
            else
            {
                if (!nameGood)
                {
                    lstOut.Items.Add("Please put an valid value for Animal's Name! ");
                }
                else if (!heightGood)
                {
                    lstOut.Items.Add("Please put an valid value for Animal's Height!");
                }
                else if (!weightGood)
                {
                    lstOut.Items.Add("Please put an valid value for Animal's Weight! ");
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSlelected;
            buttonSlelected = MessageBox.Show("Do you really want to quit?",
                                                "Exiting...",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (buttonSlelected == DialogResult.Yes) 
            {
                //ICA 2
                this.Close();
            }
            
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnimalName.Clear();
            txtAnimalWeight.Clear();
            txtAnimalHeight.Clear();
            lstOut.Items.Clear();
            txtAnimalName.Focus();

        }

        private void txtAnimalName_Enter(object sender, EventArgs e)
        {
            txtAnimalName.BackColor = Color.Beige;
        }
        private void txtAnimalName_Leave(object sender, EventArgs e)
        {
            txtAnimalName.BackColor = SystemColors.Window;
        }
        //Event Procedure that will run when the user clicks on the calculate button



    }// End of form1
} // end of namespace
