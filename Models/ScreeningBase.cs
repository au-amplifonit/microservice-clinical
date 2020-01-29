using Fox.Microservices.Clinical.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITools.EntityMapper;
using WebAPITools.Models;

namespace Fox.Microservices.Clinical.Models
{
	public class ScreeningBase : ModelBase
	{
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.CUSTOMER_CODE))]
        [JsonProperty(Order = -10)]
        public string CustomerCode { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.APPOINTMENT_ID))]
		[JsonProperty(Order = -10)]
		public string AppointmentId { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.AUDIOGRAM_TYPE_CODE))]
        [JsonProperty(Order = -10)]
		public short? AudiogramTypeCode { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.ACTIVITY_DATE))]
        [JsonProperty(Order = -10)]
		public DateTime ActivityDate { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_500_L))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_500_L { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_500_R))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_500_R { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_1_L))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_1_L { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_1_R))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_1_R { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_2_L))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_2_L { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_2_R))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_2_R { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_3_L))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_3_L { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_3_R))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_3_R { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_4_L))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_4_L { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.FREQ_4_R))]
        [JsonProperty(Order = -10)]
		public decimal? Freq_4_R { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.PTA1_L))]
        [JsonProperty(Order = -10)]
		public decimal? PTA1_L { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.PTA1_R))]
        [JsonProperty(Order = -10)]
		public decimal? PTA1_R { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.PTA2_L))]
        [JsonProperty(Order = -10)]
		public decimal? PTA2_L { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.PTA2_R))]
        [JsonProperty(Order = -10)]
		public decimal? PTA2_R { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.NALPHL))]
        [JsonProperty(Order = -10)]
		public decimal? NALPHL { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.RESULT_CODE))]
        [JsonProperty(Order = -10)]
		public string ResultCode { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.CLINICIAN_ID))]
        [JsonProperty(Order = -10)]
		public string ClinicianId { get; set; }
        [FieldMapper(nameof(CU_B_SCREENING_EXT_AUS.STATUS_CODE))]
        [JsonProperty(Order = -10)]
		public string StatusCode { get; set; }

		public ScreeningBase()
		{

		}

		public ScreeningBase(CU_B_SCREENING_EXT_AUS Entity) : base(Entity.ROWGUID)
		{
            CustomerCode = Entity.CUSTOMER_CODE;
			AppointmentId = Entity.APPOINTMENT_ID;
			AudiogramTypeCode = Entity.AUDIOGRAM_TYPE_CODE;
			ActivityDate = Entity.ACTIVITY_DATE;
			Freq_500_L = Entity.FREQ_500_L;
			Freq_500_R = Entity.FREQ_500_R;
			Freq_1_L = Entity.FREQ_1_L;
			Freq_1_R = Entity.FREQ_1_R;
			Freq_2_L = Entity.FREQ_2_L;
			Freq_2_R = Entity.FREQ_2_R;
			Freq_3_L = Entity.FREQ_3_L;
			Freq_3_R = Entity.FREQ_3_R;
			Freq_4_L = Entity.FREQ_4_L;
			Freq_4_R = Entity.FREQ_4_R;
			PTA1_L = Entity.PTA1_L;
			PTA1_R = Entity.PTA1_R;
			PTA2_L = Entity.PTA2_L;
			PTA2_R = Entity.PTA2_R;
			NALPHL = Entity.NALPHL;
			ResultCode = Entity.RESULT_CODE;
			ClinicianId = Entity.CLINICIAN_ID;
			StatusCode = Entity.STATUS_CODE;
		}
	}
}
