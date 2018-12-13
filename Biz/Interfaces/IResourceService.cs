using System;
using System.Collections.Generic;
using System.Linq;
using Core.Domains;
using System.Text;
using System.Threading.Tasks;

namespace Biz.Interfaces
{
    public interface IResourceService
    {

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        /// 

        IQueryable<Resources> GetAll();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Resources GetById(int id);

        /// <summary>
        /// Inserts or updates the model.
        /// </summary>
        /// <param name="facility">The Facility.</param>
        void InsertOrUpdate(Resources resources);

        /// <summary>
        /// Return Datatable for 
        /// </summary>
        /// <param name="sortOrder"></param>
        /// <param name="search"></param>
        /// <param name="activeFilter"></param>
        /// <returns></returns>
        IEnumerable<Resources> GetAllDataTable(string sortOrder, string search, bool? activeFilter = null);

        /// <summary>
        /// Delete Facility
        /// </summary>
        /// <param name="facility"></param>
        void Delete(Resources resources);
    }
}
