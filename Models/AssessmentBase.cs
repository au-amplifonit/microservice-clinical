using Fox.Microservices.Clinical.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITools.Models;

namespace Fox.Microservices.Clinical.Models
{
    public class AssessmentBase: ModelBase
    {
        [JsonProperty(Order = -10)]
        public string CustomerCode { get; set; }
        [JsonProperty(Order = -10)]
        public string AppointmentId { get; set; }
        [JsonProperty(Order = -10)]
        public short? AudiogramTypeCode { get; set; }
        [JsonProperty(Order = -10)]
        public DateTime ActivityDate { get; set; }
        [JsonProperty(Order = -10)]
        public string ClinicianId { get; set; }
        [JsonProperty(Order = -10)]
        public string ShopCode { get; set; }
        public decimal? PTA1_L { get; set; }
        [JsonProperty(Order = -10)]
        public decimal? PTA1_R { get; set; }
        [JsonProperty(Order = -10)]
        public decimal? PTA2_L { get; set; }
        [JsonProperty(Order = -10)]
        public decimal? PTA2_R { get; set; }
        [JsonProperty(Order = -10)]
        public decimal? NALPHL { get; set; }
        [JsonProperty(Order = -10)]
        public string HearingLossOutcomeCode_L { get; set; }
        [JsonProperty(Order = -10)]
        public string HearingLossOutcomeCode_R { get; set; }


        public AssessmentBase()
        {

        }

        public AssessmentBase(CU_B_CLINICAL_EXT_AUS Entity) : base(Entity.ROWGUID)
        {
            CustomerCode = Entity.CUSTOMER_CODE;
            AppointmentId = Entity.APPOINTMENT_ID;
            AudiogramTypeCode = Entity.AUDIOGRAM_TYPE_CODE;
            ActivityDate = Entity.ACTIVITY_DATE;
            PTA1_L = Entity.PTA1_L;
            PTA1_R = Entity.PTA1_R;
            PTA2_L = Entity.PTA2_L;
            PTA2_R = Entity.PTA2_R;
            NALPHL = Entity.NALPHL;
            HearingLossOutcomeCode_L = Entity.HEARING_LOSS_OUTCOME_CODE_L?.Trim();
            HearingLossOutcomeCode_R = Entity.HEARING_LOSS_OUTCOME_CODE_R?.Trim();
        }
    }
}
