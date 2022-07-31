using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    /// <summary>
    /// Brackets operation class
    /// </summary>
    public class Brackets
    {
        /// <summary>
        /// Check if an open bracket matches its close one
        /// </summary>
        /// <param name="open">Informed open bracket</param>
        /// <param name="close">Informed open bracket</param>
        /// <returns>Bool indicating wheter open and close bracket match</returns>
        private bool matchOpenCloseBrackets(Char open, Char close)
        {
            return new Dictionary<Char, Char>()
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' },
            }[open] == close;
        }

        /// <summary>
        /// Check if bracket is of closing
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        private bool isClosingBracket(Char bracket)
        {
            return new List<Char>() { ')', ']', '}' }.Contains(bracket);
        }

        /// <summary>
        /// Check if bracket is of opening
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        private bool isOpeningBracket(Char bracket)
        {
            return new List<Char>() { ')', ']', '}' }.Contains(bracket);
        }

        /// <summary>
        /// Calculates if a brackets string list is balanced and prints to console
        /// </summary>
        /// <param name="inputs">A list of brackets string</param>
        public void Calculate(List<string> inputs)
        {
            foreach (string input in inputs)
            {
                Console.WriteLine(String.Format("Input: {0} - is balanced: {1}", input, this.IsBalanced(input)));
            }
        }

        /// <summary>
        /// Check if a brackets string is balanced.
        /// 
        /// Two brackets are considered to be a matched pair if the an opening bracket 
        /// (i.e., (, [, or {) occurs to the left of a closing bracket (i.e., ), ], or }) 
        /// of the exact same type. There are three types of matched pairs of brackets: [], {}, and ().
        /// A matching pair of brackets is not balanced if the set of brackets it encloses are not matched.
        /// </summary>
        /// <param name="input">Brackets string</param>
        /// <returns>YES for balanced or NO</returns>
        public string IsBalanced(String input)
        {
            List<char> openBrackets = new List<char>();

            foreach (Char item in input.ToCharArray())
            {
                // No-bracket character invalidates the balancing
                if(!this.isClosingBracket(item) && !this.isOpeningBracket(item))
                {
                    return "NO";
                }

                // For every close bracket, check if previous char is a matched open bracket
                if (this.isClosingBracket(item))
                {
                    if (!this.matchOpenCloseBrackets(openBrackets.Last(), item))
                    {
                        return "NO";
                    }

                    // Remove last open bracket
                    openBrackets.RemoveAt(openBrackets.Count - 1);
                }
                else
                {
                    // Open brackets are added to the list
                    openBrackets.Add(item);
                }
            }

            // At the end of loop, check if there are open brackets without any closing
            if (openBrackets.Count > 0)
            {
                return "NO";
            }

            // String is balanced
            return "YES";
        }
    }
}
