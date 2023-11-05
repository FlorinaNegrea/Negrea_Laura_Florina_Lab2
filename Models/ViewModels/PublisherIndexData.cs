using Negrea_Laura_Florina_Lab2.Models;

namespace Negrea_Laura_Florina_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
