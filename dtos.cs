/* Options:
Date: 2021-08-25 10:46:33
Version: 5.121
Tip: To override a DTO option, remove "//" prefix before updating
BaseUrl: https://localhost:5001
UsePath: /crud/all/csharp

//GlobalNamespace: 
//MakePartial: False
//MakeVirtual: False
//MakeInternal: False
//MakeDataContractsExtensible: False
//AddReturnMarker: True
//AddDescriptionAsComments: True
//AddDataContractAttributes: True
//AddIndexesToDataMembers: True
//AddGeneratedCodeAttributes: False
//AddResponseStatus: False
//AddImplicitVersion: 
//InitializeCollections: False
//ExportValueTypes: False
//IncludeTypes: 
//ExcludeTypes: 
//AddNamespaces: 
//AddDefaultXmlNamespace: 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using autoquery.ServiceModel.Types;


namespace autoquery.ServiceModel.Types
{

    [DataContract]
    public class Employee
    {
        [DataMember(Order=1)]
        public long Id { get; set; }

        [DataMember(Order=2)]
        public string LastName { get; set; }

        [DataMember(Order=3)]
        public string FirstName { get; set; }

        [DataMember(Order=4)]
        public string Title { get; set; }

        [DataMember(Order=5)]
        public string TitleOfCourtesy { get; set; }

        [DataMember(Order=6)]
        public string BirthDate { get; set; }

        [DataMember(Order=7)]
        public string HireDate { get; set; }

        [DataMember(Order=8)]
        public string Address { get; set; }

        [DataMember(Order=9)]
        public string City { get; set; }

        [DataMember(Order=10)]
        public string Region { get; set; }

        [DataMember(Order=11)]
        public string PostalCode { get; set; }

        [DataMember(Order=12)]
        public string Country { get; set; }

        [DataMember(Order=13)]
        public string HomePhone { get; set; }

        [DataMember(Order=14)]
        public string Extension { get; set; }

        [DataMember(Order=15)]
        public byte[] Photo { get; set; }

        [DataMember(Order=16)]
        public string Notes { get; set; }

        [DataMember(Order=17)]
        public long? ReportsTo { get; set; }

        [DataMember(Order=18)]
        public string PhotoPath { get; set; }
    }

    [DataContract]
    public class EmployeeTerritory
    {
        [DataMember(Order=1)]
        public string Id { get; set; }

        [DataMember(Order=2)]
        public long EmployeeId { get; set; }

        [DataMember(Order=3)]
        public string TerritoryId { get; set; }
    }
}

