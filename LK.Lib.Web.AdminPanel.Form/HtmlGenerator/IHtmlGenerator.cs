using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LK.Lib.Web.AdminPanel.Form.Attributes;

namespace LK.Lib.Web.AdminPanel.Form.HtmlGenerator
{
    public interface IHtmlGenerator
    {
        string GenerateHtml(InputType inputType, string label, string name, string value = null, List<string> options = null);
    }
}
