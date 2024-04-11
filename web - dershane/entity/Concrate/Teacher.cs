using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
	public class Teacher
	{
		[Key]
        public int Teacher_Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int TCKNO { get; set; }
        public int Phone { get; set; }
        public string? Mail { get; set; }
        public bool Status { get; set; }
        public List<Class_Teacher>? Class_Teachers { get; set; }
        [ForeignKey("Mission")]
        public int Mission_Id { get; set; }
        public Mission? Mission { get; set; }
    }
}
