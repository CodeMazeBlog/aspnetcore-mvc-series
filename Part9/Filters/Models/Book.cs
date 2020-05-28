using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Filters.Models
{
    public class Book
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
