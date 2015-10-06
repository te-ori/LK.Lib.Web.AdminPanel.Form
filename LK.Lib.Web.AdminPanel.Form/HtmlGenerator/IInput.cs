using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.Lib.Web.AdminPanel.Form.HtmlGenerator
{
    public interface IInput
    {
        string GenerateHtml(string label, string name, string value = "", List<string> options = null);
    }
}
