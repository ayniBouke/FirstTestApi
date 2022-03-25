using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ApiTest.EntityLayer
{
    [Table("Item")]
    public class TodoItemEntity
    {
        [Key]
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("IsComplete")]
        public bool IsComplete { get; set; }
    }
}