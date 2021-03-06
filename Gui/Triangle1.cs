﻿using System;
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

    public struct Point2D
    {
        public int x;
        public int y;
    };

    class Triangle
    {
        static int f = 0;
        int n = 3;
        Point2D[] points;
        public double[] lenght;
        public double angle1 = 0;
        public double angle2 = 0;
        public double angle3 = 0;
        public double perimetr = 0;
        public double square = 0;
        public bool exist = true;
        Random rand = new Random(f++);

        public double a;
        public double b;
        public double c;
        public Triangle()
        {
            points = new Point2D[3];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = rand.Next(0, 10);
                points[i].y = rand.Next(0, 10);
            }
        }

        public void IsExists()
        {
            for (int i = 0; i < n; i++)
            {
                if (lenght[i] + lenght[(i + 1) % n] <= lenght[(i + 2) % n])
                {
                    exist = false;
                    break;
                }
            }
        }

        public string PrintData()
        {
            string data = "";

            for (int i = 0; i < 3; i++)
            {
                data += $"X = { points[i].x }\t Y = { points[i].y }\n";
            }

            for (int i = 0; i < 3; i++)
            {
                data += $"Длина {i + 1}= {lenght[i]:N1}\n";
            }
            data += $"Угол 1 = {angle1:N1}\n";
            data += $"Угол 2 = {angle2:N1}\n";
            data += $"Угол 3 = {angle3:N1}\n";
            data += $"Периметр = {perimetr:N1}\n";
            data += $"Площадь = {square:N1}\n";

            data += $"------------------------------------------\n\n";

            return data;

        }


        public void Print()
        {
            for (int i = 0; i < points.Length; i++)
            {
                MessageBox.Show("X = " + (points[i].x).ToString() + " Y  =" + (points[i].y).ToString());
            }
            for (int i = 0; i < points.Length; i++)
            {
                MessageBox.Show("Длина =  " + (i + 1) + (lenght[i]).ToString());
            }
            MessageBox.Show("Угол 1 = " + (angle1).ToString() + "\n" + "Угол 2 = " + (angle2).ToString() + "\n" + "Угол 3 = " + (angle3).ToString() + "\n" + "Периметр = " + (perimetr).ToString() + "\n" + "Площадь = " + (square).ToString());
            //MessageBox.Show("Угол 2 = " + (angle2).ToString());
            //MessageBox.Show("Угол 3 = " + (angle3).ToString());
            //MessageBox.Show("Периметр = " + (perimetr).ToString());
            //MessageBox.Show("Площадь = " + (square).ToString());


        }

        public void Lenght()
        {
            lenght = new double[n];

            for (int i = 0; i < n; i++)
            {
                lenght[i] = Math.Sqrt(Math.Pow(points[(i + 1) % n].x - points[i].x, 2) + Math.Pow(points[(i + 1) % n].y - points[i].y, 2));
            }

        }

        public void Angle()
        {
            a = lenght[0];
            b = lenght[1];
            c = lenght[2];

            angle1 = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
            angle2 = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
            angle3 = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;

        }

        public void Perimetr()
        {
            perimetr = lenght[0] + lenght[1] + lenght[2];

        }

        public void Square()
        {
            square = 0.5 * lenght[0] * lenght[1] * Math.Sin(angle1);
            if (square < 0)
            {
                square *= -1;
            }

        }
    };
}
