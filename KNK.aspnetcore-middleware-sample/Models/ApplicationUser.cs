using System.Collections.Generic;

namespace KNK.aspnetcore_middleware_sample.Models
{
    public class ApplicationUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<string> Groups { get; set; }
    }
}
