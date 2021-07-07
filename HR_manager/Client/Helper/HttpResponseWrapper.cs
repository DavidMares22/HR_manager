using HR_manager.Shared.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HR_manager.Client.Helper
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T response, bool success, HttpResponseMessage httpResponseMessage)
        {
            Success = success;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        public bool Success { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }
        public object Content { get; internal set; }

        public async Task<ErrorResponse> GetBody()
        {
            string response = await HttpResponseMessage.Content.ReadAsStringAsync();



            ErrorResponse x = JsonConvert.DeserializeObject<ErrorResponse>(response);
            

            //Console.WriteLine(x.errors.Email[0]);

            return x;
        }
        public async Task<SuccessResponse> GetBodySuccess()
        {
            string response = await HttpResponseMessage.Content.ReadAsStringAsync();



            SuccessResponse x = JsonConvert.DeserializeObject<SuccessResponse>(response);



            return x;
        }
        public async Task<UserToken> GetBodyLogin()
        {
            string response = await HttpResponseMessage.Content.ReadAsStringAsync();



            UserToken x = JsonConvert.DeserializeObject<UserToken>(response);



            return x;
        }
    }
}
