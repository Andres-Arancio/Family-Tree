namespace Library
{
    public abstract class NodeVisitor<T>
    {
        public abstract void Visit(Node<T> target);
    }
}

