using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGrandRestaurant;

namespace TestGrandRest.Recette
{
    internal class DatabaseTableRepository : IList<Table>
    {
        private IEnumerator<Table> _enumerator;

        public  IEnumerator<Table> GetEnumerator()
        {
            return _enumerator;
        }

        public IEnumerator<Table> GetEnumerator(IEnumerator<Table> monEnumerateur)
        {
            return monEnumerateur ; 
        }


        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()

        {
            return GetEnumerator(_enumerator);
        }


        /// <inheritdoc />
        public void Add(Table item)
        {
            //throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Clear()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool Contains(Table item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void CopyTo(Table[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool Remove(Table item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public int Count { get; }

        /// <inheritdoc />
        public bool IsReadOnly { get; }

        public bool EstVide { get; set; }

        /// <inheritdoc />
        public int IndexOf(Table item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Insert(int index, Table item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc />
        public void Affecter(Client monClient)
        {
            this.EstVide = false ;
        }

        public override bool Equals(object? obj)
        {
            return obj is DatabaseTableRepository repository &&
                   EqualityComparer<IEnumerator<Table>>.Default.Equals(_enumerator, repository._enumerator);
        }

        /// <inheritdoc />
        public Table this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
