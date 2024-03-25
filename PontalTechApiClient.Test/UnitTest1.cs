using PontalTechApiClient.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PontalTechApiClient.Test; 
[TestClass]
public class UnitTest1 {
    [TestMethod]
    public async Task EnvioSuperFastAsync() {
        var data = DateTime.Now;

        var api = new PontalTech("https://sms-http-api-pointer.pontaltech.com.br/v1", "4cdigitalbot", "1ncChQUw");
        var envio = new EnvioMultiplo {
            flashSms = false,
            urlCallback = "",
            messages = new List<Message> {
                new Message {
                    to = "21980246593",
                    message = "Mensagem de Teste SuperFast",
                    schedule = data
                }
            }
        };

        var statusEnvio = await api.EnviarSuperFast("21980246593", "Mensagem de Teste SuperFast");

        Assert.IsNotNull(statusEnvio);
    }
}