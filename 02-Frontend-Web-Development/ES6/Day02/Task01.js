/**====================== Task 01 ======================== */
function generateCourse(options) {
  let defParams = {
    courseName: "default Course Name",
    courseDuration: "default Course Duration",
    courseOwner: "default Course Owner",
  };

  let course = Object.assign(defParams, options);
  return course;
}

console.log(
  generateCourse({
    courseName: "JavaScript",
    courseDuration: "2 weeks",
    courseOwner: "Mustafa Hegazy",
  })
);
