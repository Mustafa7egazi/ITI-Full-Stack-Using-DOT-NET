using AdoD1.Models;
using System.Data;

namespace Day02_ADO__simpleCRUD.Models
{
    internal class CourseBussines
    {
        //DQL all
        public static DataTable RetrieveAllCourses()
        {
            return DBLayer.DQL("select * from course");
        }

        public static DataTable RetrieveAllTopics()
        {
            return DBLayer.DQL("select * from topic");
        }


        //DQL by id
        public static DataTable GetCourseById(int id)
        {
            return DBLayer.DQL($"select * from course where id={id}");
        }


        //InsertCourse

        public static int InsertCourse(string crs_name, int crs_duration, int top_id)
        {
            return DBLayer.DML($"insert into course values('{crs_name}',{crs_duration},'{top_id}')");
        }

        public static int UpdateCourse(int crs_id, string crs_name, int crs_duration, int top_id)
        {
            return DBLayer.DML($"UPDATE course SET " +
                             $"crs_name='{crs_name}', crs_duration={crs_duration}," +
                             $" top_id={top_id} WHERE crs_id={crs_id}");
        }

        public static int DeleteCourseById(int crs_id)
        {
            return DBLayer.DML($"delete from course where crs_id={crs_id}");
        }

        public static int DeleteTopicById(int top_id)
        {
            try
            {
                
               DBLayer.DML($"DELETE FROM ins_course WHERE crs_id IN " +
                           $"(SELECT crs_id FROM course WHERE top_id = {top_id})");

               
                DBLayer.DML($"DELETE FROM course WHERE top_id = {top_id}");

              
                return DBLayer.DML($"DELETE FROM topic WHERE top_id = {top_id}");
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"Error deleting topic: {ex.Message}");
                return -1; 
            }
        }
    }
}
