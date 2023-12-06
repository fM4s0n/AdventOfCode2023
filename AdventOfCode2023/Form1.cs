using AdventOfCode2023.DaySolutions;

namespace AdventOfCode2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDay1_Click(object sender, EventArgs e)
        {
            LblDay1Pt1.Text = Day1.RunDay1Pt1().ToString();
            LblDay1Pt2.Text = Day1.RunDay1Pt2().ToString();
        }

        private void btnDay2_Click(object sender, EventArgs e)
        {
            LblDay2Pt1.Text = Day2.RunDay2Pt1().ToString();
            //LblDay2Pt2.Text = Day2.RunDay2Pt2().ToString();
        }
    }
}
