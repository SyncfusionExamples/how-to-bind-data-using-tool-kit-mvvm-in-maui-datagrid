using CommunityToolkit.Mvvm.ComponentModel;

namespace SfDataGridDemoMVVM.Model;

public partial class OrderInfo : ObservableObject
{
    [ObservableProperty]
    public string orderID;
    [ObservableProperty]
    public string customerID;
    [ObservableProperty]
    public string customer;
    [ObservableProperty]
    public string shipCountry;
    [ObservableProperty]
    public string shipCity;

    public OrderInfo(string orderID, string customerID, string customer, string shipCountry, string shipCity)
    {
        OrderID = orderID;
        CustomerID = customerID;
        Customer = customer;
        ShipCountry = shipCountry;
        ShipCity = shipCity;
    }
}