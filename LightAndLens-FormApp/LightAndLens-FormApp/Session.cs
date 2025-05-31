using LightAndLens_FormApp.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LightAndLens_FormApp
{
    public static class Session
    {
        public static ApplicationUser CurrentUser { get; set; }
    }
}
