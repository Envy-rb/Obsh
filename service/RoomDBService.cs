using Obsh.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsh.service
{
    class RoomDBService
    {
        private static string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=resource\database\hostel\HostelDB.mdb";
        public static void executeQuery(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static void queryAdd(Room room)
        {
            string query;
            int roomId;

            query = string.Format("INSERT INTO Room ([Number], Capacity, Price) VALUES ('{0}','{1}','{2}')", room.Number, room.Capacity, room.Price);
            executeQuery(query);
            roomId = getRoomId(room);

            foreach (Student student in room.Students)
            {
                StudentDBService.queryAdd(student, roomId);
            }

        }

        public static DataSet getRooms()
        {
            string query;

            query = string.Format("SELECT * FROM Room");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            return ds;
        }

        public static void queryRemove(Room room)
        {
            string query;

            query = string.Format("DELETE * FROM Room WHERE Room.Number = '{0}'", room.Number);
            executeQuery(query);
        }

        public static void queryRemove(int index)
        {
            string query;

            query = string.Format("DELETE * FROM Room WHERE Room.Id = {0}", index);
            executeQuery(query);
        }

        public static void queryClear()
        {
            string query;

            query = "DELETE * FROM Room";
            executeQuery(query);
        }

        public static int getRoomId(Room room)
        {
            int result;
            string query;

            query = string.Format("SELECT Room.Id FROM Room WHERE Room.Number = '{0}'", room.Number);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Id");
            int.TryParse(ds.Tables[0].Rows[0][0].ToString(), out result);

            return result;
        }
    }
}
