using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Credit : Creators Eye
/// </summary>

class TxtBox : TextBox
{

    private Color color1 = Color.FromArgb(133, 62, 254);
    public Color BorderColor
    {
        get { return color1; }
        set { color1 = value; }
    }
    protected override void WndProc(ref Message m)
    {
        switch (m.Msg)
        {
            case 15:
                Invalidate();
                base.WndProc(ref m);
                this.CustomPaint();
                break; // TODO: might not be correct. Was : Exit Select

            default:
                base.WndProc(ref m);
                break; // TODO: might not be correct. Was : Exit Select

        }
    }

    public TxtBox()
    {
        Font = new Font("Consolas", 10, FontStyle.Bold);
        ForeColor = Color.FromArgb(133, 62, 254);
        BackColor = Color.FromArgb(223, 231, 250);
        BorderStyle = BorderStyle.FixedSingle;
    }

    private void CustomPaint()
    {
        Pen p = new Pen(color1);
        Pen o = new Pen(color1);
        CreateGraphics().DrawLine(p, 0, 0, Width, 0);
        CreateGraphics().DrawLine(p, 0, Height - 1, Width, Height - 1);
        CreateGraphics().DrawLine(p, 0, 0, 0, Height - 1);
        CreateGraphics().DrawLine(p, Width - 1, 0, Width - 1, Height - 1);

        CreateGraphics().DrawLine(o, 1, 1, Width - 2, 1);
        CreateGraphics().DrawLine(o, 1, Height - 2, Width - 2, Height - 2);
        CreateGraphics().DrawLine(o, 1, 1, 1, Height - 2);
        CreateGraphics().DrawLine(o, Width - 2, 1, Width - 2, Height - 2);
    }
}



