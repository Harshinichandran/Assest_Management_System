﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;

namespace Biz.Interfaces
{

    public interface IUsersService
    {

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        /// 
       
        IQueryable<Users> GetAll();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Users GetById(int id);

        /// <summary>
        /// Inserts or updates the model.
        /// </summary>
        /// <param name="facility">The Facility.</param>
        void InsertOrUpdate(Users users);

        /// <summary>
        /// Return Datatable for 
        /// </summary>
        /// <param name="sortOrder"></param>
        /// <param name="search"></param>
        /// <param name="activeFilter"></param>
        /// <returns></returns>
        IEnumerable<Users> GetAllDataTable(string sortOrder, string search, bool? activeFilter = null);

        /// <summary>
        /// Delete Facility
        /// </summary>
        /// <param name="facility"></param>
        void Delete(Users user);

    }
}
