﻿namespace King.BTrak.Models
{
    #region IConfigValues
    /// <summary>
    /// Configuration Values
    /// </summary>
    public interface IConfigValues
    {
        #region Properties
        /// <summary>
        /// SQL Conenction String
        /// </summary>
        string SqlConnection
        {
            get;
        }

        /// <summary>
        /// Storage Account Connection String
        /// </summary>
        string StorageAccountConnection
        {
            get;
        }

        /// <summary>
        /// Storage Table Name
        /// </summary>
        string StorageTableName
        {
            get;
        }

        /// <summary>
        /// Storage Table Name
        /// </summary>
        string SqlTableName
        {
            get;
        }

        /// <summary>
        /// Sync Direction
        /// </summary>
        Direction Direction
        {
            get;
        }
        #endregion
    }
    #endregion
}