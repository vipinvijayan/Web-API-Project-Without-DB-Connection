using Dapper;
using DryCleanerAppDataAccess.Entities;
using DryCleanerAppDataAccess.Infrastructure;
using DryCleanerAppDataAccess.IRepository;
using DryCleanerAppDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleanerAppDataAccess.Repository
{
    public class CompanyRepository : ICompanyRepository
    {

        public CompanyRepository()
        {

        }

        public async Task<string> CreateCompany(CompanyEntity param)
        {
            DynamicParameters parm = new DynamicParameters();
            parm.Add("CompanyName", param.CompanyName);
            parm.Add("CompanyDescription", param.CompanyDescription);
            parm.Add("CompanyAddress", param.CompanyAddress);
            parm.Add("CompanyCity", param.CompanyCity);
            parm.Add("CompanyState", param.CompanyState);
            parm.Add("CompanyPhone", param.CompanyPhone);
            parm.Add("CompanyCountry", param.CompanyCountry);
            parm.Add("CompanyEmail", param.CompanyEmail);
            parm.Add("LandMark", param.LandMark);
            parm.Add("Place", param.Place);
            parm.Add("CreatedBy", param.CreatedBy);


            return GeneralDTO.SuccessMessage;
        }
        public async Task<CompanyEntity?> GetCompanyById(int companyId)
        {

            CompanyEntity companyEntity = new CompanyEntity();


            companyEntity.Id = companyId;
            companyEntity.CompanyName = "Test Company Name " + companyId;
            companyEntity.CompanyDescription = "Test Company Description " + companyId;
            companyEntity.CompanyAddress = "Test Address " + companyId;
            companyEntity.CompanyCity = "Test City " + companyId;
            companyEntity.CompanyState = "Test State " + companyId;
            companyEntity.CompanyCountry = "Test  Country " + companyId;
            companyEntity.CompanyPhone = "Test Company Phone  " + companyId;
            companyEntity.CompanyEmail = "Test Company Email " + companyId;
            companyEntity.CreatedBy = 1;
            companyEntity.UpdatedBy = 1;
            companyEntity.CreatedOn = 1698101901;
            companyEntity.UpdatedOn = 1698620301;
            companyEntity.IsDeleted = false; companyEntity.IsActive = true;
            companyEntity.LandMark = "Test Landmark " + companyId;
            companyEntity.Place = "Test Place " + companyId;

            return companyEntity;

        }
        public async Task<IEnumerable<CompanyEntity>> GetAll(CommonSearchParam param)
        {

            ////string query = "SELECT `Id`,`CompanyName`,`CompanyDescription`,`CompanyAddress`,`CompanyCity`,`CompanyState`,`CompanyCountry`,`CompanyPhone`,`CompanyEmail`,`CreatedBy`," +
            ////       "`UpdatedBy`,`CreatedOn`,`UpdatedOn`,`IsDeleted`,`IsActive`,`LandMark`,`Place` FROM `companyEntities` where `companyEntities`.`IsDeleted`=b'0' and `companyEntities`.`IsActive`=b'1'";

            //if (param.TakeAll)
            //{
            //    query += "  group BY companyEntities.`ID`  order by companyEntities.`Id` Desc";
            //}
            //else
            //{
            //    query += "  group BY o.`ID`  order by o.`CreatedOn` Desc LIMIT " + param.SkipCount + " , " + param.TakeCount;

            //}
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
            return companyEntityList;


        }

        public async Task<string> UpdateCompany(CompanyListModel param)
        {
            DynamicParameters parm = new DynamicParameters();
            parm.Add("Id", param.Id);
            parm.Add("CompanyName", param.CompanyName);
            parm.Add("CompanyDescription", param.CompanyDescription);
            parm.Add("CompanyAddress", param.CompanyAddress);
            parm.Add("CompanyCity", param.CompanyCity);
            parm.Add("CompanyState", param.CompanyState);
            parm.Add("CompanyPhone", param.CompanyPhone);
            parm.Add("CompanyCountry", param.CompanyCountry);
            parm.Add("CompanyEmail", param.CompanyEmail);
            parm.Add("LandMark", param.LandMark);
            parm.Add("Place", param.Place);
            parm.Add("UpdatedBy", param.CreatedBy);
            return GeneralDTO.SuccessMessage;
        }

    }


}



