using ManyHelpers.API;
using PontalTechApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontalTechApiClient {
    public class PontalTech {
        private readonly string _usuario;
        private readonly string _senha;
        private readonly string _baseUrl;


        public PontalTech(string baseUrl, string usuario, string senha) {
            _usuario = usuario;
            _senha = senha;
            _baseUrl = baseUrl;
        }

        public async Task<EnvioMultiplo> EnviarMuitiplos(EnvioMultiplo envioMultiplo) {
            using var api = new CosumingHelper(_baseUrl)
                                        .AddcontentType()
                                        .AddBasicAuthentication(_usuario, _senha);

            var result = await api.PostAsync<EnvioMultiplo, EnvioMultiplo>("/multiple-sms", envioMultiplo);
            return result.result;
        }
         
        public async Task<EnvioMultiplo> EnviarMuitiplosConcatenados(EnvioMultiplo envioMultiplo) {
            using var api = new CosumingHelper(_baseUrl)
                                        .AddcontentType()
                                        .AddBasicAuthentication(_usuario, _senha);

            var result = await api.PostAsync<EnvioMultiplo, EnvioMultiplo>("/multiple-concat-sms", envioMultiplo);
            return result.result;
        }

        public async Task<RespostasSMS> GetRespostasSMS(SMSIds ids) {
            using var api = new CosumingHelper(_baseUrl)
                                        .AddcontentType()
                                        .AddBasicAuthentication(_usuario, _senha);

            var result = await api.PostAsync<SMSIds, RespostasSMS>("/multiple-sms-replies", ids);
            return result.result;
        }

        public async Task<StatusSMS> GetSMSStatus(SMSIds ids) {
            using var api = new CosumingHelper(_baseUrl)
                                        .AddcontentType()
                                        .AddBasicAuthentication(_usuario, _senha);

            var result = await api.PostAsync<SMSIds, StatusSMS>($"/multiple-sms-report", ids);
            return result.result;
        }
    }
}
