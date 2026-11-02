using System;

namespace ParkPass.DataStructures
{

    /// <summary>
    /// Represents the class for managing faculty data.
    /// </summary>
    public class FacultyData : BaseCommands
    {
        protected BaseList? head = null;
        protected BaseList? tail = null;
        
        public override void addNode(string name, string course, string vehiclePlate)
        {
            BaseList newNode = new BaseList(name, course, vehiclePlate);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                BaseList current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
                newNode.prev = current;
                tail = newNode;
            }
            newNode.is_Staff = true;
        }

        public override void removeNode(string name, string course, string vehiclePlate)
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty. Cannot remove node.");
                return;
            }

            BaseList current = head;
            while (current != null)
            {
                if (current.name == name && current.course == course && current.vehiclePlate == vehiclePlate)
                {
                    if (head == current)
                    {
                        head = current.next;
                        if (head != null)
                        {
                            head.prev = null;
                        }
                        else
                        {
                            tail = null; // List is now empty
                        }
                    }
                    else if (tail == current)
                    {
                        tail = current.prev;
                        if (tail != null)
                        {
                            tail.next = null;
                        }
                        else
                        {
                            head = null; // List is now empty
                        }
                    }
                    else
                    {
                        current.prev.next = current.next;
                        current.next.prev = current.prev;
                    }
                    return;
                }
                current = current.next;
            }
            Console.WriteLine("Faculty member not found. Cannot remove.");
        }

        public override BaseList searchNode(string name, string course, string vehiclePlate)
        {
            BaseList current = head;
            while (current != null)
            {
                if (current.name == name && current.course == course && current.vehiclePlate == vehiclePlate)
                {
                    return current;
                }
                current = current.next;
            }
            return null;
        }
    }
}
