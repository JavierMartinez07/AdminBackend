using AdminBackend.Models;
using AdminBackend.Repositories;

namespace AdminBackend.BusinessLogic
{
    public class ContactBusinessLogic
    {
        public static ResponseModel<Contact> Get()
        {
            var response = new ResponseModel<Contact>();
            try
            {
                var result = ContactRepository.Get();
                response.Records.AddRange(result);
            }
            catch (Exception ex)
            {
                response.OK = false;
                response.Errors.Add(ex.Message);
                response.Errors.Add(ex.StackTrace ?? "");

            }
            return response;
        }

        public static ResponseModel<Contact> Get(int Id)
        {
            var response = new ResponseModel<Contact>();
            try
            {
                var result = ContactRepository.Get(Id);
                response.Records.AddRange(result);
            }
            catch (Exception ex)
            {
                response.OK = false;
                response.Errors.Add(ex.Message);
                response.Errors.Add(ex.StackTrace ?? "");

            }
            return response;
        }

        public static ResponseModel<Contact> GetByCustomerId(int Id)
        {
            var response = new ResponseModel<Contact>();
            try
            {
                var result = ContactRepository.GetByCustomerId(Id);
                response.Records.AddRange(result);
            }
            catch (Exception ex)
            {
                response.OK = false;
                response.Errors.Add(ex.Message);
                response.Errors.Add(ex.StackTrace ?? "");

            }
            return response;
        }

        public static ResponseModel<object> Delete(int Id)
        {
            var response = new ResponseModel<object>();
            try
            {
                ContactRepository.Delete(Id);
            }
            catch (Exception ex)
            {
                response.OK = false;
                response.Errors.Add(ex.Message);
                response.Errors.Add(ex.StackTrace ?? "");

            }
            return response;
        }

        public static ResponseModel<int> Insert(Contact model)
        {
            var response = new ResponseModel<int>();
            try
            {
                var result = ContactRepository.Insert(model);
                response.Records.Add(result);
            }
            catch (Exception ex)
            {
                response.OK = false;
                response.Errors.Add(ex.Message);
                response.Errors.Add(ex.StackTrace ?? "");

            }
            return response;
        }

        public static ResponseModel<object> Update(Contact model)
        {
            var response = new ResponseModel<object>();
            try
            {
                ContactRepository.Update(model);
            }
            catch (Exception ex)
            {
                response.OK = false;
                response.Errors.Add(ex.Message);
                response.Errors.Add(ex.StackTrace ?? "");

            }
            return response;
        }

    }
}
