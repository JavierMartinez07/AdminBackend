using AdminBackend.Models;
using AdminBackend.Repositories;

namespace AdminBackend.BusinessLogic
{
    public class CustomerBusinessLogic
    {
        public static ResponseModel<Customer> Get()
        {
            var response = new ResponseModel<Customer>();
            try
            {
                var result = CustomerRepository.Get();
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

        public static ResponseModel<Customer> Get(int Id)
        {
            var response = new ResponseModel<Customer>();
            try
            {
                var result = CustomerRepository.Get(Id);
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

        public static ResponseModel<Customer> GetByCompanyId(int Id)
        {
            var response = new ResponseModel<Customer>();
            try
            {
                var result = CustomerRepository.GetByCompanyId(Id);
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
                CustomerRepository.Delete(Id);
            }
            catch (Exception ex)
            {
                response.OK = false;
                response.Errors.Add(ex.Message);
                response.Errors.Add(ex.StackTrace ?? "");

            }
            return response;
        }

        public static ResponseModel<int> Insert(Customer model)
        {
            var response = new ResponseModel<int>();
            try
            {
                var result = CustomerRepository.Insert(model);
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

        public static ResponseModel<object> Update(Customer model)
        {
            var response = new ResponseModel<object>();
            try
            {
                CustomerRepository.Update(model);
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
