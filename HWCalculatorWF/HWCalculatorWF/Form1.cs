using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWCalculatorWF
{
    public partial class Form1 : Form
    {
        bool penDown, fill;
        int x, y, lastX, lastY;
        int red, green, blue = 0;
        int a;
        int[] eraserColour = { 240, 240, 240 };
        int drawingMode = 0;
        float v, diffX, diffY, firstX, firstY;
        int crazy = 5;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            green = trackBar2.Value;
            blue = trackBar3.Value;
            button4.BackColor=Color.FromArgb(red, green, blue);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            int aX, aY;
            penDown = false;
            x = e.X;
            y = e.Y;
            aX = (int)(x - firstX);
            aY = (int)(y - firstY);
            if (aX > 0)
            {
                aX = 0;
            }
            if (aY > 0)
            {
                aY = 0;
            }

            if(fill == true) //ELLIPSE and RECTANGLE - could be simplified, but with that few possibilites, it was easier to use IFs. too much effort for almost none results :D
            {
                if (drawingMode == 1)
                {
                    Brush brush = new SolidBrush(Color.FromArgb(red, green, blue));
                    Graphics g = panel1.CreateGraphics();
                    g.FillEllipse(brush, firstX + aX, firstY + aY, Math.Abs(x - firstX), Math.Abs(y - firstY));
                }
                else if (drawingMode == 2)
                {
                    Brush brush = new SolidBrush(Color.FromArgb(red, green, blue));
                    Graphics g = panel1.CreateGraphics();
                    g.FillRectangle(brush, firstX + aX, firstY + aY, Math.Abs(x - firstX), Math.Abs(y - firstY));
                }
            }
            else
            {
                if (drawingMode == 1)
                {
                    Pen pen = new Pen(Color.FromArgb(red, green, blue),a);
                    Graphics g = panel1.CreateGraphics();
                    g.DrawEllipse(pen, firstX + aX, firstY + aY, Math.Abs(x - firstX), Math.Abs(y - firstY));
                }
                else if (drawingMode == 2)
                {
                    Pen pen = new Pen(Color.FromArgb(red, green, blue), a);
                    Graphics g = panel1.CreateGraphics();
                    g.DrawRectangle(pen, firstX + aX, firstY + aY, Math.Abs(x - firstX), Math.Abs(y - firstY));
                }
            }
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            green = trackBar2.Value;
            blue = trackBar3.Value;
            button4.BackColor = Color.FromArgb(red, green, blue);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            green = trackBar2.Value;
            blue = trackBar3.Value;
            button4.BackColor = Color.FromArgb(red, green, blue);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            red = 255;
            green = 255;
            blue = 255;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            red = 0;
            green = 0;
            blue = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            red = 255;
            green = 0;
            blue = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            green = trackBar2.Value;
            blue = trackBar3.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           Random rnd = new Random();
           red = rnd.Next(0, 256);
           green = rnd.Next(0, 256);
           blue = rnd.Next(0, 256);
           button8.BackColor= Color.FromArgb(red, green, blue);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            red = 255;
            green = 100;
            blue = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            red = 255;
            green = 240;
            blue = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            red = 0;
            green = 200;
            blue = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            red = 0;
            green = 200;
            blue = 255;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            red = 140;
            green = 0;
            blue = 255;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            drawingMode = 3;
            button19.BackColor = Color.FromArgb(red, green, blue);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fill = checkBox1.Checked;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            drawingMode = 4;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            drawingMode = 5;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            drawingMode = 6;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            drawingMode = 7;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            drawingMode = 8;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            crazy = trackBar4.Value;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            drawingMode = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            drawingMode = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            drawingMode = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            drawingMode = 0;
            red = eraserColour[0];
            green = eraserColour[1];
            blue = eraserColour[2];
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(red, green, blue);
            eraserColour = new int[]{red, green, blue};
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            a = (int) numericUpDown1.Value;
            Graphics g = panel1.CreateGraphics();
            lastX = x;
            lastY = y;
            x = e.X;
            y = e.Y;
            diffX = x - lastX;
            diffY = y - lastY;
            Color MyRGBColour = Color.FromArgb(red, green, blue);
            //Pen pen = new Pen(Color.Black);
            //Pen pen = new Pen(Color.FromArgb(red, green, blue, a));
            Pen pen = new Pen(MyRGBColour, a);
            Brush brush = new SolidBrush(MyRGBColour);
            // Brush brush = Brushes.Black;
            // Brush brush = Brushes.FromArgb(red, green, blue);
            v = (float)Math.Sqrt(diffX * diffX) + (diffY * diffY);
            Random rnd = new Random();
            if (penDown == true)
            {
                switch (drawingMode)
                {
                    case 0: // PEN creates a vector between two points (starting end ending point of the mouse) and adds stamps in betweem
                        for (int i = 0; i <= v; i=i+3)
                        {
                            g.FillEllipse(brush, (lastX + (i * diffX/v) - (a / 2)), (lastY + (i * diffY / v) - (a / 2)), a, a);
                        }   
                    break; 
                        // cases numer 1 and 2 are ELLIPSE and RECTANGLE drawing - look under panel1_MouseUp event
                    
                    case 3: // MAGIC BRUSH with each tsamp slightly changes color of the dot (randomized)
                        for (int i = 0; i <= v; i++)
                        {
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2)), (lastY + (i * diffY / v) - (a / 2)), a, a);
                            red = red + rnd.Next(-crazy, crazy +1);
                            green = green + rnd.Next(-crazy, crazy + 1);
                            blue = blue + rnd.Next(-crazy, crazy + 1);
                            if (red < 0)
                            {
                                red = crazy;
                            }
                            if (red > 255)
                            {
                                red = 255-crazy;
                            }
                            if (green < 0)
                            {
                                green = crazy;
                            }
                            if(green > 255)
                            {
                                green = 255 - crazy;
                            }
                            if (blue < 0)
                            {
                                blue = crazy;
                            }
                            if (blue > 255)
                            {
                                blue = 255 - crazy;
                            }
                            MyRGBColour = Color.FromArgb(red, green, blue);
                            brush = new SolidBrush(MyRGBColour);
                            button19.BackColor = MyRGBColour;
                        }
                        break;
                    case 4: // CHARCOAL scattered dots
                        for (int i = 0; i <= v; i++)
                        {
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a/2,a/2)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a/2, a/2)), a/4, a/4);
                        }
                        break;
                    case 5: // MARKER regular pen with imperfections added
                        for (int i = 0; i <= v; i++)
                        {
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2)), (lastY + (i * diffY / v) - (a / 2)), a, a);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 2, 2*a)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, 2*a)), a / 4, a / 4);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 2, a)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, a)), a / 4, a / 4);
                        }
                        break;
                    case 6: // CALLIGRAPHIC distorted ellipse stamp
                        for (int i = 0; i < v; i++)
                        {
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2)), (lastY + (i * diffY / v) - (a / 2)), a, a / 2);
                        }
                        break;
                    case 7: // SHARP rectangle-shaped stamp
                        for (int i = 0; i < v; i++)
                        {
                            g.FillRectangle(brush, (lastX + (i * diffX / v) - (a / 2)), (lastY + (i * diffY / v) - (a / 2)), a, a);
                        }
                        break;
                    case 8: // PENCIL combination of dots with different scatter randomness and ratio
                        for (int i = 0; i <= v; i++)
                        {
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 2, 2 * a)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, 2 * a)), a / 4, a / 4);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 2, a)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, a)), a / 4, a / 4);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 4, a)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, a)), a / 4, a / 4);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 8, a/2)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, a)), a / 4, a / 4);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 2, 2 * a)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, 2 * a)), a / 4, a / 4);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 2, a)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, a)), a / 4, a / 4);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 4, a)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, a)), a / 4, a / 4);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 8, a / 2)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, a)), a / 2, a / 2);
                            g.FillEllipse(brush, (lastX + (i * diffX / v) - (a / 2) + rnd.Next(-a / 8, a / 2)), (lastY + (i * diffY / v) - (a / 2) + rnd.Next(-a / 2, a)), a / 2, a / 2);

                        }
                        break;
                }
                //g.FillEllipse(brush, x - (a / 2), y - (a / 2), a, a);
                //g.DrawLine(pen, lastX, lastY, x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        public Form1()
        {
            InitializeComponent();
            penDown = false;
            panel1.ForeColor = Color.FromArgb(220, 220, 220);
            fill = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            if (penDown == false)
            {
                firstX = e.X;
                firstY = e.Y;
            }
            penDown = true;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
