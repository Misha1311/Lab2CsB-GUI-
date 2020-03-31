using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class Form1 : Form
    {

        public int n, m;

        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }


        public Form1()
        {
            InitializeComponent();
        }

        public void Start1_Click(object sender, EventArgs e)
        {

            N = Convert.ToInt32(OupN.Text);
            M = Convert.ToInt32(OupM.Text);


            double avgsqure = 0;
            double min = 0;

            Triangle[] tring = new Triangle[N];


            for (int i = 0; i < N; i++)
            {
                do
                {
                    tring[i] = new Triangle();
                    tring[i].Lenght();
                    tring[i].IsExists();
                    if (tring[i].exist == true)
                    {
                        tring[i].Print();
                        tring[i].Angle();
                        tring[i].Perimetr();
                        tring[i].Square();
                    }
                } while (tring[i].exist == false);

                min = tring[0].perimetr;
                avgsqure += tring[i].square;
            }
            avgsqure /= N;

            for (int i = 0; i < N; i++)
            {
                if (tring[i].perimetr < min)
                {
                    min = tring[i].perimetr;
                }

            }
            oupavsq.Text = avgsqure.ToString("n");
            oupminper.Text = min.ToString("n");

            double max = 0;

            RightTriangle[] all = new RightTriangle[M];

            for (int i = 0; i < M; i++)
            {
                do
                {
                    all[i] = new RightTriangle();
                    all[i].Lenght();
                    all[i].IsExists();
                    if (all[i].exist)
                    {
                        if (all[i].isRight())
                        {
                            all[i].Print();
                            all[i].Angle();
                            all[i].Perimetr();
                            all[i].Square();
                        }
                    }
                } while (!all[i].isRight() || !all[i].exist);

            }
            int count = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (all[i].lenght[j] > max)
                    {
                        max = all[i].lenght[j];
                        count++;
                    }
                }
            }
            oupmaxhyp.Text = count.ToString("n");
        }
    }
}
