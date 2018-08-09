using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Result : Form
    {

        public Result(int corrects, int wrongs, int points, int time)
        {
            InitializeComponent();
            totalcorrects.Text = corrects.ToString();
            totalwrongs.Text = wrongs.ToString();
            totalpoints.Text = points.ToString();
            timeleft.Text = time.ToString();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu m = new Menu();
            m.Show();
        }

        private void Result_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
