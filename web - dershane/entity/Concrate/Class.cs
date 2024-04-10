using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
	public class Class
	{
        [Key]
        public int Class_Id { get; set; }
        public string? Name { get; set; }
        public int Floor { get; set; }
        public bool Status { get; set; }
        public List<Class_Teacher>? Class_Teachers { get; set; }
    }
}
