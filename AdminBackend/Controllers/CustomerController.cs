using AdminBackend.BusinessLogic;
using AdminBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminBackend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public ResponseModel<Customer> Get()
        {
            return CustomerBusinessLogic.Get();
        }

        [HttpGet("{Id}")]
        public ResponseModel<Customer> Get(int Id)
        {
            return CustomerBusinessLogic.Get(Id);
        }

        [HttpGet("{Id}")]
        public ResponseModel<Customer> GetByCompanyId(int Id)
        {
            return CustomerBusinessLogic.GetByCompanyId(Id);
        }

        [HttpDelete("{Id}")]
        public ResponseModel<object> Delete(int Id)
        {
            return CustomerBusinessLogic.Delete(Id);
        }

        [HttpPost]
        public ResponseModel<int> Insert(Customer model)
        {
            return CustomerBusinessLogic.Insert(model);
        }


        [HttpPut]
        public ResponseModel<object> Update(Customer model)
        {
            return CustomerBusinessLogic.Update(model);
        }


    }
}
