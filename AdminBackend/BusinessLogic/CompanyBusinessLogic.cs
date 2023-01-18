using AdminBackend.Models;
using AdminBackend.Repositories;

namespace AdminBackend.BusinessLogic
{
    public class CompanyBusinessLogic
    {
        public static ResponseModel<Company> Get()
        {
            var response = new ResponseModel<Company>();
            try
            {
                var result = CompanyRepository.Get();
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

        public static ResponseModel<Company> Get(int Id)
        {
            var response = new ResponseModel<Company>();
            try
            {
                var result = CompanyRepository.Get(Id);
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
                CompanyRepository.Delete(Id);
            }
            catch (Exception ex)
            {
                response.OK = false;
                response.Errors.Add(ex.Message);
                response.Errors.Add(ex.StackTrace ?? "");

            }
            return response;
        }

        public static ResponseModel<int> Insert(Company model)
        {
            var response = new ResponseModel<int>();
            try
            {
                var result = CompanyRepository.Insert(model);
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

        public static ResponseModel<object> Update(Company model)
        {
            var response = new ResponseModel<object>();
            try
            {
                CompanyRepository.Update(model);
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
