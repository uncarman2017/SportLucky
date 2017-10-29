﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Filters;

namespace SportLucky.Service.Host
{
    public class JsonCallbackAttribute : ActionFilterAttribute
    {
        private const string CallbackQueryParameter = "callback";

        public override void OnActionExecuted(HttpActionExecutedContext context)
        {
            var callback = string.Empty;

            if (IsJsonp(out callback))
            {
                var jsonBuilder = new StringBuilder(callback);

                jsonBuilder.AppendFormat("({0})", context.Response.Content.ReadAsStringAsync().Result);

                context.Response.Content = new StringContent(jsonBuilder.ToString());
                //context.Response.Content = new StringContent("C(\"a\")");
            }

            base.OnActionExecuted(context);
        }

        private bool IsJsonp(out string callback)
        {
            callback = System.Web.HttpContext.Current.Request[CallbackQueryParameter];

            return !string.IsNullOrEmpty(callback);
        }
    }
}