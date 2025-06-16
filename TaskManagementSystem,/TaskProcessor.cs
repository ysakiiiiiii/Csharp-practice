using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem_
{
    internal class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
        private TTask _task;

        public TaskProcessor(TTask task)
        {
           _task = task;
        }

        public TResult Execute()
        {
            _task.Perform();
        }
    }
}
