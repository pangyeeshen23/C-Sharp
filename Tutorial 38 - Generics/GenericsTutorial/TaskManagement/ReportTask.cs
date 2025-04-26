using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsTutorial.TaskManagement.Interface;

namespace GenericsTutorial.TaskManagement
{
    class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }
        public string Perform()
        {
            return $"Report generated: {ReportName}";
        }
    }
}
