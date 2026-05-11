using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tubes.Repository
{
    internal class Repo<T>
    {
        private readonly List<T> dataStore = new List<T>();

        public void Add(T item)
        {
            dataStore.Add(item);
        }

        public void Delete(T item)
        {
            dataStore.Remove(item);
        }

        public List<T> GetAll()
        {
            return dataStore;
        }
    }
}
