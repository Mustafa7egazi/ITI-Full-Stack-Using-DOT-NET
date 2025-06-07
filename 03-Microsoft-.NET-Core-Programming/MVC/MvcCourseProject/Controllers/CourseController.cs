using Microsoft.AspNetCore.Mvc;
using MvcCourseProject.Models.BusinessLayers;
using MvcCourseProject.Models.DBModels;
using MvcCourseProject.Repository;
using MvcCourseProject.ViewModels;

namespace MvcCourseProject.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository CourseRepo;
        private IDepartmentRepository DeptsRepo;
        private ICrsResultRepository CrsResultRepo;
        private ITraineeRepository TraineeRepo;
        private IInstructorRepository InstructorRepo;

        public CourseController(IDepartmentRepository _deptsRepo, ICourseRepository _courseRepo
            ,ICrsResultRepository _crsResultRepo, ITraineeRepository _traineeRepo , IInstructorRepository _instructorRepo)
        {
            DeptsRepo = _deptsRepo;
            CourseRepo = _courseRepo;
            CrsResultRepo = _crsResultRepo;
            TraineeRepo = _traineeRepo;
            InstructorRepo = _instructorRepo;
        }
        public IActionResult GetAllCourses()
        {
            return View("GetAllCourses", CourseRepo.GetAll());
        }
        public IActionResult SpecificCourseAllStudentsResult(int cid)
        {
            Course? course = CourseRepo.GetById(cid);

            List<Trainee> traineesAtSpecificCourse = TraineeRepo
                .GetMultipleTrainees(CrsResultRepo.AllTraineesIdsInCourse(cid));

            List<TraineeDataViewModel> viewModelList = new List<TraineeDataViewModel>();

            foreach (var trainee in traineesAtSpecificCourse)
            {
                CrsResult result = CrsResultRepo.GetCrsResultByCourseIdAndTraineeId(trainee.Id, cid);
                TraineeDataViewModel traineeDataViewModel = new TraineeDataViewModel
                {
                    TraineeName = trainee.Name,
                    CourseName = course?.Name,
                    Image = trainee.Img,
                    Degree = result.Degree,
                    Color = (result.Degree >= course?.MinDegree) ? "green" : "red",
                    Status = (result.Degree >= course?.MinDegree) ? "pass" : "fail",
                };


                viewModelList.Add(traineeDataViewModel);
            }

            return View("SpecificCourseAllStudentsResult", viewModelList);
        }
    
        public IActionResult AddNewCoursePage()
        {
            ViewBag.Departments = DeptsRepo.GetAll();
            return View("AddNewCoursePage");
        }

        public IActionResult CheckMinDegreeInRange(int MinDegree,int Degree)
        {
            if (MinDegree>= Degree)
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveNewCourse(Course courseFromReq)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CourseRepo.Add(courseFromReq);
                    CourseRepo.Save();
                    return RedirectToAction("GetAllCourses");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("erro1", ex.InnerException.Message);
                }
            }
            ViewBag.Departments = DeptsRepo.GetAll();
            return View("AddNewCoursePage", courseFromReq);
        }
    }
}
