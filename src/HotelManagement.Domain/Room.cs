﻿using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Room : Entity
    {
        public string Name { get; set; }
        public int Status { get; set; }

        public int TypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<RoomReceipt> RoomReceipts { get; set; }
    }
}