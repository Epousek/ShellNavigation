using ShellApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ShellApp.Views
{
  public partial class ItemDetailPage : ContentPage
  {
    public ItemDetailPage()
    {
      InitializeComponent();
      BindingContext = new ItemDetailViewModel();
    }
  }
}