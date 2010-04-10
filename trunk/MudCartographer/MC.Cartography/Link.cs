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

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;
            
            Link link = (Link)obj;

            return link.startRoom.Equals(startRoom) && link.endRoom.Equals(endRoom);
        }
        
    }
}
