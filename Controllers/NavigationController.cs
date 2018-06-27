using milestonealaa.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Tanasuk.Controllers
{
    public class NavigationController : Controller
    {
        public ActionResult SideNavigation()
        {
            var datasource = RenderingContext.CurrentOrNull.Rendering.DataSource;
            IEnumerable<NavigationMenuItem> list = null;

            if (!string.IsNullOrWhiteSpace(datasource))
            {
                var datasourceItem = Sitecore.Context.Database.GetItem(datasource);
                list = datasourceItem.GetChildren().Where(o => FiletrItem(o)).Select(o => new NavigationMenuItem { item = o, Title = o["Title"], Children = GetChildren(o) });
            }
            return View("/Views/SideNavigation.cshtml", list);
        }

        public ActionResult Header()
        {

            var datasource = RenderingContext.CurrentOrNull.Rendering.DataSource;
            IEnumerable<NavigationMenuItem> list = null;
            if (!string.IsNullOrWhiteSpace(datasource))
            {
                var datasourceItem = Sitecore.Context.Database.GetItem(datasource);
                list = datasourceItem.GetChildren().Where(o => FiletrItem(o)).Select(o => new NavigationMenuItem { item = o, Title = o["Title"] });
            }
            return View("/Views/Header.cshtml", list);
        }

        public bool FiletrItem(Item currentitem)
        {
            LinkField link = currentitem.Fields["Destination"];
            var item = Sitecore.Context.Database.GetItem(link.TargetID);
            CheckboxField field = (CheckboxField)item.Fields["Include In Navigation"];
            return field.Checked;

        }

        public List<NavigationMenuItem> GetChildren(Item currentchildren)
        {

            List<NavigationMenuItem> Chill = new List<NavigationMenuItem>();

            foreach (Item itemChill in currentchildren.Children)
            {
                var title = itemChill.Fields["Title"].Value;
                LinkField linkfield = itemChill.Fields["Destination"];
                var url = linkfield.GetFriendlyUrl();
                Chill.Add(new NavigationMenuItem { item = itemChill, Title = title, URL = url });
            }

            return Chill;
        }
    }
}