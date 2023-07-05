public class Order{
    private List<Product> _products;
    private Customer _activeCustomer;
    private Address _activeAddress;
    private string _orderID;
    private float _shippingCost;

    public Order(List<Product> products, Customer activeCustomer, string orderID, float shippingCost){
        _products=products;
        _activeCustomer=activeCustomer;
        _activeAddress=activeCustomer.MyAddress();
        _orderID=orderID;
        _shippingCost=shippingCost;
    }

    public float TotalCost(){
        float beginCount = 0;
        foreach (var item in _products)
        {
            beginCount+=item.GetPrice();
        }
        return _shippingCost+beginCount;
    }
    public string GetLabelString(int packing_shipping){
        if(packing_shipping==0){
            string basic = "";
            foreach (var item in _products)
            {
                basic+=$"{item.GetName()} ({item.GetProdID()}) x{item.GetQuantity()}\n";
            }
            return basic;
        }else if(packing_shipping==1){
            return $"{_activeCustomer.GetName()}\n{_activeAddress.GetAddress()}\n\nTotal Cost: {TotalCost()}";
            
        }else{ return null;}
    }
}