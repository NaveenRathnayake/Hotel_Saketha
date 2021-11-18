using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saketha_Hotel_System_Try_1.Reception
{


    class Room
    {
        //member variables
        public int room_id;
        public int room_number;
        public string room_type;
        public float price;
        public Boolean is_booked;

        //default 
        public Room()
        {

        }

        public Room(int room_id, int room_number, string room_type, float price, bool is_booked)
        {
            this.room_id = room_id;
            this.room_number = room_number;
            this.room_type = room_type;
            this.price = price;
            this.is_booked = is_booked;
        }


    }
}
