
namespace MuseoOmeroApp.ViewModel.Templates
{
    public class TopBarViewModel: BindableObject
    {
        public TopBarViewModel(string title)
        {
            Title = title;
        }

        public string Title { get; set; }

    }
}
