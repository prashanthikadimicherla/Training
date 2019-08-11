using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.DataAccess.Model
{
    public class TrainingDetails
    {
        public int Id { get; set; }

        public string TrainingName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
