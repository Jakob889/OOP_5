using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class StateClose : IFileState
    {
        public void close(File file)
        {
            Console.WriteLine($"unable to close file '{file.FileName}' in current state '{GetType().Name}'");
        }

        public  void delete(File file)
        {
            Console.WriteLine($"Deleting file {file.FileName}");
            file.changeState(new StateDelete());
        }

        public  void open(File file)
        {
            Console.WriteLine($"Opening file {file.FileName}");
            file.changeState(new StateOpen());
        }
    }
}
