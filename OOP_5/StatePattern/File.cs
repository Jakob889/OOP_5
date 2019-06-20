using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class File
    {
        public IFileState State { get; set; }
        
        public string FileName { get; set; }

        public File(string newFileName)
        {
            FileName = newFileName;
            State = new StateClose();
        }
        
        public void open()
        {
           State.open(this);
        }

        public void close()
        {
            State.close(this);
        }

        public void delete()
        {
            State.delete(this);
        }

        public void getState()
        {
            Console.WriteLine($"Current state of '{FileName}' = {State.GetType().Name}");
        }

        public void changeState(IFileState newState)
        {
            Console.WriteLine($"Change State from '{State.GetType().Name}' to '{newState.GetType().Name}'");
            State = newState;
        }

    }
}
