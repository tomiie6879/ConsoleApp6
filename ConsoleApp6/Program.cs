
using ConsoleApp6;
// bai 1
Dog dg = new Dog();
dg.Eat("Dog");
dg.Sound();
Cat ct = new Cat();
ct.Eat("Cat");
ct.Sound();
Duck dd = new Duck();
dd.Eat("Duck");
dd.Sound();

// bai 2 
Car cc = new Car();
cc.Start("Porsche");
cc.Move(30);
cc.Stop();
Boat boat = new Boat();
boat.Start("Boat");
boat.Move(20);
boat.Stop();
Bike bk = new Bike();
bk.Start("Bike");
bk.Move(10);
bk.Stop();
// bai 3
Bird bd = new Bird();
bd.Fly();
Airplane a = new Airplane();
a.Fly();
SuperMan sm = new SuperMan();
sm.Fly();
// bai 4
Eagle eagle = new Eagle();
eagle.Fly();
Duck duck = new Duck();
duck.Fly();
duck.Swim();
Fish fish = new Fish();
fish.Swim();
// bai 5
Warrior warrior = new Warrior();
warrior.Move("Warrior");
warrior.Attack("Warrior");
Archer archer = new Archer();
archer.Move("Archer");
archer.Attack("Archer");
Mage mage = new Mage();
mage.Move("Mage");
mage.Attack("Mage");
// bai 6
Player ph  = new Player();
ph.TakeDamage(30);
Enemy en = new Enemy();
en.TakeDamage(100);
Boss bos = new Boss();
bos.TakeDamage(50);
// bai 7
Player p = new Player();
p.TakeDamage(100);
p.Interactable();
Enemy e = new Enemy();
e.TakeDamage(30);
Coin coin = new Coin();
coin.Collectable();
Chest chest = new Chest();
chest.Interactable();
// bai 8 
FullTimeEmployee ft = new FullTimeEmployee();
ft.CalculateSalary("Mai",4000000);
PartTimeEmployee pt = new PartTimeEmployee();
pt.CalculateSalary("Ngo",3000000);
// bai 9
CreditCard creditCard = new CreditCard();
creditCard.Pay(30);
PayPal payPal = new PayPal();
payPal.Pay(50);
BankTransfer bankTransfer = new BankTransfer();
bankTransfer.Pay(70);
// bai 10 
Warrior warrior1 = new Warrior();
warrior1.Attack("Warrior");
warrior.Movable();
warrior.TakeDamage(30);
Mage mage1 = new Mage();
mage1.Attack("Mage");
mage1.Movable();
mage1.TakeDamage(50);
Healer healer = new Healer();
healer.Attack("Healer");
healer.Movable();
// bai tap thu thach
List<CharacterBTTT> characters = new List<CharacterBTTT>();
List<IActionable> items = new List<IActionable>();
characters.Add(new PlayerBTTT { Name = "Hero" });
characters.Add(new EnemyBTTT { Name = "Dog" });
characters.Add(new EnemyBTTT { Name = "Cat" });
characters.Add(new EnemyBTTT { Name = "Turtle" });
characters.Add(new BossBTTT { Name = "Dragon" });

for (int i = 0; i < 5; i++)
{
    items.Add(new CoinBTTT());
    
}
items.Add(new ChestBTTT());
items.Add(new ChestBTTT());

foreach (var c in characters)
{
    Console.WriteLine(c);
}

foreach (var item in items)
{
    Console.WriteLine(item);
}