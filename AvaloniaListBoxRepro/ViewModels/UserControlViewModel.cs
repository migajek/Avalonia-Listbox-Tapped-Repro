using Avalonia.Media.Imaging;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Linq;

namespace AvaloniaListBoxRepro.ViewModels
{
    public class Item
    {
        public string Name { get; set; }        
    }


    public class UserControlViewModel: ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }
        private string _text;
        public string Text { get => _text; set => this.RaiseAndSetIfChanged(ref _text, value); }

        public UserControlViewModel()
        {            
            Items = new ObservableCollection<Item>(Enumerable.Range(0, 10).Select(x => new Item() { Name = $"Item {x}" }));
        }

    }
}
