class TaskNode
{
    public int id;        
    public string name;  
    public int priority; 
    public TaskNode next; 
}

class TaskScheduler
{
    TaskNode head; // first task

    public void AddTask(int id, string name, int p)
    {
        TaskNode node = new TaskNode { id = id, name = name, priority = p };

        if (head == null) // first task
        {
            head = node;
            node.next = head;
            return;
        }

        TaskNode temp = head;
        while (temp.next != head) // go to last
            temp = temp.next;

        temp.next = node;
        node.next = head; // keep circular
    }

    public void Display()
    {
        if (head == null) return;

        TaskNode temp = head;
        do
        {
            Console.WriteLine(temp.id + " " + temp.name);
            temp = temp.next;
        } while (temp != head); // full loop
    }
}