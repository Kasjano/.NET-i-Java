using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class Testy
    {
        [TestMethod]
        public void KolejnoscPrzedmiotowWplywaNaRozwiazanie()
        {
            Problem problem = new Problem(0, 1);
            Problem problem2 = new Problem(0, 1);
            problem.AddItemManually(1, 2, 2);
            problem.AddItemManually(2, 4, 5);
            problem.AddItemManually(3, 2, 3);
            problem2.AddItemManually(1, 4, 5);
            problem2.AddItemManually(2, 2, 3);
            problem2.AddItemManually(3, 2, 2);
            int capacity = 8;
            //act
            Result result = problem.Solve(capacity);
            Result result2 = problem2.Solve(capacity);
            //assert
            Assert.AreEqual(result.TotalValue, result2.TotalValue);
            Assert.AreEqual(result.TotalWeight, result2.TotalWeight);
        }

        [TestMethod]
        public void PrzynajmniejJedenPrzedmiotSpelniaOgraniczenia()
        {
            Problem problem = new Problem(0, 1);
            problem.AddItemManually(1, 2, 1);
            int capacity = 1;
            //act
            Result result = problem.Solve(capacity);
            //assert
            Assert.IsTrue(result.Numbers.Count > 0);
        }

        [TestMethod]
        public void SprawdzenieDzialaniaRecznegoDodawaniaPrzedmiotowDoListy()
        {
            Problem problem = new Problem(0, 1);
            //act
            problem.AddItemManually(1, 2, 3);
            //assert
            Assert.AreEqual(1, problem.Items.Count);
            Assert.AreEqual(1, problem.Items[0].Number);
            Assert.AreEqual(2, problem.Items[0].Value);
            Assert.AreEqual(3, problem.Items[0].Weight);
        }

        [TestMethod]
        //test sprawdza dzialanie programu gdy na liscie przedmiotow znajduja sie przedmioty
        //o tej samej wartosci i wadze
        public void SprawdzenieDzialaniaDlaKilkuPrzedmiotowOTejSamejWadzeIWartosci()
        {
            Problem problem = new Problem(0, 1);
            problem.AddItemManually(1, 2, 2);
            problem.AddItemManually(2, 2, 2);
            problem.AddItemManually(3, 2, 2);
            int capacity = 5;
            //act
            Result result = problem.Solve(capacity);
            //assert
            Assert.AreEqual(result.TotalValue, 4);
            Assert.AreEqual(result.TotalWeight, 4);
        }

        [TestMethod]
        public void UjemnaPojemnoscPlecaka()
        {
            Problem problem = new Problem(10, 1);
            //act
            Result result = problem.Solve(-5);
            //assert
            Assert.IsTrue(result.Numbers.Count == 0);
            Assert.IsTrue(result.TotalValue == 0);
            Assert.IsTrue(result.TotalWeight == 0);
        }

        [TestMethod]
        public void WszystkiePrzeedmiotyMieszczaSieWPlecaku()
        {
            Problem problem = new Problem(0, 1);
            //act
            problem.AddItemManually(1, 2, 2);
            problem.AddItemManually(2, 4, 5);
            problem.AddItemManually(3, 2, 3);
            Result result = problem.Solve(10);
            //assert
            Assert.AreEqual(3, result.Numbers.Count);
            Assert.AreEqual(8, result.TotalValue);
            Assert.AreEqual(10, result.TotalWeight);
        }

        [TestMethod]
        public void WynikKonkretnejInstancji()
        {
            Problem problem = new Problem(0, 1);
            problem.AddItemManually(1, 2, 2);
            problem.AddItemManually(2, 4, 5);
            problem.AddItemManually(3, 2, 3);
            int capacity = 8;
            //act
            Result result = problem.Solve(capacity);
            //assert
            Assert.AreEqual(result.TotalValue, 6);
            Assert.AreEqual(result.TotalWeight, 7);
        }

        [TestMethod]
        public void ZadenPrzedmiotNieSpelniaOgraniczen()
        {
            Problem problem = new Problem(10, 1);
            int capacity = 0;
            //act
            Result result = problem.Solve(capacity);
            //assert
            Assert.IsTrue(result.Numbers.Count == 0);
        }
    }
}

