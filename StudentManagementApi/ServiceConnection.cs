using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

namespace StudentManagementApi
{
    public class ServiceConnection
    {
        public static string CompanyName = "Parklands Baptist Church";
        public static string protocol = "http://";
        public static string DynamicsNAVServer = "173.249.23.236";
        static string SOAPPortNumber = "2022";
        static string ODATAPortNumber = "2023";
        static string DynamicsNAVServiceName = "PBC";
        static string DefaultCompanyURLName = "PBC%20Test";
        static string ConnUsername = "WSAUTH";
        static string ConnPassword = "Wsauth@2021";
        static NetworkCredential netCred = new NetworkCredential(ConnUsername, ConnPassword);
        public static string googleReCaptchaKey = "6LdBZFkUAAAAAGhY2hZVzi2B9LB-SdHX83whjp1i";
        //http://173.249.23.236:2023/PBC/OData
        public static string GetDynamicsNAVSOAPURL(string ServiceName, string CompanyURLName)
        {
            if (CompanyURLName.Equals(""))
            {
                return protocol + DynamicsNAVServer + ":" + SOAPPortNumber + "/" + DynamicsNAVServiceName + "/WS/" + DefaultCompanyURLName + "/Codeunit/" + ServiceName;
            }
            else
            {
                return protocol + DynamicsNAVServer + ":" + SOAPPortNumber + "/" + DynamicsNAVServiceName + "/WS/" + CompanyURLName + "/Codeunit/" + ServiceName;
            }
        }
        public static string GetDynamicsNAVODATAURL(string CompanyURLName)
        {
            if (CompanyURLName.Equals(""))
            {
                return protocol + DynamicsNAVServer + ":" + ODATAPortNumber + "/" + DynamicsNAVServiceName + "/OData/Company('" + DefaultCompanyURLName + "')";
            }
            else
            {
                return protocol + DynamicsNAVServer + ":" + ODATAPortNumber + "/" + DynamicsNAVServiceName + "/OData/Company('" + CompanyURLName + "')";
            }
        }
        public static CredentialCache getConnectionCredentials(string Url)
        {
            CredentialCache myCredentials = new CredentialCache();
            if (myCredentials.GetCredential(new Uri(Url), "Basic") == null)
            {
                myCredentials.Add(new Uri(Url), "Basic", netCred);
            }
            return myCredentials;
        }
    }
}