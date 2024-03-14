using Problem_plecakowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class UnitTestProblem
    {
        [TestMethod]
        public void TestMethodCountElements(){
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes ){
                Problem problem = new Problem(n,1);
                Assert.AreEqual(n, problem.Items.Count);
            }
        }
    }
}
