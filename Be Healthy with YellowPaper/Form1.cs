using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Be_Healthy_with_YellowPaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //summation of points
        int target = 0;

        // to make a new test
        int try_again = 0;
     


       

       

        private void Form1_Load(object sender, EventArgs e)
        {
          
           



        }


        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            
            
          

        }
        //function to enable all checkboxes after click on the button to start again the test
        void again()

        {

            try_again =1;
            button2.Text = "اعادة الاختبار";
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
            checkBox13.Enabled = false;
            checkBox14.Enabled = false;
            checkBox15.Enabled = false;
            checkBox16.Enabled = false;
        }


        //function to disable all checkboxes after click on the button
        void new_values()
        {

            try_again = 0;
            button2.Text = "النتيجة";
            //to remove Checked checkBox1
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            //to hide the result
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            target = 0;
            //enable all checkboxes again
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            checkBox10.Enabled = true;
            checkBox11.Enabled = true;
            checkBox12.Enabled = true;
            checkBox13.Enabled = true;
            checkBox14.Enabled = true;
            checkBox15.Enabled = true;
            checkBox16.Enabled = true;


        }
        

       

      

      

       

      

       

        

     

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Label13_Click_1(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click_1(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //try_again == 0 to know the result after clicking the button
            if (try_again == 0)
            {


                if (target <= 4)

                {
                  //lable show the result in text
                    label2.Visible = true;
                    again();
                }
                else if (target == 5)
                {


                    label1.Visible = true;
                    

                    again();

                }
                else
                {
                    label3.Visible = true;
                    
                    again();
                }
            }
            //try_again == 1 restart the test after clicking the button

            else if (try_again == 1)
            {

                new_values();
            }
        }

      

      

    

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {    // According to the target value, we calculate the result
            target = target + 2;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            target = target + 2;
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            target = target + 1;
        }

        private void CheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            target = target + 1;
        }

        private void CheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            target = target + 5;
        }

        private void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            target = target + 4;
        }

       

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            target = target + 3;
        }

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            target = target + 2;

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mohamedehabghaly");
        }
    }
}
