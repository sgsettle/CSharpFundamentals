using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository.Content
{
    public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; }

        // All of these properties can be modified to use only getters
        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }
    }

    public class Episode : StreamingContent
    {
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }

    }
}
