using System.Collections.Generic;
using System.Threading;

namespace WebApplication1
{
    public class MockDb
    {
        public string Save()
        {

            Thread.Sleep(5000);
            if (!Dictionary.ContainsKey(AddCount))
            {
                Dictionary.Add(AddCount, AddCount);
            }
            else
            {
                Dictionary[AddCount] = AddCount;
            }
            AddCount++;

            return AddCount.ToString();
        }

        public static Dictionary<int, int> Dictionary = new Dictionary<int, int>();
        public static int AddCount = 1;
    }
}