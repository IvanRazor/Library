using Library.Model;
using Library.Services.Interfaces;
using System.Xml.Serialization;

namespace Library.Services.Repository
{
    public class AutorRepositry : IRepositry<Autor>
    {
        private readonly string filePath = @"autor.xml";

        public List<Autor> LoadFromFile()
        {
            using (var stream = new FileStream(this.filePath, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(List<Autor>));
                return (List<Autor>)XML.Deserialize(stream);
            }
        }

        public void Save(List<Autor> items)
        {
            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            using (var stream = new FileStream(this.filePath, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<Autor>));
                XML.Serialize(stream, items);
            }
        }
    }
}