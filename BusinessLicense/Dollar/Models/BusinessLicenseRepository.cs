using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dollar.Models
{
    public class BusinessLicenseRepository: IBusinessLicenseRepository
    {
        private readonly AppDbContext db; 
        public BusinessLicenseRepository(AppDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<BusinessLicense_TMP> GetAllBusinessLicense()
        {
            var businessLicenses = from bl in db.BusinessLicense_TMP.Take(1000).ToList() select bl;   
            return businessLicenses; 
        }
    }
}
