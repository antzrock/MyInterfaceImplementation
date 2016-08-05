using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MyInterface : IMyInterface
    {
        /// <summary> 
        /// Gets the number of count for each unique word (case-sensitive) in the supplied comma-delimited 
        /// list of words 
        /// </summary> 
        /// <param name="commaDelimitedWords">A comma-delimited list of words to be processed</param> 
        /// <returns>The list of unique words, each with the respective number of count</returns>
        public IEnumerable<Tuple<string, int>> GetWordCounts(string commaDelimitedWords)
        {
            string[] words = new string[] { };
                
            if (!String.IsNullOrWhiteSpace(commaDelimitedWords))    
              words = commaDelimitedWords.Split(',').ToArray();

            return words.Cast<string>().GroupBy(
                         k => k.Trim(),
                         StringComparer.InvariantCulture)
                         .Select(w => new Tuple<string, int>(w.Key, w.Count()));
        }

        /// <summary> 
        /// Gets the number of count for each unique word (case-sensitive) in the supplied array of words 
        /// </summary> 
        /// <param name="words">An array of words to be processed</param> 
        /// <returns>The list of unique words, each with the respective number of count</returns>
        public IEnumerable<Tuple<string, int>> GetWordCounts(string[] words)
        {
            if (words == null)
                words = new string[] { };

            return words.Cast<string>().GroupBy(
                         k => k.Trim(),
                         StringComparer.InvariantCulture)
                         .Select(w => new Tuple<string, int>(w.Key, w.Count()));
        }

        /// <summary> 
        /// Checks if the specified bit is set in the given value 
        /// </summary> 
        /// <param name="value">The value the bit of which is to be checked</param> 
        /// <param name="bit">The bit to check</param> 
        /// <returns>true if the specified bit is set, otherwise false</returns>
        public bool IsBitSet(int value, int bit)
        {
            bool bitIsSet = false;

            //Convert to binary string
            string bitString = Convert.ToString(value, 2);

            if (bit < 0 || bit > bitString.Length - 1)
                bitIsSet = false;
            else
            {
                if (bitString[bit] == '1')
                    bitIsSet = true;
                else
                    bitIsSet = false;
            }

            return bitIsSet;
        }

        /// <summary> 
        /// Gets the bits that are set in the given value 
        /// </summary> 
        /// <param name="value">The value the bits of which are to be checked</param> 
        /// <returns>The bits that are set in the given value</returns>
        public IEnumerable<int> GetBitsSet(int value)
        {
            //Convert to binary string
            string bitString = Convert.ToString(value, 2);

            return Enumerable.Range(0, bitString.Length).Where(x => bitString[x] == '1');
        }

        /// <summary> 
        /// Sets the specified bits in the given value 
        /// </summary> 
        /// <param name="value">The value the bits of which are to be set</param> 
        /// <param name="bitsToSet">The bits to set in the given value</param> 
        /// <returns>The new value after the specified bits are set</returns>
        public int SetBits(int value, int[] bitsToSet)
        {
            //Convert to binary string
            string bitString = Convert.ToString(value, 2);
            StringBuilder bitStringBuilder = new StringBuilder(bitString);

            foreach(int index in bitsToSet)
            {
                //Out of range positive and negative...
                if (index > bitString.Length || index < 0)
                    continue;

                bitStringBuilder.Remove(index - 1, 1);
                bitStringBuilder.Insert(index - 1, '1');
            }

            string newBitString = bitStringBuilder.ToString();

            return Convert.ToInt32(bitStringBuilder.ToString(), 2);
        }

    }
}
