using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.Lib.Web.AdminPanel.Form.HtmlGenerator.Inputs
{
    public class TextBox: IInput
    {
        public string GenerateHtml(string label, string name, string value = "", List<string> options = null)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("<div>");
            builder.AppendFormat("<span>{0}<span>", label);
            builder.AppendFormat("<input type=\"text\" name=\"{0}\" id=\"{0}\" value=\"{1}\" />", name, value);
            builder.Append("</div>");

            return builder.ToString();
        }
    }
}
