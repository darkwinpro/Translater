using System;
using System.Text;

namespace ExtraSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            Dictionary[] glossary = new Dictionary[number];
            
            
            for (var i = 0; i < glossary.Length; i++)
            {
                glossary[i] = new Dictionary();
                glossary[i]._input = Console.ReadLine();
            }
            for (var i = 0; i < glossary.Length; i++)
            {
                glossary[i]._output = Console.ReadLine();
            }

            var originalString = Console.ReadLine();
            string[] words = originalString.Split(new char[] { ' ' });

            var resultString = new StringBuilder();
            
            for (var i = 0; i < words.Length; i++)
            {
                string temp = String.Empty;
                for (var j = 0; j < glossary.Length; j++)
                {
                    if (words[i].Equals(glossary[j]._input))
                    {
                        temp = glossary[j]._output;
                        break;
                    }
                    temp = words[i];
                }

                resultString.Append(temp + " ");

            }
            Console.WriteLine(resultString);
        }
    }

    public class Dictionary
    {
        public string _input;
        public string _output;
        
    }
}