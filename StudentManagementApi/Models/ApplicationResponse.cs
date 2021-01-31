using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models
{
    public class ApplicationResponse
    {
        public bool responseCode { get; set; }
        public string responseDescription { get; set; }
    }
}