using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class PermenentUser
    {
        public int id { get; set; }
        public string jobName { get; set; }
        public string qualification { get; set; }
        public int fileNumber { get; set; }
        public int installmentNumber { get; set; }
        public DateTime installmentDate { get; set; }
        public DateTime preRankDate { get; set; }
        public DateTime currentRankDate  { get; set; }
        public int jobGroupId { get; set; }
        public int jobDegreeId { get; set; }

        //navigation properties

        public JobGroup jobGroup { get; set; }
        public JobDegree jobDegree { get; set; }

    }
}