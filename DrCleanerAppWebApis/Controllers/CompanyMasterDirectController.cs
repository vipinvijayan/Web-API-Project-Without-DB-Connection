using DryCleanerAppDataAccess.Entities;
using DryCleanerAppDataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DrCleanerAppWebApis.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyMasterDirectController : ControllerBase
    {


        [HttpPost]

        public async Task<IActionResult> GetAllCompanyMasters(CommonSearchParam param)
        {
            try
            {
                List<CompanyEntity> companyEntityList = new List<CompanyEntity>();
                for (int i = 1; i < 10; i++)
                {
                    companyEntityList.Add(new CompanyEntity
                    {
                        Id = 1,
                        CompanyName = "Test Company Name " + i,
                        CompanyDescription = "Test Company Description " + i,
                        CompanyAddress = "Test Address " + i,
                        CompanyCity = "Test City " + i,
                        CompanyState = "Test State " + i,
                        CompanyCountry = "Test  Country " + i,
                        CompanyPhone = "Test Company Phone " + i,
                        CompanyEmail = "Test Company Email " + i,
                        CreatedBy = i,
                        UpdatedBy = i,
                        CreatedOn = 1698101901,
                        UpdatedOn = 1698620301,
                        IsDeleted = false,
                        IsActive = true,
                        LandMark = "Test Landmark " + i,
                        Place = "Test Place " + i
                    });
                }


                ResponseObj updatecartObj = new ResponseObj();
                updatecartObj.Result = GeneralDTO.SuccessMessage;
                updatecartObj.ResponseData = companyEntityList;
                return Ok(updatecartObj);

            }
            catch (ValidationException ex)
            {
                var response = new ResponseObj();
                response.Result = GeneralDTO.FailedMessage;
                response.ResponseData = ex.Message;
                return Ok(response);
            }
            catch (ArgumentException ar)
            {
                var response = new ResponseObj();
                response.Result = GeneralDTO.FailedMessage;
                response.ResponseData = ar.Message;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost]

        public async Task<IActionResult> GetCompanyById(IdParam param)
        {
            try
            {
                CompanyEntity companyEntity = new CompanyEntity();
                companyEntity.Id = param.Id;
                companyEntity.CompanyName = "Test Company Name " + param.Id;
                companyEntity.CompanyDescription = "Test Company Description " + param.Id;
                companyEntity.CompanyAddress = "Test Address " + param.Id;
                companyEntity.CompanyCity = "Test City " + param.Id;
                companyEntity.CompanyState = "Test State " + param.Id;
                companyEntity.CompanyCountry = "Test  Country " + param.Id;
                companyEntity.CompanyPhone = "Test Company Phone  " + param.Id;
                companyEntity.CompanyEmail = "Test Company Email " + param.Id;
                companyEntity.CreatedBy = 1;
                companyEntity.UpdatedBy = 1;
                companyEntity.CreatedOn = 1698101901;
                companyEntity.UpdatedOn = 1698620301;
                companyEntity.IsDeleted = false; companyEntity.IsActive = true;
                companyEntity.LandMark = "Test Landmark " + param.Id;
                companyEntity.Place = "Test Place " + param.Id;
                ResponseObj updatecartObj = new ResponseObj();
                updatecartObj.Result = GeneralDTO.SuccessMessage;
                updatecartObj.ResponseData = companyEntity;
                return Ok(updatecartObj);

            }
            catch (ValidationException ex)
            {
                var response = new ResponseObj();
                response.Result = GeneralDTO.FailedMessage;
                response.ResponseData = ex.Message;
                return Ok(response);
            }
            catch (ArgumentException ar)
            {
                var response = new ResponseObj();
                response.Result = GeneralDTO.FailedMessage;
                response.ResponseData = ar.Message;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
