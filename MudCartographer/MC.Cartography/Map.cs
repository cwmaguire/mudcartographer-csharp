using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MudCartographer
{
    public class Map
    {
        ArrayList rooms;
        ArrayList links;

        public Map()
        {
            rooms = new ArrayList();
            links = new ArrayList();
        }

        public IList Rooms { get { return rooms; } }
        public IList Links { get { return links; } }

        public void addRoom(Room room)
        {
            rooms.Add(room);
        }
        public void addLink(Link link)
        {
            links.Add(link);
        }

        public int getNumberofRooms()
        {
            return rooms.Count;
        }
        public int getNumberOfLinks()
        {
            return links.Count;
        }
        public void Clear()
        {
            rooms.Clear();
            links.Clear();
        }
    }
}
