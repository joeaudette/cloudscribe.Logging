﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
//	Author:                 Joe Audette
//  Created:			    2015-12-23
//	Last Modified:		    2016-07-01
// 

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;
using cloudscribe.Logging.Web.Models;

namespace cloudscribe.Logging.Web
{
    public class LogManager
    {
        public LogManager(
            ILogRepository logRepository,
            IHttpContextAccessor contextAccessor)
        {
            logRepo = logRepository;
            _context = contextAccessor?.HttpContext;
        }

        private readonly HttpContext _context;
        private CancellationToken CancellationToken => _context?.RequestAborted ?? CancellationToken.None;
        private ILogRepository logRepo;

        public int LogPageSize { get; set; } = 10;

        //public async Task<int> GetLogItemCount(string logLevel = "")
        //{
        //    return await logRepo.GetCount(logLevel, CancellationToken);
        //}

        public async Task<PagedQueryResult> GetLogsDescending(int pageNumber, int pageSize, string logLevel = "")
        {
            return await logRepo.GetPageDescending(pageNumber, pageSize, logLevel, CancellationToken);
        }

        public async Task<PagedQueryResult> GetLogsAscending(int pageNumber, int pageSize, string logLevel = "")
        {
            return await logRepo.GetPageAscending(pageNumber, pageSize, logLevel, CancellationToken);
        }

        public async Task DeleteLogItem(Guid id)
        {
            await logRepo.Delete(id, CancellationToken.None);
        }

        public async Task DeleteAllLogItems(string logLevel = "")
        {
            await logRepo.DeleteAll(logLevel, CancellationToken.None);
        }

    }
}
