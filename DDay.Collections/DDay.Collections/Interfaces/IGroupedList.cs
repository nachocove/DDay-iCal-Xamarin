using System;
using System.Collections.Generic;
using System.Text;

namespace DDay.Collections
{
    public interface IGroupedList<TGroup, TItem> :
        IGroupedCollection<TGroup, TItem>,
        IList<TItem>
        where TItem : class, IGroupedObject<TGroup>
    {
        /// <summary>
        /// Returns the index of the given item
        /// within the list, or -1 if the item
        /// is not found in the list.
        /// </summary>
        #pragma warning disable 0108
        int IndexOf(TItem obj);
        #pragma warning restore 0108

        /// <summary>
        /// Gets the object at the specified index.
        /// </summary>
        #pragma warning disable 0108
        TItem this[int index] { get; }
        #pragma warning restore 0108

    }
}
