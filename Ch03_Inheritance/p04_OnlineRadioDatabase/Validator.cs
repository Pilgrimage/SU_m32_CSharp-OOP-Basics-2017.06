namespace p04_OnlineRadioDatabase
{
    using System;
    using System.Text.RegularExpressions;

    public static class Validator
    {
        public static int TimeValidate(string time)
        {

            Match match = Regex.Match(time, "^([0-9]+):([0-9]+)$");

            if (!match.Success)
            {
                throw new ArgumentException("Invalid song length.");
            }

            int minutes = int.Parse(match.Groups[1].Value);
            int seconds = int.Parse(match.Groups[2].Value);

            if (minutes < 0 || minutes > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            else if (seconds < 0 || seconds > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            
            // Return length in seconds
            return minutes*60+seconds;
        }
    }
}
