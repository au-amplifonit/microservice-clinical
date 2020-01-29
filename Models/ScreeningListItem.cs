using Fox.Microservices.Clinical.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Clinical.Models
{
    public class ScreeningListItem: ScreeningBase
    {
        public string AudiogramTypeDescripton { get; set; }
        public ScreeningListItem()
        {

        }

        public ScreeningListItem(CU_B_SCREENING_EXT_AUS Entity): base(Entity)
        {
            AudiogramTypeDescripton = Entity.CU_S_AUDIOGRAM_TYPE?.AUDIOGRAM_TYPE_DESCR?.Trim();
        }
    }
}
