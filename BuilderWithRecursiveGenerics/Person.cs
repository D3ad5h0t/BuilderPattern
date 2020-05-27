namespace BuilderWithRecursiveGenerics
{
    public class Person
    {
        public string Name;
        public string Position;
        
        public class Builder : PersonJobBuilder<Builder>
        {
            internal Builder()
            {
            }
        }
        
        public static Builder New => new Builder();
    }
}