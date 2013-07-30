//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace DataService
{
    public class Service : DataService<CloudEDUEntities>
    {
        private static CloudEDUEntities ctx = new CloudEDUEntities();

        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
            config.UseVerboseErrors = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer_id"></param>
        /// <param name="course_id"></param>
        /// <returns>0 success, others fail</returns>
        [WebGet]
        public int? EnrollCourse(int customer_id, int course_id)
        {
            int? res = ctx.EnrollCourse(course_id, customer_id).FirstOrDefault();
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacher_id"></param>
        /// <param name="title"></param>
        /// <param name="intro"></param>
        /// <param name="category_id"></param>
        /// <param name="price"></param>
        /// <param name="pg_id"></param>
        /// <param name="icon_url"></param>
        /// <returns>0 success, others fail</returns>
        [WebGet]
        public decimal? CreateCourse(int teacher_id, string title, string intro, int category_id, double price, int pg_id, string icon_url)
        {
            decimal? res = ctx.CreateCourse(teacher_id, title, intro, category_id, new decimal(price), pg_id, icon_url).FirstOrDefault();
            return res;
        }

    }
}
