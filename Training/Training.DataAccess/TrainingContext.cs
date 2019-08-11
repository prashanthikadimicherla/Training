using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Model;

namespace Training.DataAccess
{
    public class TrainingContext : DbContext
    {
        public DbSet<TrainingDetails> TrainingDetails { get; set; }
    }
}
