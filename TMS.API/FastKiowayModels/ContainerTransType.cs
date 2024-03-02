using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ContainerTransType
    {
        public ContainerTransType()
        {
            ContTariffDemDepCharges = new HashSet<ContTariffDemDepCharges>();
            ContainerTransactionDetails = new HashSet<ContainerTransactionDetails>();
        }

        public string ContTransType { get; set; }
        public string ContTransDescription { get; set; }
        public bool? LadenIn { get; set; }
        public bool? LadenOut { get; set; }
        public bool? EmptyIn { get; set; }
        public bool? EmpyOut { get; set; }
        public bool? FullLadenIn { get; set; }
        public bool? LadenOnboard { get; set; }
        public int? IIndex { get; set; }

        public virtual ICollection<ContTariffDemDepCharges> ContTariffDemDepCharges { get; set; }
        public virtual ICollection<ContainerTransactionDetails> ContainerTransactionDetails { get; set; }
    }
}
