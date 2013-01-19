using SubsonicWS.Common;
using SubsonicWS.Exceptions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.MediaAnnotation
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class SetRating : Response<SetRating>
    {
        /// <summary>
        /// Rates the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="grade">The grade.</param>
        /// <returns></returns>
        /// <exception cref="SubsonicWS.Exceptions.RatingValueException"></exception>
        /// <exception cref="ResponseStatusFailedException">Rate error</exception>
        public async Task Rate(int id, int grade)
        {
            if (grade < 0 && grade > 5)
                throw new RatingValueException(grade + " is not a valid value for rating grade must be between 0 and 5");
            SetRating r = await Get("&id=" + id + "&rating=" + grade);
            this.Copy(r);
            if (StatusValue == ResponseStatus.Ok)
                return;
            else
                throw new ResponseStatusFailedException("Rate error", Error);
        }
    }
}