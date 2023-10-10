using Core.Entites;

namespace Presentation_Layer.ViewModels
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public List<PortofolioItem> PortofolioItems { get; set; }
    }
}
