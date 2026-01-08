class ProcessNode
{
    public int pid, burst; 
    public ProcessNode next;
}

class RoundRobin
{
    ProcessNode head; // start of circular list

    public void AddProcess(int pid, int burst)
    {
        ProcessNode node = new ProcessNode { pid = pid, burst = burst };

        if (head == null) // first process
        {
            head = node;
            node.next = head;
            return;
        }

        ProcessNode temp = head;
        while (temp.next != head) // move to last node
            temp = temp.next;

        temp.next = node;  // add at end
        node.next = head;  // keep it circular
    }

    public void Simulate(int tq)
    {
        ProcessNode temp = head;

        do
        {
            Console.WriteLine("Executing P" + temp.pid);
            temp.burst -= tq; // reduce burst by time quantum
            temp = temp.next;
        } while (temp != head); // one full round
    }
}
