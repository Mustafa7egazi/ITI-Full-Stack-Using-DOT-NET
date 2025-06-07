using Microsoft.EntityFrameworkCore;
using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Models.BusinessLayer
{
    //public static class InstructorBusinessLayer
    //{
    //    private static LearnContext db = new LearnContext();
    //    public static List<Instructor> GetAllInstructors()
    //    {
    //        return db.Instructors.ToList();
    //    }
    //    public static Instructor? GetInstructorById(int id)
    //    {
    //        return db.Instructors
    //            .Include(i => i.Department)
    //            .Include(i => i.Course)
    //            .FirstOrDefault(i => i.Id == id);
    //    }

    //    public static void AddInstructor(Instructor instructor)
    //    {
    //        db.Instructors.Add(instructor);
    //        db.SaveChanges();
    //    }

    //    public static void UpdateInstructor(Instructor instructor)
    //    {
    //        db.Instructors.Update(instructor);
    //        db.SaveChanges();
    //    }

    //    public static void DeleteInstructor(int id)
    //    {
    //        Instructor? instructor = db.Instructors.Find(id);
    //        if (instructor != null)
    //        {
    //            db.Instructors.Remove(instructor);
    //            db.SaveChanges();
    //        }
    //    }
    //}
}
