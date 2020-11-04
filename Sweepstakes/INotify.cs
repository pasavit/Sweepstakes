using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface INotify
    {
        INotify Winner { get; set; }
        void Notify(INotify subscriber);
    }
}
