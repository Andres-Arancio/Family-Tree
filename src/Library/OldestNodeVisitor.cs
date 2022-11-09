namespace Library
{
    public class OldestNodeVisitor : NodeVisitor<Persona>
    {
        public Persona runnerUp;
        public int largestAge;

        public override void Visit(Node<Persona> node)
        {
            if(node.Children.Count == 0 && largestAge < node.content.edad)
            {
                largestAge = node.content.edad;
                runnerUp = node.content;
            }
            foreach(Node<Persona> child in node.Children)
            {
                child.Accept(this);
            }
        }

        public Persona ReturnOldest()
        {
            return this.runnerUp;
        }
    }
}