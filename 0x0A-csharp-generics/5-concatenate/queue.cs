using System;

/// <summary>Generic class Queue</summary>
public class Queue<T>
{
    /// <summary>Node class</summary>
    public class Node
    {
        /// <summary>value of the node</summary>
        public T value = default(T);
        
        /// <summary>Next position of the node</summary>
        public Node next = null;

        /// <summary>Constructor that takes only 1 parameter and sets to its value</summary>
        public Node(T dValue)
        {
            value = dValue;
        }
    }
    /// <summary>Head of the queue</summary>
    public Node head;
    /// <summary>Tail of the queue</summary>
    public Node tail;
    /// <summary>Number of the nodes</summary>
    public int count;

    /// <summary>Function that returns the type of the instance</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>Function that enqueues a new node to the queue</summary>
    public void Enqueue(T value)
    {
        Node node = new Node(value);

        if (head == null)
        {
            head = node;
            count += 1;
        }
        else
        {
            if (count == 1)
                head.next = node;

            else
                tail.next = node;
            
            tail = node;
            count += 1;
        }
    }

    /// <summary>
    ///Function that removes the first element of the queue and returns its value.
    ///</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;
        count -= 1;

        return value;

    }

    /// <summary>returns the value of the first node of the queue without removing the node.</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    /// <summary>Prints the queue starting from the head</summary>
    public void Print()
    {
        if (head == null)
            Console.WriteLine("Queue is empty");
        
        else
        {
            Node h = head;

            while (h != null)
            {
                Console.WriteLine(h.value);
                h =  h.next;
            }
        }
    }

    /// <summary>concatenates all values in the queue only if the queue is of type String or Char.</summary>
    public String Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        else if (CheckType() == typeof(char) || CheckType() == typeof(string))
        {
            string result = "";

            while (head != null)
            {
                result += head.value;
                if (head.next != null && CheckType() == typeof(string))
                    result += " ";

                head = head.next;
            }

            return result;
        }

        Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
        return null;
    }

    /// <summary>Function that returns number of nodes in the queue</summary>
    public int Count()
    {
        return count;
    }
}
