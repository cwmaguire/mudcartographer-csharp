using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MudCartographer
{
    public class DrawMap
    {
        int radius = 7;
        private Map map;
        public DrawMap(Map m)
        {
            this.map = m;
        }
        public void Draw(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.None;
            foreach (Link L in map.Links) DrawLink(g, L);
            foreach (Room R in map.Rooms) DrawRoom(g, R);   
        }
        private void DrawRoom(Graphics g, Room R)
        {
            g.FillEllipse(Brushes.White, (int)R.X - radius, (int)R.Y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(new Pen(Color.Black, 1), (int)R.X - radius, (int)R.Y - radius, 2 * radius, 2 * radius);
        }

        private void DrawLink(Graphics g, Link L)
        {
            g.DrawLine(new Pen(Color.Black, 1), (int)L.startRoom.X, (int)L.startRoom.Y, (int)L.endRoom.X, (int)L.endRoom.Y);
        }


    }
}
