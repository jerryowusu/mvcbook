using System.ComponentModel.DataAnnotations;
namespace mvcbook.Models
{
    public class Category
    {
       
       public int Id { get; set; } 
       public string Name { get; set; }
       public int DisplayOrder { get; set; }
    }
} 