using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;


namespace _25._11._2024
{
    public class DatabaseOperations
    {
        private DataContext _context;

        public DatabaseOperations(string connectionString)
        {
            _context = new DataContext(connectionString);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.GetTable<Customer>().ToList();
        }

        // Пузырьковая сортировка
        public List<Customer> BubbleSort(List<Customer> customers)
        {
            int n = customers.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (customers[j].Name.CompareTo(customers[j + 1].Name) > 0)
                    {
                        // Swap
                        var temp = customers[j];
                        customers[j] = customers[j + 1];
                        customers[j + 1] = temp;
                    }
                }
            }
            return customers;
        }

        // Сортировка выбором
        public List<Customer> SelectionSort(List<Customer> customers)
        {
            int n = customers.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (customers[j].Name.CompareTo(customers[minIndex].Name) < 0)
                    {
                        minIndex = j;
                    }
                }
                // Swap
                var temp = customers[minIndex];
                customers[minIndex] = customers[i];
                customers[i] = temp;
            }
            return customers;
        }
    }

    // Пример класса Customer
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

