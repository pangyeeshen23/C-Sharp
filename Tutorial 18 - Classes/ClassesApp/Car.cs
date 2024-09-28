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
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury = false;

        // properties
        public string Model { get => _model; set => _model = value; }
        public string Brand { 
            get
            {
                if (_isLuxury)
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
        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"A {_brand} of the model {_model} has been created");
        }

    }
}
