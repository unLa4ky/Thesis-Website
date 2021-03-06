using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FiltersReadDto
    {
        public FilterForPriceReadDto PriceFilter { get; set; }
        public FilterForCategoriesReadDto CategoriesFilter { get; set; }
        public GendersFilter GenderFilter { get; set; }
        public FilterSizes SizeFilter { get; set; }
    }
}