using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem_
{
    internal interface ITask<TResult>
    {
        TResult Perform();                  
    }
}
