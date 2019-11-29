using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaListBoxRepro.ViewModels;

namespace AvaloniaListBoxRepro.Views
{
    public class UserControl1 : UserControl
    {
        public UserControl1()
        {
            this.DataContext = new UserControlViewModel();
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);          
        }

        public void GotTapped(object sender, RoutedEventArgs args)
        {
            var vm = (DataContext as UserControlViewModel);
            vm.Text += $"tap from {args.Source.GetType().Name} (Tag = {(args.Source as Control)?.Tag ?? "n/a"})\n";
        }
    }
}
