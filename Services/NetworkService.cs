using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Countries.Utility;

namespace Countries.Services
{
    /// <summary>
    /// This Class verify wheter or not Internet connection
    /// </summary>
    public class NetworkService
    {
        public Response CheckConnection()
        {
            var client = new WebClient();

            try
            {
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Response
                    {
                        IsSuccess = true
                    };
                }
            }
            catch (Exception)
            {

                return new Response
                {
                    IsSuccess = false,
                    Message = "Configure a sua ligação à internet",
                };
            }
        }
    }
}
