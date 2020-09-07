/* AUTHOR: Kyle Huber
 * DATE: 09/06/2020
 * DESCRIPTION: A name formatter which will concatenate strings
   based on the info enterd into the text box control fields */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Formatter
{
    public partial class NameFormatter : Form
    {
        public NameFormatter()
        {
            InitializeComponent();
        }

        //Declare an empty private field variable to be manipulated depending on which button is clicked
        private string name = "";
        

        private void fullNameAndTitleBtn_Click(object sender, EventArgs e)
        
        {

                //Assign value to my empty field variable
                name = preferredTitleTextBox.Text + " " + firstNameTextbox.Text + " "
                + middleNameTextBox.Text + " " + lastNameTextBox.Text;
                //Display the output
                showGeneratedNameLbl.Text = name;
            
           
        }



        private void fullNameBtn_Click(object sender, EventArgs e)
        {
           
                //Re-assign value to my empty field variable
                name = firstNameTextbox.Text + " "
                + middleNameTextBox.Text + " " + lastNameTextBox.Text;
                //Display the output
                showGeneratedNameLbl.Text = name;
            
           
        }

       

        private void firstAndLastNameBtn_Click(object sender, EventArgs e)
        {
            
                //Re-assign value to my empty field variable
                name = firstNameTextbox.Text + " " + lastNameTextBox.Text;
                //Display the output
                showGeneratedNameLbl.Text = name;
            
        }

        private void fullNameAndTitleReverseBtn_Click(object sender, EventArgs e)
        {
            
                //Re-assign value to my empty field variable
                name = lastNameTextBox.Text + ", "
                + firstNameTextbox.Text + " " + middleNameTextBox.Text + ", " + preferredTitleTextBox.Text;
                //Display the output
                showGeneratedNameLbl.Text = name;
          
        }

        private void fullNameReverseBtn_Click(object sender, EventArgs e)
        {
            
                //Re-assign value to my empty field variable
                name = lastNameTextBox.Text + ", "
                + firstNameTextbox.Text + " " + middleNameTextBox.Text;
                //Display the output
                showGeneratedNameLbl.Text = name;
            
        }

        private void firstAndLastNameReverseBtn_Click(object sender, EventArgs e)
        {

                //Re-assign value to my empty field variable
                name = lastNameTextBox.Text + ", " + firstNameTextbox.Text;
                //Display the output
                showGeneratedNameLbl.Text = name;
          
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNameTextbox.Text = "";
            middleNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            preferredTitleTextBox.Text = "";
            showGeneratedNameLbl.Text = "";
            //Message the user
            MessageBox.Show("All fields have been successfully cleared!");
            //Re-focus on the first name text box at index 0
            firstNameTextbox.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //End the program on click. Or, hit ALT+X
            MessageBox.Show("Goodbye!");
            this.Close();
        }
    }
}
