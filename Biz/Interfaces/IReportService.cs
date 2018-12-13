using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;
using Core.Helpers;

namespace Biz.Interfaces
{
    public interface IReportService
    {
        /// <summary>
        /// Returns all the facilities of the business
        /// </summary>
        /// <returns></returns>
        IQueryable<Facility> GetAllFacilities();
        /// <summary>
        /// Returns resource
        /// </summary>
        /// <returns></returns>
        IQueryable<Resources> GetResources();
        /// <summary>
        /// Returns resources of a particular facility
        /// </summary>
        /// <returns></returns>
        Reports DisplayReport(int FacilityID);

        Resources GetResourceDetail(int id);
        Facility GetFacility(int id);
        void UpdateResources(Resources resource);

    }
}
