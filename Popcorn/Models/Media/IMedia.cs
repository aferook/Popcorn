﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Popcorn.Models.Subtitles;
using Popcorn.Models.Torrent;
using Popcorn.Models.Torrent.Show;
using Popcorn.Utils;

namespace Popcorn.Models.Media
{
    public interface IMedia
    {
        ObservableCollection<ITorrent> AvailableTorrents { get; set; }

        ObservableCollection<Subtitle> AvailableSubtitles { get; set; }

        Subtitle SelectedSubtitle { get; set; }

        bool WatchInFullHdQuality { get; set; }

        bool FullHdAvailable { get; set; }

        string Title { get; set; }

        string ImdbId { get; set; }

        int? Season { get; set; }

        int? EpisodeNumber { get; set; }

        MediaType Type { get; }
    }
}
