using System;
using System.Collections.Generic;
using System.Text;

namespace SuperProxy.SpeedLimt4Fiddler
{
   public class Model
    {
        bool enabled=false; 

        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        //int requestDelay = 300;


        //public int RequestDelay
        //{
        //    get { return requestDelay; }
        //    set { requestDelay = value; }
        //}

        //int reponseDelay = 150;

        //public int ReponseDelay
        //{
        //    get { return reponseDelay; }
        //    set { reponseDelay = value; }
        //}


        int reponseDelaySpeed = 150;

        public int ReponseDelaySpeed
        {
            get { return reponseDelaySpeed; }
            set { reponseDelaySpeed = value; }
        }


        int requestDelaySpeed = 150;

        public int RequestDelaySpeed
        {
            get { return requestDelaySpeed; }
            set { requestDelaySpeed = value; }
        }
    }
}
