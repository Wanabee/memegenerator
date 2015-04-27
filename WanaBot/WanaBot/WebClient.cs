using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using RestSharp;

namespace WanaBot
{
    public class WebClient
    {
        public static void SendRequest(string requestUrl, string id, string username, string password, string topText, string botText, string unformattedJson)
        {
            var formContent = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string, string>("template_id", id),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("text0", topText),
                new KeyValuePair<string, string>("text1", botText)
            });

            var client = new RestClient(requestUrl);

            var request = new RestRequest("/ressource/", Method.POST);
            request.AddParameter("template_id", id);
            request.AddParameter("username", username);
            request.AddParameter("password", password);
            request.AddParameter("text0", topText);
            request.AddParameter("text1", botText);

            //string formattedJson = JsonHelper.ToJson(unformattedJson);

            //request.AddParameter("application/json; charset=utf-8", formattedJson, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            try
            {
                client.ExecuteAsync(request, response =>
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        //OK
                    }
                    else
                    {
                        //NOK
                    }
                });
            }
            catch (Exception error)
            {
                Debug.WriteLine("Exception occured while sending/receiving json");
                Debug.WriteLine(error.Message);
                Debug.WriteLine(error.StackTrace);
            }
        }
    }
}
