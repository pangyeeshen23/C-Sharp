﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsTutorial.TaskManagement.Interface;

namespace GenericsTutorial.TaskManagement
{
    class EmailTask : ITask<string>
    {
        public string Recipient { get; set; }
        public string Message { get; set; }
        public string Perform()
        {
            return $"Email sent to {Recipient} with message: {Message}";
        }
    }
}
