using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public class FbEventArgs : EventArgs
    {
        public string Link { get; set; }

        public string PathToImage { get; set; }

        public string StatusBody { get; set; }

        public DateTime Time { get; set; }
    }
}
