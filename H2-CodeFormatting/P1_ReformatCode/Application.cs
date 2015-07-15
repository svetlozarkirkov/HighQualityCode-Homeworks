﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ReformatCode
{
    internal class Application
    {
        private static readonly StringBuilder output = new StringBuilder();
        private static readonly EventHolder events = new EventHolder();

        static void Main()
        {
            while (ExecuteNextCommand())
            {
            }
            Console.WriteLine(output);
        }

        private static bool ExecuteNextCommand()
        {
            var command = Console.ReadLine();
            if (command[0] == 'A')
            {
                AddEvent(command);
                return true;
            }
            if (command[0] == 'D')
            {
                DeleteEvents(command);
                return true;
            }

            if (command[0] == 'L')
            {
                ListEvents(command);
                return true;
            }
            if (command[0] == 'E')
            {
                return false;
            }
            return false;
        }

        private static void ListEvents(string command)
        {
            var pipeIndex = command.IndexOf('|')
                ;
            var date = GetDate(
                command,
                "ListEvents");
            var countString = command.Substring(
                pipeIndex + 1
                );

            var count = int.Parse(countString);
            events.ListEvents(date,
                count);
        }

        private static void DeleteEvents(string command)
        {
            var title = command.Substring
                (
                    "DeleteEvents".Length + 1
                );

            events.DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);

            events.AddEvent(date, title, location);
        }

        private static void GetParameters
            (string commandForExecution, string commandType, out DateTime dateAndTime,
            out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            var firstPipeIndex = commandForExecution.IndexOf('|');
            var lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle =
                    commandForExecution.Substring(firstPipeIndex
                                                  + 1).Trim();
                eventLocation = "";
            }
            else
            {
                eventTitle = commandForExecution.Substring(
                    firstPipeIndex + 1,
                    lastPipeIndex - firstPipeIndex - 1)
                    .Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            var date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }
    }
}
