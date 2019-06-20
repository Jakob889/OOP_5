using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class StateDelete : IFileState
    {
        public void close(File file)
        {
            Console.WriteLine($"unable to close file '{file.FileName}' in current state '{GetType().Name}'");
        }

        public  void delete(File file)
        {
            Console.WriteLine($"unable to close file '{file.FileName}' in current state '{GetType().Name}'");
        }

        public  void open(File file)
        {
            Console.WriteLine($"unable to close file '{file.FileName}' in current state '{GetType().Name}'");
        }
    }
}
