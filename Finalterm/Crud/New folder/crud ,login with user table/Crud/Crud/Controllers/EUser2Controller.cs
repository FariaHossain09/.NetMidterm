﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.BOs;
using BLL.Services;


namespace Crud.Controllers
{
   
    public class EUser2Controller : ApiController
    {
        [Route("api/eusers2/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = EUser2Service.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/eusers2/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = EUser2Service.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/eusers2/create")]
        [HttpPost]
        public HttpResponseMessage Create(EUser2Model st)
        {
            var data = EUser2Service.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/eusers2/update")]
        [HttpPost]
        public HttpResponseMessage Update(EUser2Model user)
        {
            var data = EUser2Service.Update(user);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/department/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {


            var data1 = EUser2Service.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data1);
        }

    }
}
