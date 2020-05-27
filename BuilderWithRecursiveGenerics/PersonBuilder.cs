namespace BuilderWithRecursiveGenerics
{
    public abstract class PersonBuilder
    {
        protected Person Person = new Person();

        public Person Build() => Person;
    }
    
    public class PersonInfoBuilder<SELF> : PersonBuilder 
        where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            Person.Name = name;
            return (SELF) this;
        }
    }

    public class PersonJobBuilder<SELF> : PersonInfoBuilder<SELF>
        where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorksAs(string position)
        {
            Person.Position = position;
            return (SELF) this;
        }
    }
}