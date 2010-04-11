using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace MudCartographer
{
    public partial class Cartographer : Form
    {
        #region Actions & ToolStrip
        enum Action { Select, Draw, Delete}
        Action _Mode;
        Action Mode
        {
            get { return _Mode; }
            set
            {
                _Mode = value;
                //Exclusive actions
                foreach (ToolStripButton B in toolStripEdition.Items) B.Checked = false;
                switch (_Mode)
                {
                    case Action.Select:
                    {
                        toolStripSelection.Checked = true;
                        break;
                    }
                    case Action.Draw:
                    {
                        toolStripCreate.Checked = true;
                        break;
                    }

                    case Action.Delete:
                    {
                        toolStripDeleteNode.Checked = true;
                        break;
                    }
                }
            }
        }
        #endregion
       
        DBGraphics memGraphics;
        DrawMap drawMap;
        Map mapToDraw;
        bool isDraggingRoom;

        public Cartographer()
        {
            memGraphics = new DBGraphics();
            mapToDraw = new Map();
            drawMap = new DrawMap(mapToDraw);
            isDraggingRoom = false;

            InitializeComponent();            
        }

        private void Cartographer_Load(object sender, EventArgs e)
        {
            Mode = Action.Draw;
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
                memGraphics.g.FillRectangle(new SolidBrush(SystemColors.Window), e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height);
                drawMap.Draw(memGraphics.g);
                memGraphics.Render(e.Graphics);
            }
        }

        private void ToggleButtonsSelectionEdition()
        {
            if (Mode == Action.Select)
            {
                Mode = Action.Draw;
            }
            else
            {
                Mode = Action.Select;
            }
        }

        private void Cartographer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ToggleButtonsSelectionEdition();
                return;
            }

            Point3D pointOfRefence = new Point3D(e.X, e.Y, 0);
            switch (Mode)
            {
                case Action.Select:
                    {
                        mapToDraw.SelectRoomNearPoint(pointOfRefence);
                        break;
                    }
                case Action.Delete:
                    {
                        Room roomToDelete = mapToDraw.GetClosestRoomToPoint(pointOfRefence);
                        if (roomToDelete != null)
                            mapToDraw.DeleteRoom(roomToDelete);
                        break;
                    }
                case Action.Draw:
                    {
                        if (mapToDraw.ARoomIsNearPoint(pointOfRefence))
                        {
                            Room nextRoom = mapToDraw.GetClosestRoomToPoint(pointOfRefence);
                            if (mapToDraw.GetSelectedRooms().Count > 0)
                            {
                                Room lastRoomSelected = (Room)mapToDraw.GetSelectedRooms()[0];
                                mapToDraw.AddLink(lastRoomSelected, nextRoom);
                            }                                                           
                            mapToDraw.SelectRoomNearPoint(pointOfRefence);
                        }
                        else
                        {
                            Room newRoom = new Room(pointOfRefence);
                            mapToDraw.AddRoom(newRoom);

                            if (mapToDraw.GetSelectedRooms().Count == 0)
                                mapToDraw.SelectASingleRoom(newRoom);
                            else mapToDraw.LinkRoomToSelectedRooms(newRoom);
                        }
                        break;
                    }

            }
            Invalidate();
        }

        private void toolStripClear_Click(object sender, EventArgs e)
        {
            mapToDraw.DeleteRoomsLinksAndSelection();
            Invalidate();
        }

        private void toolStripSelection_Click(object sender, EventArgs e)
        {
            Mode = Action.Select;
        }

        private void toolStripCreate_Click(object sender, EventArgs e)
        {
            Mode = Action.Draw;
        }



        private void toolStripDeleteNote_Click(object sender, EventArgs e)
        {
            Mode = Action.Delete;
        }
   }
}
