using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
    public class Adress
	{
		[Key]
        public int Adress_Id { get; set; }
        public string? Town { get; set; }
        public string? Neighbourhood { get; set; }
        public string? Street { get; set; }
        public int No { get; set; }
        public int Apartment { get; set; }
        [ForeignKey("Town")]
		public int City_Id { get; set; }
		public Town? City { get; set; }
        public List<Student>? Student { get; set; }
        public List<Teacher>? Teacher { get; set; }
        public List<Parent>? Parent { get; set; }
    }
}
