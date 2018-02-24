using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        //Current Column
        public JobFieldType Column { get; set; }

        //All Columns, for displayC:\Users\jerem\lc101\source\repos\csharp-exercises\TechJobsOO\src\TechJobs\Views\Job\Index.cshtml
        public List<JobFieldType> Columns { get; set; }

        //View Title
        public string Title { get; set; } = "";

        public BaseViewModel()
        {
            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
        }
    }
}
