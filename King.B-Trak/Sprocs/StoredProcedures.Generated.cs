// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.2.6
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace King.Mapper.Generated.Sql
{
    using System;
    using System.Data;
    using King.Mapper.Data;

    /// <summary>
    /// Class that Represents dbo.SaveTableData Stored Procedure
    /// </summary>
	public partial class dboSaveTableData : IStoredProcedure
	{
        /// <summary>
        /// Gets Stored Proc name with Schema
        /// </summary>
		public virtual string FullyQualifiedName()
		{
			return "[dbo].[SaveTableData]";
		}

		#region Parameters
        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@Id", DbType.Guid)]
		public virtual Guid? Id
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TableName", DbType.String)]
		public virtual string TableName
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@PartitionKey", DbType.String)]
		public virtual string PartitionKey
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@RowKey", DbType.String)]
		public virtual string RowKey
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@ETag", DbType.String)]
		public virtual string ETag
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@Timestamp", DbType.DateTime)]
		public virtual DateTime? Timestamp
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@Data", DbType.Object)]
		public virtual object Data
		{
			get;
			set;
		}

		#endregion
	}

}