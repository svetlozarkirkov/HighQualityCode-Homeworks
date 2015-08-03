using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ReformatCode
{
    public class EventHolder
    {
        private readonly OrderedBag<Event> byDate = new OrderedBag<Event>();

        private readonly MultiDictionary<string, Event> byTitle =
            new MultiDictionary<string, Event>(true);

        public void AddEvent(DateTime date, string title, string location)
        {
            var newEvent = new Event(date,
                title,
                location);
            byTitle.Add(
                title.ToLower(),
                newEvent
                );
            byDate.Add(newEvent);
            Application.Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            var title = titleToDelete
                .ToLower();
            var removed = 0;
            foreach (var eventToRemove in byTitle[title])
            {
                removed++;
                byDate.Remove(eventToRemove);
            }
            byTitle.Remove(title);
            Application.Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View
                eventsToShow = byDate.RangeFrom(new Event(
                    date, "", ""),
                    true);
            var showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count) break;
                Application.Messages.PrintEvent(eventToShow);

                showed++;
            }
            if (showed == 0) Application.Messages.NoEventsFound();
        }
    }
}
