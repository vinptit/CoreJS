﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public class Odata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        public int? count { get; set; }
    }

    public class OdataResult<T>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        public Odata odata { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        public object value { get; set; }
        [JsonIgnore]
        public List<T> Value => value as List<T> ?? new List<T>();
        public string Query { get; set; }
        public string Sql { get; set; }

        public OdataResult()
        {
            odata = new Odata();
            value = new List<T>();
        }
    }

    public class WebSocketResponse<T>
    {
        public int EntityId { get; set; }
        public int TypeId { get; set; }
        public T Data { get; set; }
        public List<T> DataList { get; set; }
    }
}
