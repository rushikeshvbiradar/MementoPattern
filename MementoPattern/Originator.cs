namespace MementoPattern
{
    public class Originator
    {
        string brand;
        string model;
        double price;

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
                Console.WriteLine("Brand: " + brand);
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                Console.WriteLine("Price: " + price);
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                Console.WriteLine("Model: " + model);
            }
        }

        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state of Memento object...");
            return new Memento(brand, Model, price);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state of Memento object...");
            Brand = memento.Brand;
            Model = memento.Model;
            Price = memento.Price;
        }
    }
}
