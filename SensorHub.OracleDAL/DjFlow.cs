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
    public class DjFlow:IDjFlow
    {
        // Static constants
        private const string TABLE_NAME = "AD_DJ_FLOW";

        private const string COLUMN_DBID = "DBID";
        private const string COLUMN_DEVID = "DEVID";
        private const string COLUMN_INSDATA = "INSDATA";
        private const string COLUMN_NETDATA = "NETDATA";
        private const string COLUMN_POSDATA = "POSDATA";
        private const string COLUMN_NEGDATA = "NEGDATA";
        private const string COLUMN_FLOWPOWER = "FLOWPOWER";
        private const string COLUMN_SENSORPOWER = "SENSORPOWER";
        private const string COLUMN_DATATIEM = "DATATIME";
        private const string COLUMN_RECORDTIME = "RECORDTIME";

        private const string PARM_DBID = ":DBID";
        private const string PARM_DEVID = ":DEVID";
        private const string PARM_INSDATA = ":INSDATA";
        private const string PARM_NETDATA = ":NETDATA";
        private const string PARM_POSDATA = ":POSDATA";
        private const string PARM_NEGDATA = ":NEGDATA";
        private const string PARM_FLOWPOWER = ":FLOWPOWER";
        private const string PARM_SENSORPOWER = ":SENSORPOWER";
        private const string PARM_DATATIME = ":DATATIME";
        private const string PARM_RECORDTIME = ":RECORDTIME";

        private const string SQL_INSERT_DJFLOW = "INSERT INTO " + TABLE_NAME
                        + "(" + COLUMN_DBID + ","
                        + " " + COLUMN_DEVID + ","
                        + " " + COLUMN_INSDATA + ","
                        + " " + COLUMN_NETDATA + ","
                        + " " + COLUMN_POSDATA + ","
                        + " " + COLUMN_NEGDATA + ","
                        + " " + COLUMN_FLOWPOWER + ","
                        + " " + COLUMN_SENSORPOWER + ","
                        + " " + COLUMN_DATATIEM + ","
                        + " " + COLUMN_RECORDTIME + ")"
                        + " VALUES "
                        + "(" + PARM_DBID + ","
                        + " " + PARM_DEVID + ","
                        + " " + PARM_INSDATA + ","
                        + " " + PARM_NETDATA + ","
                        + " " + PARM_POSDATA + ","
                        + " " + PARM_NEGDATA + ","
                        + " " + PARM_FLOWPOWER + ","
                        + " " + PARM_SENSORPOWER + ","
                        + " " + PARM_DATATIME + ","
                        + " " + PARM_RECORDTIME + ")";

        public void insert(DjFlowInfo flow)
        {
            OracleParameter[] parms = GetAdapterParameters();

            SetAdapterParameters(parms, flow);

            try
            {
                OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionStringOrderDistributedTransaction, CommandType.Text, SQL_INSERT_DJFLOW, parms);
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
        /// <param name="flow">Values to bind to parameters</param>
        private void SetAdapterParameters(OracleParameter[] parms, DjFlowInfo flow)
        {
            parms[0].Value = flow.DBID;
            parms[1].Value = flow.DEVID;
            if (null != flow.INSDATA)
            {
                parms[2].Value = flow.INSDATA;
            }
            else
            {
                parms[2].Value = DBNull.Value;
            }
            if (null != flow.NETDATA)
            {
                parms[3].Value = flow.NETDATA;
            }
            else
            {
                parms[3].Value = DBNull.Value;
            }
            if (null != flow.POSDATA)
            {
                parms[4].Value = flow.POSDATA;
            }
            else
            {
                parms[4].Value = DBNull.Value;
            }
            if (null != flow.NEGDATA)
            {
                parms[5].Value = flow.NEGDATA;
            }
            else
            {
                parms[5].Value = DBNull.Value;
            }
            if (null != flow.FLOWPOWER)
            {
                parms[6].Value = flow.FLOWPOWER;
            }
            else
            {
                parms[6].Value = DBNull.Value;
            }
            if (null != flow.SENSORPOWER)
            {
                parms[7].Value = flow.SENSORPOWER;
            }
            else
            {
                parms[7].Value = DBNull.Value;
            }
            if (null != flow.DATATIME)
            {
                parms[8].Value = flow.DATATIME;
            }
            else
            {
                parms[8].Value = DBNull.Value;
            }
            if (null != flow.RECORDTIME)
            {
                parms[9].Value = flow.RECORDTIME;
            }
            else
            {
                parms[9].Value = DBNull.Value;
            }
        }

        /// <summary>
        /// An internal function to get the database parameters
        /// </summary>
        /// <returns>Parameter array</returns>
        private static OracleParameter[] GetAdapterParameters()
        {

            OracleParameter[] parms = OracleHelperParameterCache.GetCachedParameterSet(SQL_INSERT_DJFLOW, "INSERT:UPDATE");

            if (parms == null)
            {
                parms = new OracleParameter[]{					                            
                                        new OracleParameter(PARM_DBID, OracleType.Number,19),
                                        new OracleParameter(PARM_DEVID, OracleType.NVarChar, 19),
                                        new OracleParameter(PARM_INSDATA, OracleType.NVarChar, 255),
                                        new OracleParameter(PARM_NETDATA, OracleType.NVarChar, 255),
                                        new OracleParameter(PARM_POSDATA, OracleType.NVarChar,255),
                                        new OracleParameter(PARM_NEGDATA, OracleType.NVarChar,255),
                                        new OracleParameter(PARM_FLOWPOWER, OracleType.NVarChar, 255),
                                         new OracleParameter(PARM_SENSORPOWER, OracleType.NVarChar, 255),
                                        new OracleParameter(PARM_DATATIME, OracleType.DateTime),
                                        new OracleParameter(PARM_RECORDTIME, OracleType.DateTime)                                        
                };

                OracleHelperParameterCache.CacheParameterSet(SQL_INSERT_DJFLOW, "INSERT:UPDATE", parms);
            }

            return parms;
        }
    }
}
