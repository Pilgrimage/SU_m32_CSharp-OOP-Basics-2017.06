namespace p04_OnlineRadioDatabase
{
    using System;

    public class Song
    {
        private string artistName;
        private string songName;
        private int totalSongLengthInSeconds;

        public Song(string artistName, string songName, string time)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.TotalSongLengthInSeconds = Validator.TimeValidate(time);
        }

        public string ArtistName
        {
            get { return this.artistName; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }
                this.artistName = value;
            }
        }

        public string SongName
        {
            get { return this.songName; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                }
                this.songName = value;
            }
        }

        public int TotalSongLengthInSeconds
        {
            get { return this.totalSongLengthInSeconds; }
            private set { this.totalSongLengthInSeconds = value; }
        }
    }
}
