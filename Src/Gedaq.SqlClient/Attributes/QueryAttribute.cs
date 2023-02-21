using Gedaq.Common.Enums;
using System;

namespace Gedaq.Npgsql.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method, AllowMultiple = true)]
    public sealed class QueryAttribute : Attribute
    {
        public QueryAttribute(
            string query,
            string methodName,
            Type queryMapType = null,
            MethodType methodType = MethodType.Sync,
            QueryType queryType = QueryType.Read,
            bool generate = true
            )
        {
        }
    }
}