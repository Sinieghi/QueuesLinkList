
//As using FIFO you can make a linked list work as a queue
class Queue<T>
{
    //Front is pointing to start Node and point to all subsequential ones.
    public Node<T>? Front = null;
    //Rear is responsible to point o last node
    public Node<T>? Rear = null;
    //Node is used to create new nodes
    public Node<T>? node = null;

    public void Enqueue(T x)
    {
        node = new()
        {
            data = x,
            next = null
        };
        //if is null, stack is full already
        if (node == null) System.Console.WriteLine("Queue is full");
        else
        {
            if (Front == null) Front = Rear = node;
            else
            {
                Rear.next = node;
                Rear = node;
            }

        }
    }

    public void Dequeue()
    {
        if (node == null) System.Console.WriteLine("Queue is full");
        else
        {
            Node<T> n = null;
            if (Front == null) Front = Rear = node;
            else
            {
                n = Front;
                Front = Front.next;
            }
            if (n != null) System.Console.WriteLine("Dequeue: " + n.data);
            n = null;
        }
    }

    public void Display()
    {
        Node<T> n = Front;
        while (n != null)
        {
            System.Console.WriteLine(n.data);
            n = n.next;
        }
    }
}