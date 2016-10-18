using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbertoword
{
    public partial class Numbertoword : Form
    {
        NumberTranslater translater = new NumberTranslater();
        public Numbertoword()
        {
            InitializeComponent();
            //  comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //  comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void Numbertoword_Load(object sender, EventArgs e)
        {

        }

        private void kindBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void caseBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void outBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            outBox.Text = translater.numberToText(numberBox.Text, kindBox.SelectedIndex + 1, caseBox.SelectedIndex + 1);
        }
    }
}
