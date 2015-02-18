using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Runtime.Serialization;
using DDay.Collections;

namespace DDay.iCal
{
    /// <summary>
    /// A collection of calendar objects.
    /// </summary>
#if !SILVERLIGHT
    [Serializable]
#endif
    public class CalendarObjectList :
        GroupedList<string, ICalendarObject>,
        ICalendarObjectList<ICalendarObject>
    {
        #pragma warning disable 0414
        ICalendarObject _Parent;
        #pragma warning restore 0414

        public CalendarObjectList(ICalendarObject parent)
        {
            _Parent = parent;
        }
    }
}
