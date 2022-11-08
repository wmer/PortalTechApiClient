using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontalTechApiClient.Models {
    public class EnvioMultiplo {
        public string? id { get; set; }
        public string? urlCallback { get; set; }
        public bool flashSms { get; set; }
        public List<Message>? messages { get; set; }
    }
}
