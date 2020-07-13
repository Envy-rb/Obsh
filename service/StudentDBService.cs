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
    class StudentDBService
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

        public static DataSet getStudents()
        {
            string query;

            query = string.Format("SELECT * FROM Student");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            return ds;
        }

        public static DataSet getStudentsFromRoom(Room room)
        {
            string query;
            int roomIndex;
            roomIndex = RoomDBService.getRoomId(room);

            query = string.Format("SELECT * FROM Student WHERE roomId = {0}", roomIndex);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            return ds;
        }


        public static DataSet getStudentsFromRoom(int roomIndex)
        {
            string query;

            query = string.Format("SELECT * FROM Student WHERE roomId = {0}", roomIndex);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            return ds;
        }
        public static void queryAdd(Student student, int roomIndex)
        {
            string query;

            query = string.Format("INSERT INTO Student ( name, surname, midname, roomId ) VALUES('{0}', '{1}', '{2}', {3})", student.Name, student.Surname, student.Midname, roomIndex);
            executeQuery(query);
        }

        public static void queryRemove(int id)
        {
            string query;

            query = string.Format("DELETE * FROM Student WHERE Student.id = {0}", id);
            executeQuery(query);
        }

        public static void queryClear()
        {
            string query;

            query = "DELETE * FROM Student";
            executeQuery(query);
        }
    }
}
