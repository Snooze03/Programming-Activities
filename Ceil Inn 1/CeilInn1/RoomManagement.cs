using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace CeilInn1
{
    [Serializable]
    public class RoomManagement<T> : Collection<T>
    {
        public RoomManagement()
            : base()
        {
        }

        public RoomManagement(IList<T> list)
            : base(list)
        {
        }

        public virtual new IList<T> Items
        {
            get
            {
                return this;
            }
        }

        public new void InsertItem(int index, T item)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("The value you provided " +
                                                      "for the index is not valid");
            else if ((index >= 0) && (index <= Count))
                base.InsertItem(index, item);
            else // If the index is higher than Count, simply add the item (at the end of the list)
                this.Add(item);
        }
    }
}
