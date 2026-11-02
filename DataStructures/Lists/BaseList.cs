namespace ParkPass.DataStructures
{
    //<summary>
    /// Represents the base class for managing lists of individuals.
    /// </summary>
    public class BaseList
    {
        public string name;

        public string course;

        public string vehiclePlate;

        public bool is_Staff = false;

        public BaseList? next = null;
        public BaseList? prev = null;

        public BaseList(string name, string course, string vehiclePlate) 
        {
            this.name = name;
            this.course = course;
            this.vehiclePlate = vehiclePlate;
        } 
    }
}
