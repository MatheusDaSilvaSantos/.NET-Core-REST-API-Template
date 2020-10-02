﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST_API.Data;
using REST_API.Data.Requests;
using REST_API.Web_API.Interface;

namespace REST_API.Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : BaseCRUDController<Data.Branch, BranchSearchRequest, BranchUpsert, BranchUpsert>
    {
        public BranchController(ICRUDService<Branch, BranchSearchRequest, BranchUpsert, BranchUpsert> service) : base(service)
        {
        }
    }
}