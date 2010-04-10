using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MudCartographer
{
    public class Link
    {
        public Room startRoom;
        public Room endRoom;

        public Link(Room startRoom, Room endRoom)
        {
            this.startRoom = startRoom;
            this.endRoom = endRoom;
        }

        public bool equals(Object o)
        {
            return o.GetType().Equals(Link) && ((Link)o).startRoom.Equals(startRoom) && ((Link)o).endRoom.Equals(endRoom);
        }
        
    }
}
