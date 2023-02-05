using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Interfaces
{
    public interface IRepositry<T>
    {
        void Save(List<T> items);

        List<T> LoadFromFile();
    }
}
