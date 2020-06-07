using System;

namespace Mikebm.TestLibrary
{
    /// <summary>
    /// Class used to get a greeting.
    /// </summary>
    public class Foobar
    {
        /// <summary>
        /// Gets a greeting message.
        /// </summary>
        /// <returns>A string containing the text "Hello World!".</returns>
        public string GetGreeting()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="a">The first number to add.</param>
        /// <param name="b">The second number to add.</param>
        /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public int DoAddition(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Gets the number seven.
        /// </summary>
        /// <returns>7</returns>
        public int GetSeven()
        {
            return 7;
        }
    }
}
