using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P7ImmutableList
{
    public class ImmutableList
    {
        public ImmutableList()
        {
            list = new List<int>();
        }
        public List<int> list;
        public List<int> List
        {
            get
            {
                List<int> listCopy = new List<int>();
                for (int i = 0; i < list.Count; i++)
                {
                    listCopy.Add(list[i]);
                }
                return listCopy;
            }
        }
    }
    class P7ImmutableList
    {
        static void Main(string[] args)
        {
            Type immutableList = typeof(ImmutableList);
            FieldInfo[] fields = immutableList.GetFields();
            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(methods.Length);
            }

        }
    }
}
