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
    public class DjNoise:IDjNoise
    {
                // Static constants
        private const string TABLE_NAME = "AD_DJ_NOISE";

        private const string COLUMN_DBID = "DBID";
        private const string COLUMN_DEVID = "DEVID";
        private const string COLUMN_LOOSEDATA = "LOOSEDATA";
        private const string COLUMN_DENSEDATA = "DENSEDATA";
        private const string COLUMN_DATATIME = "DATATIME";
        private const string COLUMN_RECORDTIME = "RECORDTIME";

        private const string PARM_DBID = ":DBID";
        private const string PARM_DEVID = ":DEVID";
        private const string PARM_LOOSEDATA = ":LOOSEDATA";
        private const string PARM_DENSEDATA = ":DENSEDATA";
        private const string PARM_DATATIME = ":DATATIME";
        private const string PARM_RECORDTIME = ":RECORDTIME";

        private const string SQL_INSERT_DJNOISE = "INSERT INTO " + TABLE_NAME
                        + "(" + COLUMN_DBID + ","
                        + " " + COLUMN_DEVID + ","
                        + " " + COLUMN_LOOSEDATA + ","
                        + " " + COLUMN_DENSEDATA + ","
                        + " " + COLUMN_DATATIME + ","
                        + " " + COLUMN_RECORDTIME + ")"
                        + " VALUES "
                        + "(" + PARM_DBID + ","
                        + " " + PARM_DEVID + ","
                        + " " + PARM_LOOSEDATA + ","
                        + " " + PARM_DENSEDATA + ","
                        + " " + PARM_DATATIME + ","
                        + " " + PARM_RECORDTIME + ")";

        public void insert(DjNoiseInfo noise)
        {
            OracleParameter[] parms = GetAdapterParameters();

            SetAdapterParameters(parms, noise);

            try
            {
                OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionStringOrderDistributedTransaction, CommandType.Text, SQL_INSERT_DJNOISE, parms);
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
        /// <param name="noise">Values to bind to parameters</param>
        private void SetAdapterParameters(OracleParameter[] parms, DjNoiseInfo noise)
        {
            parms[0].Value = noise.DBID;
            parms[1].Value = noise.DEVID;
            if (null != noise.LOOSEDATA)
            {
                parms[2].Value = noise.LOOSEDATA;
            }
            else
            {
                parms[2].Value = DBNull.Value;
            }
            if (null != noise.DENSEDATA)
            {
                parms[3].Value = noise.DENSEDATA;
            }
            else
            {
                parms[3].Value = DBNull.Value;
            }
            if (null != noise.DATATIME)
            {
                parms[4].Value = noise.DATATIME;
            }
            else
            {
                parms[4].Value = DBNull.Value;
            }
            if (null != noise.RECORDTIME)
            {
                parms[5].Value = noise.RECORDTIME;
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

            OracleParameter[] parms = OracleHelperParameterCache.GetCachedParameterSet(SQL_INSERT_DJNOISE, "INSERT:UPDATE");

            if (parms == null)
            {
                parms = new OracleParameter[]{					                            
                                        new OracleParameter(PARM_DBID, OracleType.Number,19),
                                        new OracleParameter(PARM_DEVID, OracleType.Number, 19),
                                        new OracleParameter(PARM_LOOSEDATA, OracleType.NVarChar, 255),
                                        new OracleParameter(PARM_DENSEDATA, OracleType.NVarChar, 255),
                                        new OracleParameter(PARM_DATATIME, OracleType.NVarChar,255),
                                        new OracleParameter(PARM_RECORDTIME, OracleType.NVarChar,255)
                };

                OracleHelperParameterCache.CacheParameterSet(SQL_INSERT_DJNOISE, "INSERT:UPDATE", parms);
            }

            return parms;
        }
    }
}
