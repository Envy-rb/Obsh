using Obsh.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsh.parser
{
    class RoomParser
    {
        public static Room parseRoom(string number, string capacity, string price, List<Student> students)
        {
            Room result;
            int roomNumber;
            int roomCapacity;
            double roomPrice;

            int.TryParse(number, out roomNumber);
            int.TryParse(capacity, out roomCapacity);
            double.TryParse(price, out roomPrice);
            result = new Room(roomNumber, roomCapacity, roomPrice, students);
            return result;
        }

        public static Room parseRoom(string number, string capacity, string price)
        {
            Room result;
            int roomNumber;
            int roomCapacity;
            double roomPrice;

            int.TryParse(number, out roomNumber);
            int.TryParse(capacity, out roomCapacity);
            double.TryParse(price, out roomPrice);
            result = new Room(roomNumber, roomCapacity, roomPrice);
            return result;
        }
    }
}
