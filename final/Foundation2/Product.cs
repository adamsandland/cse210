public class Product{
    private string _name, _prodID;
    private float _price;
    private int _quantity;
    public Product(string name, string prodID, float price, int quantity){
        _name=name;
        _prodID=prodID;
        _price=price;
        _quantity=quantity;
    }
    public string GetName() { return _name; }
    public string GetProdID() { return _prodID; }
    public float GetPrice() { return _price*_quantity; }
    public float GetPriceIndividual() { return _price; }
    public int GetQuantity() { return _quantity; }
}