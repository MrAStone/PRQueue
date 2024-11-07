public class PRQueue <T>
{
  private  int[] priority;
    private List<Queue<T>> queues;
    private int queueCount;

    public PRQueue(int levels=10)
    {
        priority = new int[levels];
        queues = new List<Queue<T>>();
        for (int i = 0; i < levels; i++)
        {
            queues.Add(new Queue<T>());
        }
        queueCount = 0;
    }
    public void Enqueue(T value,int priority)
    {
        // Enqueue the value
        queues[priority].Enqueue(value);
        queueCount++;
    }

    public T Dequeue()
    {
        // Dequeue the value
        T item; 
        int index = 0;
        while(queues[index].Count == 0)
        {
            index++;
        }
        item = queues[index].Dequeue();
        queueCount--;
        return item;
    }
    public T Peek()
    {
        T item; ;
        int index = 0;
        while (queues[index].Count == 0)
        {
            index++;
        }
        item = queues[index].Peek();
        return item;
    }
    public void Print()
    {
        for (int i = 0; i < queues.Count; i++)
        {
            Console.WriteLine("Priority " + i);
            foreach (var item in queues[i])
            {
                Console.WriteLine(item);
            }
        }
    }
    public int Count()
    {
        return queueCount;
    }
}