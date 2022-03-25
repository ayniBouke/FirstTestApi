using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiTest.EntityLayer
{
    [Table("Employee")]
    public class EmployeeEntity
    {
        [Key]
        [JsonProperty("ID")]
        public int ID { get; set; }
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("CIN")]
        public string CIN { get; set; }
        [JsonProperty("Age")]
        public int Age { get; set; }
        [JsonProperty("Gender")]
        public string Gender { get; set; }
        [JsonProperty("Salary")]
        public int Salary { get; set; }
        [JsonProperty("CreationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("ModificationDate")]
        public DateTime ModificationDate { get; set; }

    }
}