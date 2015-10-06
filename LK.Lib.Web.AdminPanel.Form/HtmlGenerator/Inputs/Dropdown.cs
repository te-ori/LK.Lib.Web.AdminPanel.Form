using System.Collections.Generic;
using System.Text;

namespace LK.Lib.Web.AdminPanel.Form.HtmlGenerator.Inputs
{
    public class Dropdown: IInput
    {
        public string GenerateHtml(string label, string name, string value = "", List<string> options = null)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("<div>");
            builder.AppendFormat("<span>{0}<span>", label);
            builder.AppendFormat("<select type=\"text\" name=\"{0}\" id=\"{0}\">", name);
            foreach (var option in options)
            {
                if (value == option)
                {
                    builder.AppendFormat("<option value=\"{0}\" selected>{0}</option>", option);
                }
                else
                {
                    builder.AppendFormat("<option value=\"{0}\">{0}</option>", option);
                }
            }
            builder.Append("</select>");
            builder.Append("</div>");

            return builder.ToString();
        }
    }
}