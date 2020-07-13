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
    class DBService
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

        public static void clearDB()
        {
            RoomDBService.queryClear();
            StudentDBService.queryClear();
        }

        public static void writeDB(List<Room> rooms)
        {
            clearDB();
            foreach (Room room in rooms)
            {
                RoomDBService.queryAdd(room);
            }
        }

        public static void writeDraft(Room room, Student student)
        {
            string query;

            query = string.Format("INSERT INTO Draft([Дата заселения], [Стоимость проживания], [ФИО], [Комната]) VALUES ('{0}', '{1}', '{2}', '{3}')", DateTime.Now.ToShortDateString(), room.Price, student.ToString(), room.Number);
            executeQuery(query);
        }

        public static DataSet getDraft()
        {
            string query;

            query = string.Format("SELECT * FROM Draft");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds;
        }
    }
}
