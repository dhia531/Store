using Store.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Store.Entities
{
    public class Blog : EntityBase
    {
        [Required, StringLength(80)]
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
    }
}