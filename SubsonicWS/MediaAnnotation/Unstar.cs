using SubsonicWS.Common;
using SubsonicWS.Exceptions;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.MediaAnnotation
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class Unstar : Response<Unstar>
    {
        /// <summary>
        /// Remove star the specified ids.
        /// </summary>
        /// <param name="ids">The ID of the file (song) or folder (album/artist) to star. Multiple parameters allowed</param>
        /// <param name="albumIds">The album ids.</param>
        /// <param name="artistIds">The artist ids.</param>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">star adding error</exception>
        public async Task Remove(List<int> ids = null, List<int> albumIds = null, List<int> artistIds = null)
        {
            StringBuilder otherParam = new StringBuilder("");
            if (ids != null)
                foreach (var item in ids)
                    otherParam.Append("&id=" + item);
            if (albumIds != null)
                foreach (var item in albumIds)
                    otherParam.Append("&albumIds=" + item);
            if (artistIds != null)
                foreach (var item in artistIds)
                    otherParam.Append("&artistIds=" + item);

            Unstar s = await Get(otherParam.ToString());
            this.Copy(s);
            if (StatusValue == ResponseStatus.Ok)
                return;
            else
                throw new ResponseStatusFailedException("unstar error", Error);
        }
    }
}