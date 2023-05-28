Constructors:

```C#

public ParametrAttribute(
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
    string sourceColumn = "",
    bool sourceColumnNullMapping = false,
    DataRowVersion sourceVersion = DataRowVersion.Current,
    byte scale = 0,
    byte precision = 0,
    string methodParametrName = null
    )

```
Parametrs is the SqlParamet properties.
Rest parametrs and usage same as [Parametr](https://github.com/SoftStoneDevelop/Gedaq.DbConnection/blob/main/Documentation/Parametr.md).
