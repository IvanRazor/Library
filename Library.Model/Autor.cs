namespace Library.Model
{
    public class Autor : Person
    {
        public Autor()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
    }
}