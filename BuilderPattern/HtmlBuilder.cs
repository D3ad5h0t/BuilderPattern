namespace BuilderPattern
{
    public class HtmlBuilder
    {
        private readonly string _rootName;
        private HtmlElement _root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            _root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            _root.Elements.Add(element);

            return this;
        }

        public override string ToString() => _root.ToString();

        public void Clear()
        {
            _root = new HtmlElement
            {
                Name = _rootName
            };
        }

        public HtmlElement Build() => _root;

        public static implicit operator HtmlElement(HtmlBuilder builder) => builder._root;
    }
}