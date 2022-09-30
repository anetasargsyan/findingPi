using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindingPi
{
    public partial class MainForm : Form
    {

        public Action<int> OnSubmit;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Submitbutton_clicked(object sender, EventArgs e)
        {
            decimal pointCount = InputPanel.Value;
            int points = Convert.ToInt32(pointCount);

            double pi = FindingPi.VisualizePoints(points);
            Output.Text = pi.ToString();

            Graphics g = CreateGraphics();
            //g.Clear(Color.Azure);
            g.DrawEllipse(Pens.Black, 100, 100, 300, 300);
            g.DrawLine(Pens.Gray, 100, 100, 100, 400);
            g.DrawLine(Pens.Gray, 100, 400, 400, 400);
            g.DrawPie(Pens.OrangeRed, new Rectangle(100,50,100,100), 0, 50);


           // Image image =new Bitmap(resou) ;
            

            //g.DrawLines()
            //OnSubmit?.Invoke((int)pointCount);
        }
    }
}
