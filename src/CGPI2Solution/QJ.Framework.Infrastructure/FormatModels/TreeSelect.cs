using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace QJ.Framework.Infrastructure.FormatModels
{
    /// <summary>
    /// Select2树形下拉列表模型。
    /// </summary>
    public class TreeSelect
    {
        public string id { get; set; }
        public string text { get; set; }
        public string parentId { get; set; }
        public object data { get; set; }
    }

    public static class TreeSelectHelper
    {
        public static string ToTreeSelectJson(this List<TreeSelect> data)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append(ToTreeSelectJson(data, "0", ""));
            sb.Append("]");
            return sb.ToString();
        }
        private static string ToTreeSelectJson(List<TreeSelect> data, string parentId, string blank)
        {
            StringBuilder sb = new StringBuilder();
            var childList = data.FindAll(t => t.parentId == parentId);

            //var tabline = "";
            var tabline = "├ ";
            if (parentId != "0")
            {
                tabline = "　　";
                //tabline = " ";
            }
            if (childList.Count > 0)
            {
                tabline = tabline + blank;
            }
            foreach (TreeSelect entity in childList)
            {
                entity.text = tabline + entity.text;
                string strJson = JsonConvert.SerializeObject(entity);
                sb.Append(strJson);
                sb.Append(ToTreeSelectJson(data, entity.id, tabline));
            }
            return sb.ToString().Replace("}{", "},{");
        }
    }
}