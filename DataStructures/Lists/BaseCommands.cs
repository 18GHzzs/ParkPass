namespace ParkPass.DataStructures
{
    //<summary>
    /// Represents the base class for handling commands related to managing lists.
    /// </summary>
    public abstract class BaseCommands
    {
        /// <summary>
        /// Adds a new node to the list.
        /// </summary>
        /// <param name="name">The name of the individual.</param>
        /// <param name="course">The course of the individual.</param>
        /// <param name="vehiclePlate">The vehicle plate of the individual.</param>
        public abstract void addNode(string name, string course, string vehiclePlate);

        /// <summary>
        /// Removes a node from the list.
        /// </summary>
        /// <param name="name">The name of the individual.</param>
        /// <param name="course">The course of the individual.</param>
        /// <param name="vehiclePlate">The vehicle plate of the individual.</param>
        public abstract void removeNode(string name, string course, string vehiclePlate);

        /// <summary>
        /// Searches for a node in the list.
        /// </summary>
        /// <param name="name">The name of the individual.</param>
        /// <param name="course">The course of the individual.</param>
        /// <param name="vehiclePlate">The vehicle plate of the individual.</param>
        /// <returns>The found node, or null if not found.</returns>
        public abstract BaseList searchNode(string name, string course, string vehiclePlate);

    }
}
