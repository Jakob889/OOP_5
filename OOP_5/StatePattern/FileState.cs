using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    abstract interface FileState
    {
        public abstract void close(File file);

        public abstract void open(File file);

        public abstract void delete(File file);
    }
}
