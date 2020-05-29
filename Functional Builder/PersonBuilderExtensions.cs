namespace Functional_Builder
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorkAsA(this PersonBuilder builder, string position)
        {
            // builder.Actions.Add(p =>
            // {
            //     p.Position = position;
            //     return p;
            // });
            builder.Do(p => p.Position = position);
            return builder;
        }
    }
}