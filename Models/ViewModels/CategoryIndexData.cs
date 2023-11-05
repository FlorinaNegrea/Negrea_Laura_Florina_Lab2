using Negrea_Laura_Florina_Lab2.Models;

namespace Negrea_Laura_Florina_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories  { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
