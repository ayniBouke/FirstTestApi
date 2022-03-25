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
    [Table("PersonneTest")]
    public class PersonneTestEntity
    {
        [Key]
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Phone")]
        public string Phone { get; set; }
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }
        [JsonProperty("CreationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("ModificationDate")]
        public DateTime ModificationDate { get; set; }
    }
}