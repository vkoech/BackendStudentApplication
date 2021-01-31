using StudentManagementApi.WebReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi
{
    public class DynamicsNAVSOAPServices
    {
        public StudentManagementWebService studentManagementWS = new StudentManagementWebService();
        public DynamicsNAVSOAPServices(string companyURLName)
        {
            studentManagementWS.Url = ServiceConnection.GetDynamicsNAVSOAPURL("StudentManagementWebService", companyURLName);
            studentManagementWS.Credentials = ServiceConnection.getConnectionCredentials(studentManagementWS.Url);
        }
    }
}