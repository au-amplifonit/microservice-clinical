using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Clinical.Models
{
    public class Clinical
    {
        public string CustomerId { get; set; }
        public ScreeningListItem[] Screenings { get; set;}
        public AssessmentListItem[] Assessments { get; set; }
    }
}
