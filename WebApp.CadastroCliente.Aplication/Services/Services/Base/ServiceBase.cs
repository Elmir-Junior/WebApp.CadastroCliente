using System.Collections.Generic;
using System.Net.Http;

namespace WebApp.CadastroCliente.Aplication.Services.Base
{
    public class ServiceBaseApi<T>
    {
        readonly HttpClient Client = new HttpClient();
        readonly string Url = "http://localhost:52879";

        public IEnumerable<T> GetAll(string UrlParametro)
        {
            HttpResponseMessage resultado = Client.GetAsync(Url + UrlParametro).GetAwaiter().GetResult();
            return resultado.Content.ReadAsAsync<IEnumerable<T>>().GetAwaiter().GetResult();
        }
        public T GetById(string UrlParametro, int id)
        {
            HttpResponseMessage resultado = Client.GetAsync(Url + UrlParametro + id).GetAwaiter().GetResult();

            return resultado.Content.ReadAsAsync<T>().GetAwaiter().GetResult();
        }
        public bool Post(string url, T obj)
        {
            var resultado = Client.PostAsJsonAsync(Url + url, obj).GetAwaiter().GetResult();
            return resultado.IsSuccessStatusCode;
        }
        public bool Put(string url, T obj)
        {
            var resultado = Client.PutAsJsonAsync(Url + url, obj).GetAwaiter().GetResult();
            return resultado.IsSuccessStatusCode;
        }

        public bool Delete(string url)
        {
            var resultado = Client.DeleteAsync(Url + url).GetAwaiter().GetResult();
            return resultado.IsSuccessStatusCode;
        }
    }
}
