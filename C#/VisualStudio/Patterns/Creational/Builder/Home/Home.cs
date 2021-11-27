using System.Collections.Generic;

namespace Builder
{
    // Класс дома, который мы строим
    public class Home
    {
        // Который имеет поле листа с частями дома
        private List<string> parts = new List<string>();

        // Метод добавления элемента дома
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        // Метод перечисления элементов дома
        public string ListParts()
        {
            string result = string.Empty;

            for (int i = 0; i < this.parts.Count; i++)
            {
                result += this.parts[i];

                if (i != this.parts.Count - 1)
                    result += ", ";
            }

            if (result == string.Empty)
                return "Home parts: none";
            else
                return "Home parts: " + result;
        }
    }
}