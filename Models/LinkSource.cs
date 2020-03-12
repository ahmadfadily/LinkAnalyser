using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkAnalyser.Controllers;

namespace LinkAnalyser.Models
{
    public class LinkSource
    {
        public string Link { get; set; }
        public string CEID;
        public string GAP;

        public void LinkSorter()
        {
            String[] spearator = { " ", "CEID=","GAP="};
            if (Link != null)
            {
                String[] strlist = Link.Split(spearator, StringSplitOptions.RemoveEmptyEntries);//TODO
                Link = strlist == null ? strlist[0] : "";
                CEID = strlist.Length > 1 ? (strlist[1]).Substring(5) : "";
                GAP = strlist.Length > 2 ? (strlist[2]).Substring(5) : "";
            }
        }   

    }
}