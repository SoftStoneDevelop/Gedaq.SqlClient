using System;
using System.Data;
using System.Data.SqlTypes;

namespace Gedaq.SqlClient.Attributes
{
    /// <summary>
    /// An attribute for specifying a parameter passed in a request.
    /// </summary>
    /// <seealso href="https://github.com/SoftStoneDevelop/Gedaq.SqlClient/blob/main/Documentation/Parametr.md"/>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method, AllowMultiple = true)]
    public sealed class ParametrAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parametrType">The type of parameter added to the generated query</param>
        /// <param name="parametrName">Parameter name if it is a named parameter, there are also positional parameters <paramref name="position"/></param>
        /// <param name="compareInfo"></param>
        /// <param name="forceColumnEncryption"></param>
        /// <param name="localeId"></param>
        /// <param name="offset"></param>
        /// <param name="dbType"></param>
        /// <param name="typeName"></param>
        /// <param name="udtTypeName"></param>
        /// <param name="xmlSchemaCollectionDatabase"></param>
        /// <param name="xmlSchemaCollectionName"></param>
        /// <param name="xmlSchemaCollectionOwningSchema"></param>
        /// <param name="size"></param>
        /// <param name="nullable"></param>
        /// <param name="direction"></param>
        /// <param name="sourceColumn"></param>
        /// <param name="sourceColumnNullMapping"></param>
        /// <param name="sourceVersion"></param>
        /// <param name="scale"></param>
        /// <param name="precision"></param>
        /// <param name="methodParametrName">The name of the parameter in the generated method. If not specified, an abstract name will be used, such as parameter1, parameter2, etc.</param>
        public ParametrAttribute(
            Type parametrType,
            string? parametrName = null,
            SqlCompareOptions compareInfo = SqlCompareOptions.None,
            bool forceColumnEncryption = false,
            int localeId = 0,
            int offset = 0,
            SqlDbType dbType = SqlDbType.NVarChar,
            string typeName = "",
            string udtTypeName = "",
            string xmlSchemaCollectionDatabase = "",
            string xmlSchemaCollectionName = "",
            string xmlSchemaCollectionOwningSchema = "",
            int size = -1,
            bool nullable = false,
            ParameterDirection direction = ParameterDirection.Input,
            string sourceColumn = "",
            bool sourceColumnNullMapping = false,
            DataRowVersion sourceVersion = DataRowVersion.Current,
            byte scale = 0,
            byte precision = 0,
            string? methodParametrName = null)
        {
        }
    }
}