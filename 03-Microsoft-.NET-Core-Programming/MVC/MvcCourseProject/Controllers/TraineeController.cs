using Microsoft.AspNetCore.Mvc;
using MvcCourseProject.Models.BusinessLayers;
using MvcCourseProject.Models.DBModels;
using MvcCourseProject.Repository;
using MvcCourseProject.ViewModels;

namespace MvcCourseProject.Controllers
{
    public class TraineeController : Controller
    {
        ITraineeRepository TraineeRepo;
        ICrsResultRepository CrsResultRepo;
        ICourseRepository CourseRepo;

        public TraineeController(ITraineeRepository _traineeRepo , ICrsResultRepository _crsResRepo , ICourseRepository _courseRepo)
        {
            TraineeRepo = _traineeRepo;
            CrsResultRepo = _crsResRepo;
            CourseRepo = _courseRepo;
        }
        public IActionResult GetAllTrainees()
        {
            return View("GetAllTrainees",TraineeRepo.GetAll());
        }

        public IActionResult TraineeResult(int tid , int cid)
        {
            CrsResult result = CrsResultRepo.GetCrsResultByCourseIdAndTraineeId(tid, cid);
            if (result == null)
            {
                return NotFound("Result not found");
            }
            Trainee trainee = TraineeRepo.GetById(tid);
            if (trainee == null) {
                return NotFound("Trainee not found");
            }
            Course course = CourseRepo.GetById(cid);
            if (course == null)
            {
                return NotFound("Course not found");
            }

            TraineeDataViewModel traineeDataViewModel = new TraineeDataViewModel
            {
                TraineeName = trainee.Name,
                CourseName = course.Name,
                Image = trainee.Img,
                Degree = result.Degree,
                Color = (result.Degree >=course.MinDegree)?"green": "red",
                Status = (result.Degree >= course.MinDegree) ? "pass" : "fail",
            };
            return View("TraineeResult", traineeDataViewModel);
        }

        public IActionResult SpecificTraineeAllResults(int tid)
        {
            var trainee = TraineeRepo.GetById(tid);
            if (trainee == null)
            {
                return NotFound("Trainee not found");
            }

            var results = CrsResultRepo.GetCrsResultsByTraineeId(tid);
            List<TraineeDataViewModel> viewModelList = new List<TraineeDataViewModel>();

            foreach (var item in results)
            {
                var course = CourseRepo.GetById(item.Crs_Id);
                var traineeDataViewModel = new TraineeDataViewModel
                {
                    TraineeName = trainee.Name,
                    TraineeId = trainee.Id,
                    CourseName = course.Name,
                    CourseId = course.Id,
                    Image = trainee.Img,
                    Degree = item.Degree,
                    Color = (item.Degree >= course.MinDegree) ? "green" : "red",
                    Status = (item.Degree >= course.MinDegree) ? "pass" : "fail",
                };

                viewModelList.Add(traineeDataViewModel);
            }

            return View("SpecificTraineeAllResults", viewModelList);
        }

       
    }
}
