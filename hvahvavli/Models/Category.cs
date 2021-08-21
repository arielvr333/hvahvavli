using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hvahvavli.Models
{
    public class Category
    {
     
        public int Id { get; set; }
        [Required(ErrorMessage ="אתה לא בסדר")]
        [Display(Name="שם הקטגוריה:")]
        public string Name { get; set; }
        public List<havhavli.Models.Product> Products { get; set; }

    }
}
