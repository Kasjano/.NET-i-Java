using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
[assembly: InternalsVisibleTo("TestProject"), InternalsVisibleTo("GUI")]

namespace Problem_plecakowy
{
    internal class Problem
    {
        public int n;
        public int seed;
        public List<Item> Items{ get; set; }
        public Problem(int N, int Seed)
        {
            n = N;
            seed = Seed;
            Items = GenerateItems(N, Seed);
        }

        public List<Item> GenerateItems(int N, int Seed)
        {
            Random random = new Random(Seed);
            List<Item> Items= new List<Item>();

            for (int i = 1; i <= n; i++)
            {
                Items.Add(new Item
                {
                    Number = i,
                    Value = random.Next(1,10),
                    Weight = random.Next(1,10)
                }); 
            }

            foreach (var item in Items)
            {
                Console.WriteLine($"Number: {item.Number}, Value: {item.Value}, Weight: {item.Weight}");
            }

            return Items;
        }

        public void AddItemManually(int number, int value, int weight)
        {
            Items.Add(new Item
            {
                Number = number,
                Value = value,
                Weight = weight
            });
        }
        public Result Solve(int capacity) {
            List<Item> SortItems = Items.OrderByDescending(Item => (double)Item.Value / Item.Weight).ToList();

            List<int> numbers = new List<int>();
            int totalValue = 0;
            int totalWeight = 0;

            foreach (var item in SortItems)
            {
                if (totalWeight + item.Weight <= capacity)
                {
                    numbers.Add(item.Number);
                    totalValue += item.Value;
                    totalWeight += item.Weight;
                }
            }

            return new Result
            {
                Numbers = numbers,
                TotalValue = totalValue,
                TotalWeight  = totalWeight
            };
        }
    }
}
