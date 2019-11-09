using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_MailAyristirma
{

    public partial class Form1 : MetroForm
    {
     
        int i = 0;
        string[] dizi =new string[150];
        int y = 0;
        int c = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void MetroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.EndsWith(";") == true)
            {
                string mail = metroTextBox1.Text;
                var dizi1 = mail.Split(';');

                i += dizi1.Length - 1;
                for (int f=0; f< dizi1.Length - 1; f++)
                {
                    dizi[c] = dizi1[f];
                    c += 1;
                }
            }
            else
            {
                string mail = metroTextBox1.Text + ";";
                var dizi1 = mail.Split(';');
                i += dizi1.Length-1;
                // while (i < c)

                for ( int f  = 0; f!=dizi1.Length-1;  f++)
                {
                    dizi[c] = dizi1[f];
                    c += 1;
                }
            }

            //while (b > 0)
            //{
            //    addingmail = mail.Substring(0, mail.IndexOf(";")); 
            //    dizi[i] = addingmail;
            //    b = b-dizi[i].Length-1;
            //    i = i + 1;
            //    mail = mail.Substring(mail.IndexOf(";")+1,b);


            //}



        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            while (y < i)
            {
                
                 //regex mail validation c# 
                if (dizi[y].IndexOf("@") != 0)

                    if (dizi[y].EndsWith("gmail.net") == true)
                        lstGmailNet.Items.Add(dizi[y]);

                    else if (dizi[y].EndsWith("gmail.com") == true)
                        lstGmailCom.Items.Add(dizi[y]);

                    else if (dizi[y].EndsWith("hotmail.net") == true)
                        lstHotmailNet.Items.Add(dizi[y]);

                    else if (dizi[y].EndsWith("gmail.com.tr") == true)
                        lstGmailComTr.Items.Add(dizi[y]);

                    else if (dizi[y].EndsWith("hotmail.com") == true)
                        lstHotmailCom.Items.Add(dizi[y]);

                    else if (dizi[y].EndsWith("hotmail.com.tr") == true)
                        lstHotmailComTr.Items.Add(dizi[y]);
                    else
                        lstCopKutusu.Items.Add(dizi[y]);
                y +=1;
                lblGmailCom.Text = lstGmailCom.Items.Count.ToString();
                lblGmailComTr.Text = lstGmailComTr.Items.Count.ToString();
                lblGmailNet.Text = lstGmailNet.Items.Count.ToString();
                lblHotmailCom.Text = lstHotmailCom.Items.Count.ToString();
                lblHotmailComTr.Text = lstHotmailComTr.Items.Count.ToString();
                lblHotmailNet.Text = lstHotmailNet.Items.Count.ToString();

          
               
            }
        }


    }
}
