using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Converters;

namespace QJ.Framework.Infrastructure.FormatModels
{
    public class JsonDateFormat : IsoDateTimeConverter
    {
        public JsonDateFormat()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }
    }

    public class JsonDateTimeFormat : IsoDateTimeConverter
    {
        public JsonDateTimeFormat()
        {
            base.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        }

    }
}
