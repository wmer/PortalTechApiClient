using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontalTechApiClient.Models {
    public class Message {
        public string id { get; set; }
        public string to { get; set; }
        public string? message { get; set; }
        public DateTime schedule { get; set; }
        public DateTime sent { get; set; }
        public string? reference { get; set; }
        public string? account { get; set; }
        public string? from { get; set; }
        public int status { get; set; }
        public string? statusDescription { get; set; }
        public string? carrierName { get; set; }
    }
}
