using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace game0
{
    public partial class Form2 : Form
    {
        Random picrand = new Random(); // рандом выпадения
        int scl = 0; // счетчик школы(school)
        int a, b, c, d, q, p, k = 0; // a, b, c, d, q - кубики, p - ход игрока, k - счетчик нажатий
        string n1, n2 = null; // имена
        int summ = 0; // колличество полных ходов для разблокировки базы
        
        void Cleaning() 
        {
            checkBox1.Checked = false; checkBox1.Enabled = false;
            pictureBox1.Enabled = false; pictureBox1.BackgroundImage = null;
            a = 0;
            checkBox1.Text = "Кубик 1 = ";
            checkBox2.Checked = false; checkBox2.Enabled = false;
            pictureBox2.Enabled = false; pictureBox2.BackgroundImage = null;
            b = 0;
            checkBox2.Text = "Кубик 2 = ";
            checkBox3.Checked = false; checkBox3.Enabled = false;
            pictureBox3.Enabled = false; pictureBox3.BackgroundImage = null;
            c = 0;
            checkBox3.Text = "Кубик 3 = ";
            checkBox4.Checked = false; checkBox4.Enabled = false;
            pictureBox4.Enabled = false; pictureBox4.BackgroundImage = null;
            d = 0;
            checkBox4.Text = "Кубик 4 = ";
            checkBox5.Checked = false; checkBox5.Enabled = false;
            pictureBox5.Enabled = false; pictureBox5.BackgroundImage = null;
            q = 0;
            checkBox5.Text = "Кубик 5 = ";
            scl = 0; k = 0;
            switch (p)
            { 
            case 0:
                    p++; label2.Text = "Ход игрока " + n1;
                    stat1.BackColor = Color.FromArgb(182, 255, 128); stat2.BackColor = Color.FromArgb(182, 255, 128); stat3.BackColor = Color.FromArgb(182, 255, 128);
                    stat4.BackColor = Color.FromArgb(182, 255, 128); stat5.BackColor = Color.FromArgb(182, 255, 128); stat6.BackColor = Color.FromArgb(182, 255, 128);
                    stat7.BackColor = Color.FromArgb(182, 255, 128); stat8.BackColor = Color.FromArgb(182, 255, 128); stat9.BackColor = Color.FromArgb(182, 255, 128);
                    stat10.BackColor = Color.FromArgb(182, 255, 128); stat11.BackColor = Color.FromArgb(182, 255, 128); stat12.BackColor = Color.FromArgb(182, 255, 128);
                    stat13.BackColor = Color.FromArgb(182, 255, 128); stat14.BackColor = Color.FromArgb(182, 255, 128); stat15.BackColor = Color.FromArgb(182, 255, 128);
                    break;
            case 1:
                    p++; label2.Text = "Ход игрока " + n2;
                    if (p2_1.Text == "-") { stat1.BackColor = Color.FromArgb(128, 255, 128); } else { stat1.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_2.Text == "-") { stat2.BackColor = Color.FromArgb(128, 255, 128); } else { stat2.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_3.Text == "-") { stat3.BackColor = Color.FromArgb(128, 255, 128); } else { stat3.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_4.Text == "-") { stat4.BackColor = Color.FromArgb(128, 255, 128); } else { stat4.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_5.Text == "-") { stat5.BackColor = Color.FromArgb(128, 255, 128); } else { stat5.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_6.Text == "-") { stat6.BackColor = Color.FromArgb(128, 255, 128); } else { stat6.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_7.Text == "-") { stat7.BackColor = Color.FromArgb(128, 255, 128); } else { stat7.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_8.Text == "-") { stat8.BackColor = Color.FromArgb(128, 255, 128); } else { stat8.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_9.Text == "-") { stat9.BackColor = Color.FromArgb(128, 255, 128); } else { stat9.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_10.Text == "-") { stat10.BackColor = Color.FromArgb(128, 255, 128); } else { stat10.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_11.Text == "-") { stat11.BackColor = Color.FromArgb(128, 255, 128); } else { stat11.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_12.Text == "-") { stat12.BackColor = Color.FromArgb(128, 255, 128); } else { stat12.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_13.Text == "-") { stat13.BackColor = Color.FromArgb(128, 255, 128); } else { stat13.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_14.Text == "-") { stat14.BackColor = Color.FromArgb(128, 255, 128); } else { stat14.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p2_15.Text == "-") { stat15.BackColor = Color.FromArgb(128, 255, 128); } else { stat15.BackColor = Color.FromArgb(255, 128, 128); }
                    break;
            case 2:
                    p--; label2.Text = "Ход игрока " + n1;
                    if (p1_1.Text == "-") { stat1.BackColor = Color.FromArgb(128, 255, 128); } else { stat1.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_2.Text == "-") { stat2.BackColor = Color.FromArgb(128, 255, 128); } else { stat2.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_3.Text == "-") { stat3.BackColor = Color.FromArgb(128, 255, 128); } else { stat3.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_4.Text == "-") { stat4.BackColor = Color.FromArgb(128, 255, 128); } else { stat4.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_5.Text == "-") { stat5.BackColor = Color.FromArgb(128, 255, 128); } else { stat5.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_6.Text == "-") { stat6.BackColor = Color.FromArgb(128, 255, 128); } else { stat6.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_7.Text == "-") { stat7.BackColor = Color.FromArgb(128, 255, 128); } else { stat7.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_8.Text == "-") { stat8.BackColor = Color.FromArgb(128, 255, 128); } else { stat8.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_9.Text == "-") { stat9.BackColor = Color.FromArgb(128, 255, 128); } else { stat9.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_10.Text == "-") { stat10.BackColor = Color.FromArgb(128, 255, 128); } else { stat10.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_11.Text == "-") { stat11.BackColor = Color.FromArgb(128, 255, 128); } else { stat11.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_12.Text == "-") { stat12.BackColor = Color.FromArgb(128, 255, 128); } else { stat12.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_13.Text == "-") { stat13.BackColor = Color.FromArgb(128, 255, 128); } else { stat13.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_14.Text == "-") { stat14.BackColor = Color.FromArgb(128, 255, 128); } else { stat14.BackColor = Color.FromArgb(255, 128, 128); }
                    if (p1_15.Text == "-") { stat15.BackColor = Color.FromArgb(128, 255, 128); } else { stat15.BackColor = Color.FromArgb(255, 128, 128); }
                    break;
                    
            }
        }

        void ActivatedBase()
        {
            if (summ == 6) 
            {
                stat7.Enabled = true;
                stat8.Enabled = true;
                stat9.Enabled = true;
                stat10.Enabled = true;
                stat11.Enabled = true;
                stat12.Enabled = true;
                stat13.Enabled = true;
                stat14.Enabled = true;
                stat15.Enabled = true;
            }
        }

        private void stat1_Click(object sender, EventArgs e) //school-1
        {           
            switch (p)
            {
                case 1:
                    
                    if (checkBox1.Checked == true && a == 1) { scl++; }
                    if (checkBox2.Checked == true && b == 1) { scl++; }
                    if (checkBox3.Checked == true && c == 1) { scl++; }
                    if (checkBox4.Checked == true && d == 1) { scl++; }
                    if (checkBox5.Checked == true && q == 1) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p1_1.Text == "-") { p1_1.Text = "-3"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0;  return;  }                            
                            break;
                        case 1:
                            if (p1_1.Text == "-") { p1_1.Text = "-2"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p1_1.Text == "-") { p1_1.Text = "-1"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 3:
                            if (p1_1.Text == "-") { p1_1.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p1_1.Text == "-") { p1_1.Text = "1"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p1_1.Text == "-") { p1_1.Text = "2"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button2.Enabled = false;
                    button3.Enabled = true;
                    break;
                case 2:
                    
                    if (checkBox1.Checked == true && a == 1) { scl++; }
                    if (checkBox2.Checked == true && b == 1) { scl++; }
                    if (checkBox3.Checked == true && c == 1) { scl++; }
                    if (checkBox4.Checked == true && d == 1) { scl++; }
                    if (checkBox5.Checked == true && q == 1) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p2_1.Text == "-") { p2_1.Text = "-3"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p2_1.Text == "-") { p2_1.Text = "-2"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p2_1.Text == "-") { p2_1.Text = "-1"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 3:
                            if (p2_1.Text == "-") { p2_1.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p2_1.Text == "-") { p2_1.Text = "1"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p2_1.Text == "-") { p2_1.Text = "2"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button3.Enabled = false;
                    button2.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }
            Cleaning();
            
        }
        
        private void stat2_Click(object sender, EventArgs e) //school-2
        {            
            switch (p)
            {
                case 1:

                    if (checkBox1.Checked == true && a == 2) { scl++; }
                    if (checkBox2.Checked == true && b == 2) { scl++; }
                    if (checkBox3.Checked == true && c == 2) { scl++; }
                    if (checkBox4.Checked == true && d == 2) { scl++; }
                    if (checkBox5.Checked == true && q == 2) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p1_2.Text == "-") { p1_2.Text = "-6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p1_2.Text == "-") { p1_2.Text = "-4"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p1_2.Text == "-") { p1_2.Text = "-2"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; };
                            break;
                        case 3:
                            if (p1_2.Text == "-") { p1_2.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p1_2.Text == "-") {p1_2.Text = "2"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p1_2.Text == "-") { p1_2.Text = "4"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button2.Enabled = false;
                    button3.Enabled = true;

                    break;
                case 2:

                    if (checkBox1.Checked == true && a == 2) { scl++; }
                    if (checkBox2.Checked == true && b == 2) { scl++; }
                    if (checkBox3.Checked == true && c == 2) { scl++; }
                    if (checkBox4.Checked == true && d == 2) { scl++; }
                    if (checkBox5.Checked == true && q == 2) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p2_2.Text == "-") { p2_2.Text = "-6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p2_2.Text == "-") { p2_2.Text = "-4"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p2_2.Text == "-") { p2_2.Text = "-2"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 3:
                            if (p2_2.Text == "-") { p2_2.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p2_2.Text == "-") { p2_2.Text = "2"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p2_2.Text == "-") { p2_2.Text = "4"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button3.Enabled = false;
                    button2.Enabled = true;

                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }
            Cleaning();

        }

        private void stat3_Click(object sender, EventArgs e) //school-3
        {
            switch (p)
            {
                case 1:

                    if (checkBox1.Checked == true && a == 3) { scl++; }
                    if (checkBox2.Checked == true && b == 3) { scl++; }
                    if (checkBox3.Checked == true && c == 3) { scl++; }
                    if (checkBox4.Checked == true && d == 3) { scl++; }
                    if (checkBox5.Checked == true && q == 3) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p1_3.Text == "-") { p1_3.Text = "-9"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p1_3.Text == "-") { p1_3.Text = "-6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p1_3.Text == "-") { p1_3.Text = "-3"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; };
                            break;
                        case 3:
                            if (p1_3.Text == "-") { p1_3.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p1_3.Text == "-") { p1_3.Text = "3"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p1_3.Text == "-") { p1_3.Text = "6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button2.Enabled = false;
                    button3.Enabled = true;

                    break;
                case 2:

                    if (checkBox1.Checked == true && a == 3) { scl++; }
                    if (checkBox2.Checked == true && b == 3) { scl++; }
                    if (checkBox3.Checked == true && c == 3) { scl++; }
                    if (checkBox4.Checked == true && d == 3) { scl++; }
                    if (checkBox5.Checked == true && q == 3) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p2_3.Text == "-") { p2_3.Text = "-9"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p2_3.Text == "-") { p2_3.Text = "-6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p2_3.Text == "-") { p2_3.Text = "-3"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 3:
                            if (p2_3.Text == "-") { p2_3.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p2_3.Text == "-") { p2_3.Text = "3"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p2_3.Text == "-") { p2_3.Text = "6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button3.Enabled = false;
                    button2.Enabled = true;

                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }
            Cleaning();

        }

        private void stat4_Click(object sender, EventArgs e) //school-4
        {            
            switch (p)
            {
                case 1:

                    if (checkBox1.Checked == true && a == 4) { scl++; }
                    if (checkBox2.Checked == true && b == 4) { scl++; }
                    if (checkBox3.Checked == true && c == 4) { scl++; }
                    if (checkBox4.Checked == true && d == 4) { scl++; }
                    if (checkBox5.Checked == true && q == 4) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p1_4.Text == "-") { p1_4.Text = "-12"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p1_4.Text == "-") { p1_4.Text = "-8"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p1_4.Text == "-") { p1_4.Text = "-4"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; };
                            break;
                        case 3:
                            if (p1_4.Text == "-") { p1_4.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p1_4.Text == "-") { p1_4.Text = "4"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p1_4.Text == "-") { p1_4.Text = "8"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button2.Enabled = false;
                    button3.Enabled = true;

                    break;
                case 2:

                    if (checkBox1.Checked == true && a == 4) { scl++; }
                    if (checkBox2.Checked == true && b == 4) { scl++; }
                    if (checkBox3.Checked == true && c == 4) { scl++; }
                    if (checkBox4.Checked == true && d == 4) { scl++; }
                    if (checkBox5.Checked == true && q == 4) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p2_4.Text == "-") { p2_4.Text = "-12"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p2_4.Text == "-") { p2_4.Text = "-8"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p2_4.Text == "-") { p2_4.Text = "-4"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 3:
                            if (p2_4.Text == "-") { p2_4.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p2_4.Text == "-") { p2_4.Text = "4"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p2_4.Text == "-") { p2_4.Text = "8"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button3.Enabled = false;
                    button2.Enabled = true;

                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }
            Cleaning();

        }

        private void stat5_Click(object sender, EventArgs e) //school-5
        {           
            switch (p)
            {
                case 1:

                    if (checkBox1.Checked == true && a == 5) { scl++; }
                    if (checkBox2.Checked == true && b == 5) { scl++; }
                    if (checkBox3.Checked == true && c == 5) { scl++; }
                    if (checkBox4.Checked == true && d == 5) { scl++; }
                    if (checkBox5.Checked == true && q == 5) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p1_5.Text == "-") { p1_5.Text = "-15"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p1_5.Text == "-") { p1_5.Text = "-10"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p1_5.Text == "-") { p1_5.Text = "-5"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; };
                            break;
                        case 3:
                            if (p1_5.Text == "-") { p1_5.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p1_5.Text == "-") { p1_5.Text = "5"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p1_5.Text == "-") { p1_5.Text = "10"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button2.Enabled = false;
                    button3.Enabled = true;

                    break;
                case 2:

                    if (checkBox1.Checked == true && a == 5) { scl++; }
                    if (checkBox2.Checked == true && b == 5) { scl++; }
                    if (checkBox3.Checked == true && c == 5) { scl++; }
                    if (checkBox4.Checked == true && d == 5) { scl++; }
                    if (checkBox5.Checked == true && q == 5) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p2_5.Text == "-") { p2_5.Text = "-15"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p2_5.Text == "-") { p2_5.Text = "-10"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p2_5.Text == "-") { p2_5.Text = "-5"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 3:
                            if (p2_5.Text == "-") { p2_5.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p2_5.Text == "-") { p2_5.Text = "5"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p2_5.Text == "-") { p2_5.Text = "10"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button3.Enabled = false;
                    button2.Enabled = true;

                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }
            Cleaning();

        }

        private void stat6_Click(object sender, EventArgs e) //school-6
        {           
            switch (p)
            {
                case 1:

                    if (checkBox1.Checked == true && a == 6) { scl++; }
                    if (checkBox2.Checked == true && b == 6) { scl++; }
                    if (checkBox3.Checked == true && c == 6) { scl++; }
                    if (checkBox4.Checked == true && d == 6) { scl++; }
                    if (checkBox5.Checked == true && q == 6) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p1_6.Text == "-") { p1_6.Text = "-18"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p1_6.Text == "-") { p1_6.Text = "-12"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p1_6.Text == "-") { p1_6.Text = "-6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; };
                            break;
                        case 3:
                            if (p1_6.Text == "-") { p1_6.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p1_6.Text == "-") { p1_6.Text = "6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p1_6.Text == "-") { p1_6.Text = "12"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button2.Enabled = false;
                    button3.Enabled = true;

                    break;
                case 2:

                    if (checkBox1.Checked == true && a == 6) { scl++; }
                    if (checkBox2.Checked == true && b == 6) { scl++; }
                    if (checkBox3.Checked == true && c == 6) { scl++; }
                    if (checkBox4.Checked == true && d == 6) { scl++; }
                    if (checkBox5.Checked == true && q == 6) { scl++; }
                    switch (scl)
                    {
                        case 0:
                            if (p2_6.Text == "-") { p2_6.Text = "-18"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 1:
                            if (p2_6.Text == "-") { p2_6.Text = "-12"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 2:
                            if (p2_6.Text == "-") { p2_6.Text = "-6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 3:
                            if (p2_6.Text == "-") { p2_6.Text = "0"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 4:
                            if (p2_6.Text == "-") { p2_6.Text = "6"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                        case 5:
                            if (p2_6.Text == "-") { p2_6.Text = "12"; summ++; ActivatedBase(); }
                            else { MessageBox.Show("Значение присвоено"); scl = 0; return; }
                            break;
                    }
                    button3.Enabled = false;
                    button2.Enabled = true;

                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }
            Cleaning();

        }

        private void stat7_Click(object sender, EventArgs e) //1 para
        {
            switch (p)
            {
                case 1:
                    if (p1_7.Text == "-")
                    {
                        if (checkBox1.Checked == true)
                        {
                            if (checkBox2.Checked == true && a == b)
                            { p1_7.Text = Convert.ToString(a + b); }
                            else
                            {
                                if (checkBox3.Checked == true && a == c)
                                { p1_7.Text = Convert.ToString(a + c); }
                                else
                                {
                                    if (checkBox4.Checked == true && a == d)
                                    { p1_7.Text = Convert.ToString(a + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && a == q)
                                        { p1_7.Text = Convert.ToString(a + q); }
                                        else { p1_7.Text = "0"; }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (checkBox2.Checked == true)
                            {
                                if (checkBox3.Checked == true && b == c)
                                { p1_7.Text = Convert.ToString(b + c); }
                                else
                                {
                                    if (checkBox4.Checked == true && b == d)
                                    { p1_7.Text = Convert.ToString(b + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && b == q)
                                        { p1_7.Text = Convert.ToString(b + q); }
                                        else { p1_7.Text = "0"; }
                                    }
                                }
                            }
                            else
                            {
                                if (checkBox3.Checked == true)
                                {
                                    if (checkBox4.Checked == true && c == d)
                                    { p1_7.Text = Convert.ToString(c + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && c == q)
                                        { p1_7.Text = Convert.ToString(c + q); }
                                        else { p1_7.Text = "0"; }
                                    }
                                }
                                else
                                {
                                    if (checkBox4.Checked == true)
                                    {                                        
                                        if (checkBox5.Checked == true && d == q)
                                        { p1_7.Text = Convert.ToString(d + q);  }
                                        else { p1_7.Text = "0"; }
                                    }
                                    else { MessageBox.Show("Выберите больше значений"); return; }
                                }
                            }

                        }
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    button2.Enabled = false;
                    button3.Enabled = true;
                    break;
                case 2:
                    if (p2_7.Text == "-")
                    {
                        if (checkBox1.Checked == true)
                        {
                            if (checkBox2.Checked == true && a == b)
                            { p2_7.Text = Convert.ToString(a + b); }
                            else
                            {
                                if (checkBox3.Checked == true && a == c)
                                { p2_7.Text = Convert.ToString(a + c); }
                                else
                                {
                                    if (checkBox4.Checked == true && a == d)
                                    { p2_7.Text = Convert.ToString(a + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && a == q)
                                        { p2_7.Text = Convert.ToString(a + q); }
                                        else { p2_7.Text = "0"; }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (checkBox2.Checked == true)
                            {
                                if (checkBox3.Checked == true && b == c)
                                { p2_7.Text = Convert.ToString(b + c); }
                                else
                                {
                                    if (checkBox4.Checked == true && b == d)
                                    { p2_7.Text = Convert.ToString(b + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && b == q)
                                        { p2_7.Text = Convert.ToString(b + q); }
                                        else { p2_7.Text = "0"; }
                                    }
                                }
                            }
                            else
                            {
                                if (checkBox3.Checked == true)
                                {
                                    if (checkBox4.Checked == true && c == d)
                                    { p2_7.Text = Convert.ToString(c + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && c == q)
                                        { p2_7.Text = Convert.ToString(c + q); }
                                        else { p2_7.Text = "0"; }
                                    }
                                }
                                else
                                {
                                    if (checkBox4.Checked == true)
                                    {                                        
                                        if (checkBox5.Checked == true && d == q)
                                        { p2_7.Text = Convert.ToString(d + q);  }
                                        else { p2_7.Text = "0"; }
                                    }
                                    else { MessageBox.Show("Выберите больше значений"); return; }
                                }
                            }
                        }
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    button3.Enabled = false;
                    button2.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }
            
            Cleaning();

        }

        private void stat8_Click(object sender, EventArgs e) //2 para
        {
            switch (p)
            {
                case 1:
                    if (p1_8.Text == "-")
                    {
                        if (checkBox1.Checked == true)
                        {
                            if (checkBox2.Checked == true)
                            {
                                if (checkBox3.Checked == true)
                                {
                                    if (checkBox4.Checked == true)
                                    {
                                        if ((a == b && c == d)||(a == c && b == d)||(a == d && c == b)) 
                                        { p1_8.Text = Convert.ToString(a + b + c + d); }
                                        else { p1_8.Text = "0"; }
                                    }
                                    else
                                    {
                                        if (checkBox5.Checked == true)
                                        {
                                            if ((a == b && c == q) || (a == c && b == q) || (a == q && c == b))
                                                { p1_8.Text = Convert.ToString(a + b + c + q); }
                                            else { p1_8.Text = "0"; }
                                        }
                                        else { MessageBox.Show("Выберите больше значений"); return; }
                                    }
                                }
                                else
                                {
                                    if (checkBox4.Checked == true && checkBox5.Checked == true)
                                    {
                                        if ((a == b && d == q) || (a == d && b == q) || (a == q && d == b))
                                        { p1_8.Text = Convert.ToString(a + b + d + q); }
                                        else { p1_8.Text = "0"; }
                                    }
                                    else { MessageBox.Show("Выберите больше значений"); return; }
                                }
                            }
                            else
                            {
                                if (checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                                {
                                    if ((a == c && d == q) || (a == d && c == q) || (a == q && d == c))
                                    { p1_8.Text = Convert.ToString(a + c + d + q); }
                                    else { p1_8.Text = "0"; }
                                }
                                else { MessageBox.Show("Выберите больше значений"); return; }
                            }
                        }
                        else
                        {
                            if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                            {
                                if ((b == c && d == q) || (b == d && c == q) || (b == q && d == c))
                                { p1_8.Text = Convert.ToString(b + c + d + q); }
                                else { p1_8.Text = "0"; }
                            }
                            else { MessageBox.Show("Выберите больше значений"); return; }
                        }
                        button2.Enabled = false;
                        button3.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                case 2:
                    if (p2_8.Text == "-")
                    {
                        if (checkBox1.Checked == true)
                        {
                            if (checkBox2.Checked == true)
                            {
                                if (checkBox3.Checked == true)
                                {
                                    if (checkBox4.Checked == true)
                                    {
                                        if ((a == b && c == d) || (a == c && b == d) || (a == d && c == b))
                                        { p2_8.Text = Convert.ToString(a + b + c + d); }
                                        else { p2_8.Text = "0"; }
                                    }
                                    else
                                    {
                                        if (checkBox5.Checked == true)
                                        {
                                            if ((a == b && c == q) || (a == c && b == q) || (a == q && c == b))
                                            { p2_8.Text = Convert.ToString(a + b + c + q); }
                                            else { p2_8.Text = "0"; }
                                        }
                                        else { MessageBox.Show("Выберите больше значений"); return; }
                                    }
                                }
                                else
                                {
                                    if (checkBox4.Checked == true && checkBox5.Checked == true)
                                    {
                                        if ((a == b && d == q) || (a == d && b == q) || (a == q && d == b))
                                        { p2_8.Text = Convert.ToString(a + b + d + q); }
                                        else { p2_8.Text = "0"; }
                                    }
                                    else { MessageBox.Show("Выберите больше значений"); return; }
                                }
                            }
                            else
                            {
                                if (checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                                {
                                    if ((a == c && d == q) || (a == d && c == q) || (a == q && d == c))
                                    { p2_8.Text = Convert.ToString(a + c + d + q); }
                                    else { p2_8.Text = "0"; }
                                }
                                else { MessageBox.Show("Выберите больше значений"); return; }
                            }
                        }
                        else
                        {
                            if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                            {
                                if ((b == c && d == q) || (b == d && c == q) || (b == q && d == c))
                                { p2_8.Text = Convert.ToString(b + c + d + q); }
                                else { p2_8.Text = "0"; }
                            }
                            else { MessageBox.Show("Выберите больше значений"); return; }
                        }
                        button3.Enabled = false;
                        button2.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }
            Cleaning();        
        }

        private void stat9_Click(object sender, EventArgs e) //set
        {
            switch (p)
            {
                case 1:
                    if (p1_9.Text == "-")
                    {
                        if (checkBox1.Checked == true)
                        {
                            if (checkBox2.Checked == true && a == b)
                            {
                                if (checkBox3.Checked == true && a == c)
                                { p1_9.Text = Convert.ToString(a + b + c); }
                                else
                                {
                                    if (checkBox4.Checked == true && a == d)
                                    { p1_9.Text = Convert.ToString(a + b + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && a == q)
                                        { p1_9.Text = Convert.ToString(a + b + q); }
                                        else { p1_9.Text = "0"; }
                                    }
                                }
                                
                            }
                            else
                            {
                                if (checkBox3.Checked == true && a == c)
                                {
                                    if (checkBox4.Checked == true && a == d)
                                    { p1_9.Text = Convert.ToString(a + c + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && a == q)
                                        { p1_9.Text = Convert.ToString(a + c + q); }
                                        else { p1_9.Text = "0"; }
                                    }
                                }
                                else
                                {
                                    if (checkBox4.Checked == true && a == d)
                                    {
                                        if (checkBox5.Checked == true && a == q)
                                        { p1_9.Text = Convert.ToString(a + d + q); }
                                        else { p1_9.Text = "0"; }
                                    }
                                    else { p1_9.Text = "0";}
                                }
                            }
                        }
                        else
                        {
                            if (checkBox2.Checked == true)
                            {
                                if (checkBox3.Checked == true && b == c)
                                {
                                    if (checkBox4.Checked == true && b == d)
                                    { p1_9.Text = Convert.ToString(b + c + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && b == q)
                                        { p1_9.Text = Convert.ToString(b + c + q); }
                                        else { p1_9.Text = "0"; }
                                    }
                                }
                                else
                                {
                                    if (checkBox4.Checked == true && b == d)
                                    { 
                                        if (checkBox5.Checked == true && b == q)
                                        { p1_9.Text = Convert.ToString(b + c + q); }
                                        else { p1_9.Text = "0"; } 
                                    }
                                    else { p1_9.Text = "0"; }

                                }
                            }
                            else
                            {
                                if (checkBox3.Checked == true)
                                {
                                    if (checkBox4.Checked == true && c == d)
                                    { 
                                        if (checkBox5.Checked == true && c == q)
                                            { p1_9.Text = Convert.ToString(c + d + q); }
                                        else { p1_9.Text = "0"; }
                                    }
                                    else { p1_9.Text = "0"; }

                                }
                                else { MessageBox.Show("Выберите больше значений"); return; }
                            }

                        }
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    button2.Enabled = false;
                    button3.Enabled = true;
                    break;
                case 2:
                    if (p2_9.Text == "-")
                    {
                        if (checkBox1.Checked == true)
                        {
                            if (checkBox2.Checked == true && a == b)
                            {
                                if (checkBox3.Checked == true && a == c)
                                { p2_9.Text = Convert.ToString(a + b + c); }
                                else
                                {
                                    if (checkBox4.Checked == true && a == d)
                                    { p2_9.Text = Convert.ToString(a + b + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && a == q)
                                        { p2_9.Text = Convert.ToString(a + b + q); }
                                        else { p2_9.Text = "0"; }
                                    }
                                }

                            }
                            else
                            {
                                if (checkBox3.Checked == true && a == c)
                                {
                                    if (checkBox4.Checked == true && a == d)
                                    { p2_9.Text = Convert.ToString(a + c + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && a == q)
                                        { p2_9.Text = Convert.ToString(a + c + q); }
                                        else { p2_9.Text = "0"; }
                                    }
                                }
                                else
                                {
                                    if (checkBox4.Checked == true && a == d)
                                    {
                                        if (checkBox5.Checked == true && a == q)
                                        { p2_9.Text = Convert.ToString(a + d + q); }
                                        else { p2_9.Text = "0"; }
                                    }
                                    else { p1_9.Text = "0"; }
                                }
                            }
                        }
                        else
                        {
                            if (checkBox2.Checked == true)
                            {
                                if (checkBox3.Checked == true && b == c)
                                {
                                    if (checkBox4.Checked == true && b == d)
                                    { p2_9.Text = Convert.ToString(b + c + d); }
                                    else
                                    {
                                        if (checkBox5.Checked == true && b == q)
                                        { p2_9.Text = Convert.ToString(b + c + q); }
                                        else { p2_9.Text = "0"; }
                                    }
                                }
                                else
                                {
                                    if (checkBox4.Checked == true && b == d)
                                    {
                                        if (checkBox5.Checked == true && b == q)
                                        { p2_9.Text = Convert.ToString(b + c + q); }
                                        else { p2_9.Text = "0"; }
                                    }
                                    else { p1_9.Text = "0"; }

                                }
                            }
                            else
                            {
                                if (checkBox3.Checked == true)
                                {
                                    if (checkBox4.Checked == true && c == d)
                                    {
                                        if (checkBox5.Checked == true && c == q)
                                        { p2_9.Text = Convert.ToString(c + d + q); }
                                        else { p2_9.Text = "0"; }
                                    }
                                    else { p1_9.Text = "0"; }

                                }
                                else { MessageBox.Show("Выберите больше значений"); return; }
                            }

                        }
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    button3.Enabled = false;
                    button2.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }

            Cleaning();

        }

        private void stat10_Click(object sender, EventArgs e) //strit
        {
            switch (p)
            {
                case 1:
                    if (p1_10.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            int[] arr = { a, b, c, d, q };
                            int pos, tmp, f = 0;
                            for (int i = 0; i < 5; ++i)
                            {
                                pos = i;
                                tmp = arr[i];
                                for (int j = i + 1; j < 5; ++j)
                                {
                                    if (arr[j] < tmp)
                                    {
                                        pos = j;
                                        tmp = arr[j];
                                    }
                                }
                                arr[pos] = arr[i];
                                arr[i] = tmp;
                                f = f + tmp;
                                if (f == 15 || f == 20) { p1_10.Text = Convert.ToString(a + b + c + d + q + 10); }
                                else { p1_10.Text = "0"; }
                            }
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button2.Enabled = false;
                        button3.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                case 2:
                    if (p2_10.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            int[] arr = { a, b, c, d, q };
                            int pos, tmp, f = 0;
                            for (int i = 0; i < 5; ++i)
                            {
                                pos = i;
                                tmp = arr[i];
                                for (int j = i + 1; j < 5; ++j)
                                {
                                    if (arr[j] < tmp)
                                    {
                                        pos = j;
                                        tmp = arr[j];
                                    }
                                }
                                arr[pos] = arr[i];
                                arr[i] = tmp;
                                f = f + tmp;
                                if (f == 15 || f == 20) { p2_10.Text = Convert.ToString(a + b + c + d + q + 10); }
                                else { p2_10.Text = "0"; }
                            }
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button3.Enabled = false;
                        button2.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }

            Cleaning();

        }

        private void stat11_Click(object sender, EventArgs e) //strit
        {
            switch (p)
            {
                case 1:
                    if (p1_11.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            int[] arr = { a, b, c, d, q };
                            int pos, tmp, f = 0;
                            for (int i = 0; i < 5; ++i)
                            {
                                pos = i;
                                tmp = arr[i];
                                for (int j = i + 1; j < 5; ++j)
                                {
                                    if (arr[j] < tmp)
                                    {
                                        pos = j;
                                        tmp = arr[j];
                                    }
                                }
                                arr[pos] = arr[i];
                                arr[i] = tmp;
                                f = f + tmp;
                                if (f == 15 || f == 20) { p1_11.Text = Convert.ToString(a + b + c + d + q + 10); }
                                else { p1_11.Text = "0"; }
                            }
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button2.Enabled = false;
                        button3.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                case 2:
                    if (p2_11.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            int[] arr = { a, b, c, d, q };
                            int pos, tmp, f = 0;
                            for (int i = 0; i < 5; ++i)
                            {
                                pos = i;
                                tmp = arr[i];
                                for (int j = i + 1; j < 5; ++j)
                                {
                                    if (arr[j] < tmp)
                                    {
                                        pos = j;
                                        tmp = arr[j];
                                    }
                                }
                                arr[pos] = arr[i];
                                arr[i] = tmp;
                                f = f + tmp;
                                if (f == 15 || f == 20) { p2_11.Text = Convert.ToString(a + b + c + d + q + 10); }
                                else { p2_11.Text = "0"; }
                            }
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button3.Enabled = false;
                        button2.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }

            Cleaning();

        }

        private void stat12_Click(object sender, EventArgs e) //fullhouse
        {
            switch (p)
            {
                case 1:
                    if (p1_12.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            if ((a == b && b == c && d == q)||(a == b && b == d && c == q)||(a == b && b == q && d == c)||
                                (a == d && d == c && b == q)||(a == q && q == c && d == b)||(d == b && b == c && a == q)||
                                (q == b && b == c && d == a)||(a == d && d == q && b == c)||(d == b && b == q && a == c)||
                                (d == q && q == c && b == a))
                            { p1_12.Text = Convert.ToString(a + b + c + d + q + 20); }
                            else { p1_12.Text = "0"; }
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button2.Enabled = false;
                        button3.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                case 2:
                    if (p2_12.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            if ((a == b && b == c && d == q) || (a == b && b == d && c == q) || (a == b && b == q && d == c) ||
                                (a == d && d == c && b == q) || (a == q && q == c && d == b) || (d == b && b == c && a == q) ||
                                (q == b && b == c && d == a) || (a == d && d == q && b == c) || (d == b && b == q && a == c) ||
                                (d == q && q == c && b == a))
                            { p2_12.Text = Convert.ToString(a + b + c + d + q + 20); }
                            else { p2_12.Text = "0"; }
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button3.Enabled = false;
                        button2.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }

            Cleaning();

        }

        private void stat13_Click(object sender, EventArgs e) //kare
        {
            switch (p)
            {
                case 1:
                    if (p1_13.Text == "-")
                    {
                        if (checkBox1.Checked == true)
                        {
                            if (checkBox2.Checked == true)
                            {
                                if (checkBox3.Checked == true)
                                {
                                    if (checkBox4.Checked == true)
                                    {
                                        if (a == b && b == c && c == d) { p1_13.Text = Convert.ToString(a + b + c + d + 40); }
                                        else { p1_13.Text = "0"; }
                                    }
                                    else 
                                    {
                                        if (checkBox5.Checked == true)
                                        {
                                            if (a == b && b == c && c == q) { p1_13.Text = Convert.ToString(a + b + c + q + 40); }
                                            else { p1_13.Text = "0"; }
                                        }
                                        else { MessageBox.Show("Выберите больше значений"); return; }
                                    }
                                }
                                else 
                                {
                                    if (checkBox4.Checked == true && checkBox5.Checked == true)
                                    {
                                        if (a == b && b == d && d == q) { p1_13.Text = Convert.ToString(a + b + d + q + 40); }
                                        else { p1_13.Text = "0"; }
                                    }
                                    else { MessageBox.Show("Выберите больше значений"); return; }
                                }
                            }
                            else 
                            {
                                if (checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                                {
                                    if (a == c && c == d && d == q) { p1_13.Text = Convert.ToString(a + c + d + q + 40); }
                                    else { p1_13.Text = "0"; }
                                }
                                else { MessageBox.Show("Выберите больше значений"); return; }
                            }
                        }
                        else 
                        {
                            if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                            {
                                if (b == c && c == d && d == q) { p1_13.Text = Convert.ToString(b + c + d + q + 40); }
                                else { p1_13.Text = "0"; }
                            }
                            else { MessageBox.Show("Выберите больше значений"); return; }
                        }
                        button2.Enabled = false;
                        button3.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                case 2:
                    if (p2_13.Text == "-")
                    {
                        if (checkBox1.Checked == true)
                        {
                            if (checkBox2.Checked == true)
                            {
                                if (checkBox3.Checked == true)
                                {
                                    if (checkBox4.Checked == true)
                                    {
                                        if (a == b && b == c && c == d) { p2_13.Text = Convert.ToString(a + b + c + d + 40); }
                                        else { p2_13.Text = "0"; }
                                    }
                                    else
                                    {
                                        if (checkBox5.Checked == true)
                                        {
                                            if (a == b && b == c && c == q) { p2_13.Text = Convert.ToString(a + b + c + q + 40); }
                                            else { p2_13.Text = "0"; }
                                        }
                                        else { MessageBox.Show("Выберите больше значений"); return; }
                                    }
                                }
                                else
                                {
                                    if (checkBox4.Checked == true && checkBox5.Checked == true)
                                    {
                                        if (a == b && b == d && d == q) { p2_13.Text = Convert.ToString(a + b + d + q + 40); }
                                        else { p2_13.Text = "0"; }
                                    }
                                    else { MessageBox.Show("Выберите больше значений"); return; }
                                }
                            }
                            else
                            {
                                if (checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                                {
                                    if (a == c && c == d && d == q) { p2_13.Text = Convert.ToString(a + c + d + q + 40); }
                                    else { p2_13.Text = "0"; }
                                }
                                else { MessageBox.Show("Выберите больше значений"); return; }
                            }
                        }
                        else
                        {
                            if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                            {
                                if (b == c && c == d && d == q) { p2_13.Text = Convert.ToString(b + c + d + q + 40); }
                                else { p2_13.Text = "0"; }
                            }
                            else { MessageBox.Show("Выберите больше значений"); return; }
                        }
                        button3.Enabled = false;
                        button2.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }

            Cleaning();

        }

        private void stat14_Click(object sender, EventArgs e) //royal flash
        {
            switch (p)
            {
                case 1:
                    if (p1_14.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            if (a == b && b == c && c == d && d == q)
                            { p1_14.Text = Convert.ToString(a + b + c + d + q + 50); }
                            else { p1_14.Text = "0"; }
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button2.Enabled = false;
                        button3.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                case 2:
                    if (p2_14.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            if (a == b && b == c && c == d && d == q)
                            { p2_14.Text = Convert.ToString(a + b + c + d + q + 50); }
                            else { p2_14.Text = "0"; }
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button3.Enabled = false;
                        button2.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }
            
            Cleaning();

        }

        private void stat15_Click(object sender, EventArgs e) //trash
        {
            switch (p)
            {
                case 1:
                    if (p1_15.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            p1_15.Text = Convert.ToString(a + b + c + d + q);
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button2.Enabled = false;
                        button3.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                case 2:
                    if (p2_15.Text == "-")
                    {
                        if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                        checkBox4.Checked == true && checkBox5.Checked == true)
                        {
                            p2_15.Text = Convert.ToString(a + b + c + d + q);
                        }
                        else { MessageBox.Show("Выберите больше значений"); return; }

                        button3.Enabled = false;
                        button2.Enabled = true;
                    }
                    else { MessageBox.Show("Значение присвоено"); return; }
                    break;
                default:
                    MessageBox.Show("Ход не сделан");
                    break;
            }

            Cleaning();
        }

        



        private void Form2_Paint(object sender, PaintEventArgs e) //paint
        {
            Graphics graph = this.CreateGraphics();
            Pen pen = new Pen(Color.White, 2);
            graph.DrawLine(pen, 0, 20, 200, 20);
            graph.DrawLine(pen, 40, 0, 40, 430);
            graph.DrawLine(pen, 80, 0, 80, 430);
            graph.DrawLine(pen, 120, 0, 120, 430);
            graph.DrawLine(pen, 0, 178, 200, 178);//school
            graph.DrawLine(pen, 0, 410, 200, 410);//итог            
        } 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) { checkBox1.Checked = true; }
            else { checkBox1.Checked = false; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false) { checkBox2.Checked = true; }
            else { checkBox2.Checked = false; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false) { checkBox3.Checked = true; }
            else { checkBox3.Checked = false; }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false) { checkBox4.Checked = true; }
            else { checkBox4.Checked = false; }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false) { checkBox5.Checked = true; }
            else { checkBox5.Checked = false; }
        }

        private void result_Click(object sender, EventArgs e) //result
        {            
            if (p1_1.Text == "-" && p1_2.Text == "-" && p1_3.Text == "-" && p1_4.Text == "-" && p1_5.Text == "-" &&
                p1_6.Text == "-" && p1_7.Text == "-" && p1_8.Text == "-" && p1_9.Text == "-" && p1_10.Text == "-" &&
                p1_11.Text == "-" && p1_12.Text == "-" && p1_13.Text == "-" && p1_14.Text == "-" && p1_15.Text == "-"&&
                p2_1.Text == "-" && p2_2.Text == "-" && p2_3.Text == "-" && p2_4.Text == "-" && p2_5.Text == "-" &&
                p2_6.Text == "-" && p2_7.Text == "-" && p2_8.Text == "-" && p2_9.Text == "-" && p2_10.Text == "-" &&
                p2_11.Text == "-" && p2_12.Text == "-" && p2_13.Text == "-" && p2_14.Text == "-" && p2_15.Text == "-") 
            { MessageBox.Show("Заполните все поля"); return; }
            else 
            {
                int res1 = Convert.ToInt32(p1_1.Text) + Convert.ToInt32(p1_2.Text) + Convert.ToInt32(p1_3.Text) + Convert.ToInt32(p1_4.Text) +
                    Convert.ToInt32(p1_5.Text) + Convert.ToInt32(p1_6.Text) + Convert.ToInt32(p1_7.Text) + Convert.ToInt32(p1_8.Text) +
                    Convert.ToInt32(p1_9.Text) + Convert.ToInt32(p1_10.Text) + Convert.ToInt32(p1_11.Text) + Convert.ToInt32(p1_12.Text) +
                    Convert.ToInt32(p1_13.Text) + Convert.ToInt32(p1_14.Text) + Convert.ToInt32(p1_15.Text);
                int res2 = Convert.ToInt32(p2_1.Text) + Convert.ToInt32(p2_2.Text) + Convert.ToInt32(p2_3.Text) + Convert.ToInt32(p2_4.Text) +
                    Convert.ToInt32(p2_5.Text) + Convert.ToInt32(p2_6.Text) + Convert.ToInt32(p2_7.Text) + Convert.ToInt32(p2_8.Text) +
                    Convert.ToInt32(p2_9.Text) + Convert.ToInt32(p2_10.Text) + Convert.ToInt32(p2_11.Text) + Convert.ToInt32(p2_12.Text) +
                    Convert.ToInt32(p2_13.Text) + Convert.ToInt32(p2_14.Text) + Convert.ToInt32(p2_15.Text);
                Label labeli1 = new Label() { Location = new Point(45, 415), Size = new Size(25, 12) };//
                Label labeli2 = new Label() { Location = new Point(85, 415), Size = new Size(25, 12) };//итог
                Controls.Add(labeli1); Controls.Add(labeli2);//итог                
                labeli1.Text = res1.ToString();
                labeli2.Text = res2.ToString();
                if (res1 == res2)
                { 
                    DialogResult over =  MessageBox.Show("У вас ничья!", "Exit", MessageBoxButtons.OK);
                    switch (over)
                    {
                        case DialogResult.OK:
                            Closeform();                          
                            break;
                    }
                }
                else 
                {
                    if (res1 < res2)
                    {
                        DialogResult over = MessageBox.Show(n2 + " победил!", "Exit", MessageBoxButtons.OK);
                        switch (over)
                        {
                            case DialogResult.OK:
                                Closeform();
                                break;
                        }
                    }
                    else 
                    {
                        DialogResult over = MessageBox.Show(n1 + " победил!", "Exit", MessageBoxButtons.OK);
                        switch (over)
                        {
                            case DialogResult.OK:
                                Closeform();
                                break;
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time1 = Convert.ToInt32(label3.Text);
            if (time1 == 0)
            {
                timer1.Stop();
                label3.Text = "10";
                if (checkBox1.Checked == false)
                {
                    a = picrand.Next(1, 7); ;
                    checkBox1.Text = "Кубик 1 = " + a.ToString();
                    pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + a + ".jpg");
                    pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (checkBox2.Checked == false)
                {
                    b = picrand.Next(1, 7); ;
                    checkBox2.Text = "Кубик 2 = " + b.ToString();
                    pictureBox2.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + b + ".jpg");
                    pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (checkBox3.Checked == false)
                {
                    c = picrand.Next(1, 7); ;
                    checkBox3.Text = "Кубик 3 = " + c.ToString();
                    pictureBox3.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + c + ".jpg");
                    pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (checkBox4.Checked == false)
                {
                    d = picrand.Next(1, 7); ;
                    checkBox4.Text = "Кубик 4 = " + d.ToString();
                    pictureBox4.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + d + ".jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (checkBox5.Checked == false)
                {
                    q = picrand.Next(1, 7); ;
                    checkBox5.Text = "Кубик 5 = " + q.ToString();
                    pictureBox5.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + q + ".jpg");
                    pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            else
            {
                if (checkBox1.Checked == false)
                {
                    a = picrand.Next(1, 7);
                    checkBox1.Text = "Кубик 1 = " + a.ToString();
                    pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + a + ".jpg");
                    pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (checkBox2.Checked == false)
                {
                    b = picrand.Next(1, 7); ;
                    checkBox2.Text = "Кубик 2 = " + b.ToString();
                    pictureBox2.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + b + ".jpg");
                    pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (checkBox3.Checked == false)
                {
                    c = picrand.Next(1, 7); ;
                    checkBox3.Text = "Кубик 3 = " + c.ToString();
                    pictureBox3.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + c + ".jpg");
                    pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (checkBox4.Checked == false)
                {
                    d = picrand.Next(1, 7); ;
                    checkBox4.Text = "Кубик 4 = " + d.ToString();
                    pictureBox4.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + d + ".jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (checkBox5.Checked == false)
                {
                    q = picrand.Next(1, 7); ;
                    checkBox5.Text = "Кубик 5 = " + q.ToString();
                    pictureBox5.BackgroundImage = Image.FromFile("C:\\Users\\хайруллинаф\\source\\repos\\game0\\game0\\Resources\\" + q + ".jpg");
                    pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
                }
                int time0 = time1 - 1;
                label3.Text = Convert.ToString(time0);
            }
        }

        private void button4_Click(object sender, EventArgs e) //add name
       {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                n1 = textBox1.Text; n2 = textBox2.Text;
                Label name1 = new Label() { Text = n1, Location = new Point(45, 5), Size = new Size(25, 12) };//
                Label name2 = new Label() { Text = n2, Location = new Point(85, 5), Size = new Size(25, 12) };//name
                Controls.Add(name1); Controls.Add(name2);//name
                textBox1.Enabled = false; textBox2.Enabled = false;               
                stat1.Enabled = true; stat2.Enabled = true; stat3.Enabled = true; stat4.Enabled = true; stat5.Enabled = true; stat6.Enabled = true;
                result.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = false;
                label2.Text = "";
            }
            else { label2.Text = "Введите имя"; return; }            
            Cleaning();
        }
 
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) //exit
        {
            DialogResult dr = MessageBox.Show("Вы уверены?","Выход",MessageBoxButtons.YesNo);
            switch (dr) 
            {
                case DialogResult.Yes:
                    Closeform();
                    break;
                case DialogResult.No:                    
                    break;
            }
            
        }      


        private void button2_Click(object sender, EventArgs e) //name1
        {
            
            if (k < 2)
            {
                k++;
                label1.Text = "Колличество бросков: " + k.ToString();
            }
            else
            {
                k++;
                label1.Text = "Колличество бросков: " + k.ToString();
                button2.Enabled = false;                
                k = 0;
            }            
            Cub();
        }
        private void button3_Click(object sender, EventArgs e) //name2
        {
            
            if (k < 2)
            {
                k++;
                label1.Text = "Колличество бросков: " + k.ToString();
            }
            else
            {
                k++;
                label1.Text = "Колличество бросков: " + k.ToString();
                button3.Enabled = false;                
                k = 0;
            }            
            Cub();
        }

        

        void Cub()
        {
            checkBox1.Enabled = true; checkBox2.Enabled = true; checkBox3.Enabled = true; checkBox4.Enabled = true; checkBox5.Enabled = true;
            pictureBox1.Enabled = true; pictureBox2.Enabled = true; pictureBox3.Enabled = true; pictureBox4.Enabled = true; pictureBox5.Enabled = true;
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true;
            timer1.Start();                     
        }

        void Closeform()
        {
            this.Visible = false;
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 == null)
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
            else { form1.Visible = true; }
        }
        
    }
}