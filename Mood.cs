using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_ExceptionHandling
{
    public class Mood
    {
        private string message;

        public Mood()
        {
            message = "";
        }

        public Mood(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Mood other = (Mood)obj;
            return this.message.Equals(other.message);
        }

        public override int GetHashCode()
        {
            return message.GetHashCode();
        }
    }   
}

