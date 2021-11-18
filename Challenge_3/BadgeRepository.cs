using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class BadgeRepository
    {
        private List<Badge> _listOfBadges = new List<Badge>();

        //Create
        public void AddBadgeToList(Badge badge)
        {
            _listOfBadges.Add(badge);
        }

        //Read
        public List<Badge> GetBadges()
        {
            return _listOfBadges;
        }
        //Update
        public bool UpdateExistingBadge(int originalBadgeID, Badge newBadge)
        {
            Badge oldBadge = GetBadgeByBadgeID(originalBadgeID);

            if(oldBadge != null)
            {
                oldBadge.BadgeID = newBadge.BadgeID;
                oldBadge.DoorA1 = newBadge.DoorA1;
                oldBadge.DoorA2 = newBadge.DoorA2;
                oldBadge.DoorA3 = newBadge.DoorA3;
                oldBadge.DoorA4 = newBadge.DoorA4;
                oldBadge.DoorA5 = newBadge.DoorA5;
                oldBadge.DoorB1 = newBadge.DoorB1;
                oldBadge.DoorB2 = newBadge.DoorB2;
                oldBadge.DoorB3 = newBadge.DoorB3;
                oldBadge.DoorB4 = newBadge.DoorB4;
                oldBadge.DoorB5 = newBadge.DoorB5;

                return true;
            }
            else
            {
                return false;
            }
        }

        private Badge GetBadgeByBadgeID(object oldBadgeID)
        {
            throw new NotImplementedException();
        }

        //Delete
        public bool RemoveBadgeFromList(int badgeID)
        {
            Badge badge = GetBadgeByBadgeID(badgeID);

            if (badge == null)
            {
                return false;
            }

            int initialCount = _listOfBadges.Count;
            _listOfBadges.Remove(badge);

            if (initialCount > _listOfBadges.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Helper Method
        private Badge GetBadgeByBadgeID(int badgeID)
        {
            foreach (Badge badge in _listOfBadges)
            {
                if (badge.BadgeID == badgeID)
                {
                    return badge;
                }
            }
            return null;
        }

        internal void UpdateExistingBadge(object originalBadgeID, Badge newbadge)
        {
            throw new NotImplementedException();
        }
    }
}
