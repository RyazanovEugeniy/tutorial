using System.Collections.Generic;

namespace Builder
{
    public class Home
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public string ListParts()
        {
            string result = string.Empty;

            for (int i = 0; i < this.parts.Count; i++)
            {
                result += this.parts[i];

                if (i != this.parts.Count - 1)
                    result += ", ";
            }

            return "Home parts: " + result + "\n";
        }
    }
}