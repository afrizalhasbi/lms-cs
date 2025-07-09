namespace Application.DataObj.Course
{
    public class SearchCoursesDataObj
    {
        public String? CourseName { get; set; }
        public String? Category { get; set; }
        public String? Tags { get; set; }
        public String? Difficulty { get; set; }
    }

    public class CourseDetailsDataObj
    {
        required public String CourseName { get; set; }
    }

    public class EnrollCourseDataObj
    {
        required public String CourseName { get; set; }
        required public String UserName { get; set; }
        required public String? JwtToken { get; set; }
    }

    public class CourseModulesDataObj { }

}
