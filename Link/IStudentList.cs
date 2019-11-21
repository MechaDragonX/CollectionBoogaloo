using System;

namespace Link
{
    interface IStudentList
    {
        Student Next();
        void Add(Student value);
        void Remove();
    }
}
