using System.ComponentModel.DataAnnotations;

namespace CrudUniversity.Models
{
    public enum Grade
    {
        A,B,C,D,E,F
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [EnumDataType(typeof(Grade), ErrorMessage = "La calificación no es válida.")]
        public Grade? Grade { get; set; }
        public Course? Course { get; set; }
        public Student? Student { get; set; }
    }
}
