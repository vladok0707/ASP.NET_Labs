﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
    public class GetHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
         
            HttpResponse res = context.Response;
        string A = req.QueryString["ParmA"];
        string B = req.QueryString["ParmB"];
        res.Write(req.HttpMethod + "-HTTP-" +req.Path + ":ParmA="+A + ", ParmB=" + B);
    }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }