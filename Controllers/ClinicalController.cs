

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fox.Microservices.Clinical.Models;
using Fox.Microservices.Clinical.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebAPITools.EntityMapper;
using WebAPITools.ErrorHandling;
using WebAPITools.Models.Configuration;

namespace Fox.Microservices.Clinical.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class ClinicalController : ControllerBase
	{
		private readonly IOptions<AppSettings> Settings;
		private readonly ClinicalContext DBContext;

		public ClinicalController(IOptions<AppSettings> ASettings, ClinicalContext ADBContext)
		{
			Settings = ASettings;
            EntityMapper.Settings = Settings.Value;
            DBContext = ADBContext;
		}

		// GET api/values
		[ApiExplorerSettings(IgnoreApi = true)]
		[NonAction]
		public ActionResult<IEnumerable<string>> Get()
		{
			return null;
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<Models.Clinical> Get(string id)
		{
			Models.Clinical Result = new Models.Clinical() { CustomerId = id };
			Result.Screenings = GetScreenings(id).ToArray();
			Result.Assessments = GetAssessments(id).ToArray();
			return Result;
		}

		[HttpGet("[action]/{id}")]
		public ActionResult<IEnumerable<ScreeningListItem>> Screenings(string id)
		{
			List<ScreeningListItem> Result = GetScreenings(id);
			return Result;
		}

		List<ScreeningListItem> GetScreenings(string CustomerId)
		{
			List<ScreeningListItem> Result = new List<ScreeningListItem>();
			foreach (CU_B_SCREENING_EXT_AUS Item in DBContext.CU_B_SCREENING_EXT_AUS.Where(E => E.CUSTOMER_CODE == CustomerId).OrderByDescending(E => E.ACTIVITY_DATE))
				Result.Add(new ScreeningListItem(Item));

			return Result;
		}

		[HttpGet("[action]/{id}")]
		public ActionResult<IEnumerable<AssessmentListItem>> Assessments(string id)
		{
			List<AssessmentListItem> Result = GetAssessments(id);
			return Result;
		}

		List<AssessmentListItem> GetAssessments(string CustomerId)
		{
			List<AssessmentListItem> Result = new List<AssessmentListItem>();
			foreach (CU_B_CLINICAL_EXT_AUS Item in DBContext.CU_B_CLINICAL_EXT_AUS.Where(E => E.CUSTOMER_CODE == CustomerId).OrderByDescending(E => E.ACTIVITY_DATE))
				Result.Add(new AssessmentListItem(Item));

			return Result;
		}

		// PUT api/values/5
		[HttpPut("Screening")]
		public void ScreeningPut([FromBody] ScreeningBase value)
		{
			if (value == null)
				throw new ArgumentNullException($"Argument value cannot be null");

			CU_B_SCREENING_EXT_AUS Item = DBContext.CU_B_SCREENING_EXT_AUS.SingleOrDefault(E => E.ROWGUID == value.RowGuid);
			if (Item == null)
				throw new NotFoundException($"No screening found with id:{value.RowGuid}");

			EntityMapper.UpdateEntity(value, Item);
            Item.DT_UPDATE = DateTime.UtcNow;
            Item.USERUPDATE = "Microservices";

            value.SaveData<CU_B_SCREENING_EXT_AUS>(DBContext, Item);

			DBContext.SaveChanges();
		}

        // POST api/values
        [HttpPost("Screening")]
        public void ScreeningPost([FromBody] ScreeningBase value)
        {
            if (value == null)
                throw new ArgumentNullException($"Argument value cannot be null");

            CU_B_SCREENING_EXT_AUS Item = EntityMapper.CreateEntity<CU_B_SCREENING_EXT_AUS>();

            EntityMapper.UpdateEntity(value, Item);

            DBContext.CU_B_SCREENING_EXT_AUS.Add(Item);
            DBContext.SaveChanges();
        }
    }
}
