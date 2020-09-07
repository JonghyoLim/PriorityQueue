using System; // array
using System.Collections.Generic; // List<T>
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // ArrayList Class


namespace Assignment6PQ
{
    class HeapSortPQ
    {
        public struct Patient
        {
            public String name;
            public int priority;
            public Patient(String name, int priority)
            {
                this.name = name;
                this.priority = priority;
            }
        }

        private int numItems;
        public int NumItems
        {
            get { return NumItems; }
            set { numItems = value; }
        }

        private int maxItems;
        public int MaxItems
        {
            get { return maxItems; }
            set { maxItems = value; }
        }

        ArrayList items;

        public HeapSortPQ()
        {
            numItems = 0;
            maxItems = 10; //  maxItems = 30; 
            items = new ArrayList();
        }

        public void MakeEmpty()
        {
            numItems = 0;
        }

        public bool IsFull()
        {
            return (maxItems <= items.Count); //ArrayList.Count property. get the 
                                               //actual number of elements contained
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }
        
        public void Enqueue(String name, int priority)
        {
            if (!IsFull())
            {
                items.Add(new Patient(name, priority));
                numItems++;
                ReheapUp(0, numItems - 1);
            }
        }

        public void Dequeue(String name, int priorty)
        {
            if(!IsEmpty())
            {
                items.Remove(new Patient(name, priorty));
                numItems--;
                ReheapDown(0, numItems - 1);
            }
        }

        public void ReheapDown(int root, int bottom)
        {
            int maxChild;
            int leftChild = root * 2 + 1;
            int rightChild = root * 2 + 2;

            if (leftChild <= bottom)
            {
                if (leftChild == bottom)
                    maxChild = leftChild;
                else
                {
                    if (((Patient)items[leftChild]).priority <= ((Patient)items[rightChild]).priority)
                        maxChild = rightChild;
                    else
                        maxChild = leftChild;
                }
                if (((Patient)items[root]).priority < ((Patient)items[maxChild]).priority)
                {
                    Swap(root, maxChild);
                    ReheapDown(maxChild, bottom);
                }
            }
        }

        public void ReheapUp(int root, int bottom)
        {
            int parent;
            if (bottom > root)
            {
                parent = (bottom - 1) / 2;
                if (((Patient)items[parent]).priority < ((Patient)items[bottom]).priority)
                {
                    Swap(parent, bottom);
                    ReheapUp(root, parent);
                }
            }
        }

        public void Swap(int root, int child)
        {
            Patient temp = new Patient();

            temp = (Patient)items[root];
            items[root] = items[child];
            items[child] = temp;
            //root = child;
            //child = temp;
        }


        //calling patient is correct and remove from lists 
        //but priorty of patients are changiable while press the button
        public string Display()
        {
            String list = "";
            foreach (Patient p in items)
            {
                list += p.name + "\t\t" + p.priority + "\r\n";
                //list += p.name + "\t\t";
                //list += p.priority + "\r\n";
            }
            return list;
        }

        public string Call()
        {
            if (!IsEmpty())
            {
                string result = ((Patient)items[0]).name + " " + ((Patient)items[0]).priority;
                Swap(0, numItems - 1);
                items.RemoveAt(numItems - 1); // arrayList.remove = object remove, arrayList.romoveAt=index
               // items.Remove(numItems - 1);
                numItems--;
                ReheapDown(0, numItems - 1);
                return result;
            }
            else
                return " List is an empty ";
        }



    }
}
