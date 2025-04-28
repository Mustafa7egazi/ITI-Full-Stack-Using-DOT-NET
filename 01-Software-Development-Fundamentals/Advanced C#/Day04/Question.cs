using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    internal class Question
    {
        int id { get; set; }
        string header { get; set; }
        string body { get; set; }

        public Question(int id, string header, string body)
        {
            this.id = id;
            this.header = header;
            this.body = body;
        }

        public override string ToString()
        {
            return $"Question ID: {id}, Header: {header}, Body: {body}";
        }
    }
}
