using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Concrate
{
    public class Parent
	{
		[Key]
        public int Parent_Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public int TCKNO { get; set; }
        public int Phone { get; set; }  
        [ForeignKey("Town")]
        public int Hometown_Id { get; set; }
        public Town? Hometown { get; set; }
        [ForeignKey("Adress")]
        public int Adress_Id { get; set; }
        public Adress? Adress { get; set; }
        public List<Student>? Students { get; set; }
    }
}
