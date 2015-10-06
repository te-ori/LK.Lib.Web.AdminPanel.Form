using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.Lib.Web.AdminPanel.Form.Attributes
{
    public interface IAdminFormAttribute
    {
        InputType InputType { get; set; }
        string GenerateHtml(string name, string value);

    }
}
