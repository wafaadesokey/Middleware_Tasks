using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyCookieCollection//indexer test
    {
        public Dictionary<string, string> cookies = new Dictionary<string, string>();

        public MyCookieCollection()
        {
            cookies["Mai"] = "Dark";
            cookies["roza"] = "Pink";
            cookies["ali"] = "nila";
        }
        public string this[string username]//this refer to indesxr lazm tkon wa7da bs 
        {
            //read indexer value if exist
            get
            {
                if (cookies.ContainsKey(username))
                {
                    return cookies[username];
                }
                else
                {
                    return "User Dosent exist";
                }

            }
            set
            {
                cookies[username] = value;
            }
        }

    }
}
