using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class OtusDictionary
    {
        public OtusDictionary()
        {
            capacity = 32;
            keys = new int[capacity];
            values = new string[capacity];
        }
        private int capacity;
        private int[] keys;
        private string[] values;
        public string Get(int key)
        {
            int index = GetIndex(key, capacity);
            return values[index];
        }
        public void Add(int key, string value)
        {
            if (value == null)
                throw new ArgumentNullException();

            while (true)
            {
                int index = GetIndex(key, capacity);
                if (values[index] == null || keys[index] == key)
                {
                    values[index] = value;
                    keys[index] = key;
                    return;
                }
                else Resize();
            }
        }

        private int GetIndex(int key, int capacity)
        {
            int index = key % capacity;
            if (index < 0) index += capacity;
            return index;
        }

        private void Resize()
        {
            int oldcapacity = capacity;
            capacity *= 2;
            int[] _newkeys = new int[capacity];
            string[] _newvalues = new string[capacity];
            for (int i = 0; i < oldcapacity; i++)
            {
                if (values[i] == null) continue;
                int index = GetIndex(keys[i],oldcapacity);
                _newkeys[index] = keys[i];
                _newvalues[index] = values[i];
            }
            keys = _newkeys;
            values = _newvalues;
        }

    }
}
