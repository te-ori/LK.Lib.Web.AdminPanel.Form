using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using LK.Lib.Web.AdminPanel.Form.HtmlGenerator;

namespace LK.Lib.Web.AdminPanel.Form.Attributes
{
    public class AdminFormAttribute: Attribute, IAdminFormAttribute
    {
        private IHtmlGenerator _htmlGenerator;

        public InputType InputType { get; set; }
        public string Label { get; set; }
        public List<string> Options { get; set; }

        public AdminFormAttribute(InputType inputType, string label, string options ="" )
        {
            _htmlGenerator = new HtmlGenerator.HtmlGenerator();

            InputType = inputType;
            Label = label;
            Options =(string.IsNullOrWhiteSpace(options))?null :options.Split(new []{','}).ToList();
        }

        public string GenerateHtml(string name, string value)
        {
            string result = _htmlGenerator.GenerateHtml(InputType, Label, name, value, Options);

            return result;
        }            
    }
}
