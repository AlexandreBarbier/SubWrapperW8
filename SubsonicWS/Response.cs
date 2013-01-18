using SubsonicWS.Common;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS
{
    public abstract class Response<T> where T : Response<T>
    {
        [XmlAttribute("status")]
        public String Status { get; set; }

        [XmlAttribute("version")]
        public String Version { get; set; }

        [XmlElement("error")]
        public ResponseError Error { get; set; }

        public ResponseStatus StatusValue
        {
            get
            {
                if (Status == "ok")
                    return ResponseStatus.Ok;
                return ResponseStatus.Failed;
            }
        }

        protected void Copy(T copy)
        {
            this.Error = copy.Error;
            this.Status = copy.Status;
            this.Version = copy.Version;
        }

        protected async virtual Task<T> Get(String otherParam = "")
        {
            try
            {
                Byte[] b = await getData(Constants.Pages[typeof(T)], otherParam);
                using (Stream str = new MemoryStream(b))
                {
                    XmlSerializer s = new XmlSerializer(typeof(T), new Type[] { });
                    T ret = s.Deserialize(str) as T;
                    if (ret.StatusValue == ResponseStatus.Ok)
                        return ret;
                    else
                        throw new Exceptions.ResponseStatusFailedException("status failed", ret.Error);
                }
            }
            catch (HttpRequestException e)
            {
                throw;
            }
        }

        protected static async Task<Byte[]> getData(String page, String otherParam = "")
        {
            try
            {
                using (HttpClient http = new HttpClient())
                using (HttpResponseMessage message = await http.GetAsync(ConnectionInformations.getConnectionString(page, otherParam)))
                    if (message.IsSuccessStatusCode)
                        return await message.Content.ReadAsByteArrayAsync();
                    else
                        return null;
            }
            catch (HttpRequestException e)
            {
                throw e;
            }
        }
    }
}