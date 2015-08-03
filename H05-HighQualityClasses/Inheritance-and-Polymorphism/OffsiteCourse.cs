namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name, string teacherName, IList<string> students, string town)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.town = value;
                }
                else
                {
                    throw new ArgumentException("Town name should not be empty.");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            result.Append("; Town = ");
            result.Append(this.Town);
            
            result.Append(" }");
            
            return result.ToString();
        }
    }
}
