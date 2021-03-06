using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Commander.Models;

namespace Commander.Dtos
{
    public class FilterForCategoriesReadDto
    {
        public List<FilterForCategoryReadDto> listOfCategoryFilter { get; set; }
    }
    public class FilterForCategoryReadDto
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public int Length { get; set; }
    }
}