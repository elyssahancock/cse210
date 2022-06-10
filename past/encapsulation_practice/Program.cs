
Console.WriteLine("");
VendingMachine Machine1 = new VendingMachine();

Machine1.Populate();
Machine1.getList();
Console.WriteLine("");
// Console.WriteLine(Machine1.items);
public class Item{
    // class variables
    private string name;
    private double price;

    private string location;

    private int quantity;
    
    // construnctor
    public Item(string name, double price, string location, int quantity = 1){ // passing in variables from class
        // making the variables accessable
        this.name = name;
        this.price = price;
        this.location = location;
        this.quantity = quantity;
}
    private double totalValue(){
        return quantity * price;
    }
    public void showItem(){
        Console.WriteLine();
        Console.WriteLine($"{name}({quantity}) - {price} -- {location} ");
        Console.WriteLine($"Total Value: {totalValue()}");
        
    }


}

public class VendingMachine {
    private List<Item> items = new List<Item>();

// constructor:
    public VendingMachine(){
        Console.WriteLine("I am a vending machine!");
    }

    public void Populate(){
        items.Add(new Item("Cool Ranch Doritos", 2.5, "A1"));
        items.Add(new Item("Reeses", .75, "A2"));

    }

    public void getList(){
        Console.WriteLine("These are the items in the vending machine:");
        foreach(Item item in items){
            item.showItem();
        }
    }
}