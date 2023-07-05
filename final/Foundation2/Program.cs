using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> OrderIDs = new List<int>();
        int orderID;
        if(OrderIDs.Count>0){
            orderID = OrderIDs.Last()+1;
        }else{
            orderID = 0;
        }
        string orderID_s = orderID+"";
        
        List<Product> orderSummary = new List<Product>();
        orderSummary.Add(new Product("Banana", "4011", 0.11f, 6));
        Customer active = new Customer("Adam", new Address("266 W 3rd S", "Rexburg", "ID", "United States of America"));
        float shipping = 0f;
        if(active.LivesInUSA()){
            shipping = 5.0f;
        }else{
            shipping = 35.0f;
        }
        Order order1 = new Order(orderSummary, active, orderID_s, shipping);
        Console.WriteLine($"Packing Label:\n{order1.GetLabelString(0)}\n\nShipping Label:\n{order1.GetLabelString(1)}");
    }
}