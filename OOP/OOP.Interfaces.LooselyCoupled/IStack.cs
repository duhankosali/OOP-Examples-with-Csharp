using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.LooselyCoupled
{
    public interface IStack
    {
        void Push(int item); // ekle 
        void Pop(); // çıkar (Stack yapısında çıkarma işlemi sondan olur)
    }


}
