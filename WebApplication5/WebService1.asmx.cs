﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication5
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService {

        [WebMethod]
        public string ValidateInput(string input)
        {
            // Convert to lowercase for case-insensitive comparison
            string loweredInput = input.ToLower();

            // Check for common SQL injection patterns
            if (loweredInput.Contains("drop table") || loweredInput.Contains("select *") || loweredInput.Contains("rm -rf"))
            {
                return "malicious code detected";
            }

            return "text is safe";
        }

    }
}
