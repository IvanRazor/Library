using Library.Model;
using System.ComponentModel;

namespace Library.Interfaces
{
    public interface IAutorService
    {
        BindingList<Autor> GetAutorList();
    }
}
