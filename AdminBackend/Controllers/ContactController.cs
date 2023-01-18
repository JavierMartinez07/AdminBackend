using AdminBackend.BusinessLogic;
using AdminBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminBackend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ContactController : Controller
    {
        [HttpGet]
        public ResponseModel<Contact> Get()
        {
            return ContactBusinessLogic.Get();
        }

        [HttpGet("{Id}")]
        public ResponseModel<Contact> Get(int Id)
        {
            return ContactBusinessLogic.Get(Id);
        }

        [HttpGet("{Id}")]
        public ResponseModel<Contact> GetByCustomerId(int Id)
        {
            return ContactBusinessLogic.GetByCustomerId(Id);
        }

        [HttpDelete("{Id}")]
        public ResponseModel<object> Delete(int Id)
        {
            return ContactBusinessLogic.Delete(Id);
        }

        [HttpPost]
        public ResponseModel<int> Insert(Contact model)
        {
            return ContactBusinessLogic.Insert(model);
        }


        [HttpPut]
        public ResponseModel<object> Update(Contact model)
        {
            return ContactBusinessLogic.Update(model);
        }


    }
}
