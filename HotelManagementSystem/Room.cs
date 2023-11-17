using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public partial class Room
    {
        private int room_Number_;
        private string room_Status_;
        private string booked_;

        public Room()
        {
            room_Number_ = 0;
            room_Status_ = string.Empty;
            booked_ = string.Empty;
        }

        public int RoomNumber
        {
            set { room_Number_ = value; }
            get { return room_Number_; }
        }
        public string RoomStatus
        {
            set { room_Status_ = value; }
            get { return room_Status_; }
        }
        public string Booked
        {
            set { booked_ = value; }
            get { return booked_; }
        }
    }
}
