namespace ClassesApp
{
    /// <summary>
    /// It's internal, which means that
    /// it can only be accessed from
    /// within the same assembly
    /// </summary>
    internal class Car
    {

        // member variable / field
        // private keywords
        // backing field of the Model property
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury = false;

        public static int NumberOfCar = 0;

        // properties
        public string Model { get => _model; set => _model = value; }
        public string Brand { 
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }

            set
            {
                _brand = value;
            }
        }
        public bool IsLuxury { get; set; }

        // Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCar++;
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"A {_brand} of the model {_model} has been created");
        }

        public Car()
        {
            NumberOfCar++;
        }


        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} and I'm driving");
        }

    }
}
