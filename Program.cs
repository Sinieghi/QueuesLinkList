class Program
{
    static void Main(string[] args)
    {
        Queue<int> queue = new();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);
        queue.Dequeue();
        queue.Display();
    }
}