using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class students
    {
        private int id_;
        private string name_;
        private string sex_;
        private string college_;
        private string address_;
        private int room_Num_;
        private string status_;

        public students()
        {
            id_ = 0;
            name_ = string.Empty;
            sex_ = string.Empty;
            college_ = string.Empty;
            address_ = string.Empty;
            room_Num_ = 0;
            status_ = string.Empty;
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

        public string Sex
        {
            set { sex_ = value; }
            get { return sex_; }
        }

        public string College
        {
            set { college_ = value; }
            get { return college_; }
        }

        public string Address
        {
            set { address_ = value; }
            get { return address_; }
        }

        public int RoomNum
        {
            set { room_Num_ = value; }
            get { return room_Num_; }
        }

        public string Status
        {
            set { status_ = value; }
            get { return status_; }
        }
    }
}
