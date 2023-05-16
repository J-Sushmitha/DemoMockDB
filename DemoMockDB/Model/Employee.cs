using System.ComponentModel.DataAnnotations;

namespace DemoMockDB.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desgination { get; set; }
    }
}
