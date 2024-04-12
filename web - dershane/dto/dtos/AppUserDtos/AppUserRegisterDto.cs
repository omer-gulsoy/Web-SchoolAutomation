using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto.dtos.AppUserDtos
{
	public class AppUserRegisterDto
	{
		//ad,soyad,e-posta,parola
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? UserName { get; set; }
		public string? Password { get; set; }
		public string? ConfirmPassword { get; set; }
	}
}
