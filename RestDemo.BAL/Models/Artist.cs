using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RestDemo.Core.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Music> Musics { get; set; } = new Collection<Music>();
    }
}
