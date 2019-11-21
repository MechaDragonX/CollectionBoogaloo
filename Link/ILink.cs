using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link
{
    interface ILink<T>
    {
        LinkNode<T> Next();
        LinkNode<T> Next(T value);
        bool Exists(T value);
        void Add(T value);
        void Remove();
        void Remove(T value);
        string ToString();
    }
}
