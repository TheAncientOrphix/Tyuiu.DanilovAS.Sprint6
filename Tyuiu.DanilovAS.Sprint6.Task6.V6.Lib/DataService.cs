using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DanilovAS.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            List<string> foundWords = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t', '\r', '\n', '.', ',', ';', ':', '!', '?', '"', '\'' },
                                         StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Проверяем, содержит ли слово букву 'b' или 'B'
                        if (word.Contains('b') || word.Contains('B'))
                        {
                            foundWords.Add(word);
                        }
                    }
                }
            }
            return string.Join(" ", foundWords);
        }
    }
}
