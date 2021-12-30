namespace MementoPattern
{
    public class Memento
    {
        string brand;
        string model;
        double price;

        public Memento(string brand, string model, double price)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
    }
}
