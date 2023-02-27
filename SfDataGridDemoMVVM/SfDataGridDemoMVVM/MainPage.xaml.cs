using SfDataGridDemoMVVM.ViewModel;
using System.Diagnostics;

namespace SfDataGridDemoMVVM;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

