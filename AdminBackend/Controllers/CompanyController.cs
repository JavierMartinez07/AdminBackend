using AdminBackend.BusinessLogic;
using AdminBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminBackend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CompanyController : Controller
    {
        [HttpGet]
        public ResponseModel<Company> Get()
        {
            return CompanyBusinessLogic.Get();
        }

        [HttpGet("{Id}")]
        public ResponseModel<Company> Get(int Id)
        {
            return CompanyBusinessLogic.Get(Id);
        }

        [HttpDelete("{Id}")]
        public ResponseModel<object> Delete(int Id)
        {
            return CompanyBusinessLogic.Delete(Id);
        }

        [HttpPost]
        public ResponseModel<int> Insert(Company model)
        {
            return CompanyBusinessLogic.Insert(model);
        }


        [HttpPut]
        public ResponseModel<object> Update(Company model)
        {
            return CompanyBusinessLogic.Update(model);
        }


    }
}
