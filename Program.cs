using LINQ.Data;
using System.Collections;
using System.Xml.Linq;
using static LINQ.ListGenerator;
namespace LINQ
{
    class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
     
    class AnagramComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            if (x == null || y == null)
                return false;

            return String.Concat(x.OrderBy(c => c)) == String.Concat(y.OrderBy(c => c));
        }

        public int GetHashCode(string obj)
        {
            return String.Concat(obj.OrderBy(c => c)).GetHashCode();
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators Q.1
            //var result = ProductList.Where((P) => P.UnitsInStock == 0).ToList();
            #endregion

            #region LINQ - Restriction Operators Q.2
            //var result = ProductList.Where((P) => P.UnitsInStock > 0 & P.UnitPrice > 3).ToList();

            #endregion

            #region LINQ - Restriction Operators Q.3
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((Name, Index) => Name.Length < Index).ToArray(); 
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region LINQ - Element Operators Q.1
            //var result = ProductList.Where((P)=> P.UnitsInStock == 0 ).First();
            //Console.WriteLine(result);
            #endregion

            #region LINQ - Element Operators Q.2
            //var result = ProductList.FirstOrDefault((P) => P.UnitPrice > 1000);
            //Console.WriteLine(result);

            #endregion

            #region LINQ - Element Operators Q.3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumber = Arr.Where( (N) => N > 5).Skip(1).FirstOrDefault();
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region LINQ - Aggregate Operators Q.1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count((N) => N % 2 == 1);
            //Console.WriteLine(result);
            #endregion

            #region  LINQ - Aggregate Operators Q.2
            //foreach(var C in CustomerList)
            //{
            //    Console.WriteLine($"Name : {C.CustomerName} || Number Of Orders : {C.Orders.Count()}");
            //}
            #endregion

            #region  LINQ - Aggregate Operators Q.3
            //List<Product> Products = new List<Product>();
            //var CategoryCount = products.GroupBy(p => p.Category)
            //                            .Select(g => new { Category = g.Key, ProductCount = g.Count() }).ToList();
            #endregion

            #region LINQ - Aggregate Operators Q.4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int ArrSum = Arr.Sum();
            //Console.WriteLine(ArrSum);
            #endregion

            #region LINQ - Aggregate Operators Q.5
            //// Read all words from dictionary_english.txt into an array
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //// Get the total number of characters across all words
            //int TotalCharacters = words.Sum(word => word.Length);

            //// Output the result
            //Console.WriteLine($"Total number of characters in all words: {TotalCharacters}");
            #endregion

            #region LINQ - Aggregate Operators Q.6
            //// Read all words from dictionary_english.txt into an array
            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //// Get the length of the shortest word
            //int ShortestWordLength = Words.Min(word => word.Length);

            //// Output the result
            //Console.WriteLine($"Length of the shortest word: {ShortestWordLength}");
            #endregion

            #region LINQ - Aggregate Operators Q.7
            //// Read all words from dictionary_english.txt into an array
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //// Get the length of the longest word
            //int longestWordLength = words.Max(word => word.Length);

            //// Output the result
            //Console.WriteLine($"Length of the longest word: {longestWordLength}");
            #endregion

            #region LINQ - Aggregate Operators Q.8
            //// Read all words from dictionary_english.txt into an array
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //// Get the average length of the words
            //double averageWordLength = words.Average(word => word.Length);

            //// Output the result
            //Console.WriteLine($"Average length of words: {averageWordLength:F2}");
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region LINQ - Ordering Operators Q.1
            //var OrderedByName = ProductList.OrderBy(P => P.ProductName).ToList();
            #endregion

            #region LINQ - Ordering Operators Q.2 || ChatGPT Help
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //// Sort using LINQ with custom comparer
            //var sortedWords = words.OrderBy(word => word, new CaseInsensitiveComparer()).ToArray();

            //// Output sorted words
            //Console.WriteLine("Sorted words (case-insensitive):");
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region LINQ - Ordering Operators Q.3
            //var OrderedUnitesDesc = ProductList.OrderByDescending(P => P.UnitsInStock).ToList();
            //foreach(var OrderedUnites in OrderedUnitesDesc)
            //{
            //    Console.WriteLine(OrderedUnites);
            //}
            #endregion

            #region LINQ - Ordering Operators Q.4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //// Sort first by length, then alphabetically
            //var sortedDigits = Arr.OrderBy(word => word.Length).ThenBy(word => word).ToArray();

            //// Output sorted words
            //Console.WriteLine("Sorted digits:");
            //foreach (var word in sortedDigits)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region LINQ - Ordering Operators Q.5 
            //// StringComparer.OrdinalIgnoreCase from chat GPT
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //// Sort first by length, then case-insensitively
            //var sortedWords = words.OrderBy(word => word.Length)
            //                       .ThenBy(word => word, StringComparer.OrdinalIgnoreCase).ToArray();

            //// Output sorted words
            //Console.WriteLine("Sorted words (by length, then case-insensitive):");
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region LINQ - Ordering Operators Q.6
            //var sortedProducts = ProductList.OrderBy(p => p.Category)
            //                                .ThenByDescending(p => p.UnitPrice).ToList();

            #endregion

            #region LINQ - Ordering Operators Q.7
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //// Sort first by length, then case-insensitively in descending order
            //var sortedWords = words.OrderBy(word => word.Length)
            //                       .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase).ToArray();

            //// Output sorted words
            //Console.WriteLine("Sorted words (by length, then case-insensitive descending):");
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region LINQ - Ordering Operators Q.8
            ////string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            ////// Filter words where the second letter is 'i', then reverse the order
            ////var filteredReversedWords = words.Where(word => word.Length > 1 && word[1] == 'i')
            ////                                 .Reverse().ToList();

            ////// Output filtered and reversed words
            ////Console.WriteLine("Filtered words (second letter 'i', reversed order):");
            ////foreach (var word in filteredReversedWords)
            ////{
            ////    Console.WriteLine(word);
            ////}
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region LINQ – Transformation Operators Q.1
            //var PNames = ProductList.Select((P) => P.ProductName).ToList();
            #endregion

            #region LINQ – Transformation Operators Q.2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var wordCases = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            #endregion

            #region LINQ – Transformation Operators Q.3
            //var ProductInfo = ProductList.Select(P => new { P.ProductName, Price = P.UnitPrice });

            #endregion

            #region LINQ – Transformation Operators Q.4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var MatchingIndexes = Arr.Select((value, index) => new { Value = value, Matches = value == index });
            //Console.WriteLine("\nMatching Indexes:");
            //foreach (var item in MatchingIndexes)
            //{
            //    Console.WriteLine($"Value: {item.Value}, Matches Position: {item.Matches}");
            //}
            #endregion

            #region LINQ – Transformation Operators Q.5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var numberPairs = from a in numbersA
            //                  from b in numbersB
            //                  where a < b
            //                  select new { A = a, B = b };
            //Console.WriteLine("\nNumber Pairs:");
            //foreach (var pair in numberPairs)
            //{
            //    Console.WriteLine($"({pair.A}, {pair.B})");
            //}
            #endregion

            #region LINQ – Transformation Operators Q.6
            //List<Order> orders = new List<Order>
            //{
            //    new Order { OrderID = 1, OrderDate = new DateTime(1999, 5, 1), Total = 450m },
            //    new Order { OrderID = 2, OrderDate = new DateTime(2000, 6, 10), Total = 600m },
            //    new Order { OrderID = 3, OrderDate = new DateTime(1997, 7, 15), Total = 300m }
            //};
            //var smallOrders = orders.Where(o => o.Total < 500);
            //Console.WriteLine("\nOrders with Total < 500:");
            //foreach (var order in smallOrders)
            //{
            //    Console.WriteLine($"Order {order.OrderID}: ${order.Total}");
            //}
            #endregion

            #region LINQ – Transformation Operators Q.7
            //var orders1998Later = Order.Where(o => o.OrderDate.Year >= 1998);
            //Console.WriteLine("\nOrders from 1998 or Later:");
            //foreach (var order in orders1998Later)
            //{
            //    Console.WriteLine($"Order {order.OrderID}: {order.OrderDate.ToShortDateString()}");
            //}
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region LINQ - Aggregate Operators Q.1
            //var totalUnits = ProductList.GroupBy(p => p.Category)
            //                     .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });
            //Console.WriteLine("Total units in stock for each category:");
            //foreach (var item in totalUnits)
            //    Console.WriteLine($"{item.Category}: {item.TotalUnits}");
            #endregion

            #region LINQ - Aggregate Operators Q.2
            //var cheapestPrice = ProductList.GroupBy(p => p.Category)
            //                        .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });
            //Console.WriteLine("\nCheapest price in each category:");
            //foreach (var item in cheapestPrice)
            //    Console.WriteLine($"{item.Category}: ${item.CheapestPrice}");
            #endregion

            #region LINQ - Aggregate Operators Q.3
            //var cheapestProducts = from p in ProductList
            //                       group p by p.Category into g
            //                       let cheapest = g.Min(p => p.UnitPrice)
            //                       from p in g
            //                       where p.UnitPrice == cheapest
            //                       select new { p.Category, p.ProductName, p.UnitPrice };
            //Console.WriteLine("\nProducts with the cheapest price in each category:");
            //foreach (var product in cheapestProducts)
            //    Console.WriteLine($"{product.Category} - {product.ProductName}: ${product.UnitPrice}");

            #endregion

            #region LINQ - Aggregate Operators Q.4
            //var mostExpensivePrice = ProductList.GroupBy(p => p.Category)
            //                             .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });
            //Console.WriteLine("\nMost expensive price in each category:");
            //foreach (var item in mostExpensivePrice)
            //    Console.WriteLine($"{item.Category}: ${item.MaxPrice}");

            #endregion

            #region LINQ - Aggregate Operators Q.5
            //var expensiveProducts = from p in ProductList
            //                        group p by p.Category into g
            //                        let maxPrice = g.Max(p => p.UnitPrice)
            //                        from p in g
            //                        where p.UnitPrice == maxPrice
            //                        select new { p.Category, p.Name, p.UnitPrice };
            //Console.WriteLine("\nProducts with the most expensive price in each category:");
            //foreach (var product in expensiveProducts)
            //    Console.WriteLine($"{product.Category} - {product.Name}: ${product.UnitPrice}");

            #endregion

            #region LINQ - Aggregate Operators Q.6
            //var averagePrice = ProductList.GroupBy(p => p.Category)
            //                       .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });
            //Console.WriteLine("\nAverage price of each category's products:");
            //foreach (var item in averagePrice)
            //    Console.WriteLine($"{item.Category}: ${item.AveragePrice:F2}");
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region LINQ - Set Operators Q.1
            //var uniqueCategories = ProductList.Select(p => p.Category).Distinct();
            //Console.WriteLine("Unique Categories:");
            //foreach (var category in uniqueCategories)
            //    Console.WriteLine(category);

            #endregion

            #region LINQ - Set Operators Q.2
            //var uniqueFirstLetters = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0])).Distinct();
            //Console.WriteLine("\nUnique first letters:");
            //foreach (var letter in uniqueFirstLetters)
            //    Console.WriteLine(letter);

            #endregion

            #region LINQ - Set Operators Q.3
            //var commonFirstLetters = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //Console.WriteLine("\nCommon first letters:");
            //foreach (var letter in commonFirstLetters)
            //    Console.WriteLine(letter);
            #endregion

            #region LINQ - Set Operators Q.4
            //var productOnlyFirstLetters = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            //Console.WriteLine("\nProduct first letters not in customer names:");
            //foreach (var letter in productOnlyFirstLetters)
            //    Console.WriteLine(letter);

            #endregion

            #region LINQ - Set Operators Q.5
            //var lastThreeChars = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
            //                                .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName));
            //Console.WriteLine("\nLast three characters of all names:");
            //foreach (var chars in lastThreeChars)
            //    Console.WriteLine(chars);
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region LINQ - Partitioning Operators Q.1
            //var firstThreeOrders = (from c in CustomerList
            //                        where c.City == "Washington"
            //                        from o in c.Orders
            //                        select o).ToList().Take(3);
            //Console.WriteLine("First 3 orders from Washington:");
            //foreach (var order in firstThreeOrders)
            //    Console.WriteLine($"Order ID: {order.OrderID}, Total: ${order.Total}");

            #endregion

            #region LINQ - Partitioning Operators Q.2
            //var skipTwoOrders = (from c in CustomerList
            //                     where c.City == "Washington"
            //                     from o in c.Orders
            //                     select o).ToList().Skip(2);
            //Console.WriteLine("\nAll but the first 2 orders from Washington:");
            //foreach (var order in skipTwoOrders)
            //    Console.WriteLine($"Order ID: {order.OrderID}, Total: ${order.Total}");

            #endregion

            #region LINQ - Partitioning Operators Q.3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((n, index) => n >= index);
            //Console.WriteLine("\nElements until less than position:");
            //foreach (var number in result)
            //    Console.WriteLine(number);
            #endregion

            #region LINQ - Partitioning Operators Q.4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var DivisibleByThree = numbers.SkipWhile(n => n % 3 != 0);
            //Console.WriteLine("\nElements from first divisible by 3:");
            //foreach (var number in DivisibleByThree)
            //    Console.WriteLine(number);
            #endregion

            #region LINQ - Partitioning Operators Q.5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var fromLessThanPosition = numbers.SkipWhile((n, index) => n >= index);
            //Console.WriteLine("\nElements from first less than position:");
            //foreach (var number in fromLessThanPosition)
            //    Console.WriteLine(number);
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region LINQ - Quantifiers Q.1
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //bool containsEi = words.Any(word => word.Contains("ei"));
            //Console.WriteLine($"Any word contains 'ei': {containsEi}");

            #endregion

            #region LINQ - Quantifiers Q.2
            //var Result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             group p by p.Category into g
            //             select g;
            //Console.WriteLine("\nCategories with out-of-stock products:");
            //foreach (var group in Result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var product in group)
            //        Console.WriteLine($" - {product.ProductName}");
            //}
            #endregion

            #region LINQ - Quantifiers Q.3
            //var Result = from p in ProductList
            //                           group p by p.Category into g
            //                           where g.All(p => p.UnitsInStock > 0)
            //                           select g;
            //Console.WriteLine("\nCategories with all products in stock:");
            //foreach (var group in Result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var product in group)
            //        Console.WriteLine($" - {product.ProductName}");
            //}
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region LINQ – Grouping Operators Q.1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var GroupedByRemainder = from number in numbers
            //                         group number by number % 5 into g
            //                         select g;

            //Console.WriteLine("Numbers partitioned by remainder when divided by 5:");
            //foreach (var group in GroupedByRemainder)
            //{
            //    Console.WriteLine($"Remainder {group.Key}:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            #endregion

            #region LINQ – Grouping Operators Q.2
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var groupedByFirstLetter = from word in words
            //                           where !string.IsNullOrWhiteSpace(word)
            //                           group word by char.ToUpper(word[0]) into g
            //                           select g;

            //Console.WriteLine("\nWords partitioned by their first letter:");
            //foreach (var group in groupedByFirstLetter)
            //{
            //    Console.WriteLine($"Letter {group.Key}:");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            #endregion

            #region LINQ – Grouping Operators Q.3
            string[] words = { "from", "salt", "earn", " last", "near", "form" };

            var groupedByAnagram = words.GroupBy(word => word.Trim(), new AnagramComparer());

            Console.WriteLine("Words grouped by anagram:");
            foreach (var group in groupedByAnagram)
            {
                Console.WriteLine($"Group: {group.Key}");
                foreach (var word in group)
                {
                    Console.WriteLine(word);
                }
            }
        }
        #endregion
    }
}

