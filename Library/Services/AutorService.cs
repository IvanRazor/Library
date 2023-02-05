using Library.Interfaces;
using Library.Model;
using Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Library.Services
{
    public class AutorService : IAutorService
    {
        public AutorService(IRepositry<Autor> repository)
        {
            Repository = repository;
        }

        public IRepositry<Autor> Repository { get; }

        public BindingList<Autor> GetAutorList()
        {
            var items = this.Repository.LoadFromFile();

            return new BindingList<Autor>(items);
        }

        public void SaveAutors(BindingList<Autor> items)
        {
            var autors = items.ToList();
            this.Repository.Save(autors);
        }
    }
}
