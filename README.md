Priortiy Queue 

Creating Priority Queue

<pre lang=C#><code>
PRQueue<data type> identifier = new PRQueue(number of levels required)
</code></pre>
Create a priority queue with a defined number of levels (priorities)  If levels are not provided then the default value of 10 is used (0 to 9);

Methods
Enqueue
<pre lang=C#><code>
 public void Enqueue(T value,int priority)
</code></pre>
Add the value and priority

Dequeu
<pre lang=C#><code>
 public T Dequeue()
</code></pre>
Returns the item with the highest priority using FIFO for the queue

Peek
<pre lang=C#><code>
public T Peek()
</code></pre>
Returns the highest priority item in the priority queue

Print
<pre lang=C#><code>
public void Print()
</code></pre>
Prints a list of priorities for non empty queues and then the items in FIFO order

Count
<pre lang=C#><code>
public int Count()
</code></pre>
Returns the total number of items in the priority queue
