using Microsoft.EntityFrameworkCore;
using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Models.BusinessLayers
{
    //public static class CrsResultBusinessLayer
    //{
    //    private static LearnContext db = new LearnContext();
    //    public static List<CrsResult> GetAllCrsResults()
    //    {
    //        return db.CrsResults.ToList();
    //    }
    //    public static CrsResult GetCrsResultByCourseIdAnd(int tid , int cid)
    //    {
    //        return db.CrsResults
    //            .Where(crs => crs.Trainee_Id == tid && crs.Crs_Id == cid)
    //            .FirstOrDefault();
    //    }

    //    public static List<CrsResult> GetCrsResultsByTraineeId(int traineeId)
    //    {
    //        return db.CrsResults
    //            .Where(crs => crs.Trainee_Id == traineeId)
    //            .ToList();
    //    }

    //    public static List<int> AllTraineesIdsInCourse(int cid)
    //    {
    //        return db.CrsResults
    //            .Where(crs => crs.Crs_Id == cid)
    //            .Select(crs => crs.Trainee_Id)
    //            .ToList();
    //    }
    //}
}
