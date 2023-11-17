using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Emloy
    {
        private int id_;
        private string name_;
        private string sex_;
        private string address_;
        private string position_;
        private string status_;

        public Emloy()
        {
            id_ = 0;
            name_ = string.Empty;
            sex_ = string.Empty;
            address_ = string.Empty;
            position_ = string.Empty;
            status_ = string.Empty;
        }

        public int Id
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

        public string Address
        {
            set { address_ = value; }
            get { return address_; }
        }
        public string Position
        {
            set { position_ = value; }
            get { return position_; }
        }
        public string Status
        {
            set { status_ = value; }
            get { return status_; }
        }

    }
}
