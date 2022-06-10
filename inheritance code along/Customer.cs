namespace CSE210.InheritancePractice;
class Customer
{
    public string Name { get; set; }
    public Customer (string name){
        Name = name;
    }

    public void Purchase(double cartTotal){
        Console.WriteLine($"{Name} made purchase for {cartTotal}");
    }
    public virtual void GetInfo(){
        Console.WriteLine($"My name is {Name}");
    }
}