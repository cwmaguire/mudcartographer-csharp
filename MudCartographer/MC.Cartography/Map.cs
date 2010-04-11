using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MC.Cartography;

namespace MudCartographer
{
    public class Map
    {
        ArrayList rooms;
        ArrayList links;

        ArrayList selectedRooms;


        public Map()
        {
            rooms = new ArrayList();
            links = new ArrayList();
            selectedRooms = new ArrayList();
        }

        public IList Rooms { get { return rooms; } }
        public IList Links { get { return links; } }
        public IList SelectedRooms { get { return links; } }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public void AddLink(Link link)
        {
            links.Add(link);
        }
        public void AddLink(Room startRoom, Room endRoom)
        {
            AddLink(new Link(startRoom, endRoom));
        }

        public int GetNumberOfRooms()
        {
            return rooms.Count;
        }
        public int GetNumberOfLinks()
        {
            return links.Count;
        }
        public void DeleteRoomsAndLinks()
        {
            rooms.Clear();
            links.Clear();            
        }
        public void DeleteRoomsLinksAndSelection()
        {
            DeleteRoomsAndLinks();
            DeleteSelectedRooms();
        }

        public ArrayList GetSelectedRooms()
        {
            return selectedRooms;
        }

        public void DeleteSelectedRooms()
        {
            selectedRooms.Clear();
        }
        
        public void AddRoomToSelectedRoom(Room roomToSelect)
        {
            selectedRooms.Add(roomToSelect);
        }
        public void SelectASingleRoom(Room roomToSelect)
        {
            DeleteSelectedRooms();
            AddRoomToSelectedRoom(roomToSelect);
        }

        public void LinkRoomToSelectedRooms(Room roomToLink)
        {
            if (selectedRooms.Count == 0) return;
            foreach (Room roomStart in selectedRooms)
            {
                this.AddLink(roomStart, roomToLink);
            }
            
        }

        public void SelectRoomNearPoint(double X, double Y, double Z)
        {
            SelectRoomNearPoint(new Point3D(X, Y, Z));
        }

        public void SelectRoomNearPoint(Point3D nearPoint)
        {
            selectedRooms.Clear();
            Room roomNearPoint = GetClosestRoomToPoint(nearPoint);
            if (roomNearPoint != null)
                AddRoomToSelectedRoom(roomNearPoint);
        }
        public bool ARoomIsNearPoint(Point3D nearPoint)
        {
            return GetClosestRoomToPoint(nearPoint) != null;
        }
        public void DeleteRoom(Room roomToRemove)
        {
            rooms.Remove(roomToRemove);
            selectedRooms.Remove(roomToRemove);
            RemoveLinksWithRoom(roomToRemove);
        }
        private void RemoveLinksWithRoom(Room roomToRemove)
        {
            ArrayList linksToRemove = new ArrayList();
            foreach (Link linkToCheck in this.Links)
            {
                if (linkToCheck.Contains(roomToRemove))
                    linksToRemove.Add(linkToCheck);
            }
            foreach(Link linkToRemove in linksToRemove)
                this.Links.Remove(linkToRemove);
        }


        // This function will find the closest room from a geographical position in space.
        public Room GetClosestRoomToPoint(Point3D pointOfComparison)
        {            
            Room RoomMin = null;
            Room result;
            double DistanceMin = -1;
            foreach (Room R in Rooms)
            {
                if (pointOfComparison.Z == R.Z)
                {
                    double DistanceTemp = Point3D.DistanceBetween(R.Position, pointOfComparison);
                    if (DistanceMin == -1 || DistanceMin > DistanceTemp)
                    {
                        DistanceMin = DistanceTemp;
                        RoomMin = R;
                    }
                }
            }
            result = DistanceMin <= 2 * Constants.RADIUS ? RoomMin : null;
            return result;
        }

    }
}
