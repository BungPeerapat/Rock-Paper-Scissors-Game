using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicPath g = new GraphicPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            base.OnPaint(pe);
        }
    }
}
