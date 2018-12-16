using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WindowsFormsPlane

{
    public interface IFighter
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        void SetMainColor(Color color);
        void DrawFighter(Graphics g);
    }
}

