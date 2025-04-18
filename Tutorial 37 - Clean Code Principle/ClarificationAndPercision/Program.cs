using ClarificationAndPercision.Models;

namespace ClarificationAndPercision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clarification and Precision
            // bad 
            int n = 0;
            string s = "John";

            // good
            int studentCount = 0;
            string studentName = "John";

            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "John Doe";
        }
    }

    /// <summary>
    /// Provides functionalities for handling customers
    /// </summary>
    class CustomerService
    {

        public const int MAX_CUSTOMERS = 100; // ALL_CAPS
        public int CustomerCount { get; set; } 

        private string lasCustomerName = "John";
        private string customerName = "JohnDoe";
        private string _customerName = "JohnDoe";

        public CustomerService(string customerName)
        {
            this.customerName = customerName;
            _customerName = customerName;
        }

        /// <summary>
        /// Geth the customer by id
        /// </summary>
        /// <param name="id">The name for the customer to retrieve</param>
        /// <returns> Return the name of customer </returns>
        public string GetCustomerName(int id)
        {
            string customerName = "John Doe";
            return customerName;
        }
    }

    class OrderProcessor // nouns
    {
        // Is, Get, Set, Has, Can

        private bool hasErrors = false;
        private bool isValid = true;

        public void ProcessOrder() // verbs
        {

        }

        public void PrintOrder() // verbs
        {

        }

        public void DeleteOrder() // verbs
        {

        }
        
        // Meaning through naming
        // bad
        public void Save()
        {

        }

        // good
        public void SaveOrder()
        {

        }
    }

    public class MathUtils
    {
        // Comment

        // Bad : Calculate the factorial number
        // 
        public int CalculateFactorial(int number)
        {
            if(number <= 1)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactorial(number - 1);
            }
        }

        // Using binary search here to improve the performance for large data sets
        public int BinarySearch(int[] sortedArray, int target)
        {
            int left = 0;
            int right = sortedArray.Length - 1;
            while(left <= right)
            {
                int middle = (left + right) / 2;
                if (sortedArray[middle] == target)
                    return middle;
                else if (sortedArray[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return 0;
        }

    }

    /// <summary>
    /// Represent a customer with Id and Name
    /// </summary>
    public class MathsUtils
    {
        // TODO: Implement the binary search algorithm
        public int BinarySearch()
        {
            return -1;
        }
    }
}
