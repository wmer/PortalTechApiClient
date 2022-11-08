using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontalTechApiClient.Models {
    public class Reply {
        public string? messageId { get; set; }
        public string? reference { get; set; }
        public object? accountId { get; set; }
        public string? message { get; set; }
        public DateTime received { get; set; }
        public string? from { get; set; }
    }
}
