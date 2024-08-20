namespace backend.Models
{
    public class Course
    {

        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
         

        public Course(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }

        
    }
}
