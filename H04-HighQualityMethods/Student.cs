namespace Methods
{
    using System;

    // No validations used for properties - the main method assumes they will be correct
    public class Student
    {
        public Student(string firstName, string lastName, string otherInfo, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
            this.DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsOlderThan(Student other)
        {
            return this.DateOfBirth < other.DateOfBirth;
        }
    }
}
