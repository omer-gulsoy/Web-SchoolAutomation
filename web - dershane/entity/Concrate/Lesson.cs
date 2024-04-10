using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
	public class Lesson
	{
		[Key]
		public int Lesson_Id { get; set; }
		public string? Name { get; set; }
		public bool Status { get; set; }
		public List<Student_Lesson>? Student_Lessons { get; set; }
		[ForeignKey("Course")]
		public int Course_Id { get; set; }
		public Course? Course { get; set; }
		[ForeignKey("Grade")]
		public int Grade_Id { get; set; }
		public Grade? Grade { get; set; }
	}
}
