using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LK.Lib.Web.AdminPanel.Form.Attributes;
using LK.Lib.Web.AdminPanel.Form.FormGenerator;

namespace Test.Models
{
    public class Custom: FormGenerator
    {
        [AdminForm(InputType.TextBox, "İsim")]
        public string Name { get; set; }
        [AdminForm(InputType.TextBox, "Soyisim")]
        public string Surname { get; set; }
        [AdminForm(InputType.DropDown, "Doğumyeri", "İstanbul,Elazığ,Ankara,Niğde")]
        public string BirthPlace { get; set; }
        [AdminForm(InputType.DropDown, "Doğum Tarihi", "1980,1981,1982,1983,1984,1985,1986,1987")]
        public int BirthYear { get; set; }
    }
}