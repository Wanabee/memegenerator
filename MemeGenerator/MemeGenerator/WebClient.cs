using System;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace MemeGenerator
{
    public class WebClient
    {
        public static object SendRequest(string requestUrl, string id, string username, string password, string topText, string botText)
        {
            var client = new RestClient(requestUrl);
            var request = new RestRequest(Method.POST);
            var memeUrl = "";
            request.AddParameter("template_id", id);
            request.AddParameter("username", username);
            request.AddParameter("password", password);
            request.AddParameter("text0", topText);
            request.AddParameter("text1", botText);

            try
            {
                var responseValue = client.Execute(request);
                if (responseValue.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("Success sending request");
                    var responseObject = JsonConvert.DeserializeObject<MemeGeneratorModel>(responseValue.Content);
                    memeUrl = responseObject.Success ? responseObject.Data.Url : responseObject.ErrorMessage;
                }
                else
                    Console.WriteLine("Error while sending request");
            }
            catch (Exception error)
            {
                Debug.WriteLine("Exception occured while sending/receiving json");
                Debug.WriteLine(error.Message);
                Debug.WriteLine(error.StackTrace);
            }
            return memeUrl;
        }
    }
}
