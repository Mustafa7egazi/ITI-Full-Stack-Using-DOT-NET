using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MvcCourseProject.Models.BusinessLayer;
using MvcCourseProject.Models.BusinessLayers;
using MvcCourseProject.Models.DBModels;
using MvcCourseProject.Repository;
using MvcCourseProject.ViewModels;

namespace MvcCourseProject.Controllers
{

    public class InstructorController : Controller
    {
        private IInstructorRepository InstructorRepo;
        private IDepartmentRepository DeptsRepo;
        private ICourseRepository CourseRepo;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public InstructorController(IWebHostEnvironment _webHost,
            IInstructorRepository _insRepo, IDepartmentRepository _deptsRepo, ICourseRepository _courseRepo)
        {
            _webHostEnvironment = _webHost;
            InstructorRepo = _insRepo;
            DeptsRepo = _deptsRepo;
            CourseRepo = _courseRepo;
        }

        public IActionResult GetAllInstructors()
        {
            return View("ShowAllInstructors", InstructorRepo.GetAll());
        }

        public IActionResult GetInstructorById(int id)
        {
            Instructor? instructor = InstructorRepo.GetById(id);
            if (instructor == null)
            {
                return NotFound();
            }
            return View("ShowInstructorDetails", instructor);
        }

        public IActionResult AddInstructorForm()
        {
            InstructorWithDeptsAndCoursesViewModel instructorVM = new InstructorWithDeptsAndCoursesViewModel();
            instructorVM.DepartmentsList = DeptsRepo.GetAll();
            instructorVM.CoursesList = CourseRepo.GetAll();
            return View("AddInstructor", instructorVM);
        }

        [HttpPost]
        public IActionResult SaveNewInstructor(Instructor instructorFromReq, IFormFile ImgFile)
        {

            if (ImgFile != null && ImgFile.Length > 0)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + ImgFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    ImgFile.CopyTo(fileStream);
                }
                instructorFromReq.Img = uniqueFileName;
            }

            if (!(instructorFromReq.Name.IsNullOrEmpty() || instructorFromReq.Salary.ToString().IsNullOrEmpty()
                || instructorFromReq.Img.IsNullOrEmpty() || instructorFromReq.Address.IsNullOrEmpty())
                || instructorFromReq.Crs_id.ToString().IsNullOrEmpty()
                || instructorFromReq.DepartmentId.ToString().IsNullOrEmpty())
            {
                InstructorWithDeptsAndCoursesViewModel instrutorVM = new InstructorWithDeptsAndCoursesViewModel();
                instrutorVM.Id = instructorFromReq.Id;
                instrutorVM.Name = instructorFromReq.Name;
                instrutorVM.Address = instructorFromReq.Address;
                instrutorVM.Img = instructorFromReq.Img;
                instrutorVM.Salary = instructorFromReq.Salary;
                instrutorVM.DepartmentId = instructorFromReq.DepartmentId;
                instrutorVM.Crs_id = instructorFromReq.Crs_id;

                InstructorRepo.Add(instructorFromReq);
                InstructorRepo.Save();
                return RedirectToAction("GetAllInstructors", InstructorRepo.GetAll());
            }

            return View("AddInstructor", instructorFromReq);

        }

        [HttpGet]
        public IActionResult EditInstructorInfo(int id)
        {
            Instructor? instructor = InstructorRepo.GetById(id);
            if (instructor == null)
            {
                return NotFound();
            }
            InstructorWithDeptsAndCoursesViewModel instructorVM = new InstructorWithDeptsAndCoursesViewModel();
            instructorVM.DepartmentsList = DeptsRepo.GetAll();
            instructorVM.CoursesList = CourseRepo.GetAll();
            instructorVM.Id = instructor.Id;
            instructorVM.Name = instructor.Name;
            instructorVM.Address = instructor.Address;
            instructorVM.Img = instructor.Img;
            instructorVM.Salary = instructor.Salary;
            instructorVM.DepartmentId = instructor.DepartmentId;
            instructorVM.Crs_id = instructor.Crs_id;
            return View("EditInstructorInfo", instructorVM);
        }

        [HttpPost]
        public IActionResult EditInstructorInfo(int id, Instructor instructorFromReq, IFormFile ImgFile)
        {
            Instructor? instructor = InstructorRepo.GetById(id);
            if (instructor == null)
            {
                return NotFound();
            }
            else
            {

                if (ImgFile != null && ImgFile.Length > 0)
                {
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");

                    // Delete the existing file if it exists
                    if (!string.IsNullOrEmpty(instructor.Img))
                    {
                        string oldFilePath = Path.Combine(uploadsFolder, instructor.Img);
                        if (System.IO.File.Exists(oldFilePath))
                        {
                            System.IO.File.Delete(oldFilePath);
                        }
                    }


                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + ImgFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        ImgFile.CopyTo(fileStream);
                    }
                    instructorFromReq.Img = uniqueFileName;
                }


                InstructorRepo.Update(instructorFromReq);
                InstructorRepo.Save();
            }

            return RedirectToAction("GetAllInstructors");
        }

        public IActionResult DeleteInstructor(int id)
        {
            InstructorRepo.Delete(id);
            InstructorRepo.Save();
            return RedirectToAction("GetAllInstructors");
        }
    }
}
