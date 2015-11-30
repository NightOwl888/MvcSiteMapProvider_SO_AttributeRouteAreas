//using System.Web.Mvc;

//namespace SO_AttributeRouteAreas.Areas.Store
//{
//    public class StoreAreaRegistration : AreaRegistration
//    {
//        public override string AreaName
//        {
//            get
//            {
//                return "Store";
//            }
//        }

//        public override void RegisterArea(AreaRegistrationContext context)
//        {
//            context.MapRoute(
//                "Store_List",
//                "Store/List/{page}/{itemsPerPage}",
//                new { controller = "Home", action = "List", page = UrlParameter.Optional, itemsPerPage = UrlParameter.Optional },
//                new string[] { "SO_AttributeRouteAreas.Areas.Store.Controllers" }
//            );

//            context.MapRoute(
//                "Store_Search",
//                "Store/Search/{tags}/{page}",
//                new { controller = "Home", action = "Search", tags = UrlParameter.Optional, page = UrlParameter.Optional },
//                new string[] { "SO_AttributeRouteAreas.Areas.Store.Controllers" }
//            );

//            context.MapRoute(
//                "Store_default",
//                "Store/{controller}/{action}/{id}",
//                new { action = "Index", id = UrlParameter.Optional },
//                new string[] { "SO_AttributeRouteAreas.Areas.Store.Controllers" }
//            );
//        }
//    }
//}