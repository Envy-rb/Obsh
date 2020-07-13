using Obsh.entity;
using Obsh.parser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsh.service
{
    class RoomService
    {
        public List<Room> rooms = new List<Room>();

        public void parseRooms()
        {
            rooms.Clear();
            DataSet input = RoomDBService.getRooms();
            foreach (DataRow row in input.Tables[0].Rows)
            {
                Room room = RoomParser.parseRoom(row[1].ToString(), row[2].ToString(), row[3].ToString());
                List<Student> students = new List<Student>();
                DataSet data = StudentDBService.getStudentsFromRoom(room);
                students = StudentService.parseStudents(data);
                room.Students = students;
                rooms.Add(room);
            }
        }
    }
}
