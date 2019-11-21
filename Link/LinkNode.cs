using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link
{
    public class LinkNode<T>
    {
        public T Node { get; set; }
        public LinkNode<T> Next { get; set; }

        /// <summary>
        /// Construct a Link Node given a Node of a generic type
        /// </summary>
        /// <param name="node"></param>
        public LinkNode(T node)
        {
            Node = node;
            Next = null;
        }
        /// <summary>
        /// Construct a Link Node given a Node and Next vaue both of a generic type
        /// </summary>
        /// <param name="node"></param>
        /// <param name="next"></param>
        public LinkNode(T node, LinkNode<T> next)
        {
            Node = node;
            Next = next;
        }
    }
}
