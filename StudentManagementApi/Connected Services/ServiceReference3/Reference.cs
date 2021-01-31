﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagementApi.ServiceReference3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", ConfigurationName="ServiceReference3.StudentManagementWebService_Port")]
    public interface StudentManagementWebService_Port {
        
        // CODEGEN: Generating message contract since the wrapper name (INSERTStudentApplication_Result) of message INSERTStudentApplication_Result does not match the default value (INSERTStudentApplication)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService:INSERTStudent" +
            "Application", ReplyAction="*")]
        StudentManagementApi.ServiceReference3.INSERTStudentApplication_Result INSERTStudentApplication(StudentManagementApi.ServiceReference3.INSERTStudentApplication request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService:INSERTStudent" +
            "Application", ReplyAction="*")]
        System.Threading.Tasks.Task<StudentManagementApi.ServiceReference3.INSERTStudentApplication_Result> INSERTStudentApplicationAsync(StudentManagementApi.ServiceReference3.INSERTStudentApplication request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="INSERTStudentApplication", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", IsWrapped=true)]
    public partial class INSERTStudentApplication {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=0)]
        public string firstName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=1)]
        public string middleName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=2)]
        public string lastName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=3)]
        public string dOB;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=4)]
        public string gender;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=5)]
        public string @class;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=6)]
        public string term;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=7)]
        public string countyCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=8)]
        public string nEMISNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=9)]
        public string academicYear;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=10)]
        public string names;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=11)]
        public string type;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=12)]
        public string occupation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=13)]
        public string mobileNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=14)]
        public string companyName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=15)]
        public string companyAddress;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=16)]
        public string email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=17)]
        public string companyTelNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=18)]
        public string residentialAddress;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=19)]
        public string apartmentNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=20)]
        public string houseNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=21)]
        public string address;
        
        public INSERTStudentApplication() {
        }
        
        public INSERTStudentApplication(
                    string firstName, 
                    string middleName, 
                    string lastName, 
                    string dOB, 
                    string gender, 
                    string @class, 
                    string term, 
                    string countyCode, 
                    string nEMISNo, 
                    string academicYear, 
                    string names, 
                    string type, 
                    string occupation, 
                    string mobileNo, 
                    string companyName, 
                    string companyAddress, 
                    string email, 
                    string companyTelNo, 
                    string residentialAddress, 
                    string apartmentNo, 
                    string houseNo, 
                    string address) {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.dOB = dOB;
            this.gender = gender;
            this.@class = @class;
            this.term = term;
            this.countyCode = countyCode;
            this.nEMISNo = nEMISNo;
            this.academicYear = academicYear;
            this.names = names;
            this.type = type;
            this.occupation = occupation;
            this.mobileNo = mobileNo;
            this.companyName = companyName;
            this.companyAddress = companyAddress;
            this.email = email;
            this.companyTelNo = companyTelNo;
            this.residentialAddress = residentialAddress;
            this.apartmentNo = apartmentNo;
            this.houseNo = houseNo;
            this.address = address;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="INSERTStudentApplication_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", IsWrapped=true)]
    public partial class INSERTStudentApplication_Result {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/StudentManagementWebService", Order=0)]
        public bool return_value;
        
        public INSERTStudentApplication_Result() {
        }
        
        public INSERTStudentApplication_Result(bool return_value) {
            this.return_value = return_value;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StudentManagementWebService_PortChannel : StudentManagementApi.ServiceReference3.StudentManagementWebService_Port, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentManagementWebService_PortClient : System.ServiceModel.ClientBase<StudentManagementApi.ServiceReference3.StudentManagementWebService_Port>, StudentManagementApi.ServiceReference3.StudentManagementWebService_Port {
        
        public StudentManagementWebService_PortClient() {
        }
        
        public StudentManagementWebService_PortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentManagementWebService_PortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentManagementWebService_PortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentManagementWebService_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StudentManagementApi.ServiceReference3.INSERTStudentApplication_Result StudentManagementApi.ServiceReference3.StudentManagementWebService_Port.INSERTStudentApplication(StudentManagementApi.ServiceReference3.INSERTStudentApplication request) {
            return base.Channel.INSERTStudentApplication(request);
        }
        
        public bool INSERTStudentApplication(
                    string firstName, 
                    string middleName, 
                    string lastName, 
                    string dOB, 
                    string gender, 
                    string @class, 
                    string term, 
                    string countyCode, 
                    string nEMISNo, 
                    string academicYear, 
                    string names, 
                    string type, 
                    string occupation, 
                    string mobileNo, 
                    string companyName, 
                    string companyAddress, 
                    string email, 
                    string companyTelNo, 
                    string residentialAddress, 
                    string apartmentNo, 
                    string houseNo, 
                    string address) {
            StudentManagementApi.ServiceReference3.INSERTStudentApplication inValue = new StudentManagementApi.ServiceReference3.INSERTStudentApplication();
            inValue.firstName = firstName;
            inValue.middleName = middleName;
            inValue.lastName = lastName;
            inValue.dOB = dOB;
            inValue.gender = gender;
            inValue.@class = @class;
            inValue.term = term;
            inValue.countyCode = countyCode;
            inValue.nEMISNo = nEMISNo;
            inValue.academicYear = academicYear;
            inValue.names = names;
            inValue.type = type;
            inValue.occupation = occupation;
            inValue.mobileNo = mobileNo;
            inValue.companyName = companyName;
            inValue.companyAddress = companyAddress;
            inValue.email = email;
            inValue.companyTelNo = companyTelNo;
            inValue.residentialAddress = residentialAddress;
            inValue.apartmentNo = apartmentNo;
            inValue.houseNo = houseNo;
            inValue.address = address;
            StudentManagementApi.ServiceReference3.INSERTStudentApplication_Result retVal = ((StudentManagementApi.ServiceReference3.StudentManagementWebService_Port)(this)).INSERTStudentApplication(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StudentManagementApi.ServiceReference3.INSERTStudentApplication_Result> StudentManagementApi.ServiceReference3.StudentManagementWebService_Port.INSERTStudentApplicationAsync(StudentManagementApi.ServiceReference3.INSERTStudentApplication request) {
            return base.Channel.INSERTStudentApplicationAsync(request);
        }
        
        public System.Threading.Tasks.Task<StudentManagementApi.ServiceReference3.INSERTStudentApplication_Result> INSERTStudentApplicationAsync(
                    string firstName, 
                    string middleName, 
                    string lastName, 
                    string dOB, 
                    string gender, 
                    string @class, 
                    string term, 
                    string countyCode, 
                    string nEMISNo, 
                    string academicYear, 
                    string names, 
                    string type, 
                    string occupation, 
                    string mobileNo, 
                    string companyName, 
                    string companyAddress, 
                    string email, 
                    string companyTelNo, 
                    string residentialAddress, 
                    string apartmentNo, 
                    string houseNo, 
                    string address) {
            StudentManagementApi.ServiceReference3.INSERTStudentApplication inValue = new StudentManagementApi.ServiceReference3.INSERTStudentApplication();
            inValue.firstName = firstName;
            inValue.middleName = middleName;
            inValue.lastName = lastName;
            inValue.dOB = dOB;
            inValue.gender = gender;
            inValue.@class = @class;
            inValue.term = term;
            inValue.countyCode = countyCode;
            inValue.nEMISNo = nEMISNo;
            inValue.academicYear = academicYear;
            inValue.names = names;
            inValue.type = type;
            inValue.occupation = occupation;
            inValue.mobileNo = mobileNo;
            inValue.companyName = companyName;
            inValue.companyAddress = companyAddress;
            inValue.email = email;
            inValue.companyTelNo = companyTelNo;
            inValue.residentialAddress = residentialAddress;
            inValue.apartmentNo = apartmentNo;
            inValue.houseNo = houseNo;
            inValue.address = address;
            return ((StudentManagementApi.ServiceReference3.StudentManagementWebService_Port)(this)).INSERTStudentApplicationAsync(inValue);
        }
    }
}
