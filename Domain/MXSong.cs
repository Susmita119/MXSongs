using System;

namespace Domain
{
    public class MXSong
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Movie { get; set; }
        public DateTime Date { get; set; }
    }
}