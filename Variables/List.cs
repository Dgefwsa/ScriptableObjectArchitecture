using System;
using System.Collections.Generic;
using UnityEngine;

namespace Variables
{
    public abstract class ListVariable<T> : ScriptableObject
    {
        public List<T> Items = new List<T>();
        
        public void Add(T t)
        {
            Items.Add(t);
        }
        public void Remove(T t)
        {
            Items.Remove(t);
        }
        public void RemoveAt(int index)
        {
            Items.RemoveAt(index);
        }
    }
}