﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace ClinicalTrials
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.EnableCors();
            

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "RepliesRoute",
                routeTemplate: "api/v1/topics/{topicid}/replies/{id}",
                defaults: new { controller = "replies", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "FormElementsRoute",
                routeTemplate: "api/v1/groups/{groupid}/formelement/{id}",
                defaults: new { controller = "FormElements", id = RouteParameter.Optional }
            );


            config.Routes.MapHttpRoute(
                name: "FormElementOptionsRoute",
                routeTemplate: "api/v1/formelementoptions/{formElementId}/{id}",
                defaults: new { controller = "FormElementOptions", id = RouteParameter.Optional }
            );


            config.Routes.MapHttpRoute(
                name: "ChildFormElementRoute",
                routeTemplate: "api/v1/childformelement/{formElementOptionId}/{id}",
                defaults: new { controller = "ChildFormElement", id = RouteParameter.Optional }
            );


            config.Routes.MapHttpRoute(
                name: "GroupsRoute",
                routeTemplate: "api/v1/groups/{groupId}/{id}",
                defaults: new { controller = "groups", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GroupByName",
                routeTemplate: "api/v1/groupbyname/{groupName}/{id}",
                defaults: new { controller = "groups", action = "GetGroupByName", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v1/topics/{id}",
                defaults: new { controller = "topics", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ProtocolFormElementOptionsByFormElementOption_Id",
                routeTemplate: "api/v1/protocolformelementoptionsbyid/{formElementOptionId}/{id}",
                defaults: new { controller = "ProtocolFormElementOptions", id = RouteParameter.Optional }
                );

            config.Routes.MapHttpRoute(
                name: "Protocols",
                routeTemplate: "api/v1/protocols/{protocolId}/{id}",
                defaults: new { controller = "Protocols", action = "Get", id = RouteParameter.Optional }
            );
            
            config.Routes.MapHttpRoute(
                name: "ProtocolById",
                routeTemplate: "api/v1/protocolbyid/{trialId}",
                defaults: new { controller = "Protocols", action = "GetById" }
            );

            config.Routes.MapHttpRoute(
                name: "ProtocolIds",
                routeTemplate: "api/v1/protocolids/{start}/{quantity}",
                defaults: new { controller = "Protocols", action = "GetListIds", start = RouteParameter.Optional, quantity = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ProtocolCount",
                routeTemplate: "api/v1/protocolcount",
                defaults: new { controller = "Protocols", action = "GetListCount" }
            );

            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();
        }
    }
}