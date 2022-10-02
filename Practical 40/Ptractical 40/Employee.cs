namespace PartialClassDemo
{
    internal class Employee
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int Salary { get; internal set; }
        public string Gender { get; internal set; }

        internal void DisplayEmployeeDetails()
        {
            throw new NotImplementedException();
        }

        internal void DisplayFullName()
        {
            throw new NotImplementedException();
        }
    }
}