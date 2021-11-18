using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Badge
    {
        public int BadgeID { get; set; }
        public bool DoorA1 { get; set; }
        public bool DoorA2 { get; set; }
        public bool DoorA3 { get; set; }
        public bool DoorA4 { get; set; }
        public bool DoorA5 { get; set; }
        public bool DoorB1 { get; set; }
        public bool DoorB2 { get; set; }
        public bool DoorB3 { get; set; }
        public bool DoorB4 { get; set; }
        public bool DoorB5 { get; set; }

        public Badge(int badgeID, bool doorA1, bool doorA2, bool doorA3, bool doorA4, bool doorA5, bool doorB1, bool doorB2, bool doorB3, bool doorB4, bool doorB5)
        {
            BadgeID = badgeID;
            DoorA1 = doorA1;
            DoorA2 = doorA2;
            DoorA3 = doorA3;
            DoorA4 = doorA4;
            DoorA5 = doorA5;
            DoorB1 = doorB1;
            DoorB2 = doorB2;
            DoorB3 = doorB3;
            DoorB4 = doorB4;
            DoorB5 = doorB5;

        }

        public Badge()
        {
        }
    }
}
