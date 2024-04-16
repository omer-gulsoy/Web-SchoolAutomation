using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity.Abstract;
using entity.Apstract;

namespace entity.Concrate
{
	public class Teacher
	{
		[Key]
		public int Teacher_Id { get; set; }
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public int TCKNO { get; set; }
		public DateTime BirthDay { get; set; }
		public int Phone { get; set; }
		public string? Mail { get; set; }
		public bool Status { get; set; }
		[ForeignKey("Town")]
		public int Hometown_Id { get; set; }
		public Town? Hometown { get; set; }
		[ForeignKey("Lesson")]
		public int Lesson_Id { get; set; }
		public Lesson? Lesson { get; set; }
		[ForeignKey("Adress")]
		public int Adress_Id { get; set; }
		public Adress? Adress { get; set; }
        public List<Syllabus>? Syllabus { get; set; }
	}
}
