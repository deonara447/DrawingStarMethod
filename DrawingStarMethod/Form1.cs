﻿/// Description: Program containing generic DrawStar and FillStar methods which could then
/// be used in any other program
/// Author: Mr. T.
/// Date: February 2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// Gathers information from the input boxes and then sends values
        /// to the DrawStar method to draw the star in the location and the 
        /// size that the user indicated.
        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red);

            float xValue, yValue, size;

            //xValue = Convert.ToSingle(xInput.Text);
            //yValue = Convert.ToSingle(yInput.Text);
            //size = Convert.ToSingle(sizeInput.Text);

            formGraphics.Clear(Color.DarkKhaki);
            //DrawStar(drawPen, xValue, yValue, size);
            DrawStar(drawPen, 50, 50, 100);

            string temp;

            temp = testMeth("hello", "How are you");
       }

        /// <summary>
        /// Draws an unfilled star on the screen
        /// </summary>
        /// <param name="starPen">The pen that will be used to draw the star</param>
        /// <param name="x">X value of the top left corner of the square within which the star is drawn</param>
        /// <param name="y">Y value of the top left corner of the square within which the star is drawn</param>
        /// <param name="pixels">Side lengths of the square within which the star is drawn</param>
        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {
            Graphics formGraphics = this.CreateGraphics();
           // Pen drawPen = new Pen(Color.Black);
          //  SolidBrush drawBrush = new SolidBrush(Color.Red);

            // base star is 207 pixels wide.  A scale is created based on this value to determine how long
            // to draw each side so that it will end up being the number of pixels wide that the user desires.
            float scale = pixels / 207;

            Thread.Sleep(2000);
            formGraphics.DrawLine(starPen, 80 * scale + x, 77 * scale + y, 103 * scale + x, 4 * scale + y);
            formGraphics.DrawLine(starPen, 103 * scale + x, 4 * scale + y, 126 * scale + x, 78 * scale + y);
            formGraphics.DrawLine(starPen, 126 * scale + x, 78 * scale + y, 207 * scale + x, 78 * scale + y);
            formGraphics.DrawLine(starPen, 207 * scale + x, 78 * scale + y, 143 * scale + x, 125 * scale + y);
            formGraphics.DrawLine(starPen, 143 * scale + x, 125 * scale + y, 167 * scale + x, 197 * scale + y);
            formGraphics.DrawLine(starPen, 167 * scale + x, 197 * scale + y, 103 * scale + x, 152 * scale + y);
            formGraphics.DrawLine(starPen, 103 * scale + x, 152 * scale + y, 40 * scale + x, 196 * scale + y);
            formGraphics.DrawLine(starPen, 40 * scale + x, 196 * scale + y, 63 * scale + x, 123 * scale + y);
            formGraphics.DrawLine(starPen, 63 * scale + x, 123 * scale + y, 0 * scale + x, 77 * scale + y);
            formGraphics.DrawLine(starPen, 0 * scale + x, 77 * scale + y, 80 * scale + x, 77 * scale + y);

            // TODO put the above points into a PointF array and use DrawPolygon to draw your star
        }

        public string testMeth(string message1, string message2)
        {
            MessageBox.Show(message1 + " " + message2);
            return "done";
        }

        /// Gathers information from the input boxes and then sends values
        /// to the FillStar method to draw the filled star in the location and the 
        /// size that the user indicated.
        private void fillButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            float xValue, yValue, size;

            xValue = Convert.ToSingle(xInput.Text);
            yValue = Convert.ToSingle(yInput.Text);
            size = Convert.ToSingle(sizeInput.Text);

            formGraphics.Clear(Color.DarkKhaki);
            FillStar(drawBrush, xValue, yValue, size);
        }

        /// <summary>
        /// Draws a filled star on the screen
        /// </summary>
        /// <param name="drawBrush">The brush that will be used to draw and fill the star</param>
        /// <param name="x">X value of the top left corner of the square within which the filled star is drawn</param>
        /// <param name="y">Y value of the top left corner of the square within which the filled star is drawn</param>
        /// <param name="pixels">Side lengths of the square within which the star is drawn</param>
        public void FillStar(SolidBrush drawBrush, float x, float y, float pixels)
        {
            // TODO create FillStar code here similar to DrawStar code but using FillPolygon instead

        }
    }
}
