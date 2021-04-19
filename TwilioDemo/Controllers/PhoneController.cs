using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;

namespace TwilioDemo.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult makeCall()
        {
            var accountSid = "ACa4b1cd8adeaed667dcf4d0e2d79f4dfe";
            var accountToken = "38d84c9dd6a8b2d717a07b98cc5c7fa1";
            TwilioClient.Init(accountSid, accountToken);

            var to = new PhoneNumber("+917038641410");
            var from = new PhoneNumber("+19726354380");
            var call = CallResource.Create(
                to: to,
                from: from,
                url: new Uri("http://demo.twilio.com/docs/voice.xml"));

            return Content(call.Sid);
        }
    }
}