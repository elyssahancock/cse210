namespace CSE210.InheritancePractice;
class Dealer : Customer
{
    public long dealerID {get; set;}
    public double Discount {get; set;}

    public Dealer(string name, long dealerID, double Discount): base(name){

    }
}
