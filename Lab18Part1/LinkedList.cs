using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Part1
{
    class LinkedList
    {
        private Node head;//first node
        private Node current;//last node in list
        public int Count;//counts the nodes in list

        public LinkedList()
        {
            head = null;
            current = null;
            Count = 0;
        }
        public void RemoveAll(Object o)
        {
            Node thisNode = head;
            Node previousNode = null;

            while (thisNode != null)
            {
                if (thisNode.Value == o)
                {
                    previousNode.Next = thisNode.Next; 
                }
                else
                {
                    previousNode = thisNode;

                }
                thisNode = thisNode.Next;
            }


        }
        public void PrintAllNodes()
        {
            //start at the first node
            //console.writeline the node's value
            //go to the next node
            Node thisNode = head;
            while (thisNode != null)
            {
                Console.WriteLine(thisNode.Value);
                thisNode = thisNode.Next;
            }


        }
        public void AddAtStart(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;


            //first time--list is empty
            if (head == null)
            {
                newNode.Next = null;

                //only one node--both the start (head) and end (current)
                head = newNode;
                current = newNode;
            }
            else //not my first rodeo
            {
                newNode.Next = head;
                head = newNode;
                //current is correct--don't change
            }
            //could reset head = newNode here
            Count++;
        }
    }
}
