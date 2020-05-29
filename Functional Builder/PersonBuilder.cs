namespace Functional_Builder
{
    public sealed class PersonBuilder : FunctoinalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name) => Do(p => p.Name = name);
    }
}