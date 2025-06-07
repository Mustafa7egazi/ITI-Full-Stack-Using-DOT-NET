using Microsoft.EntityFrameworkCore;
using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Models.BusinessLayers
{
    //public static class CourseBusinessLayer
    //{
    //    private static LearnContext db = new LearnContext();

    //    public static List<Course> GetAllCourses()
    //    {
    //        return db.Courses
    //            .Include(c => c.Department)
    //            .Include(c => c.Instructors)
    //            .ToList();
    //    }

    //    public static Course? GetCourseById(int id)
    //    {
    //        return db.Courses
    //            .Include(c => c.Department)
    //            .Include(c => c.Instructors)
    //            .FirstOrDefault(c => c.Id == id);
    //    }

    //    public static Course? GetCourseByNameAndDeptId(string name, int deptId)
    //    {
    //        return db.Courses.FirstOrDefault(c => c.Name == name && c.DepartmentId == deptId);
    //    }

    //    public static void AddNewCourse(Course course)
    //    {

    //        db.Courses.Add(course);
    //        db.SaveChanges();

    //    }


    //}
}
