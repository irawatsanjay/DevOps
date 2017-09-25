using System.IO;

namespace DevOpsAssignment
{
    public class OutputString
    {
        private readonly string _filePath;
        public OutputString(string filePath)
        {
            _filePath = filePath;
        }
        public void Save(string inputString)
        {
            using (var writer = File.CreateText(_filePath))
            {
                writer.Write(inputString);
            }
        }
        
    }
}
