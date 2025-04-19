using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarificationAndPercision.Exception_Handling
{
    class FileManager
    {
        public void ReadFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File not found :" + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied :" + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception :" + ex.Message);
            }
        }
    }
}
