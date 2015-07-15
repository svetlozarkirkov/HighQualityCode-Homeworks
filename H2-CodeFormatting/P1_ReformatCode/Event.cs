using System;
using System.Text;

namespace P1_ReformatCode
{
    internal class Event : IComparable
    {
        public DateTime date;
        public string location;
        public string title;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            var other = obj as Event;
            var byDate = date.CompareTo(other.date);
            var byTitle = title.CompareTo(other.title);
            var byLocation = location.CompareTo(other.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                return byTitle;
            }
            return byDate;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            result.Append(" | " + title);

            if (!string.IsNullOrEmpty(location))
            {
                result.Append(" | " + location);
            }
            return result.ToString();
        }
    }
}