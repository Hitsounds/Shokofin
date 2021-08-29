using System.Collections.Generic;
using Shokofin.API.Models;

namespace Shokofin.API.Info
{
    public class SeriesInfo
    {
        public string Id;

        public System.Guid Guid;

        public Series Shoko;

        public Series.AniDB AniDB;

        public string TvDBId;

        /// <summary>
        /// All episodes (of all type) that belong to this series.
        /// </summary>
        public List<EpisodeInfo> EpisodeList;

        /// <summary>
        /// A pre-filtered list of special episodes without an ExtraType
        /// attached.
        /// </summary>
        public List<EpisodeInfo> FilteredSpecialEpisodesList;
    }
}