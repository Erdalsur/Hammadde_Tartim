using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Tipler
{
    [Flags]
    public enum DaysOfWeek
    {
        None = 0,
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Weekdays = Monday | Tuesday | Wednesday | Thursday | Friday,
        Saturday = 64,
        Weekend = Sunday | Saturday,
        All = Sunday | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday
    }
    [Flags]
    public enum DayType
    {
        Weekday = 1,
        Weekend = 2,
        Holiday = 4
    }
}
