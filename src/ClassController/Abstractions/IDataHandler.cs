namespace ClassController.Abstractions
{
    /// <summary>
    /// Interface for handling data operations.
    /// This interface is only to define the contract for data handling and does not specify any methods, connections or servers.
    /// </summary>
    /// <typeparam name="T">Type of the element to handle</typeparam>
    public interface IDataHandler<T>
    {
        /// <summary>
        /// Saves the data.
        /// </summary>
        /// <typeparam name="T">Type of the element to save</typeparam>
        /// <param name="filePath">The file path.</param>
        /// <param name="data">The data.</param>
        /// <returns>True if the data is saved successfully; otherwise, false.</returns>
        public bool SaveData(List<T> data);

        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <typeparam name="T">Type of the element to load</typeparam>
        /// <param name="filePath">The file path.</param>
        /// <returns>The loaded data.</returns>
        public List<T> LoadData();
    }
}
