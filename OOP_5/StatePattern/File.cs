using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class File
    {
        FileState State = new StateClose();
        private string FileName;

        public File(File file)
        {
            FileName = file;
        }
   
        public void SetOpen()
        {
            switch (State)
            {
                case State = StateOpen:
                    Console.WriteLine('unable to open file 'this.FileName' in current state 'this.State );
                    break;

                case State = StateDelete:
                    Console.WriteLine('unable to open file 'this.FileName' in current state 'this.State);
                    break;

                case State = StateClose:
                    State.SetOpen(this);
                    Console.WriteLine('changed State from 'this.FileName' to' this.State);
            }
            
        }

        public void SetClose()
        {
            Status = "Close";
        }

        public void SetDelete()
        {
            Status = "Delete";
        }

    }
}
