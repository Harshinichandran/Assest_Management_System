using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biz.Interfaces;
using Biz.Interfaces.Services;
using Core.Domains;
using Core.Helpers;
using Data;


namespace Biz.Services
{
    public class ReportService : IReportService
    {
        #region Variables
        private Reports m_report;
        private FacilityService _facilityService;
        private ResourcesService _resourceService;
        #endregion

        #region Properties
        public Reports Report
        {
            get { return m_report; }
            set { m_report = value; }
        }
        #endregion



        #region Constructor

        public ReportService()
        {
            Report = new Reports();
            _resourceService = new ResourcesService();
            _facilityService = new FacilityService();
        }
        #endregion

        #region Methods
        public Reports DisplayReport(int FacilityID)
        {
            //List<Reports> reportCollection = new List<Reports>();
            Report.facilityCollection = GetAllFacilities().Where(x => x.Id == FacilityID);
            Report.facility = Report.facilityCollection.First();
            Report.resourceCollection = GetResources().Where(x => x.FacilityId == FacilityID);
            //reportCollection.Add(Report);
            return Report;
        }

        public IQueryable<Facility> GetAllFacilities()
        {
            try
            {
                return _facilityService.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Resources> GetResources()
        {
            try
            {
                return _resourceService.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Resources GetResourceDetail(int id)
        {
            return _resourceService.GetById(id);
        }

        public Facility GetFacility(int id)
        {
            return _facilityService.GetById(id);
        }

        public void UpdateResources(Resources resource)
        {
            _resourceService.InsertOrUpdate(resource);
        }
        #endregion
    }
}
