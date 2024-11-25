using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _25._11._2024
{
    [TestClass]
    public class DatabaseOperationsTests
    {
        private DatabaseOperations _databaseOperations;

        [TestInitialize]
        public void Setup()
        {
            // Подключение к Вашей тестовой базе данных
            _databaseOperations = new DatabaseOperations("YourConnectionStringHere");
        }

        [TestMethod]
        public void TestBubbleSort()
        {
            // Данные для тестирования
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Charlie" },
                new Customer { Id = 2, Name = "Alice" },
                new Customer { Id = 3, Name = "Bob" }
            };

            var sortedCustomers = _databaseOperations.BubbleSort(customers);

            Assert.AreEqual("Alice", sortedCustomers[0].Name);
            Assert.AreEqual("Bob", sortedCustomers[1].Name);
            Assert.AreEqual("Charlie", sortedCustomers[2].Name);
        }

        [TestMethod]
        public void TestSelectionSort()
        {
            // Данные для тестирования
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Charlie" },
                new Customer { Id = 2, Name = "Alice" },
                new Customer { Id = 3, Name = "Bob" }
            };

            var sortedCustomers = _databaseOperations.SelectionSort(customers);

            Assert.AreEqual("Alice", sortedCustomers[0].Name);
            Assert.AreEqual("Bob", sortedCustomers[1].Name);
            Assert.AreEqual("Charlie", sortedCustomers[2].Name);
        }
    }
}

