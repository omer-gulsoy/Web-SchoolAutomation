using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
	public class Student
	{
		[Key]
		public int Student_Id { get; set; }
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public int TCKNO { get; set; }
		public int Phone { get; set; }
		public string? Mail { get; set; }
		public bool Status { get; set; }
		public List<Student_Lesson>? Student_Lessons { get; set; }
		[ForeignKey("Grade")]
		public int Grade_Id { get; set; }
		public Grade? Grade { get; set; }
	}
}
