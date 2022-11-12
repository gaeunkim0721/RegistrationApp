using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace RegistrationApp.Model
{
    public class LineNotify
    {
        public LineNotify()
        {

            try
            {
                WebClient wc4 = new WebClient();
                string targetAddress4 = "https://notify-api.line.me/api/notify";
                wc4.Headers["Authorization"] = "Bearer KqimoerQYEE135vVIhif66spJfUTxnIBqwZWzOt2frA";

                NameValueCollection nc4 = new NameValueCollection();




                nc4["message"] = "안녕하세요~~";

                byte[] bResult4 = wc4.UploadValues(targetAddress4, nc4);
                string result4 = Encoding.UTF8.GetString(bResult4);
            }
            catch (Exception e)
            {

            }
        }
    }
}