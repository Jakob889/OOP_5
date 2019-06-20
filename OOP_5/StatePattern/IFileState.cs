using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IFileState
    {
        void close(File file);

        void open(File file);

        void delete(File file);
    }
}
