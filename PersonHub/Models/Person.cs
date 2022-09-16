namespace PersonHub.Models
{
    public class Person
    {
        public Person() { }
        public Person(int id, string name, int age, int gender, string email)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
    }
}