using StudentManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentManagementApi.Controllers
{
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]

    public class ApplicationController : ApiController
    {
        static string CompanyURLName = "";
        DynamicsNAVSOAPServices dynamicsNAVSOAPService = new DynamicsNAVSOAPServices(CompanyURLName);

        #region Student Application
        public ApplicationResponse Post([FromBody] ApplicationModel ApplicationObj)
        {
            ApplicationResponse response = new ApplicationResponse();
            try
            {
                string NewDateStr;


                DateTime Temp;


                if (DateTime.TryParseExact(ApplicationObj.DateOfBirth, "yyyy-MM-dd", null, DateTimeStyles.AllowWhiteSpaces, out Temp) == true)
                {
                    NewDateStr = Temp.ToString("MM/dd/yy");
                }

                if (dynamicsNAVSOAPService.studentManagementWS.INSERTStudentApplication(ApplicationObj.FirstName, ApplicationObj.MiddleName, ApplicationObj.LastName,
                   Temp, ApplicationObj.Gender, ApplicationObj.Class, ApplicationObj.Term, ApplicationObj.County, ApplicationObj.NemisNo,
                    ApplicationObj.AcademicYear, ApplicationObj.Names, ApplicationObj.Type, ApplicationObj.Occupation, ApplicationObj.MobileNo, ApplicationObj.CompanyName,
                    ApplicationObj.CompanyAddress, ApplicationObj.Email, ApplicationObj.CompanyTelNo, ApplicationObj.ResidentialAddress, ApplicationObj.ApartmentNo, ApplicationObj.HouseNo, ApplicationObj.Address))
                {
                    response.responseCode = true;
                    response.responseDescription = "Student Application completed.";
                    return response;
                }

                else
                {
                    response.responseCode = false;
                    response.responseDescription = "Student Application was incomplete.";
                    return response;
                }

            }
            catch(Exception ex)
            {
                response.responseCode = false;
                response.responseDescription = ex.Message;
                return response;
            }
        }
        #endregion End Student Application
    }
}
