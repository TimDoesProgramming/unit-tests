using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_Tests
{
    class TestRunner
    {
        TestObject testObj = new TestObject();

        public void RunTests()
        {
            testObj.IsHeads();
            print("IsHeads", testObj.Pass, testObj.TestMessage);
        }
        public void print(string testName, bool pass, string testMessahe)
        {
            Console.WriteLine("Running Test{0}... \nThe test was {1}, {2}", testName, pass, testMessahe);
        }

    }
}
