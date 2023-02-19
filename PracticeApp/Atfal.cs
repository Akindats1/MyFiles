using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApp
{
    public class Atfal
    {
        
        
        public string name {get;set;}
        public int age{get;set;}
        public string dila{get;set;}
        public string _theme;
            

        public void SetTheme(string theme)
        {
            _theme = theme;
        }

        public string GetTheme()
        {
            return _theme;
        }

        public string Register()
        {
            string detail = "You have registered!";

            return detail;
        
        }


           
        

    }
}