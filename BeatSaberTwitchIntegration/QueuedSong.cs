﻿using System;
using SongLoaderPlugin;

namespace TwitchIntegrationPlugin
{
    public class QueuedSong
    {
        
        public string _songName;
        public string _beatName;
        public string _authName;
        public float  _bpm;
        public  string _id;

        public QueuedSong(String songname, String beatname, String authname, String bpm, String id)
        {
            _songName = songname;
            _beatName = beatname;
            _authName = authname;
            _id = id;
            _bpm = float.Parse(bpm, System.Globalization.CultureInfo.InvariantCulture);
        }
    
        public bool CompareSongs(CustomSongInfo song)
        {
            if(_songName == song.songName && _authName == song.authorName && _bpm == song.beatsPerMinute)
            {
                return true;
            }
            return false;
        }
    }
    
}