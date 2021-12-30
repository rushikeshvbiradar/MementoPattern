using MementoPattern;

Console.WriteLine("Memento Pattern Example...");

// creating object
Originator originator = new Originator();
originator.Brand = "Motorola";
originator.Model = "G51";
originator.Price = 100;

// Store object state
CareTaker careTaker = new CareTaker();
careTaker.Memento = originator.SaveMemento();

// change state of object
originator.Brand = "Motorola";
originator.Model = "G31";
originator.Price = 150;

// restoring object
originator.RestoreMemento(careTaker.Memento);

Console.ReadKey();