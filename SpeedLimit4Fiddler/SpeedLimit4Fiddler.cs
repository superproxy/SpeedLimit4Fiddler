using System;
using System.Collections.Generic;
using System.Text;

using Fiddler;

//[assembly: Fiddler.RequiredVersion("2.6.1.5")]
[assembly: Fiddler.RequiredVersion("2.1.0.1")]
namespace SuperProxy.SpeedLimt4Fiddler
{

    public class SpeedLimit4Fiddler : IAutoTamper    // Ensure class is public, or Fiddler won't see it!
    {
       // string sUserAgent = "Violin";
        Model model= new Model();
        SpeedLimitControl userContorl1;

        public SpeedLimit4Fiddler()
        {
            /* NOTE: It's possible that Fiddler UI isn't fully loaded yet, so don't add any UI in the constructor.

               But it's also possible that AutoTamper* methods are called before OnLoad (below), so be
               sure any needed data structures are initialized to safe values here in this constructor */

          //  sUserAgent = "Violin";
        }

        public void OnLoad(
            
            ) { /* Load your UI here */
                     userContorl1  = new SpeedLimitControl(model);
        }
        public void OnBeforeUnload() { }

        public void AutoTamperRequestBefore(Session oSession)
        {
            if (model.Enabled)
            {
                //  if (m_SimulateModem) {
                //    // Delay sends by 300ms per KB uploaded.
                //    oSession["request-trickle-delay"] = "30"; 
                //    // Delay receives by 150ms per KB downloaded.
                //    oSession["response-trickle-delay"] = "150"; 
                //}


                int requestDelay = SpeedConvert.covert(model.RequestDelaySpeed);
               int  reponseDelay = SpeedConvert.covert(model.ReponseDelaySpeed);

               oSession["request-trickle-delay"] = Convert.ToString(requestDelay);
               oSession["response-trickle-delay"] = Convert.ToString(reponseDelay);
            }
            else
            {
                oSession["request-trickle-delay"] = null;
                oSession["response-trickle-delay"] = null;
            }

           // oSession.oRequest["User-Agent"] = sUserAgent;
        }
        public void AutoTamperRequestAfter(Session oSession) { }
        public void AutoTamperResponseBefore(Session oSession) { }
        public void AutoTamperResponseAfter(Session oSession) { }
        public void OnBeforeReturningError(Session oSession) { }
    }
}
