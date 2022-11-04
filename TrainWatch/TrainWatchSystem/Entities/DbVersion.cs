using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainWatchSystem.Entities
{
    [Table(name: "DbVersion")]
    public class DbVersion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Major is required")]
        public int Major { get; set; }
        [Required(ErrorMessage = "Minor is required")]
        public int Minor { get; set; }
        [Required(ErrorMessage = "Build is required")]
        public int Build { get; set; }
        [Required(ErrorMessage = "The date is required")]
        public DateTime ReleaseDate { get; set; }
    }
}
