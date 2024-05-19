using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Waggly_DB_Hostpage.Models
{
    public class LeadEntity
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Name of Owner")]
        public string Name { get; set; }
        
        [DisplayName("Name of Dog")]
        public string dogName { get; set; }
        
    }
}

    

