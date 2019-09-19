using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class Student : Form
    {
        List<string> id = new List<string> { };
        List<string> name = new List<string> { };
        List<string> mobile = new List<string> { };
        List<string> age = new List<string> { };
        List<string> address = new List<string> { };
        List<string> gpa = new List<string> { };

        List<string> add = new List<string> { };

        int index = 0;
        string value = "";
        string max;
        public Student()
        {
            InitializeComponent();
        }

        private void idTextBox_KeyUp(object sender, KeyPressEventArgs e)
        {
            string tempid = idTextBox.Text;
            if (tempid.Length >= 4)
            {
                MessageBox.Show("length is 4..");
            }
            
           /*     for (int i = 0; i <= id.Count; i++)
                {
                    if (tempid == id[i])
                    {
                        MessageBox.Show("duplicate id ...");
                    }
                }
                */
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {


            string tname = nameTextBox.Text;
            string tid = idTextBox.Text;
            string tmobile = mobileTextBox.Text;
            string tage = ageTextBox.Text;
            string taddress = addressTextBox.Text;
            string tgpa = gpaTextBox.Text;
            if (tname == "")
            {
                MessageBox.Show("name can not empty");

            }
            else if (tid == "")
            {
                MessageBox.Show("id can not empty");
                

            }
            else if (tmobile == "")
            {
                MessageBox.Show("mobile can not empty");

            }
            else if (taddress == "")
            {
                MessageBox.Show("address can not empty");

            }
            else if (tage == "")
            {
                MessageBox.Show("age  can not empty");

            }
            else if (tgpa == "")
            {
                MessageBox.Show("gpa can not empty");

            }else if(Checku()== false)
            {
                MessageBox.Show("mobile can not duplicate");

            }
            else if (Checkid() == false)
            {
                MessageBox.Show("id can not duplicate");

            }
            else if(tname.Length>30)
            {
                MessageBox.Show("length must be below 30 ..");
            }
            else
            {




                id.Add(idTextBox.Text);
                name.Add(nameTextBox.Text);
                mobile.Add(mobileTextBox.Text);
                age.Add(ageTextBox.Text);
                address.Add(addressTextBox.Text);
                gpa.Add(gpaTextBox.Text);

                value += "id\t" + id[index] + Environment.NewLine +
                    "name\t" + name[index] + Environment.NewLine +
                    "mobile\t" + mobile[index] + Environment.NewLine +
                    "age\t" + age[index] + Environment.NewLine +
                    "address\t" + address[index] + Environment.NewLine +
                    "gpa\t" + gpa[index] + Environment.NewLine;
                add.Add(value);


                index++;
            }
            Cleartextbox();


        }
        private void Cleartextbox()
        { nameTextBox.Text="";
             idTextBox.Text="";
             mobileTextBox.Text="";
           ageTextBox.Text=""; 
            addressTextBox.Text="";
            gpaTextBox.Text="";
        }
        private bool Checku()
        {
            string tempmobile = mobileTextBox.Text;
            for (int i = 0; i < mobile.Count; i++)
            {
                if (tempmobile == mobile[i])
                {
                    return false;
                    // MessageBox.Show("duplicate id ...");
                    
                }
                
            }
            return true;



        }
        private bool Checkid()
        {
            string tempid = idTextBox.Text;
            for (int i = 0; i < id.Count; i++)
            {
                if (tempid == id[i])
                {
                    return false;
                    // MessageBox.Show("duplicate id ...");

                }

            }
            return true;



        }


        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void mobileTextBox_KeyUp(object sender, KeyPressEventArgs e)
        {
          
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < add.Count; i++)
            {
                displayrichTextBox.Text = add[i];

            }
            Max();
        }
        private void Max()
        {
            

            for (int i=0; i<gpa.Count;i++)
            {
                
                for(int j=i+1; j<gpa.Count; j++)
                {
                    if(int.Parse(gpa[i])> int.Parse(gpa[j]))
                    {
                            max = gpa[i];
                       // maxtextBox.Text =Convert.ToString( gpa[i]);

                    }

                }
                
            }
            maxtextBox.Text = Convert.ToString(max);

        }
    }
}
