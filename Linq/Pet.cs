namespace Linq
{
    internal class Pet
    {
        public Pet(string name, Person owner)
        {
            Name = name;
            Owner = owner;
        }
        public string Name { get; set; }
        public Person Owner { get; set; }
    }
}