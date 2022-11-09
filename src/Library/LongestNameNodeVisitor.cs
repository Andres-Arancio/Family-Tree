namespace Library
{
    public class LongestNameNodeVisitor : NodeVisitor<Persona>
    {
        public Persona runnerUp;
        public int longestNameLength;

        public override void Visit(Node<Persona> node)
        {
            if(longestNameLength < node.content.nombre.Length)
            {
                longestNameLength = node.content.nombre.Length;
                runnerUp = node.content;
            }
            foreach(Node<Persona> child in node.Children)
            {
                child.Accept(this);
            }
        }

        public Persona ReturnLongest()
        {
            return this.runnerUp;
        }
    }
}