﻿namespace King.BTrak
{
    using King.Azure.Data;
    using King.BTrak.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Table Storage Writer
    /// </summary>
    public class TableStorageWriter
    {
        #region Members
        /// <summary>
        /// Table Storage
        /// </summary>
        protected readonly ITableStorage table = null;
        #endregion

        #region Constructors
        public TableStorageWriter(ITableStorage table)
        {
            this.table = table;
        }
        #endregion

        #region Methods
        public virtual async Task Store(IList<TableData> tables)
        {
            foreach (var table in tables)
            {
                foreach (var entity in table.Data)
                {
                    entity.Add(TableStorage.PartitionKey, table.Name);
                    var rowKey = entity[table.PrimaryKey] ?? Guid.NewGuid();
                    entity.Add(TableStorage.RowKey, rowKey);
                    await this.table.InsertOrReplace(entity);
                }
            }
        }
        #endregion
    }
}