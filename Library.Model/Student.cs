namespace Library.Model
{
    public class Student : Person
    {
        public int Id { get; set; }

        public Address Address { get; set; }

        public string Description { get; set; }
    }
}
