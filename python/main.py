import pyarrow.parquet as pq
import deltalake

# meta = pq.read_metadata("./data/sales_salesorderheader.parquet")
# df = pq.read_table("./data/sales_salesorderheader.parquet")

# print(meta.row_group(0))


def read_schema():
    dt = deltalake.DeltaTable("data/deltalake/sales_salesorderheader.delta")
    schema = dt.schema()
    return schema
