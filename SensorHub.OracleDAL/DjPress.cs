using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SensorHub.IDAL;
using SensorHub.Model;
using System.Data.OracleClient;
using System.Data;

namespace SensorHub.OracleDAL
{
    public class DjPress:IDjPress
    {
        // Static constants
        private const string TABLE_NAME = "AD_DJ_PRESS";

        private const string COLUMN_DBID = "DBID";
        private const string COLUMN_DEVID = "DEVID";
        private const string COLUMN_PRESSDATA = "PRESSDATA";
        private const string COLUMN_PRESSPOWER = "PRESSPOWER";
        private const string COLUMN_SENSORPOWER = "SENSORPOWER";
        private const string COLUMN_DATATIEM = "DATATIME";
        private const string COLUMN_RECORDTIME = "RECORDTIME";

        private const string PARM_DBID = ":DBID";
        private const string PARM_DEVID = ":DEVID";
        private const string PARM_PRESSDATA = ":PRESSDATA";
        private const string PARM_PRESSPOWER = ":PRESSPOWER";
        private const string PARM_SENSORPOWER = ":SENSORPOWER";
        private const string PARM_DATATIME = ":DATATIME";
        private const string PARM_RECORDTIME = ":RECORDTIME";

        private const string SQL_INSERT_DJPRESS = "INSERT INTO " + TABLE_NAME
                        + "(" + COLUMN_DBID + ","
                        + " " + COLUMN_DEVID + ","
                        + " " + COLUMN_PRESSDATA + ","
                        + " " + COLUMN_PRESSPOWER + ","
                        + " " + COLUMN_SENSORPOWER + ","
                        + " " + COLUMN_DATATIEM + ","
                        + " " + COLUMN_RECORDTIME + ")"
                        + " VALUES "
                        + "(" + PARM_DBID + ","
                        + " " + PARM_DEVID + ","
                        + " " + PARM_PRESSDATA + ","
                        + " " + PARM_PRESSPOWER + ","
                        + " " + PARM_SENSORPOWER + ","
                        + " " + PARM_DATATIME + ","
                        + " " + PARM_RECORDTIME + ")";

        public void insert(DjPressInfo press)
        {
            OracleParameter[] parms = GetAdapterParameters();

            SetAdapterParameters(parms, press);

            try
            {
                OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionStringOrderDistributedTransaction, CommandType.Text, SQL_INSERT_DJPRESS, parms);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        /// <summary>
        /// An internal function to bind values parameters for insert
        /// </summary>
        /// <param name="parms">Database parameters</param>
        /// <param name="press">Values to bind to parameters</param>
        private void SetAdapterParameters(OracleParameter[] parms, DjPressInfo press)
        {
            parms[0].Value = press.DBID;
            parms[1].Value = press.DEVID;
            if (null != press.PRESSDATA)
            {
                parms[2].Value = press.PRESSDATA;
            }
            else
            {
                parms[2].Value = DBNull.Value;
            }
            if (null != press.PRESSPOWER)
            {
                parms[3].Value = press.PRESSPOWER;
            }
            else
            {
                parms[3].Value = DBNull.Value;
            }
            if (null != press.DATATIME)
            {
                parms[4].Value = press.DATATIME;
            }
            else
            {
                parms[4].Value = DBNull.Value;
            }
            if (null != press.RECORDTIME)
            {
                parms[5].Value = press.RECORDTIME;
            }
            else
            {
                parms[5].Value = DBNull.Value;
            }
        }

        /// <summary>
        /// An internal function to get the database parameters
        /// </summary>
        /// <returns>Parameter array</returns>
        private static OracleParameter[] GetAdapterParameters()
        {

            OracleParameter[] parms = OracleHelperParameterCache.GetCachedParameterSet(SQL_INSERT_DJPRESS, "INSERT:UPDATE");

            if (parms == null)
            {
                parms = new OracleParameter[]{					                            
                                        new OracleParameter(PARM_DBID, OracleType.Number,19),
                                        new OracleParameter(PARM_DEVID, OracleType.Number, 19),
                                        new OracleParameter(PARM_PRESSDATA, OracleType.NVarChar, 255),
                                        new OracleParameter(PARM_PRESSPOWER, OracleType.NVarChar, 255),
                                         new OracleParameter(PARM_SENSORPOWER, OracleType.NVarChar, 255),
                                        new OracleParameter(PARM_DATATIME, OracleType.DateTime),
                                        new OracleParameter(PARM_RECORDTIME, OracleType.DateTime)                                        
                };

                OracleHelperParameterCache.CacheParameterSet(SQL_INSERT_DJPRESS, "INSERT:UPDATE", parms);
            }

            return parms;
        }
    }
}
