using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CM_Login.Models;
using CM_Login.Services;

namespace CM_Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMController : ControllerBase
    {
        private readonly CM_Service cms = new CM_Service();




        [HttpGet]

        public ActionResult<List<Content_Manager>> GetAllCM()
        {
            return Ok(cms.GetAllCM());
        }
        [HttpGet]
        [Route("Get CM by Id/{CM_id}")]

        public ActionResult<List<Content_Manager>> Get_Cm_by_Id(int CM_id)
        {
            return Ok(cms.Select_CM_By_id(CM_id));


        }


        [HttpPost]
        public ActionResult insertCM(Content_Manager C)
        {
            cms.insertCM(C);
            return Ok();
        }


        [HttpPut]
        [Route("update CM/{CM_id}")]
        public IActionResult UpdateAdmin(Content_Manager C, int CM_id)
        {
            cms.UpdateCM(C, CM_id);
            return Ok();

        }
        [HttpDelete]
        public IActionResult DeleteCM(int CM_id)
        {
            bool b = cms.DeleteCM(CM_id);    
            if (b)
                return Ok();
            else
                return NotFound();
        }

    }
}
