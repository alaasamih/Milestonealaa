using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace milestonealaa.Models
{
    public class NavigationMenuItem
    {
        public Item item { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public List<NavigationMenuItem> Children { get; set; }
    }
}