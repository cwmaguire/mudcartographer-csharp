using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace MudCartographer
{
    public partial class Graphs : Form
    {
        Map m;
        Room firstRoom;

        static int radius = 7;

        public Graphs()
        {
            m = new Map();         
            firstRoom = null;
            InitializeComponent();
        }
        
        ~Graphs()
        {
            m = null;
            firstRoom = null;
        }

        private void toolStripClear_Click(object sender, EventArgs e)
        {
            m.Clear();
            firstRoom = null;
            mapPanel.Invalidate();
        }

        private void mapPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.None;

            SuspendLayout();
            foreach (Link L in m.Links) DrawLink(g, L);
            foreach (Room R in m.Rooms) DrawRoom(g, R);            
            ResumeLayout(false);
        }

        private void mapPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (firstRoom == null)
            {
                firstRoom = new Room(new Point3D(e.X, e.Y, 0));
                m.addRoom(firstRoom);
            }
            else
            {
                Room newRoom = new Room(new Point3D(e.X, e.Y, 0));
                m.addRoom(newRoom);
                Link newLink = new Link(firstRoom, newRoom);
                m.addLink(newLink);
            }            
            mapPanel.Invalidate();
        }

        static private void DrawRoom(Graphics g,Room R)
        {
            g.FillEllipse(Brushes.White, (int)R.X - radius, (int)R.Y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(new Pen(Color.Black, 1), (int)R.X - radius, (int)R.Y - radius, 2 * radius, 2 * radius);
        }

        static private void DrawLink(Graphics g, Link L)
        {   
            g.DrawLine(new Pen(Color.Black, 1), (int) L.startRoom.X, (int) L.startRoom.Y, (int) L.endRoom.X, (int) L.endRoom.Y); 
        }

    }
}
