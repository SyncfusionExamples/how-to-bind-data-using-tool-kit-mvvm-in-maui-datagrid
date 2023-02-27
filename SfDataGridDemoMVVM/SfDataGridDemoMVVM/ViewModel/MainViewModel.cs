using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SfDataGridDemoMVVM.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Model.OrderInfo> orders;

    public MainViewModel()
    {
        Orders = new ObservableCollection<Model.OrderInfo>();
        GenerateOrders();
    }

    public void GenerateOrders()
    {
        Orders.Add(new Model.OrderInfo("1001", "ALFKI", "Maria Anders", "Germany", "Berlin"));
        Orders.Add(new Model.OrderInfo("1002", "ANATR", "Ana Trujillo", "Mexico", "Mexico D.F."));
        Orders.Add(new Model.OrderInfo("1003", "ANTON", "Ant Fuller", "Mexico", "Mexico D.F."));
        Orders.Add(new Model.OrderInfo("1004", "AROUT", "Thomas Hardy", "UK", "London"));
        Orders.Add(new Model.OrderInfo("1005", "BERGS", "Tim Adams", "Sweden", "London"));
        Orders.Add(new Model.OrderInfo("1006", "BLAUS", "Hanna Moos", "Germany", "Mannheim"));
        Orders.Add(new Model.OrderInfo("1007", "BLONP", "Andrew Fuller", "France", "Strasbourg"));
        Orders.Add(new Model.OrderInfo("1008", "BOLID", "Martin King", "Spain", "Madrid"));
        Orders.Add(new Model.OrderInfo("1009", "BONAP", "Lenny Lin", "France", "Marsiella"));
        Orders.Add(new Model.OrderInfo("1010", "BOTTM", "John Carter", "Canada", "Lenny Lin"));
        Orders.Add(new Model.OrderInfo("1011", "AROUT", "Laura King", "UK", "London"));
        Orders.Add(new Model.OrderInfo("1012", "BLAUS", "Anne Wilson", "Germany", "Mannheim"));
        Orders.Add(new Model.OrderInfo("1013", "BLONP", "Martin King", "France", "Strasbourg"));
        Orders.Add(new Model.OrderInfo("1014", "AROUT", "Gina Irene", "UK", "London"));
    }
}
