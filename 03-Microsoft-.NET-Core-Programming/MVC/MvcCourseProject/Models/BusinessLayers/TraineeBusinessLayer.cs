using Microsoft.EntityFrameworkCore;
using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Models.BusinessLayers
{
    //public static class TraineeBusinessLayer
    //{
    //    private static LearnContext db = new LearnContext();
    //    public static List<Trainee> GetAllTrainees()
    //    {
    //        return db.Trainees
    //            .Include(t => t.Department)
    //            .ToList();
    //    }

    //    public static Trainee GetTraineeById(int id)
    //    {
    //        return db.Trainees.FirstOrDefault(t => t.Id == id);
    //    }

    //    public static List<Trainee> GetMultipleTrainees(List<int> ids)
    //    {
    //        return db.Trainees
    //            .Where(t => ids.Contains(t.Id))
    //            .ToList();
    //    }
    //}
}
