using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Introduceti textul si alegeti optiunea dorita "); 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            B.Enabled = true;
            B1.Enabled = true;
           
        }

        private void B_Click(object sender, EventArgs e)
        {
            //criptarea
            

            char[] c; string a;  int i;
            a = textBox1.Text;
            c = a.ToCharArray();
            int[] v = new int[300];
            for (i = 0; i < c.Length; i++)
                v[i] = (int)c[i];            
                for (i = 0; i < c.Length; i++)                   
                        v[i] = v[i] * 3 + 5;
                   
            for (i = 0; i < c.Length; i++)
                textBox2.Text += v[i];
     
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void B1_Click(object sender, EventArgs e)
        {
            //decriptarea
           
            char[] c; string a;  int[] v = new int[300];
                a = textBox1.Text;
                c = a.ToCharArray();
                int i;
                for (i = 0; i < c.Length; i++)
                    v[i] = (int)Char.GetNumericValue(c[i]);                
                    for (i = 0; i < c.Length; i += 3)                          
                                v[i] = (v[i] * 100 + v[i + 1] * 10 + v[i + 2] - 5) / 3;
                           
                                
                  

                for (i = 0; i < c.Length; i+=3)
                    textBox2.Text += Convert.ToChar(v[i]);
                
                
                
            }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

    
        

            


        }



    
}
