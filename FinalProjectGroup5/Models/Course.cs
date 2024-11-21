namespace FinalProjectGroup5.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Professor { get; set; }
        public string Building {  get; set; }
        public string Time {  get; set; }

        public Course() { }

        public Course(int courseId, string courseName, string professor, string building, string time)
        {
            CourseId = courseId;
            CourseName = courseName;
            Professor = professor;
            Building = building;
            Time = time;
        }
    }
}
