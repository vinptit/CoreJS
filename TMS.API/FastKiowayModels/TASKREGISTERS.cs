using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TASKREGISTERS
    {
        public decimal ID { get; set; }
        public string TASKNAME { get; set; }
        public string TRANSACTIONTYPEID { get; set; }
        public string APPLICATIONID { get; set; }
        public string STAFFID { get; set; }
        public string DEPARTMENTID { get; set; }
        public byte? TASKORDER { get; set; }
        public int? UPDATECOUNTER { get; set; }
        public string CREATEDBY { get; set; }
        public DateTime? CREATEDON { get; set; }
        public string MODIFIEDBY { get; set; }
        public DateTime? MODIFIEDON { get; set; }
        public bool? Export { get; set; }
        public string CUSTOMERID { get; set; }
        public string SERVICES { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMMODITY { get; set; }
        public string GROUPTASK { get; set; }
        public string ROUTER { get; set; }
        public string CUSTOMTYPE { get; set; }
        public bool CREATETRUCK { get; set; }
        public bool ISOPERATED { get; set; }
        public bool ASSIGNCREATOR { get; set; }
        public bool ASSIGNSALESMAN { get; set; }
        public bool ASSIGNMOBILE { get; set; }
        public string DEADLINE { get; set; }
        public bool ASSIGNOPIC { get; set; }
        public bool ISBILLREADY { get; set; }
        public bool ISPAID { get; set; }
        public double? DefaultAmount { get; set; }
        public string SERVICESID { get; set; }
        public string FEECODE { get; set; }
        public bool? ISDOC { get; set; }
    }
}
