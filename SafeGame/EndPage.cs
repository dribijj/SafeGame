using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeGame
{
    public partial class EndPage : Form
    {
        public EndPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();
        }
    }
}
