using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    internal class Answer
    {
        int id { get; set; }
        string answer { get; set; }

        public Answer(int id, string answer)
        {
            this.id = id;
            this.answer = answer;
        }

        public override string ToString()
        {
            return $"Answer ID: {id}, Answer: {answer}";
        }
    }
}
