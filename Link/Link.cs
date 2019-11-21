using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link
{
    class Link<T> : ILink<T>
    {
        public LinkNode<T> Head { get; set; }
        public LinkNode<T> Tail { get; set; }

        public Link() { }

        public LinkNode<T> Next()
        {
            return Head.Next;
        }
        public LinkNode<T> Next(T value)
        {
            LinkNode<T> current = Head;
            while (current != null)
            {
                if (current.Node.Equals(value))
                {
                    return current.Next;
                }
                current = current.Next;
            }
            throw new ItemNotFoundException(string.Format("\"{0}\" was not found!", value));
        }
        public bool Exists(T value)
        {
            LinkNode<T> current = Head;
            while (current != null)
            {
                if (current.Node.Equals(value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void Add(T value)
        {
            if (Head == null)
            {
                Head = new LinkNode<T>(value);
                Tail = new LinkNode<T>(value);
            }
            else
            {
                Tail.Next = new LinkNode<T>(value);
                Tail = new LinkNode<T>(value);
            }
        }
        public void Remove()
        {
            LinkNode<T> previous = Head;
            LinkNode<T> current = Head.Next;
            while(current != null)
            {
                if(current.Equals(Tail))
                {
                    previous.Next = null;
                    break;
                }
                previous = previous.Next;
                current = current.Next;
            }
        }
        public void Remove(T value)
        {
            LinkNode<T> previous = Head;
            LinkNode<T> current = Head.Next;
            while (current != null)
            {
                if (current.Equals(value))
                {
                    previous.Next = current.Next;
                    break;
                }
                previous = previous.Next;
                current = current.Next;
            }
        }
    }
}
