using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom12.DTO
{
    class Question
    {
        public String question;
        public List<String> answers;
        public String id;

        public Question(string question, List<string> answers, String id)
        {
            this.question = question;
            this.answers = answers;
            this.id = id;
        }
    }
}
