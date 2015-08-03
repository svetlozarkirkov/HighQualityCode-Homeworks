namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string courseName, string teacherName, IList<string> students, string labName)
            : base(courseName, teacherName, students)
        {
            this.Lab = labName;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.lab = value;
                }
                else
                {
                    throw new ArgumentException("Lab name should not be empty.");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            
            result.Append("; Lab = ");
            result.Append(this.Lab);
            
            result.Append(" }");
            
            return result.ToString();
        }
    }
}
