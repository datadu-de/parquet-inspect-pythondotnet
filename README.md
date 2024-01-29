# Output

```
Hello, World!


ListFiles:
['2-1f7ae4d2-1cc7-45bf-86b0-466a2c13b4f4-0.parquet']


ReadHistory:
Schema([Field(SalesOrderID, PrimitiveType("integer"), nullable=True), Field(RevisionNumber, PrimitiveType("byte"), nullable=True), Field(OrderDate, PrimitiveType("timestamp"), nullable=True), Field(DueDate, PrimitiveType("timestamp"), nullable=True), Field(ShipDate, PrimitiveType("timestamp"), nullable=True), Field(Status, PrimitiveType("byte"), nullable=True), Field(OnlineOrderFlag, PrimitiveType("boolean"), nullable=True), Field(SalesOrderNumber, PrimitiveType("string"), nullable=True), Field(PurchaseOrderNumber, PrimitiveType("string"), nullable=True), Field(AccountNumber, PrimitiveType("string"), nullable=True), Field(CustomerID, PrimitiveType("integer"), nullable=True), Field(SalesPersonID, PrimitiveType("integer"), nullable=True), Field(TerritoryID, PrimitiveType("integer"), nullable=True), Field(BillToAddressID, PrimitiveType("integer"), nullable=True), Field(ShipToAddressID, PrimitiveType("integer"), nullable=True), Field(ShipMethodID, PrimitiveType("integer"), nullable=True), Field(CreditCardID, PrimitiveType("integer"), nullable=True), Field(CreditCardApprovalCode, PrimitiveType("string"), nullable=True), Field(CurrencyRateID, PrimitiveType("integer"), nullable=True), Field(SubTotal, PrimitiveType("double"), nullable=True), Field(TaxAmt, PrimitiveType("double"), nullable=True), Field(Freight, PrimitiveType("double"), nullable=True), Field(TotalDue, PrimitiveType("double"), nullable=True), Field(Comment, PrimitiveType("string"), nullable=True), Field(rowguid, PrimitiveType("string"), nullable=True), Field(ModifiedDate, PrimitiveType("timestamp"), nullable=True)])

ReadHistory:
[{'timestamp': 1702735145541, 'operation': 'WRITE', 'operationParameters': {'mode': 'Overwrite', 'partitionBy': '[]'}, 'clientVersion': 'delta-rs.0.17.0', 'version': 2}, {'timestamp': 1702735097303, 'operation': 'WRITE', 'operationParameters': {'partitionBy': '[]', 'mode': 'Overwrite'}, 'clientVersion': 'delta-rs.0.17.0', 'version': 1}, {'timestamp': 1702735022032, 'operation': 'CREATE TABLE', 'operationParameters': {'protocol': '{"minReaderVersion":1,"minWriterVersion":2,"readerFeatures":null,"writerFeatures":null}', 'mode': 'ErrorIfExists', 'location': 'file:///Users/frank/Code/parquet-inspect/data/deltalake/sales_salesorderheader.delta', 'metadata': '{"configuration":{},"created_time":1702735022031,"description":null,"format":{"options":{},"provider":"parquet"},"id":"52a2d777-bc2e-433f-8818-3b7f4bb667bd","name":null,"partition_columns":[],"schema":{"fields":[{"metadata":{},"name":"SalesOrderID","nullable":true,"type":"integer"},{"metadata":{},"name":"RevisionNumber","nullable":true,"type":"byte"},{"metadata":{},"name":"OrderDate","nullable":true,"type":"timestamp"},{"metadata":{},"name":"DueDate","nullable":true,"type":"timestamp"},{"metadata":{},"name":"ShipDate","nullable":true,"type":"timestamp"},{"metadata":{},"name":"Status","nullable":true,"type":"byte"},{"metadata":{},"name":"OnlineOrderFlag","nullable":true,"type":"boolean"},{"metadata":{},"name":"SalesOrderNumber","nullable":true,"type":"string"},{"metadata":{},"name":"PurchaseOrderNumber","nullable":true,"type":"string"},{"metadata":{},"name":"AccountNumber","nullable":true,"type":"string"},{"metadata":{},"name":"CustomerID","nullable":true,"type":"integer"},{"metadata":{},"name":"SalesPersonID","nullable":true,"type":"integer"},{"metadata":{},"name":"TerritoryID","nullable":true,"type":"integer"},{"metadata":{},"name":"BillToAddressID","nullable":true,"type":"integer"},{"metadata":{},"name":"ShipToAddressID","nullable":true,"type":"integer"},{"metadata":{},"name":"ShipMethodID","nullable":true,"type":"integer"},{"metadata":{},"name":"CreditCardID","nullable":true,"type":"integer"},{"metadata":{},"name":"CreditCardApprovalCode","nullable":true,"type":"string"},{"metadata":{},"name":"CurrencyRateID","nullable":true,"type":"integer"},{"metadata":{},"name":"SubTotal","nullable":true,"type":"double"},{"metadata":{},"name":"TaxAmt","nullable":true,"type":"double"},{"metadata":{},"name":"Freight","nullable":true,"type":"double"},{"metadata":{},"name":"TotalDue","nullable":true,"type":"double"},{"metadata":{},"name":"Comment","nullable":true,"type":"string"},{"metadata":{},"name":"rowguid","nullable":true,"type":"string"},{"metadata":{},"name":"ModifiedDate","nullable":true,"type":"timestamp"}],"type":"struct"}}'}, 'clientVersion': 'delta-rs.0.17.0', 'version': 0}]


ReadMetadata:
Metadata(id: 52a2d777-bc2e-433f-8818-3b7f4bb667bd, name: None, description: None, partition_columns: [], created_time: 1702735022031, configuration: {})


CurrentAddActions:
pyarrow.RecordBatch
path: string not null
size_bytes: int64 not null
modification_time: timestamp[ms] not null
data_change: bool not null
num_records: int64 not null
null_count.SalesOrderID: int64 not null
min.SalesOrderID: int32 not null
max.SalesOrderID: int32 not null
null_count.RevisionNumber: int64 not null
min.RevisionNumber: int8 not null
max.RevisionNumber: int8 not null
null_count.OrderDate: int64 not null
min.OrderDate: timestamp[us] not null
max.OrderDate: timestamp[us] not null
null_count.DueDate: int64 not null
min.DueDate: timestamp[us] not null
max.DueDate: timestamp[us] not null
null_count.ShipDate: int64 not null
min.ShipDate: timestamp[us] not null
max.ShipDate: timestamp[us] not null
null_count.Status: int64 not null
min.Status: int8 not null
max.Status: int8 not null
null_count.OnlineOrderFlag: int64 not null
min.OnlineOrderFlag: bool not null
max.OnlineOrderFlag: bool not null
null_count.SalesOrderNumber: int64 not null
min.SalesOrderNumber: string not null
max.SalesOrderNumber: string not null
null_count.PurchaseOrderNumber: int64 not null
min.PurchaseOrderNumber: string not null
max.PurchaseOrderNumber: string not null
null_count.AccountNumber: int64 not null
min.AccountNumber: string not null
max.AccountNumber: string not null
null_count.CustomerID: int64 not null
min.CustomerID: int32 not null
max.CustomerID: int32 not null
null_count.SalesPersonID: int64 not null
min.SalesPersonID: int32 not null
max.SalesPersonID: int32 not null
null_count.TerritoryID: int64 not null
min.TerritoryID: int32 not null
max.TerritoryID: int32 not null
null_count.BillToAddressID: int64 not null
min.BillToAddressID: int32 not null
max.BillToAddressID: int32 not null
null_count.ShipToAddressID: int64 not null
min.ShipToAddressID: int32 not null
max.ShipToAddressID: int32 not null
null_count.ShipMethodID: int64 not null
min.ShipMethodID: int32 not null
max.ShipMethodID: int32 not null
null_count.CreditCardID: int64 not null
min.CreditCardID: int32 not null
max.CreditCardID: int32 not null
null_count.CreditCardApprovalCode: int64 not null
min.CreditCardApprovalCode: string not null
max.CreditCardApprovalCode: string not null
null_count.CurrencyRateID: int64 not null
min.CurrencyRateID: int32 not null
...
---
path: ["2-1f7ae4d2-1cc7-45bf-86b0-466a2c13b4f4-0.parquet"]
size_bytes: [3177536]
modification_time: [2023-12-16 13:59:05.540]
data_change: [true]
num_records: [31465]
null_count.SalesOrderID: [0]
min.SalesOrderID: [43659]
max.SalesOrderID: [75123]
null_count.RevisionNumber: [0]
min.RevisionNumber: [10]
...
```