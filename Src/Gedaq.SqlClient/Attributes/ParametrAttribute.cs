using System;
using System.Data;
using System.Data.SqlTypes;

namespace Gedaq.Npgsql.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method, AllowMultiple = true)]
    public sealed class ParametrAttribute : Attribute
    {
        public ParametrAttribute(
            string methodName,
            Type parametrType,
            string parametrName = null,
            SqlCompareOptions compareInfo = SqlCompareOptions.None,
            bool forceColumnEncryption = false,
            int localeId = 0,
            int offset = 0,
            SqlDbType sqlDbType = SqlDbType.NVarChar,
            string typeName = "",
            string udtTypeName = "",
            string xmlSchemaCollectionDatabase = "",
            string xmlSchemaCollectionName = "",
            string xmlSchemaCollectionOwningSchema = "",
            int size = -1,
            bool nullable = false,
            ParameterDirection direction = ParameterDirection.Input,
            int position = -1,
            string sourceColumn = "",
            bool sourceColumnNullMapping = false,
            DataRowVersion sourceVersion = DataRowVersion.Current,
            byte scale = 0,
            byte precision = 0
            )
        {
        }
    }
}