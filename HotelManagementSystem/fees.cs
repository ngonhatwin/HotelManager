using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class fees
    {
        private int id_;
        private string name_;
        private string usn_;
        private int room_Number_;
        private DateTime month_;
        private int amount_;

        public fees()
        {
            id_ = 0;
            name_ = string.Empty;
            usn_ = string.Empty;
            room_Number_ = 0;
            amount_ = 0;
        }

        public int ID
        {
            set { id_ = value; }
            get { return id_; }
        }

        public string Name
        {
            set { name_ = value; }
            get { return name_; }
        }

        public string USN
        {
            set { usn_ = value; }
            get { return usn_; }
        }

        public int RoomNumber
        {
            set { room_Number_ = value; }
            get { return room_Number_; }
        }

        public DateTime Month
        {
            set { month_ = value; }
            get { return month_; }
        }

        public int Amount
        {
            set { amount_ = value; }
            get { return amount_; }
        }
    }
}
