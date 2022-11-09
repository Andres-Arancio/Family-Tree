using System.Collections.Generic;

namespace Library
{
    public class AgeNodeVisitor : NodeVisitor<Persona>
    {
        public int Value;
        public override void Visit(Node<Persona> node)
        {
            this.Value = this.Value + node.content.edad;
            foreach(Node<Persona> child in node.Children)
            {
                child.Accept(this);
            }
        }

        public int ReturnValue()
        {
            return this.Value;
        }
    }
}