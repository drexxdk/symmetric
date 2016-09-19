using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prototype.Helpers
{
    public static class HtmlHelpers
    {
        public static string ActiveController(this HtmlHelper helper, string controller)
        {
            string classValue = "";
            string currentController = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();
            if (currentController == controller)
            {
                classValue += "active";
            }
            return classValue;
        }

        public static string ActiveAction(this HtmlHelper helper, string action)
        {
            string classValue = "";
            // using viewbag since the current action might be a partial view action.
            //string currentAction = helper.ViewContext.RouteData.Values["action"].ToString();


            string currentAction = helper.ViewContext.Controller.ValueProvider.GetValue("action").RawValue.ToString();
            if (currentAction == action)
            {
                classValue += "active";
            }
            return classValue;
        }

        public static string ActiveActionAndController(this HtmlHelper helper, string action, string controller)
        {
            string classValue = "";
            // using viewbag since the current action might be a partial view action.
            string currentAction = helper.ViewContext.RouteData.Values["action"].ToString();
            string currentController = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();
            if (currentAction == action && currentController == controller)
            {
                classValue += "active";
            }
            return classValue;
        }

    }
}