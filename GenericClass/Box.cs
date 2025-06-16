using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class Box<T>
    {
        public T Content { get; set; }
        public string Log()
        {
            return $"Box contains {Content}";
        }
    }

    internal interface IDimension
    {
        int Id { get; }
    };

    internal class Block<T> where T : IDimension
    {
        private List<T> values = new List<T>();

        public void Update(T dimension)
        {
            values.Add(dimension);
        }

    }
}
