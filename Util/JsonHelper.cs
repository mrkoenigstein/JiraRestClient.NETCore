using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Micromata.Jira.Util
{
    public class JsonHelper
    {
        public static string ToJson(object obj, Type type)
        {
            var serializer = new DataContractJsonSerializer(type);
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, obj);
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            var retval = sr.ReadToEnd();
            ms.Dispose();
            sr.Dispose();
            return retval;
        }
    }

}