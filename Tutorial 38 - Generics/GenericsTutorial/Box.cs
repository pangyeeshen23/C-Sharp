using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTutorial
{
    internal class Box<T>
    {
        private T content;

        public Box(T initialVal)
        {
            content = initialVal;
        }

        public T Content { get; set; }
        public string Log()
        {
            return $"Box contains {Content}";
        }

        public void UpdateContent(T newContent)
        {
            content = newContent;
            Console.WriteLine($"Updated Content to {content}");
        }

        public T GetContent()
        {
            return content;
        }
    }
}
