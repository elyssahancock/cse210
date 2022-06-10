using CSE210.InheritancePractice;
Customer John  = new Customer("John Smith");
John.Purchase(50.00);
John.GetInfo();
Console.WriteLine(John.Name);

Dealer Ace = new Dealer("Ace Hardware", 12345678, .05);
Ace.Purchase(50.00);
Ace.GetInfo();
Console.WriteLine(Ace.Name);