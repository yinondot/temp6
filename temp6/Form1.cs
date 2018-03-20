using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temp6
{
    public partial class Form1 : Form
    {
        string[] dates;
        public Form1()
        {
            InitializeComponent();
            //comboBox1.AutoScrollOffset=
            // dates = new string[] {"1","2",

            //"3",
            //"5"};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var biggerThan2 =
                  from n in dates
                  where int.Parse(n) > 2
                  select n;

            foreach (var item in biggerThan2)
            {
                MessageBox.Show(item+"");
            }
        }
    }
}
