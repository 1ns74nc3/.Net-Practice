using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLogic
{
    interface IManager<T>
    {
        IList<T> GetData();
        void AddItem(T item);
    }
}
