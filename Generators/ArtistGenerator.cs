﻿namespace MusicDatabaseGenerator.Generators
{
    public class ArtistGenerator : AGenerator, IGenerator
    {
        public ArtistGenerator(TagLibFile file, MusicLibraryTrack data)
        {
            _file = file;
            _data = data;
        }

        public void Generate()
        {
            foreach(string artistName in _file.mp3.Tag.Performers)
            {
                _data.artist.Add(new Artist
                {
                    ArtistName = artistName
                });
            }
        }
    }
}
