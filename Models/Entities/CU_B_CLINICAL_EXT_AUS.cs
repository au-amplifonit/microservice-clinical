using System;
using System.Collections.Generic;

namespace Fox.Microservices.Clinical.Models.Entities
{
    public partial class CU_B_CLINICAL_EXT_AUS
    {
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string APPOINTMENT_ID { get; set; }
        public short AUDIOGRAM_TYPE_CODE { get; set; }
        public DateTime ACTIVITY_DATE { get; set; }
        public decimal? PTA1_L { get; set; }
        public decimal? PTA1_R { get; set; }
        public decimal? PTA2_L { get; set; }
        public decimal? PTA2_R { get; set; }
        public string HEARING_LOSS_OUTCOME_CODE_L { get; set; }
        public string HEARING_LOSS_OUTCOME_CODE_R { get; set; }
        public decimal? NALPHL { get; set; }
        public string CLINICIAN_ID { get; set; }
        public DateTime? DT_INSERT { get; set; }
        public string USERINSERT { get; set; }
        public DateTime? DT_UPDATE { get; set; }
        public string USERUPDATE { get; set; }
        public Guid ROWGUID { get; set; }
        public string SHOP_CODE { get; set; }

        public virtual CU_S_AUDIOGRAM_TYPE CU_S_AUDIOGRAM_TYPE { get; set; }
    }
}
