using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
	public class Adress
	{
        [Key]
        public int Adress_Id { get; set; }
        public string? City { get; set; }
        public string? Town { get; set; }   
        public string? Neighbourhood { get; set; }   
        public string? Street { get; set; }
        public int NO { get; set; }
        public int Apartment { get; set; }
        public bool Status { get; set; }
        public List<Student>? Students { get; set; }
        public List<Teacher>? Teachers { get; set; }
        public List<Parent>? Parents { get; set; }
    }
}
