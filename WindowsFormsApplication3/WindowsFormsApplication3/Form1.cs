using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = "แบบสอบถามผู้ใช้ระบบขนส่งมวลชนมหาวิทยาลัยพะเยา :" + Environment.NewLine;


            str = str + "1.คุณคิดอย่างไรกับความพอเพียงของรถเมล์ต่อจำนวนนักศึกษาในมหาวิทยาลัย == ";
            if (apt1.Checked == true)
            {
                str = str + "มาก" + Environment.NewLine;


            }
            if (radioButton2.Checked == true)
            {
                str = str + "ปานกลาง" + Environment.NewLine;

            }
            if (radioButton4.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;

            }


            str = str + "2.ความสุภาพของพนักงานขัขรถในการบริการ == ";
            if (bpt1.Checked == true)
            {
                str = str + "มาก" + Environment.NewLine;
            }
            if (bpt2.Checked == true)
            {
                str = str + "ปานกลาง" + Environment.NewLine;
            }
            if (radioButton1.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;

            }


            str = str + "3.ความสะอาดของรถเมล์มหาวิทยาลัยพะเยาในการให้บริการ == ";
            if (cpt1.Checked == true)
            {
                str = str + "มาก" + Environment.NewLine;
            }
            if (cpt2.Checked == true)
            {
                str = str + "ปานกลาง" + Environment.NewLine;
            }
            if (cpt3.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;

            }

            str = str + "4.ความปลอดภัยในการใช้บริการรถเมล์มหาวิทยาลัยพะเยา == ";
            if (dpt1.Checked == true)
            {
                str = str + "มาก" + Environment.NewLine;
            }
            if (dpt2.Checked == true)
            {
                str = str + "ปานกลาง" + Environment.NewLine;
            }
            if (radioButton3.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;
            }
            str = str + "5.ความเหมาะสมของการวางรูปแบบที่นั่งบนรถ == ";
            if (radioButton9.Checked == true)
                str = str + "มาก" + Environment.NewLine;
            {
                if (radioButton8.Checked == true)
                    str = str + "ปานกลาง" + Environment.NewLine;
            }
            if (radioButton5.Checked == true)
                str = str + "น้อย" + Environment.NewLine;
            {
              }
            str = str + "6.ความเหมาะสมของเวลาในการหมุนเวียนรับส่งนักศึกษา == " ;
            if (radioButton10.Checked == true)
                str = str + "มาก" + Environment.NewLine;
            {
                if (radioButton7.Checked == true)
                    str = str + "ปานกลาง" + Environment.NewLine;
            }
            if (radioButton6.Checked == true)
                str = str + "น้อย" + Environment.NewLine;



            MessageBox.Show(str, "รายงานผล");
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cpt2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

