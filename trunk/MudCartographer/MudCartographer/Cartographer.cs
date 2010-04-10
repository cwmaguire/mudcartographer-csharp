using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MudCartographer
{
    public partial class Cartographer : Form
    {
        private DBGraphics memGraphics;
        private DrawMap drawMap;
        Map m;
        Room firstRoom;

        public Cartographer()
        {
            memGraphics = new DBGraphics();
            m = new Map();
            drawMap = new DrawMap(m);
            InitializeComponent();
        }

        private void Cartographer_Load(object sender, EventArgs e)
        {
            memGraphics.CreateDoubleBuffer(this.CreateGraphics(), this.ClientRectangle.Width, this.ClientRectangle.Height);
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        private void Cartographer_Resize(object sender, EventArgs e)
        {
            memGraphics.CreateDoubleBuffer(this.CreateGraphics(), this.ClientRectangle.Width, this.ClientRectangle.Height);
            Invalidate();
        }

        private void Cartographer_Paint(object sender, PaintEventArgs e)
        {
            if (memGraphics.CanDoubleBuffer())
            {
                // Fill in Background (for effieciency only the area that has been clipped)
                memGraphics.g.FillRectangle(new SolidBrush(SystemColors.Window), e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height);

                // Draw the object
                drawMap.Draw(memGraphics.g);

                // Render to the form
                memGraphics.Render(e.Graphics);
            }

        }

        private void Cartographer_MouseDown(object sender, MouseEventArgs e)
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
            Invalidate();
        }

        private void toolStripClear_Click(object sender, EventArgs e)
        {
            m.Clear();
            firstRoom = null;
            Invalidate();
        }

    }
}
