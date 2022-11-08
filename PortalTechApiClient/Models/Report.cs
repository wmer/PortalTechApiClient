using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontalTechApiClient.Models {
    public class Report {
        public string? id { get; set; }
        public string? to { get; set; }
        public string? message { get; set; }
        public DateTime schedule { get; set; }
        public DateTime sent { get; set; }
        public string? carrier_name { get; set; }
        public DateTime delivered_at { get; set; }
        public string? status { get; set; }
        public string? statusDescription { get; set; }
    }
}