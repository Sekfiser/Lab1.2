namespace Lab1._2
{
    /// <summary>
    /// Interface of summable arrays.
    /// </summary>
    interface IArray
    {
        /// <summary>
        /// Arguments from console line
        /// </summary>
        string[] Args { get; set; }
        /// <summary>
        /// Array that will be summed 
        /// </summary>
        int[] Digits { get; set; }
        /// <summary>
        /// Method to sum digits in array
        /// </summary>
        /// <returns>Returns sum of integer digits in array</returns>
        int Sum();
        /// <summary>
        /// Method to multiply digits in array
        /// </summary>
        /// <returns>Returns production of integer digits in array</returns>
        int Multi();
    }
}
