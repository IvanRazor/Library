using Library.Interfaces;
using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Library.Services
{
    public class AutorService : IAutorService
    {
        public AutorService()
        {
        }

        public BindingList<Autor> GetAutorList()
        {
            var autors = new List<Autor>()
            {
                new Autor() { Id = Guid.NewGuid().ToString(), FirstName = "John", SecondName = "G." },
                new Autor() { Id = Guid.NewGuid().ToString(), FirstName = "Martin", SecondName = "F." }
            };

            return new BindingList<Autor>(autors);
        }
    }
}
