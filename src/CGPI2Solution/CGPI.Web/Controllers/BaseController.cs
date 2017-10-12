using Microsoft.AspNetCore.Mvc;
using QJ.Framework.Infrastructure.FormatModels;
using QJ.Framework.Infrastructure.Json;

namespace CGPI.Web.Controllers
{
    public class BaseController : Controller
    {
        #region ��ݷ���

        protected ActionResult Success(string message = "��ϲ���������ɹ���", object data = null)
        {
            return Content(new AjaxResult(ResultType.Success, message, data).ToJson());
        }

        protected ActionResult Error(string message = "�Բ��𣬲���ʧ�ܡ�", object data = null)
        {
            return Content(new AjaxResult(ResultType.Error, message, data).ToJson());
        }

        protected ActionResult Warning(string message, object data = null)
        {
            return Content(new AjaxResult(ResultType.Warning, message, data).ToJson());
        }

        protected ActionResult Info(string message, object data = null)
        {
            return Content(new AjaxResult(ResultType.Info, message, data).ToJson());
        }

        #endregion
    }
}