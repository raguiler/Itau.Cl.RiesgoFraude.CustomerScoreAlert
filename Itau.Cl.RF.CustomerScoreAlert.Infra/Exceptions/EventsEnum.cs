using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itau.Cl.Rf.CustomerScoreAlert.Infra.Exceptions
{
    public static class EventsEnum
    {
        public static EventId RecordUpdatedSucessfully = 204;
        public static EventId No200ResponseBiometricScore = 201;
        public static EventId UserNotValid = 401;
        public static EventId UserNotFound = 404;
        public static EventId BadRequest = 400;
        public static EventId RecaptchaNotValid = 422;
        public static EventId InternalServerError = 500;

    }
}
