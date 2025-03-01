using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {

        [BindNever]
        public int id { set; get; }

        [Display(Name = "Введіть ім'я")]
        [StringLength(25)]
        [Required(ErrorMessage = "Ви ввели менше 3 символів") ]
        public string name { get; set; }

        [Display(Name = "Введіть фамілію")]
        [StringLength(15)]
        [Required(ErrorMessage = "Ви ввели менше 4 символів")]
        public string surname { get; set; }

        [Display(Name = "Адресса")]
        [StringLength(35)]
        [Required(ErrorMessage = "Ви ввели менше 5 символів")]
        public string adress { get; set; }

        [Display(Name = "Номер телефону")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Номер не може складати менше ніж 10 символів")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина електронної пошти не може бути меншою за 6 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public  DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
