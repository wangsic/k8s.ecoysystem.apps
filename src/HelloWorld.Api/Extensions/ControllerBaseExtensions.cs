﻿using HelloWorld.Api.ActionResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Api.Extensions
{
    public static class ControllerBaseExtensions
    {
        public static InternalServerErrorObjectResult InternalServerError(this ControllerBase source)
        {
            return new InternalServerErrorObjectResult();
        }
    }
}
