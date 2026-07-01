
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
