using System.ComponentModel.DataAnnotations;
using apis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;

namespace apis.Models
{
    public class Students
    {
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Age { get; set; }
    }

}