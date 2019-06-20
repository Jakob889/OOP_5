using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class StateOpen : IFileState
    {
        public void close(File file)
        {
            Console.WriteLine($"Closing file {file.FileName}");
            file.changeState(new StateClose());
        }

        public void delete(File file)
        {
            Console.WriteLine($"unable to delete file '{file.FileName}' in current state '{GetType().Name}'");
        }

        public void open(File file)
        {
            Console.WriteLine($"unable to open file '{file.FileName}' in current state '{GetType().Name}'");
        }
    }
}
