using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;

namespace Biz.Interfaces
{

    public interface IAssociationService
    {

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        /// 

        IQueryable<Association> GetAll();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Association GetById(int id);

        /// <summary>
        /// Inserts or updates the model.
        /// </summary>
        /// <param name="facility">The Facility.</param>
        void InsertOrUpdate(Association association);

        /// <summary>
        /// Return Datatable for 
        /// </summary>
        /// <param name="sortOrder"></param>
        /// <param name="search"></param>
        /// <param name="activeFilter"></param>
        /// <returns></returns>
        IEnumerable<Association> GetAllDataTable(string sortOrder, string search, bool? activeFilter = null);

        /// <summary>
        /// Delete Facility
        /// </summary>
        /// <param name="facility"></param>
        void Delete(Association association);

    }
}
