using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using MC.Cartography;

namespace MudCartographer
{
    public class DrawMap
    {
        private Map mapToDraw;

        public DrawMap(Map mapToDraw)
        {
            this.mapToDraw = mapToDraw;            
        }
        public void Draw(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.PixelOffsetMode = PixelOffsetMode.None;
            foreach (Link linkToDraw in mapToDraw.Links) DrawLink(graphics, linkToDraw);
            foreach (Room roomToDraw in mapToDraw.Rooms) DrawRoom(graphics, roomToDraw);
            DrawSelectedRooms(graphics);
        }
        private void DrawRoom(Graphics graphics, Room roomToDraw)
        {
            graphics.FillEllipse(Brushes.White, (int)roomToDraw.X - Constants.RADIUS, (int)roomToDraw.Y - Constants.RADIUS, 2 * Constants.RADIUS, 2 * Constants.RADIUS);
            graphics.DrawEllipse(new Pen(Color.Black, Constants.PEN_NORMAL_SIZE), (int)roomToDraw.X - Constants.RADIUS, (int)roomToDraw.Y - Constants.RADIUS, 2 * Constants.RADIUS, 2 * Constants.RADIUS);
        }
        private void DrawSelectedRooms(Graphics graphics)
        {
            foreach(Room roomToDraw in mapToDraw.GetSelectedRooms())
                graphics.DrawEllipse(new Pen(Color.Blue, Constants.PEN_BOLD_SIZE), (int)roomToDraw.X - Constants.RADIUS, (int)roomToDraw.Y - Constants.RADIUS, 2 * Constants.RADIUS, 2 * Constants.RADIUS);
        }

        private void DrawLink(Graphics graphics, Link linkToDraw)
        {
            graphics.DrawLine(new Pen(Color.Black, Constants.PEN_NORMAL_SIZE), (int)linkToDraw.startRoom.X, (int)linkToDraw.startRoom.Y, (int)linkToDraw.endRoom.X, (int)linkToDraw.endRoom.Y);
        }



    }
}
