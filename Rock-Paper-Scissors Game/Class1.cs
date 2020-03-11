using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    public class CircularPictureBox : CB1
    {
        protected override voide OnPaint(PaintEventAge pe)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0 ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pe);
        }
    }
}
