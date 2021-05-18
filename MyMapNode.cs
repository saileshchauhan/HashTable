using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasTable
{
    class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        LinkedList<KeyValue<K, V>> linkedList;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key); 
            linkedList = GetLinkedList(position);
            if (Exists(key))
            {
                Remove(key);
            }
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
         
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        public void  Display()
        {
            foreach (var item in items)
            {
                if (item != null)
                {
                    foreach (KeyValue<K, V> keyValuePair in item)
                    {
                        Console.WriteLine(keyValuePair.Key + "\t\t" + keyValuePair.Value);
                    }
                }
                
            }
        }
        public bool  Exists(K word)
        {
            foreach (var subitem in items)
            {
                if (subitem != null)
                {
                    foreach (KeyValue<K, V> item in subitem)
                    {
                        if (item.Key.Equals(word))
                        {
                           return true;
                        }
                    }
                }
            }
            return false;
        }
        public void Word_Frequency(string sentences, MyMapNode<string, int> Dictionary)
        {
            string[] words = sentences.Split(' ');
            foreach (var word in words)
            {
                if (Dictionary.Exists(word))
                {
                    Dictionary.Add(word, Dictionary.Get(word) + 1);
                }
                else
                {
                    Dictionary.Add(word,1);
                }
            }
            
        }

        

    }
    
    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }

}
