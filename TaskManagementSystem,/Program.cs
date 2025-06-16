using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailTask = new EmailTask()
            {
                Message= "Test email",
                Recipient="sample@example.com"
            };

            var reportTask = new ReportTask()
            {
                ReportName = "Annual Report"
            };

            var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute());
        }
    }
}
