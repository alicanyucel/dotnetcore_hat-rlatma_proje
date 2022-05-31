using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsminizi Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Emailinizi Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon Numaranızı Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Kursa Katılıp Katılmayacağınızı Bilmemiz Gerekiyor")]
        public bool? WillAttend { get; set; }
    }
}
