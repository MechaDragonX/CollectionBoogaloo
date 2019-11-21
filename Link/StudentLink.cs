using System;
using System.Text;

namespace Link
{
    public class StudentLink : IStudentList
    {
        public Student Head { get; set; }
        public Student Tail { get; set; }

        public StudentLink() { }

        public Student Next()
        {
            return Head.Next;
        }
        public Student Next(Student value)
        {
            return value.Next;
        }
        public Student Find(string name)
        {
            Student current = Head;
            while(current != null)
            {
                if(current.Name == name)
                {
                    return current;
                }
                current = current.Next;
            }
            throw new ItemNotFoundException(string.Format("{0} was not found!", name));
        }
        public void Add(string name, int age)
        {
            Student value = new Student(name, age);
            Add(value);
        }
        public void Add(Student value)
        {
            if(Head == null)
            {
                Head = value;
                Tail = value;
            }
            else
            {
                Tail.Next = value;
                Tail = value;
            }
        }
        public void Remove()
        {
            Student previous = Head;
            Student current = Head.Next;
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
        public void Remove(string name)
        {
            Student previous = Head;
            Student current = Head.Next;
            while(current != null)
            {
                if (current.Name == name)
                {
                    previous.Next = current.Next;
                    break;
                }
                previous = previous.Next;
                current = current.Next;
            }
        }
        public void Remove(Student value)
        {
            Student previous = Head;
            Student current = Head.Next;
            while(current != null)
            {
                if(current.Equals(value))
                {
                    previous.Next = current.Next;
                    break;
                }
                previous = previous.Next;
                current = current.Next;
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            Student current = Head;
            while(current != null)
            {
                builder.AppendFormat("{0}\n", current);
                current = current.Next;
            }
            return builder.ToString();
        }
    }
}
