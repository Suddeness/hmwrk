using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Paint += new PaintEventHandler(this.OnPaint);
    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        Pen pen = new Pen(Color.DeepPink, 3);
        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

        Rectangle rect = new Rectangle(50, 50, 200, 100);
        g.DrawRectangle(pen, rect);

        Font font = new Font("Arial Black", 14);
        Brush textBrush = Brushes.Black;
        g.DrawString("Kurkuma", font, textBrush, rect.X + 10, rect.Y + 30);

        HatchBrush hatchBrush = new HatchBrush(System.Drawing.Drawing2D.HatchStyle.DiagonalCross, Color.BlueViolet, Color.Transparent);

        Rectangle ellipseRect = new Rectangle(100, 180, 150, 80);
        g.FillEllipse(hatchBrush, ellipseRect);
        g.DrawEllipse(pen, ellipseRect);
    }
