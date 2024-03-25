using HelpersLib.Strings;
using HelpersLibs.Web;
using PontalTechApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PontalTechApiClient {
    public class PontalTech {
        private readonly string _usuario;
        private readonly string _senha;
        private readonly string _baseUrl;
        private readonly HttpClientHelper _api;


        public PontalTech(string baseUrl, string usuario, string senha) {
            _usuario = usuario;
            _senha = senha;
            _baseUrl = baseUrl;
            _api = new HttpClientHelper(_baseUrl)
                                        .AddcontentType()
                                        .AddBasicAuthentication(_usuario, _senha);
        }

        public async Task<string> EnviarSuperFast(string telefone, string message) {
            var apiKey = StringHelper.Base64Encode($"{_usuario}:{_senha}");

            var result = await _api.GetAsync<string>($"/message?to={telefone}&message={message}&apikey={apiKey}");
            return result.result;
        }

        public async Task<EnvioMultiplo> EnviarMuitiplos(EnvioMultiplo envioMultiplo) {
            var result = await _api.PostAsync<EnvioMultiplo, EnvioMultiplo>("/multiple-sms", envioMultiplo);
            return result.result;
        }
         
        public async Task<EnvioMultiplo> EnviarMuitiplosConcatenados(EnvioMultiplo envioMultiplo) {
            var result = await _api.PostAsync<EnvioMultiplo, EnvioMultiplo>("/multiple-concat-sms", envioMultiplo);
            return result.result;
        }

        public async Task<RespostasSMS> GetRespostasSMS(SMSIds ids) {
            var result = await _api.PostAsync<SMSIds, RespostasSMS>("/multiple-sms-replies", ids);
            return result.result;
        }

        public async Task<StatusSMS> GetSMSStatus(SMSIds ids) {
            var result = await _api.PostAsync<SMSIds, StatusSMS>($"/multiple-sms-report", ids);
            return result.result;
        }
    }
}
