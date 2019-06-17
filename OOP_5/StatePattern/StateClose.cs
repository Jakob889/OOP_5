using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class StateClose : FileState
    {
        public override void close(File file)
        {
            Console.WriteLine("Closed");
            File.SetClose;
        }

        public override void delete(File file)
        {
            throw new NotImplementedException();
        }

        public override void open(File file)
        {
            throw new NotImplementedException();
        }
    }
}
