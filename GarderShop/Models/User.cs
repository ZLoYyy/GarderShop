using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GarderShop.Models
{
    public class User
    {
        [BindNever]
        public int ID { get; set; }
        
        [Display(Name = "Имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string FirsName { get; set; }
        
        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string LastName { get; set; }
        
        [Display(Name = "Отчество")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string SecontName { get; set; }

        [Display(Name = "Дата рождения")]
        [StringLength(25)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string DateOfBorn { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string Email { get; set; }
        
        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string Phone { get; set; }
        
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string Password { get; set; }
        
        [NotMapped]
        [Display(Name = "Подтверждени пароля")]
        [DataType(DataType.Password)]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string ConfirmPassword { get; set; }
        [NotMapped]
        [Display(Name = "Подтверждени пароля")]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public bool IsAgree { get; set; }
    }
}
