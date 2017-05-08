using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

using System.Drawing;
using System.Data;
using System.IO;

using FirebirdSql.Data.FirebirdClient;

namespace NMS
{
    public class clsDBMS
    {
        protected FbConnection fbDBConn = null;
        protected FbConnectionStringBuilder fb = new FbConnectionStringBuilder();

        public clsDBMS()
        {
        }

        ~clsDBMS()
        {
            Dispose();
        }
        
        public void Dispose()
        {
            if (fbDBConn.State == System.Data.ConnectionState.Open)
            {
                fbDBConn.Close();
            }
        }

        public void DBConnect(string fileName)
        {
            try
            {
                //fb.UserID = "KTC";
                //fb.Password = "KTC2233";
                string LOGIN_PATH = Directory.GetCurrentDirectory() + "\\db_login.txt";

                GetLoginData(LOGIN_PATH);

                //fb.UserID = "sysdba";
                //fb.Password = "masterkey";



                fb.Database = fileName;

                fbDBConn = new FbConnection(fb.ToString());
            }
            catch
            {
            }
        }

        private void GetLoginData(string path)
        {
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);

                fb.UserID = lines[0];
                fb.Password = lines[1];
            }
            else
            {
                fb.UserID = "sysdba";
                fb.Password = "masterkey";

            }

        }
    }

    public class nmsDBMS : clsDBMS
    {
        public nmsDBMS()
        {
        }

        #region NMS DataBase 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// Mu Data를 저장한다.
        /// </summary>
        public bool MuInsert(MuInfo tmpMuInfo, FmData tmpFmInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into Mu_Table ( muID, AutoManual, MainStby, WideNarrow, AC, DC, TrxUnit, " +
                                                "cce1Ptt, cce2Ptt, rc1Ptt, rc2Ptt, rc3Ptt, " +
                                                "mainPtt, mainBusy, stbyPtt, stbyBusy, MonBusy, " +
                                                "dcValue, mainRf, mainRssi, stbyRf, stbyRssi, monRssi, mainRfSet, stbyRfSet, " +
                                                "mainCh, stbyCh, monCh, mainComm, stbyComm, monComm, " +
                                                "muTrxCpu, muOptCpu, muUps, chReturn, " +
                                                "mainPllLock, stbyPllLock, monPllLock, " +
                                                "optDc, optModOpen, optCcePtt, optDcValue, " +
                                                "opt1Ld, opt2Ld, opt3Ld, opt4Ld, opt1Pd, opt2Pd, opt3Pd, opt4Pd, dateTime, fm_Power, fm_Rf ) " + 
                                       "values ( @muID, @AutoManual, @MainStby, @WideNarrow, @AC, @DC, @TrxUnit, " +
                                                "@cce1Ptt, @cce2Ptt, @rc1Ptt, @rc2Ptt, @rc3Ptt, " +
                                                "@mainPtt, @mainBusy, @stbyPtt, @stbyBusy, @MonBusy, " +
                                                "@dcValue, @mainRf, @mainRssi, @stbyRf, @stbyRssi, @monRssi, @mainRfSet, @stbyRfSet, " +
                                                "@mainCh, @stbyCh, @monCh, @mainComm, @stbyComm, @monComm, " +
                                                "@muTrxCpu, @muOptCpu, @muUps, @chReturn, " +
                                                "@mainPllLock, @stbyPllLock, @monPllLock, " +
                                                "@optDc, @optModOpen, @optCcePtt, @optDcValue, " +
                                                "@opt1Ld, @opt2Ld, @opt3Ld, @opt4Ld, @opt1Pd, @opt2Pd, @opt3Pd, @opt4Pd, @dateTime, @fm_Power, @fm_Rf )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@muID", FbDbType.Text).Value = tmpMuInfo.mu_id;
                fbCMD_Insert.Parameters.Add("@AutoManual", FbDbType.Text).Value = tmpMuInfo.autoManual;
                fbCMD_Insert.Parameters.Add("@MainStby", FbDbType.Text).Value = tmpMuInfo.mainStby;
                fbCMD_Insert.Parameters.Add("@WideNarrow", FbDbType.Text).Value = tmpMuInfo.wideNarrow;
                fbCMD_Insert.Parameters.Add("@AC", FbDbType.Text).Value = tmpMuInfo.ac;
                fbCMD_Insert.Parameters.Add("@DC", FbDbType.Text).Value = tmpMuInfo.dc;
                fbCMD_Insert.Parameters.Add("@TrxUnit", FbDbType.Text).Value = tmpMuInfo.trxUnit;
                fbCMD_Insert.Parameters.Add("@cce1Ptt", FbDbType.Text).Value = tmpMuInfo.cce1Ptt;
                fbCMD_Insert.Parameters.Add("@cce2Ptt", FbDbType.Text).Value = tmpMuInfo.cce2Ptt;
                fbCMD_Insert.Parameters.Add("@rc1Ptt", FbDbType.Text).Value = tmpMuInfo.rc1Ptt;
                fbCMD_Insert.Parameters.Add("@rc2Ptt", FbDbType.Text).Value = tmpMuInfo.rc2Ptt;
                fbCMD_Insert.Parameters.Add("@rc3Ptt", FbDbType.Text).Value = tmpMuInfo.rc3Ptt;
                fbCMD_Insert.Parameters.Add("@mainPtt", FbDbType.Text).Value = tmpMuInfo.mainPtt;
                fbCMD_Insert.Parameters.Add("@mainBusy", FbDbType.Text).Value = tmpMuInfo.mainBusy;
                fbCMD_Insert.Parameters.Add("@stbyPtt", FbDbType.Text).Value = tmpMuInfo.stbyPtt;
                fbCMD_Insert.Parameters.Add("@stbyBusy", FbDbType.Text).Value = tmpMuInfo.stbyBusy;
                fbCMD_Insert.Parameters.Add("@MonBusy", FbDbType.Text).Value = tmpMuInfo.monBusy;
                fbCMD_Insert.Parameters.Add("@dcValue", FbDbType.Text).Value = tmpMuInfo.dcValue;
                fbCMD_Insert.Parameters.Add("@mainRf", FbDbType.Text).Value = tmpMuInfo.mainRf;
                fbCMD_Insert.Parameters.Add("@mainRssi", FbDbType.Text).Value = tmpMuInfo.mainRssi;
                fbCMD_Insert.Parameters.Add("@stbyRf", FbDbType.Text).Value = tmpMuInfo.stbyRf;
                fbCMD_Insert.Parameters.Add("@stbyRssi", FbDbType.Text).Value = tmpMuInfo.stbyRssi;
                fbCMD_Insert.Parameters.Add("@monRssi", FbDbType.Text).Value = tmpMuInfo.monRssi;
                fbCMD_Insert.Parameters.Add("@mainRfSet", FbDbType.Text).Value = tmpMuInfo.mainRfSet;
                fbCMD_Insert.Parameters.Add("@stbyRfSet", FbDbType.Text).Value = tmpMuInfo.stbyRfSet;
                fbCMD_Insert.Parameters.Add("@mainCh", FbDbType.Text).Value = tmpMuInfo.mainCh;
                fbCMD_Insert.Parameters.Add("@stbyCh", FbDbType.Text).Value = tmpMuInfo.stbyCh;
                fbCMD_Insert.Parameters.Add("@monCh", FbDbType.Text).Value = tmpMuInfo.monCh;
                fbCMD_Insert.Parameters.Add("@mainComm", FbDbType.Text).Value = tmpMuInfo.mainComm;
                fbCMD_Insert.Parameters.Add("@stbyComm", FbDbType.Text).Value = tmpMuInfo.stbyComm;
                fbCMD_Insert.Parameters.Add("@monComm", FbDbType.Text).Value = tmpMuInfo.monComm;
                fbCMD_Insert.Parameters.Add("@muTrxCpu", FbDbType.Text).Value = tmpMuInfo.muTrxCpu;
                fbCMD_Insert.Parameters.Add("@muOptCpu", FbDbType.Text).Value = tmpMuInfo.muOptCpu;
                fbCMD_Insert.Parameters.Add("@muUps", FbDbType.Text).Value = tmpMuInfo.MuUps;
                fbCMD_Insert.Parameters.Add("@chReturn", FbDbType.Text).Value = tmpMuInfo.chReturn;
                fbCMD_Insert.Parameters.Add("@mainPllLock", FbDbType.Text).Value = tmpMuInfo.mainPllLock;
                fbCMD_Insert.Parameters.Add("@stbyPllLock", FbDbType.Text).Value = tmpMuInfo.stbyPllLock;
                fbCMD_Insert.Parameters.Add("@monPllLock", FbDbType.Text).Value = tmpMuInfo.monPllLock;
                fbCMD_Insert.Parameters.Add("@optDc", FbDbType.Text).Value = tmpMuInfo.optDc;
                fbCMD_Insert.Parameters.Add("@optModOpen", FbDbType.Text).Value = tmpMuInfo.optModOpen;
                fbCMD_Insert.Parameters.Add("@optCcePtt", FbDbType.Text).Value = tmpMuInfo.optCcePtt;
                fbCMD_Insert.Parameters.Add("@optDcValue", FbDbType.Text).Value = tmpMuInfo.optDcValue;
                fbCMD_Insert.Parameters.Add("@opt1Ld", FbDbType.Text).Value = tmpMuInfo.opt1Ld;
                fbCMD_Insert.Parameters.Add("@opt2Ld", FbDbType.Text).Value = tmpMuInfo.opt2Ld;
                fbCMD_Insert.Parameters.Add("@opt3Ld", FbDbType.Text).Value = tmpMuInfo.opt3Ld;
                fbCMD_Insert.Parameters.Add("@opt4Ld", FbDbType.Text).Value = tmpMuInfo.opt4Ld;
                fbCMD_Insert.Parameters.Add("@opt1Pd", FbDbType.Text).Value = tmpMuInfo.opt1Pd;
                fbCMD_Insert.Parameters.Add("@opt2Pd", FbDbType.Text).Value = tmpMuInfo.opt2Pd;
                fbCMD_Insert.Parameters.Add("@opt3Pd", FbDbType.Text).Value = tmpMuInfo.opt3Pd;
                fbCMD_Insert.Parameters.Add("@opt4Pd", FbDbType.Text).Value = tmpMuInfo.opt4Pd;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;
                fbCMD_Insert.Parameters.Add("@fm_Power", FbDbType.Text).Value = (char)clsCommon.HexaConvert(tmpFmInfo.otherSt[0]);
                fbCMD_Insert.Parameters.Add("@fm_Rf", FbDbType.Text).Value = (char)clsCommon.HexaConvert(tmpFmInfo.otherSt[1]);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace); 

                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// Mu Data를 모두 삭제한다.
        /// </summary>
        public bool MuDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from Mu_Table";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// UPS Data를 저장한다.
        /// </summary>
        public bool UpsInsert(UpsInfo tmpUpsInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into UPS_Table ( muID, inputVoltage, faultVoltage, outVoltage, batteryVoltage, currentPercent, frequency, temperature, " +
                                                 "upsFailed, batteryLow, bypass, utilityFail, dateTime ) " +
                                        "values ( @muID, @inputVoltage, @faultVoltage, @outVoltage, @batteryVoltage, @currentPercent, @frequency, @temperature, " +
                                                 "@upsFailed, @batteryLow, @bypass, @utilityFail, @dateTime )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@muID", FbDbType.Text).Value = tmpUpsInfo.mu_id;
                fbCMD_Insert.Parameters.Add("@inputVoltage", FbDbType.Text).Value = tmpUpsInfo.inputVoltage;
                fbCMD_Insert.Parameters.Add("@faultVoltage", FbDbType.Text).Value = tmpUpsInfo.faultVoltage;
                fbCMD_Insert.Parameters.Add("@outVoltage", FbDbType.Text).Value = tmpUpsInfo.outVoltage;
                fbCMD_Insert.Parameters.Add("@batteryVoltage", FbDbType.Text).Value = tmpUpsInfo.batteryVoltage;
                fbCMD_Insert.Parameters.Add("@currentPercent", FbDbType.Text).Value = tmpUpsInfo.currentPercent;
                fbCMD_Insert.Parameters.Add("@frequency", FbDbType.Text).Value = tmpUpsInfo.frequency;
                fbCMD_Insert.Parameters.Add("@temperature", FbDbType.Text).Value = tmpUpsInfo.temperature;
                fbCMD_Insert.Parameters.Add("@upsFailed", FbDbType.Text).Value = tmpUpsInfo.upsFailed;
                fbCMD_Insert.Parameters.Add("@batteryLow", FbDbType.Text).Value = tmpUpsInfo.batteryLow;
                fbCMD_Insert.Parameters.Add("@bypass", FbDbType.Text).Value = tmpUpsInfo.bypass;
                fbCMD_Insert.Parameters.Add("@utilityFail", FbDbType.Text).Value = tmpUpsInfo.utilityFail;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// UPS Data를 모두 삭제한다.
        /// </summary>
        public bool UpsDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from Ups_Table";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// RU Data를 저장한다.
        /// </summary>
        public bool RuInsert(RuInfo tmpRuInfo, FmData tmpFmInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into RU_Table ( muID, ruID, autoManual, mainStby, wideNarrow, ac, dc, " +
                                                "modOpen, ptt, localRemote, ruCpu, data, optLd, optPd, " +
                                                "xmtrPllLock, rcvrPllLock, dcValue, rf, rfSet, rssi, dateTime, fm_Power, fm_Rf ) " +
                                       "values ( @muID, @ruID, @autoManual, @mainStby, @wideNarrow, @ac, @dc, " +
                                                "@modOpen, @ptt, @localRemote, @ruCpu, @data, @optLd, @optPd, " +
                                                "@xmtrPllLock, @rcvrPllLock, @dcValue, @rf, @rfSet, @rssi, @dateTime, @fm_Power, @fm_Rf )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@muID", FbDbType.Text).Value = tmpRuInfo.mu_id;
                fbCMD_Insert.Parameters.Add("@ruID", FbDbType.Text).Value = tmpRuInfo.ru_id;
                fbCMD_Insert.Parameters.Add("@autoManual", FbDbType.Text).Value = tmpRuInfo.autoManual;
                fbCMD_Insert.Parameters.Add("@mainStby", FbDbType.Text).Value = tmpRuInfo.mainStby;
                fbCMD_Insert.Parameters.Add("@wideNarrow", FbDbType.Text).Value = tmpRuInfo.wideNarrow;
                fbCMD_Insert.Parameters.Add("@ac", FbDbType.Text).Value = tmpRuInfo.ac;
                fbCMD_Insert.Parameters.Add("@dc", FbDbType.Text).Value = tmpRuInfo.dc;
                fbCMD_Insert.Parameters.Add("@modOpen", FbDbType.Text).Value = tmpRuInfo.modOpen;
                fbCMD_Insert.Parameters.Add("@ptt", FbDbType.Text).Value = tmpRuInfo.ptt;
                fbCMD_Insert.Parameters.Add("@localRemote", FbDbType.Text).Value = tmpRuInfo.localRemote;
                fbCMD_Insert.Parameters.Add("@ruCpu", FbDbType.Text).Value = tmpRuInfo.ruCpu;
                fbCMD_Insert.Parameters.Add("@data", FbDbType.Text).Value = tmpRuInfo.data;
                fbCMD_Insert.Parameters.Add("@optLd", FbDbType.Text).Value = tmpRuInfo.optLd;
                fbCMD_Insert.Parameters.Add("@optPd", FbDbType.Text).Value = tmpRuInfo.optPd;
                fbCMD_Insert.Parameters.Add("@xmtrPllLock", FbDbType.Text).Value = tmpRuInfo.xmtrPllLock;
                fbCMD_Insert.Parameters.Add("@rcvrPllLock", FbDbType.Text).Value = tmpRuInfo.rcvrpllLock;
                fbCMD_Insert.Parameters.Add("@dcValue", FbDbType.Text).Value = tmpRuInfo.dcValue;
                fbCMD_Insert.Parameters.Add("@rf", FbDbType.Text).Value = tmpRuInfo.rf;
                fbCMD_Insert.Parameters.Add("@rfSet", FbDbType.Text).Value = tmpRuInfo.rfSet;
                fbCMD_Insert.Parameters.Add("@rssi", FbDbType.Text).Value = tmpRuInfo.rssi;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;
                fbCMD_Insert.Parameters.Add("@fm_Power", FbDbType.Text).Value = (char)clsCommon.HexaConvert(tmpFmInfo.otherSt[0]);
                fbCMD_Insert.Parameters.Add("@fm_Rf", FbDbType.Text).Value = (char)clsCommon.HexaConvert(tmpFmInfo.otherSt[1]);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// Ru Data를 모두 삭제한다.
        /// </summary>
        public bool RuDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from Ru_Table";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// BDA Data를 저장한다.
        /// </summary>
        public bool BdaInsert(BdaInfo tmpBdaInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into BDA_Table ( muID, ruID, bdaID, dc12v, dc24v, ac220v, Comm, " +
                                                "fm, vhf, dmb, protection, trs, " +
                                                "bypass, ac, fail, battery, " +
                                                "fmvalue, vhfvalue, dmbvalue, protectionvalue, trsvalue, dateTime ) " +
                                       "values ( @muID, @ruID, @bdaID, @dc12v, @dc24v, @ac220v, @Comm, " +
                                                "@fm, @vhf, @dmb, @protection, @trs, " +
                                                "@bypass, @ac, @fail, @battery, " +
                                                "@fmvalue, @vhfvalue, @dmbvalue, @protectionvalue, @trsvalue, @dateTime )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@muID", FbDbType.Text).Value = tmpBdaInfo.mu_id;
                fbCMD_Insert.Parameters.Add("@ruID", FbDbType.Text).Value = tmpBdaInfo.ru_id;
                fbCMD_Insert.Parameters.Add("@bdaID", FbDbType.Text).Value = tmpBdaInfo.bda_id;
                fbCMD_Insert.Parameters.Add("@dc12v", FbDbType.Text).Value = tmpBdaInfo.power12;
                fbCMD_Insert.Parameters.Add("@dc24v", FbDbType.Text).Value = tmpBdaInfo.power24;
                fbCMD_Insert.Parameters.Add("@ac220v", FbDbType.Text).Value = tmpBdaInfo.power220;
                fbCMD_Insert.Parameters.Add("@Comm", FbDbType.Text).Value = tmpBdaInfo.comm;
                fbCMD_Insert.Parameters.Add("@fm", FbDbType.Text).Value = tmpBdaInfo.fm;
                fbCMD_Insert.Parameters.Add("@vhf", FbDbType.Text).Value = tmpBdaInfo.vhf;
                fbCMD_Insert.Parameters.Add("@dmb", FbDbType.Text).Value = tmpBdaInfo.dmb;
                fbCMD_Insert.Parameters.Add("@protection", FbDbType.Text).Value = tmpBdaInfo.protection;
                fbCMD_Insert.Parameters.Add("@trs", FbDbType.Text).Value = tmpBdaInfo.trs;
                fbCMD_Insert.Parameters.Add("@bypass", FbDbType.Text).Value = tmpBdaInfo.upsBypass;
                fbCMD_Insert.Parameters.Add("@ac", FbDbType.Text).Value = tmpBdaInfo.upsAC;
                fbCMD_Insert.Parameters.Add("@fail", FbDbType.Text).Value = tmpBdaInfo.upsFail;
                fbCMD_Insert.Parameters.Add("@battery", FbDbType.Text).Value = tmpBdaInfo.upsBattery;
                fbCMD_Insert.Parameters.Add("@fmvalue", FbDbType.Text).Value = tmpBdaInfo.fmValue;
                fbCMD_Insert.Parameters.Add("@vhfvalue", FbDbType.Text).Value = tmpBdaInfo.vhfValue;
                fbCMD_Insert.Parameters.Add("@dmbvalue", FbDbType.Text).Value = tmpBdaInfo.dmbValue;
                fbCMD_Insert.Parameters.Add("@protectionvalue", FbDbType.Text).Value = tmpBdaInfo.protectionValue;
                fbCMD_Insert.Parameters.Add("@trsvalue", FbDbType.Text).Value = tmpBdaInfo.trsValue;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// UPS Data를 모두 삭제한다.
        /// </summary>
        public bool BdaDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from Bda_Table";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// MU의 FM Data를 저장한다.
        /// </summary>
        public bool MuFmInsert(FM_Info tmpFmInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into MU_FM ( muID, acVoltage, acCurrent, dc12Voltage, dc12Current, dc5Voltage, dc5Current, " +
                                             "betteryVoltage, betteryChange, betteryDisChange, " +
                                             "acInputFail, lnaFail, dcOutputFail, overDisChange, ldAlarm, ldPower, pdAlarm, pdPower, " +
                                             "alc, alcDepth, mgc, rssi, tssi, onOff, deviceFail, temperature, dateTime ) " +
                                   "values ( @muID, @acVoltage, @acCurrent, @dc12Voltage, @dc12Current, @dc5Voltage, @dc5Current, " +
                                             "@betteryVoltage, @betteryChange, @betteryDisChange, " +
                                             "@acInputFail, @lnaFail, @dcOutputFail, @overDisChange, @ldAlarm, @ldPower, @pdAlarm, @pdPower, " +
                                             "@alc, @alcDepth, @mgc, @rssi, @tssi, @onOff, @deviceFail, @temperature, @dateTime )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@muID", FbDbType.Text).Value = tmpFmInfo.mu_id;
                fbCMD_Insert.Parameters.Add("@acVoltage", FbDbType.Text).Value = tmpFmInfo.acVoltage;
                fbCMD_Insert.Parameters.Add("@acCurrent", FbDbType.Text).Value = tmpFmInfo.acCurrent;
                fbCMD_Insert.Parameters.Add("@dc12Voltage", FbDbType.Text).Value = tmpFmInfo.dc12Voltage;
                fbCMD_Insert.Parameters.Add("@dc12Current", FbDbType.Text).Value = tmpFmInfo.dc12Current;
                fbCMD_Insert.Parameters.Add("@dc5Voltage", FbDbType.Text).Value = tmpFmInfo.dc5Voltage;
                fbCMD_Insert.Parameters.Add("@dc5Current", FbDbType.Text).Value = tmpFmInfo.dc5Current;
                fbCMD_Insert.Parameters.Add("@betteryVoltage", FbDbType.Text).Value = tmpFmInfo.betteryVoltage;
                fbCMD_Insert.Parameters.Add("@betteryChange", FbDbType.Text).Value = tmpFmInfo.betteryChangeCurrent;
                fbCMD_Insert.Parameters.Add("@betteryDisChange", FbDbType.Text).Value = tmpFmInfo.betteryDisChangeCurrent;
                fbCMD_Insert.Parameters.Add("@acInputFail", FbDbType.Text).Value = tmpFmInfo.acInputFail;
                fbCMD_Insert.Parameters.Add("@lnaFail", FbDbType.Text).Value = tmpFmInfo.lnaFail;
                fbCMD_Insert.Parameters.Add("@dcOutputFail", FbDbType.Text).Value = tmpFmInfo.dcOutputFail;
                fbCMD_Insert.Parameters.Add("@overDisChange", FbDbType.Text).Value = tmpFmInfo.overDisChange;
                fbCMD_Insert.Parameters.Add("@ldAlarm", FbDbType.Text).Value = tmpFmInfo.ldAlarm;
                fbCMD_Insert.Parameters.Add("@ldPower", FbDbType.Text).Value = tmpFmInfo.ldPower;
                fbCMD_Insert.Parameters.Add("@pdAlarm", FbDbType.Text).Value = tmpFmInfo.pdAlarm;
                fbCMD_Insert.Parameters.Add("@pdPower", FbDbType.Text).Value = tmpFmInfo.pdPower;
                fbCMD_Insert.Parameters.Add("@alc", FbDbType.Text).Value = tmpFmInfo.alc;
                fbCMD_Insert.Parameters.Add("@alcDepth", FbDbType.Text).Value = tmpFmInfo.alcDepth;
                fbCMD_Insert.Parameters.Add("@mgc", FbDbType.Text).Value = tmpFmInfo.mgc;
                fbCMD_Insert.Parameters.Add("@rssi", FbDbType.Text).Value = tmpFmInfo.rssi;
                fbCMD_Insert.Parameters.Add("@tssi", FbDbType.Text).Value = tmpFmInfo.tssi;
                fbCMD_Insert.Parameters.Add("@onOff", FbDbType.Text).Value = tmpFmInfo.onOff;
                fbCMD_Insert.Parameters.Add("@deviceFail", FbDbType.Text).Value = tmpFmInfo.deviceFail;
                fbCMD_Insert.Parameters.Add("@temperature", FbDbType.Text).Value = tmpFmInfo.temperature;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// MU의 FM Data를 모두 삭제한다.
        /// </summary>
        public bool MuFmDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from MU_FM";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// RU의 FM Data를 저장한다.
        /// </summary>
        public bool RuFmInsert(FM_Info tmpFmInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                if (tmpFmInfo.ru_id == 0)
                {
                    strSQL = "insert into RUA_FM ( muID, acVoltage, acCurrent, dc12Voltage, dc12Current, dc5Voltage, dc5Current, " +
                                                 "betteryVoltage, betteryChange, betteryDisChange, " +
                                                 "acInputFail, lnaFail, dcOutputFail, overDisChange, ldAlarm, ldPower, pdAlarm, pdPower, " +
                                                 "alc, alcDepth, mgc, rssi, tssi, onOff, deviceFail, temperature, dateTime ) " +
                                       "values ( @muID, @acVoltage, @acCurrent, @dc12Voltage, @dc12Current, @dc5Voltage, @dc5Current, " +
                                                 "@betteryVoltage, @betteryChange, @betteryDisChange, " +
                                                 "@acInputFail, @lnaFail, @dcOutputFail, @overDisChange, @ldAlarm, @ldPower, @pdAlarm, @pdPower, " +
                                                 "@alc, @alcDepth, @mgc, @rssi, @tssi, @onOff, @deviceFail, @temperature, @dateTime )";

                    FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                    fbCMD_Insert.Parameters.Add("@muID", FbDbType.Text).Value = tmpFmInfo.mu_id;
                    fbCMD_Insert.Parameters.Add("@acVoltage", FbDbType.Text).Value = tmpFmInfo.acVoltage;
                    fbCMD_Insert.Parameters.Add("@acCurrent", FbDbType.Text).Value = tmpFmInfo.acCurrent;
                    fbCMD_Insert.Parameters.Add("@dc12Voltage", FbDbType.Text).Value = tmpFmInfo.dc12Voltage;
                    fbCMD_Insert.Parameters.Add("@dc12Current", FbDbType.Text).Value = tmpFmInfo.dc12Current;
                    fbCMD_Insert.Parameters.Add("@dc5Voltage", FbDbType.Text).Value = tmpFmInfo.dc5Voltage;
                    fbCMD_Insert.Parameters.Add("@dc5Current", FbDbType.Text).Value = tmpFmInfo.dc5Current;
                    fbCMD_Insert.Parameters.Add("@betteryVoltage", FbDbType.Text).Value = tmpFmInfo.betteryVoltage;
                    fbCMD_Insert.Parameters.Add("@betteryChange", FbDbType.Text).Value = tmpFmInfo.betteryChangeCurrent;
                    fbCMD_Insert.Parameters.Add("@betteryDisChange", FbDbType.Text).Value = tmpFmInfo.betteryDisChangeCurrent;
                    fbCMD_Insert.Parameters.Add("@acInputFail", FbDbType.Text).Value = tmpFmInfo.acInputFail;
                    fbCMD_Insert.Parameters.Add("@lnaFail", FbDbType.Text).Value = tmpFmInfo.lnaFail;
                    fbCMD_Insert.Parameters.Add("@dcOutputFail", FbDbType.Text).Value = tmpFmInfo.dcOutputFail;
                    fbCMD_Insert.Parameters.Add("@overDisChange", FbDbType.Text).Value = tmpFmInfo.overDisChange;
                    fbCMD_Insert.Parameters.Add("@ldAlarm", FbDbType.Text).Value = tmpFmInfo.ldAlarm;
                    fbCMD_Insert.Parameters.Add("@ldPower", FbDbType.Text).Value = tmpFmInfo.ldPower;
                    fbCMD_Insert.Parameters.Add("@pdAlarm", FbDbType.Text).Value = tmpFmInfo.pdAlarm;
                    fbCMD_Insert.Parameters.Add("@pdPower", FbDbType.Text).Value = tmpFmInfo.pdPower;
                    fbCMD_Insert.Parameters.Add("@alc", FbDbType.Text).Value = tmpFmInfo.alc;
                    fbCMD_Insert.Parameters.Add("@alcDepth", FbDbType.Text).Value = tmpFmInfo.alcDepth;
                    fbCMD_Insert.Parameters.Add("@mgc", FbDbType.Text).Value = tmpFmInfo.mgc;
                    fbCMD_Insert.Parameters.Add("@rssi", FbDbType.Text).Value = tmpFmInfo.rssi;
                    fbCMD_Insert.Parameters.Add("@tssi", FbDbType.Text).Value = tmpFmInfo.tssi;
                    fbCMD_Insert.Parameters.Add("@onOff", FbDbType.Text).Value = tmpFmInfo.onOff;
                    fbCMD_Insert.Parameters.Add("@deviceFail", FbDbType.Text).Value = tmpFmInfo.deviceFail;
                    fbCMD_Insert.Parameters.Add("@temperature", FbDbType.Text).Value = tmpFmInfo.temperature;
                    fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;

                    fbCMD_Insert.ExecuteNonQuery();
                    fbCMD_Insert.Dispose();
                }
                else
                {
                    strSQL = "insert into RU_FM ( muID, ruID, acVoltage, acCurrent, betteryVoltage, betteryChange, " +
                                "acInputFail, dcOutputFail, ldAlarm, ldPower, pdAlarm, pdPower, " +
                                "rssi, tssiFwd, tssiRev, temperature, dateTime ) " +
                      "values ( @muID, @ruID, @acVoltage, @acCurrent, @betteryVoltage, @betteryChange, " +
                               "@acInputFail, @dcOutputFail, @ldAlarm, @ldPower, @pdAlarm, @pdPower, " +
                               "@rssi, @tssiFwd, @tssiRev, @temperature, @dateTime )";

                    FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                    fbCMD_Insert.Parameters.Add("@muID", FbDbType.Text).Value = tmpFmInfo.mu_id;
                    fbCMD_Insert.Parameters.Add("@ruID", FbDbType.Text).Value = tmpFmInfo.ru_id;
                    fbCMD_Insert.Parameters.Add("@acVoltage", FbDbType.Text).Value = tmpFmInfo.acVoltage;
                    fbCMD_Insert.Parameters.Add("@acCurrent", FbDbType.Text).Value = tmpFmInfo.acCurrent;
                    fbCMD_Insert.Parameters.Add("@betteryVoltage", FbDbType.Text).Value = tmpFmInfo.betteryVoltage;
                    fbCMD_Insert.Parameters.Add("@betteryChange", FbDbType.Text).Value = tmpFmInfo.betteryChangeCurrent;
                    fbCMD_Insert.Parameters.Add("@acInputFail", FbDbType.Text).Value = tmpFmInfo.acInputFail;
                    fbCMD_Insert.Parameters.Add("@dcOutputFail", FbDbType.Text).Value = tmpFmInfo.dcOutputFail;
                    fbCMD_Insert.Parameters.Add("@ldAlarm", FbDbType.Text).Value = tmpFmInfo.ldAlarm;
                    fbCMD_Insert.Parameters.Add("@ldPower", FbDbType.Text).Value = tmpFmInfo.ldPower;
                    fbCMD_Insert.Parameters.Add("@pdAlarm", FbDbType.Text).Value = tmpFmInfo.pdAlarm;
                    fbCMD_Insert.Parameters.Add("@pdPower", FbDbType.Text).Value = tmpFmInfo.pdPower;
                    fbCMD_Insert.Parameters.Add("@rssi", FbDbType.Text).Value = tmpFmInfo.rssi;
                    fbCMD_Insert.Parameters.Add("@tssiFwd", FbDbType.Text).Value = tmpFmInfo.tssiFwd;
                    fbCMD_Insert.Parameters.Add("@tssiRev", FbDbType.Text).Value = tmpFmInfo.tssiRev;
                    fbCMD_Insert.Parameters.Add("@temperature", FbDbType.Text).Value = tmpFmInfo.temperature;
                    fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;

                    fbCMD_Insert.ExecuteNonQuery();
                    fbCMD_Insert.Dispose();
                }
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// RU의 FM Data를 모두 삭제한다.
        /// </summary>
        public bool RuFmDelete(byte ruID)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                if (ruID == 0) strSQL = "delete from RUA_FM";
                else strSQL = "delete from RU_FM";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// 소스텔의 BDA Data를 저장한다.
        /// </summary>
        public bool sourcetelBdaInsert(BDA_St bdaInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into Sourcetel_BDA_Table ( muID, ruID, bdaID, fmTemperature, fmTssi, fmAlarm, " +
                                                           "vhfAmp, vhfAcAlarm, vhfDcAlarm, vhfBatteryAlarm, vhfPtt1, vhfPtt2, " +
                                                           "uhfAmp, uhfAcAlarm, uhfDcAlarm, uhfBatteryAlarm, uhfPtt1, uhfPtt2, dateTime ) " +
                                                  "values ( @muID, @ruID, @bdaID, @fmTemperature, @fmTssi, @fmAlarm, " +
                                                           "@vhfAmp, @vhfAcAlarm, @vhfDcAlarm, @vhfBatteryAlarm, @vhfPtt1, @vhfPtt2, " +
                                                           "@uhfAmp, @uhfAcAlarm, @uhfDcAlarm, @uhfBatteryAlarm, @uhfPtt1, @uhfPtt2, @dateTime )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@muID", FbDbType.Text).Value = bdaInfo.mu_id;
                fbCMD_Insert.Parameters.Add("@ruID", FbDbType.Text).Value = bdaInfo.ru_id;
                fbCMD_Insert.Parameters.Add("@bdaID", FbDbType.Text).Value = bdaInfo.bda_id;

                fbCMD_Insert.Parameters.Add("@fmTemperature", FbDbType.Text).Value = bdaInfo.fmTemperature;
                fbCMD_Insert.Parameters.Add("@fmTssi", FbDbType.Text).Value = bdaInfo.fmTssi ;
                fbCMD_Insert.Parameters.Add("@fmAlarm", FbDbType.Text).Value = bdaInfo.fmAlarm;

                fbCMD_Insert.Parameters.Add("@vhfAmp", FbDbType.Text).Value = bdaInfo.vhfBypass;
                fbCMD_Insert.Parameters.Add("@vhfAcAlarm", FbDbType.Text).Value = bdaInfo.vhfAcAlarm;
                fbCMD_Insert.Parameters.Add("@vhfDcAlarm", FbDbType.Text).Value = bdaInfo.vhfDcAlarm;
                fbCMD_Insert.Parameters.Add("@vhfBatteryAlarm", FbDbType.Text).Value = bdaInfo.vhfBatteryAlarm;
                fbCMD_Insert.Parameters.Add("@vhfPtt1", FbDbType.Text).Value = bdaInfo.vhfPtt1;
                fbCMD_Insert.Parameters.Add("@vhfPtt2", FbDbType.Text).Value = bdaInfo.vhfPtt2;

                fbCMD_Insert.Parameters.Add("@uhfAmp", FbDbType.Text).Value = bdaInfo.uhfBypass;
                fbCMD_Insert.Parameters.Add("@uhfAcAlarm", FbDbType.Text).Value = bdaInfo.uhfAcAlarm;
                fbCMD_Insert.Parameters.Add("@uhfDcAlarm", FbDbType.Text).Value = bdaInfo.uhfDcAlarm;
                fbCMD_Insert.Parameters.Add("@uhfBatteryAlarm", FbDbType.Text).Value = bdaInfo.uhfBatteryAlarm;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;
                fbCMD_Insert.Parameters.Add("@uhfPtt1", FbDbType.Text).Value = bdaInfo.uhfPtt1;
                fbCMD_Insert.Parameters.Add("@uhfPtt2", FbDbType.Text).Value = bdaInfo.uhfPtt2;

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// 소스텔의 BDA Data를 모두 삭제한다.
        /// </summary>
        public bool sourcetelBdaDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from Sourcetel_BDA_Table";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        public DataSet MuAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Mu_Table";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Mu_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList MuFind(DateTime startTime, DateTime stopTime, int muID)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Mu_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime and muID = @muID";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간
                fbCMD.Parameters.Add("@muID", FbDbType.SmallInt).Value = (short)(muID + 1);     //muID

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    MuInfo tmpMuInfo = new MuInfo();

                    tmpMuInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpMuInfo.mu_id = (short)(fbReader["muID"]);

                    tmpMuInfo.autoManual = Convert.ToChar(fbReader["AutoManual"]);
                    tmpMuInfo.mainStby = Convert.ToChar(fbReader["MainStby"]);
                    tmpMuInfo.wideNarrow = Convert.ToChar(fbReader["WideNarrow"]);
                    tmpMuInfo.ac = Convert.ToChar(fbReader["AC"]);
                    tmpMuInfo.dc = Convert.ToChar(fbReader["DC"]);
                    tmpMuInfo.trxUnit = Convert.ToChar(fbReader["TrxUnit"]);
                    tmpMuInfo.cce1Ptt = Convert.ToChar(fbReader["cce1Ptt"]);
                    tmpMuInfo.cce2Ptt = Convert.ToChar(fbReader["cce2Ptt"]);
                    tmpMuInfo.rc1Ptt = Convert.ToChar(fbReader["rc1Ptt"]);
                    tmpMuInfo.rc2Ptt = Convert.ToChar(fbReader["rc2Ptt"]);
                    tmpMuInfo.rc3Ptt = Convert.ToChar(fbReader["rc3Ptt"]);
                    tmpMuInfo.mainPtt = Convert.ToChar(fbReader["mainPtt"]);
                    tmpMuInfo.mainBusy = Convert.ToChar(fbReader["mainBusy"]);
                    tmpMuInfo.stbyPtt = Convert.ToChar(fbReader["stbyPtt"]);
                    tmpMuInfo.stbyBusy = Convert.ToChar(fbReader["stbyBusy"]);
                    tmpMuInfo.monBusy = Convert.ToChar(fbReader["monBusy"]);

                    tmpMuInfo.dcValue = (float)(Convert.ToDouble(fbReader["dcValue"]));
                    tmpMuInfo.mainRf = (float)(Convert.ToDouble(fbReader["mainRf"]));
                    tmpMuInfo.mainRssi = Convert.ToInt16(fbReader["mainRssi"]);
                    tmpMuInfo.stbyRf = (float)(Convert.ToDouble(fbReader["stbyRf"]));
                    tmpMuInfo.stbyRssi = Convert.ToInt16(fbReader["stbyRssi"]);
                    tmpMuInfo.monRssi = Convert.ToInt16(fbReader["monRssi"]);
                    tmpMuInfo.mainRfSet = Convert.ToInt16(fbReader["mainRfSet"]);
                    tmpMuInfo.stbyRfSet = Convert.ToInt16(fbReader["stbyRfSet"]);

                    tmpMuInfo.mainCh = Convert.ToChar(fbReader["mainCh"]);
                    tmpMuInfo.stbyCh = Convert.ToChar(fbReader["stbyCh"]);
                    tmpMuInfo.monCh = Convert.ToChar(fbReader["monCh"]);
                    tmpMuInfo.mainComm = Convert.ToChar(fbReader["mainComm"]);
                    tmpMuInfo.stbyComm = Convert.ToChar(fbReader["stbyComm"]);
                    tmpMuInfo.monComm = Convert.ToChar(fbReader["monComm"]);
                    tmpMuInfo.muTrxCpu = Convert.ToChar(fbReader["muTrxCpu"]);
                    tmpMuInfo.muOptCpu = Convert.ToChar(fbReader["muOptCpu"]);
                    tmpMuInfo.MuUps = Convert.ToChar(fbReader["muUps"]);

                    tmpMuInfo.chReturn = Convert.ToInt16(fbReader["chReturn"]);

                    tmpMuInfo.mainPllLock = Convert.ToChar(fbReader["mainPllLock"]);
                    tmpMuInfo.stbyPllLock = Convert.ToChar(fbReader["stbyPllLock"]);
                    tmpMuInfo.monPllLock = Convert.ToChar(fbReader["monPllLock"]);

                    tmpMuInfo.optDc = Convert.ToChar(fbReader["optDc"]);
                    tmpMuInfo.optModOpen = Convert.ToChar(fbReader["optModOpen"]);
                    tmpMuInfo.optCcePtt = Convert.ToChar(fbReader["optCcePtt"]);

                    tmpMuInfo.optDcValue = (float)(Convert.ToDouble(fbReader["optDcValue"]));

                    tmpMuInfo.opt1Ld = Convert.ToChar(fbReader["opt1Ld"]);
                    tmpMuInfo.opt2Ld = Convert.ToChar(fbReader["opt2Ld"]);
                    tmpMuInfo.opt3Ld = Convert.ToChar(fbReader["opt3Ld"]);
                    tmpMuInfo.opt4Ld = Convert.ToChar(fbReader["opt4Ld"]);
                    tmpMuInfo.opt1Pd = Convert.ToChar(fbReader["opt1Pd"]);
                    tmpMuInfo.opt2Pd = Convert.ToChar(fbReader["opt2Pd"]);
                    tmpMuInfo.opt3Pd = Convert.ToChar(fbReader["opt3Pd"]);
                    tmpMuInfo.opt4Pd = Convert.ToChar(fbReader["opt4Pd"]);

                    resultList.Add(tmpMuInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public DataSet UpsAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Ups_Table";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Ups_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList UpsFind(DateTime startTime, DateTime stopTime, int muID)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Ups_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime and muID = @muID";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간
                fbCMD.Parameters.Add("@muID", FbDbType.SmallInt).Value = (short)(muID + 1);     //muID

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    UpsInfo tmpUpsInfo = new UpsInfo();

                    tmpUpsInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpUpsInfo.mu_id = (short)(fbReader["muID"]);

                    tmpUpsInfo.inputVoltage = (float)(Convert.ToDouble(fbReader["inputVoltage"]));
                    tmpUpsInfo.faultVoltage = (float)(Convert.ToDouble(fbReader["faultVoltage"]));
                    tmpUpsInfo.outVoltage = (float)(Convert.ToDouble(fbReader["outVoltage"]));
                    tmpUpsInfo.batteryVoltage = (float)(Convert.ToDouble(fbReader["batteryVoltage"]));
                    tmpUpsInfo.currentPercent = (short)(fbReader["currentPercent"]);
                    tmpUpsInfo.frequency = (float)(Convert.ToDouble(fbReader["frequency"]));
                    tmpUpsInfo.temperature = (float)(Convert.ToDouble(fbReader["temperature"]));

                    tmpUpsInfo.upsFailed = Convert.ToChar(fbReader["upsFailed"]);
                    tmpUpsInfo.batteryLow = Convert.ToChar(fbReader["batteryLow"]);
                    tmpUpsInfo.bypass = Convert.ToChar(fbReader["bypass"]);
                    tmpUpsInfo.utilityFail = Convert.ToChar(fbReader["utilityFail"]);

                    resultList.Add(tmpUpsInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public DataSet RuAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Ru_Table";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Ru_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList RuFind(DateTime startTime, DateTime stopTime, int muID, int ruID)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Ru_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime and muID = @muID and ruID = @ruID";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간
                fbCMD.Parameters.Add("@muID", FbDbType.SmallInt).Value = (short)(muID + 1);     //muID
                fbCMD.Parameters.Add("@ruID", FbDbType.SmallInt).Value = (short)(ruID + 1);     //muID

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    RuInfo tmpRuInfo = new RuInfo();

                    tmpRuInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpRuInfo.mu_id = (short)(fbReader["muID"]);
                    tmpRuInfo.ru_id = (short)(fbReader["ruID"]);

                    tmpRuInfo.autoManual = Convert.ToChar(fbReader["AutoManual"]);
                    tmpRuInfo.mainStby = Convert.ToChar(fbReader["MainStby"]);
                    tmpRuInfo.wideNarrow = Convert.ToChar(fbReader["WideNarrow"]);
                    tmpRuInfo.ac = Convert.ToChar(fbReader["AC"]);
                    tmpRuInfo.dc = Convert.ToChar(fbReader["DC"]);

                    tmpRuInfo.modOpen = Convert.ToChar(fbReader["modOpen"]);
                    tmpRuInfo.ptt = Convert.ToChar(fbReader["ptt"]);
                    tmpRuInfo.localRemote = Convert.ToChar(fbReader["localRemote"]);
                    tmpRuInfo.ruCpu = Convert.ToChar(fbReader["ruCpu"]);
                    tmpRuInfo.data = Convert.ToChar(fbReader["data"]);
                    tmpRuInfo.optLd = Convert.ToChar(fbReader["optLd"]);
                    tmpRuInfo.optPd = Convert.ToChar(fbReader["optPd"]);
                    tmpRuInfo.xmtrPllLock = Convert.ToChar(fbReader["xmtrPllLock"]);
                    tmpRuInfo.rcvrpllLock = Convert.ToChar(fbReader["rcvrpllLock"]);
                    tmpRuInfo.dcValue = (float)(Convert.ToDouble(fbReader["dcValue"]));
                    tmpRuInfo.rf = (float)(Convert.ToDouble(fbReader["rf"]));
                    tmpRuInfo.rfSet = (short)(fbReader["rfSet"]);
                    tmpRuInfo.rssi = (short)(fbReader["rssi"]);
                    
                    resultList.Add(tmpRuInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public DataSet BdaAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from BDA_Table";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "BDA_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList BdaFind(DateTime startTime, DateTime stopTime, int muID, int ruID, int bdaID)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from BDA_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime and muID = @muID and ruID = @ruID and bdaID = @bdaID";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간
                fbCMD.Parameters.Add("@muID", FbDbType.SmallInt).Value = (short)(muID + 1);     //muID
                fbCMD.Parameters.Add("@ruID", FbDbType.SmallInt).Value = (short)(ruID + 1);     //ruID
                fbCMD.Parameters.Add("@bdaID", FbDbType.SmallInt).Value = (short)(bdaID + 1);   //bdaID

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    BdaInfo tmpBdaInfo = new BdaInfo();

                    tmpBdaInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpBdaInfo.mu_id = (short)(fbReader["muID"]);
                    tmpBdaInfo.ru_id = (short)(fbReader["ruID"]);
                    tmpBdaInfo.bda_id = (short)(fbReader["bdaID"]);

                    tmpBdaInfo.power12 = Convert.ToChar(fbReader["DC12V"]);
                    tmpBdaInfo.power24 = Convert.ToChar(fbReader["Dc24V"]);
                    tmpBdaInfo.power220 = Convert.ToChar(fbReader["AC220V"]);
                    tmpBdaInfo.comm = Convert.ToChar(fbReader["COMM"]);

                    tmpBdaInfo.fm = Convert.ToChar(fbReader["FM"]);
                    tmpBdaInfo.vhf = Convert.ToChar(fbReader["VHF"]);
                    tmpBdaInfo.dmb = Convert.ToChar(fbReader["DMB"]);
                    tmpBdaInfo.protection = Convert.ToChar(fbReader["PROTECTION"]);
                    tmpBdaInfo.trs = Convert.ToChar(fbReader["TRS"]);

                    tmpBdaInfo.upsBypass = Convert.ToChar(fbReader["BYPASS"]);
                    tmpBdaInfo.upsAC = Convert.ToChar(fbReader["AC"]);
                    tmpBdaInfo .upsFail = Convert.ToChar(fbReader["FAIL"]);
                    tmpBdaInfo.upsBattery = Convert.ToChar(fbReader["BATTERY"]);

                    tmpBdaInfo.fmValue = Convert.ToInt16(fbReader["FMVALUE"]);
                    tmpBdaInfo.vhfValue = Convert.ToInt16(fbReader["VHFVALUE"]);
                    tmpBdaInfo.dmbValue = Convert.ToInt16(fbReader["DMBVALUE"]);
                    tmpBdaInfo.protectionValue = Convert.ToInt16(fbReader["PROTECTIONVALUE"]);
                    tmpBdaInfo.trsValue = Convert.ToInt16(fbReader["TRSVALUE"]);

                    resultList.Add(tmpBdaInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public DataSet MuFmAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Mu_Fm";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Mu_Fm");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList MuFmFind(DateTime startTime, DateTime stopTime, int muID)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Mu_Fm where dateTime >= @startDateTime and dateTime <= @stopDateTime and muID = @muID";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간
                fbCMD.Parameters.Add("@muID", FbDbType.SmallInt).Value = (short)(muID + 1);     //muID

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    FM_Info tmpFmInfo = new FM_Info();

                    tmpFmInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpFmInfo.mu_id = (short)(fbReader["muID"]);

                    tmpFmInfo.betteryVoltage = Convert.ToByte(fbReader["betteryVoltage"]);
                    tmpFmInfo.betteryChangeCurrent = Convert.ToByte(fbReader["betteryChange"]);
                    tmpFmInfo.betteryDisChangeCurrent = Convert.ToByte(fbReader["betteryDisChange"]);

                    tmpFmInfo.acInputFail = Convert.ToByte(fbReader["acInputFail"]);
                    tmpFmInfo.lnaFail = Convert.ToByte(fbReader["lnaFail"]);
                    tmpFmInfo.dcOutputFail = Convert.ToByte(fbReader["dcOutputFail"]);

                    tmpFmInfo.ldAlarm = Convert.ToByte(fbReader["lnaFail"]);
                    tmpFmInfo.ldPower = Convert.ToSByte(fbReader["ldPower"]);
                    tmpFmInfo.pdAlarm = Convert.ToByte(fbReader["pdAlarm"]);
                    tmpFmInfo.pdPower = Convert.ToSByte(fbReader["pdPower"]);

                    tmpFmInfo.rssi = Convert.ToSByte(fbReader["rssi"]);
                    tmpFmInfo.tssi = Convert.ToSByte(fbReader["tssi"]);
                    tmpFmInfo.temperature = Convert.ToSByte(fbReader["temperature"]);

                    resultList.Add(tmpFmInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public DataSet RuFmAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Ru_Fm";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Ru_Fm");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList RuFmFind(DateTime startTime, DateTime stopTime, int muID, int ruID)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                if (ruID == 0)
                {
                    strSQL = "select * from RuA_Fm where dateTime >= @startDateTime and dateTime <= @stopDateTime and muID = @muID and ruID = @ruID";

                    FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                    fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                    fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간
                    fbCMD.Parameters.Add("@muID", FbDbType.SmallInt).Value = (short)(muID + 1);     //muID
                    fbCMD.Parameters.Add("@ruID", FbDbType.SmallInt).Value = (short)(ruID + 1);     //ruID

                    fbCMD.CommandType = System.Data.CommandType.Text;
                    FbDataReader fbReader = fbCMD.ExecuteReader();

                    while (fbReader.Read())
                    {
                        FM_Info tmpFmInfo = new FM_Info();

                        tmpFmInfo.datetime = (DateTime)fbReader["datetime"];
                        tmpFmInfo.mu_id = (short)(fbReader["muID"]);
                        tmpFmInfo.ru_id = (short)(fbReader["ruID"]);

                        tmpFmInfo.betteryVoltage = Convert.ToByte(fbReader["betteryVoltage"]);
                        tmpFmInfo.betteryChangeCurrent = Convert.ToByte(fbReader["betteryChange"]);
                        tmpFmInfo.betteryDisChangeCurrent = Convert.ToByte(fbReader["betteryDisChange"]);

                        tmpFmInfo.acInputFail = Convert.ToByte(fbReader["acInputFail"]);
                        tmpFmInfo.lnaFail = Convert.ToByte(fbReader["lnaFail"]);
                        tmpFmInfo.dcOutputFail = Convert.ToByte(fbReader["dcOutputFail"]);

                        tmpFmInfo.ldAlarm = Convert.ToByte(fbReader["ldAlarm"]);
                        tmpFmInfo.ldPower = Convert.ToSByte(fbReader["ldPower"]);
                        tmpFmInfo.pdAlarm = Convert.ToByte(fbReader["pdAlarm"]);
                        tmpFmInfo.pdPower = Convert.ToSByte(fbReader["pdPower"]);

                        tmpFmInfo.rssi = Convert.ToSByte(fbReader["rssi"]);
                        tmpFmInfo.tssi = Convert.ToSByte(fbReader["tssi"]);
                        tmpFmInfo.temperature = Convert.ToSByte(fbReader["temperature"]);

                        resultList.Add(tmpFmInfo);
                    }
                }
                else
                {
                    strSQL = "select * from Ru_Fm where dateTime >= @startDateTime and dateTime <= @stopDateTime and muID = @muID and ruID = @ruID";

                    FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                    fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                    fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간
                    fbCMD.Parameters.Add("@muID", FbDbType.SmallInt).Value = (short)(muID + 1);     //muID
                    fbCMD.Parameters.Add("@ruID", FbDbType.SmallInt).Value = (short)(ruID + 1);     //ruID

                    fbCMD.CommandType = System.Data.CommandType.Text;
                    FbDataReader fbReader = fbCMD.ExecuteReader();

                    while (fbReader.Read())
                    {
                        FM_Info tmpFmInfo = new FM_Info();

                        tmpFmInfo.datetime = (DateTime)fbReader["datetime"];
                        tmpFmInfo.mu_id = (short)(fbReader["muID"]);
                        tmpFmInfo.ru_id = (short)(fbReader["ruID"]);

                        tmpFmInfo.betteryVoltage = Convert.ToByte(fbReader["betteryVoltage"]);
                        tmpFmInfo.betteryChangeCurrent = Convert.ToByte(fbReader["betteryChange"]);

                        tmpFmInfo.acInputFail = Convert.ToByte(fbReader["acInputFail"]);
                        tmpFmInfo.dcOutputFail = Convert.ToByte(fbReader["dcOutputFail"]);

                        tmpFmInfo.ldAlarm = Convert.ToByte(fbReader["ldAlarm"]);
                        tmpFmInfo.ldPower = Convert.ToSByte(fbReader["ldPower"]);
                        tmpFmInfo.pdAlarm = Convert.ToByte(fbReader["pdAlarm"]);
                        tmpFmInfo.pdPower = Convert.ToSByte(fbReader["pdPower"]);

                        tmpFmInfo.rssi = Convert.ToSByte(fbReader["rssi"]);
                        tmpFmInfo.tssi = Convert.ToSByte(fbReader["tssiFwd"]);
                        tmpFmInfo.tssi = Convert.ToSByte(fbReader["tssiRev"]);
                        tmpFmInfo.temperature = Convert.ToSByte(fbReader["temperature"]);

                        resultList.Add(tmpFmInfo);
                    }
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }
        
        public DataSet sourcetelBdaAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Sourcetel_BDA_Table";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Sourcetel_BDA_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList sourcetelBdaFind(DateTime startTime, DateTime stopTime, int muID, int ruID, int bdaID)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Sourcetel_BDA_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime and muID = @muID and ruID = @ruID and bdaID = @bdaID";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간
                fbCMD.Parameters.Add("@muID", FbDbType.SmallInt).Value = (short)(muID + 1);     //muID
                fbCMD.Parameters.Add("@ruID", FbDbType.SmallInt).Value = (short)(ruID + 1);     //ruID
                fbCMD.Parameters.Add("@bdaID", FbDbType.SmallInt).Value = (short)(bdaID + 1);   //bdaID

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    BDA_St tmpBdaInfo = new BDA_St();

                    tmpBdaInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpBdaInfo.mu_id = (short)(fbReader["muID"]);
                    tmpBdaInfo.ru_id = (short)(fbReader["ruID"]);
                    tmpBdaInfo.bda_id = (short)(fbReader["bdaID"]);

                    tmpBdaInfo.fmTemperature = Convert.ToSByte(fbReader["fmTemperature"]);
                    tmpBdaInfo.fmTssi = Convert.ToSByte(fbReader["fmTssi"]);
                    tmpBdaInfo.fmAlarm = Convert.ToByte(fbReader["fmAlarm"]);

                    tmpBdaInfo.vhfBypass = Convert.ToByte(fbReader["vhfAmp"]);
                    tmpBdaInfo.vhfAcAlarm = Convert.ToByte(fbReader["vhfAcAlarm"]);
                    tmpBdaInfo.vhfDcAlarm = Convert.ToByte(fbReader["vhfDcAlarm"]);
                    tmpBdaInfo.vhfBatteryAlarm = Convert.ToByte(fbReader["vhfBatteryAlarm"]);
                    tmpBdaInfo.vhfPtt1 = Convert.ToByte(fbReader["vhfPtt1"]);
                    tmpBdaInfo.vhfPtt2 = Convert.ToByte(fbReader["vhfPtt2"]);

                    tmpBdaInfo.uhfBypass = Convert.ToByte(fbReader["uhfAmp"]);
                    tmpBdaInfo.uhfAcAlarm = Convert.ToByte(fbReader["uhfAcAlarm"]);
                    tmpBdaInfo.uhfDcAlarm = Convert.ToByte(fbReader["uhfDcAlarm"]);
                    tmpBdaInfo.uhfBatteryAlarm = Convert.ToByte(fbReader["uhfBatteryAlarm"]);
                    tmpBdaInfo.uhfPtt1 = Convert.ToByte(fbReader["uhfPtt1"]);
                    tmpBdaInfo.uhfPtt2 = Convert.ToByte(fbReader["uhfPtt2"]);

                    resultList.Add(tmpBdaInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public ArrayList MuErrorStFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Mu_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);  //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    MuInfo tmpMuInfo = new MuInfo();

                    tmpMuInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpMuInfo.mu_id = (short)(fbReader["muID"]);

                    tmpMuInfo.ac = Convert.ToChar(fbReader["AC"]);
                    tmpMuInfo.dc = Convert.ToChar(fbReader["DC"]);
                    tmpMuInfo.trxUnit = Convert.ToChar(fbReader["TrxUnit"]);

                    tmpMuInfo.mainComm = Convert.ToChar(fbReader["mainComm"]);
                    tmpMuInfo.stbyComm = Convert.ToChar(fbReader["stbyComm"]);
                    tmpMuInfo.monComm = Convert.ToChar(fbReader["monComm"]);
                    tmpMuInfo.muTrxCpu = Convert.ToChar(fbReader["muTrxCpu"]);
                    tmpMuInfo.muOptCpu = Convert.ToChar(fbReader["muOptCpu"]);
                    tmpMuInfo.MuUps = Convert.ToChar(fbReader["muUps"]);

                    tmpMuInfo.mainPllLock = Convert.ToChar(fbReader["mainPllLock"]);
                    tmpMuInfo.stbyPllLock = Convert.ToChar(fbReader["stbyPllLock"]);
                    tmpMuInfo.monPllLock = Convert.ToChar(fbReader["monPllLock"]);

                    tmpMuInfo.optDc = Convert.ToChar(fbReader["optDc"]);
                    tmpMuInfo.optModOpen = Convert.ToChar(fbReader["optModOpen"]);

                    tmpMuInfo.opt1Ld = Convert.ToChar(fbReader["opt1Ld"]);
                    tmpMuInfo.opt2Ld = Convert.ToChar(fbReader["opt2Ld"]);
                    tmpMuInfo.opt3Ld = Convert.ToChar(fbReader["opt3Ld"]);
                    tmpMuInfo.opt4Ld = Convert.ToChar(fbReader["opt4Ld"]);
                    tmpMuInfo.opt1Pd = Convert.ToChar(fbReader["opt1Pd"]);
                    tmpMuInfo.opt2Pd = Convert.ToChar(fbReader["opt2Pd"]);
                    tmpMuInfo.opt3Pd = Convert.ToChar(fbReader["opt3Pd"]);
                    tmpMuInfo.opt4Pd = Convert.ToChar(fbReader["opt4Pd"]);

                    tmpMuInfo.fm_Power = Convert.ToChar(fbReader["FM_POWER"]);
                    tmpMuInfo.fm_Rf = Convert.ToChar(fbReader["FM_RF"]);

                    resultList.Add(tmpMuInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public ArrayList UpsErrorStFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Ups_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    UpsInfo tmpUpsInfo = new UpsInfo();

                    tmpUpsInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpUpsInfo.mu_id = (short)(fbReader["muID"]);

                    tmpUpsInfo.upsFailed = Convert.ToChar(fbReader["upsFailed"]);
                    tmpUpsInfo.batteryLow = Convert.ToChar(fbReader["batteryLow"]);
                    tmpUpsInfo.bypass = Convert.ToChar(fbReader["bypass"]);
                    tmpUpsInfo.utilityFail = Convert.ToChar(fbReader["utilityFail"]);

                    resultList.Add(tmpUpsInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public ArrayList RuErrorStFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Ru_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    RuInfo tmpRuInfo = new RuInfo();

                    tmpRuInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpRuInfo.mu_id = (short)(fbReader["muID"]);
                    tmpRuInfo.ru_id = (short)(fbReader["ruID"]);

                    tmpRuInfo.ac = Convert.ToChar(fbReader["AC"]);
                    tmpRuInfo.dc = Convert.ToChar(fbReader["DC"]);
                    tmpRuInfo.modOpen = Convert.ToChar(fbReader["modOpen"]);
                    tmpRuInfo.ruCpu = Convert.ToChar(fbReader["ruCpu"]);
                    tmpRuInfo.data = Convert.ToChar(fbReader["data"]);
                    tmpRuInfo.optLd = Convert.ToChar(fbReader["optLd"]);
                    tmpRuInfo.xmtrPllLock = Convert.ToChar(fbReader["xmtrPllLock"]);
                    tmpRuInfo.rcvrpllLock = Convert.ToChar(fbReader["rcvrpllLock"]);

                    tmpRuInfo.fm_Power = Convert.ToChar(fbReader["FM_POWER"]);
                    tmpRuInfo.fm_Rf = Convert.ToChar(fbReader["FM_RF"]);

                    resultList.Add(tmpRuInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public ArrayList BdaErrorStFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from BDA_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    BdaInfo tmpBdaInfo = new BdaInfo();

                    tmpBdaInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpBdaInfo.mu_id = (short)(fbReader["muID"]);
                    tmpBdaInfo.ru_id = (short)(fbReader["ruID"]);
                    tmpBdaInfo.bda_id = (short)(fbReader["bdaID"]);

                    tmpBdaInfo.power12 = Convert.ToChar(fbReader["DC12V"]);
                    tmpBdaInfo.power24 = Convert.ToChar(fbReader["DC24V"]);
                    tmpBdaInfo.power220 = Convert.ToChar(fbReader["AC220V"]);
                    tmpBdaInfo.comm = Convert.ToChar(fbReader["COMM"]);

                    tmpBdaInfo.fm = Convert.ToChar(fbReader["FM"]);
                    tmpBdaInfo.vhf = Convert.ToChar(fbReader["VHF"]);
                    tmpBdaInfo.dmb = Convert.ToChar(fbReader["DMB"]);
                    tmpBdaInfo.protection = Convert.ToChar(fbReader["PROTECTION"]);
                    tmpBdaInfo.trs = Convert.ToChar(fbReader["TRS"]);

                    tmpBdaInfo.upsBypass = Convert.ToChar(fbReader["BYPASS"]);
                    tmpBdaInfo.upsAC = Convert.ToChar(fbReader["AC"]);
                    tmpBdaInfo.upsFail = Convert.ToChar(fbReader["FAIL"]);
                    tmpBdaInfo.upsBattery = Convert.ToChar(fbReader["BATTERY"]);

                    resultList.Add(tmpBdaInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public ArrayList MuFmErrorStFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Mu_Fm where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);  //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    FM_Info tmpFmInfo = new FM_Info();

                    tmpFmInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpFmInfo.mu_id = (short)(fbReader["muID"]);

                    tmpFmInfo.acInputFail = Convert.ToByte(fbReader["acInputFail"]);
                    tmpFmInfo.lnaFail = Convert.ToByte(fbReader["lnaFail"]);
                    tmpFmInfo.dcOutputFail = Convert.ToByte(fbReader["dcOutputFail"]);

                    tmpFmInfo.ldAlarm = Convert.ToByte(fbReader["ldAlarm"]);
                    tmpFmInfo.pdAlarm = Convert.ToByte(fbReader["pdAlarm"]);

                    resultList.Add(tmpFmInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public ArrayList RuFmErrorStFind(DateTime startTime, DateTime stopTime, bool flagRuA)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                if (flagRuA)
                {
                    strSQL = "select * from RuA_Fm where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                    FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                    fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                    fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);  //검색 종료 시간

                    fbCMD.CommandType = System.Data.CommandType.Text;
                    FbDataReader fbReader = fbCMD.ExecuteReader();

                    while (fbReader.Read())
                    {
                        FM_Info tmpFmInfo = new FM_Info();

                        tmpFmInfo.datetime = (DateTime)fbReader["datetime"];
                        tmpFmInfo.mu_id = (short)(fbReader["muID"]);

                        tmpFmInfo.acInputFail = Convert.ToByte(fbReader["acInputFail"]);
                        tmpFmInfo.lnaFail = Convert.ToByte(fbReader["lnaFail"]);
                        tmpFmInfo.dcOutputFail = Convert.ToByte(fbReader["dcOutputFail"]);

                        tmpFmInfo.ldAlarm = Convert.ToByte(fbReader["ldAlarm"]);
                        tmpFmInfo.pdAlarm = Convert.ToByte(fbReader["pdAlarm"]);

                        resultList.Add(tmpFmInfo);
                    }
                }
                else
                {
                    strSQL = "select * from Ru_Fm where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                    FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                    fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                    fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);  //검색 종료 시간

                    fbCMD.CommandType = System.Data.CommandType.Text;
                    FbDataReader fbReader = fbCMD.ExecuteReader();

                    while (fbReader.Read())
                    {
                        FM_Info tmpFmInfo = new FM_Info();

                        tmpFmInfo.datetime = (DateTime)fbReader["datetime"];
                        tmpFmInfo.mu_id = (short)(fbReader["muID"]);
                        tmpFmInfo.ru_id = (short)(fbReader["ruID"]);

                        tmpFmInfo.acInputFail = Convert.ToByte(fbReader["acInputFail"]);
                        tmpFmInfo.dcOutputFail = Convert.ToByte(fbReader["dcOutputFail"]);

                        tmpFmInfo.ldAlarm = Convert.ToByte(fbReader["ldAlarm"]);
                        tmpFmInfo.pdAlarm = Convert.ToByte(fbReader["pdAlarm"]);

                        resultList.Add(tmpFmInfo);
                    }
                }

            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public ArrayList sourcetelBdaErrorStFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Sourcetel_BDA_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    BDA_St tmpBdaInfo = new BDA_St();

                    tmpBdaInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpBdaInfo.mu_id = (short)(fbReader["muID"]);
                    tmpBdaInfo.ru_id = (short)(fbReader["ruID"]);
                    tmpBdaInfo.bda_id = (short)(fbReader["bdaID"]);

                    tmpBdaInfo.fmAlarm = Convert.ToByte(fbReader["fmAlarm"]);

                    tmpBdaInfo.vhfBypass = Convert.ToByte(fbReader["vhfAmp"]);
                    tmpBdaInfo.vhfAcAlarm = Convert.ToByte(fbReader["vhfAcAlarm"]);
                    tmpBdaInfo.vhfDcAlarm = Convert.ToByte(fbReader["vhfDcAlarm"]);
                    tmpBdaInfo.vhfBatteryAlarm = Convert.ToByte(fbReader["vhfBatteryAlarm"]);

                    tmpBdaInfo.uhfBypass = Convert.ToByte(fbReader["uhfAmp"]);
                    tmpBdaInfo.uhfAcAlarm = Convert.ToByte(fbReader["uhfAcAlarm"]);
                    tmpBdaInfo.uhfDcAlarm = Convert.ToByte(fbReader["uhfDcAlarm"]);
                    tmpBdaInfo.uhfBatteryAlarm = Convert.ToByte(fbReader["uhfBatteryAlarm"]);

                    resultList.Add(tmpBdaInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public ArrayList MuTxRxErxStFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Mu_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    MuInfo tmpMuInfo = new MuInfo();

                    tmpMuInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpMuInfo.mu_id = (short)(fbReader["muID"]);

                    tmpMuInfo.mainPtt = Convert.ToChar(fbReader["mainPtt"]);
                    tmpMuInfo.mainBusy = Convert.ToChar(fbReader["mainBusy"]);
                    tmpMuInfo.stbyPtt = Convert.ToChar(fbReader["stbyPtt"]);
                    tmpMuInfo.stbyBusy = Convert.ToChar(fbReader["stbyBusy"]);
                    tmpMuInfo.monBusy = Convert.ToChar(fbReader["monBusy"]);

                    tmpMuInfo.mainCh = Convert.ToChar(fbReader["mainCh"]);
                    tmpMuInfo.stbyCh = Convert.ToChar(fbReader["stbyCh"]);
                    tmpMuInfo.monCh = Convert.ToChar(fbReader["monCh"]);

                    resultList.Add(tmpMuInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }
        
        //2013년 08월 05일 추가
        public DataSet MuIndividualErrorFind(DateTime startTime, DateTime stopTime, string strError, int muID)
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select dateTime, muID, " + strError + " from Mu_Table where MUID = " + muID.ToString();

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Mu_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public DataSet UPSIndividualErrorFind(DateTime startTime, DateTime stopTime, string strError, int muID)
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select dateTime, muID, " + strError + " from UPS_Table where MUID = " + muID.ToString();

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "UPS_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public DataSet RuIndividualErrorFind(DateTime startTime, DateTime stopTime, string strError, int muID, int ruID)
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                if (ruID == 0) strSQL = "select dateTime, muID, ruID, " + strError + " from Ru_Table where MUID = " + muID.ToString();
                else strSQL = "select dateTime, muID, ruID, " + strError + " from Ru_Table where MUID = " + muID.ToString() + "and RUID = " + ruID.ToString();

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Ru_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public DataSet BDAIndividualErrorFind(DateTime startTime, DateTime stopTime, string strError, int muID, int ruID, int bdaID)
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                if (bdaID == 0) strSQL = "select dateTime, muID, ruID, bdaID, " + strError + " from BDA_Table where MUID = " + muID.ToString() + "and RUID = " + ruID.ToString();
                else strSQL = "select dateTime, muID, ruID, bdaID, " + strError + " from BDA_Table where MUID = " + muID.ToString() + "and RUID = " + ruID.ToString() + "and BDAID = " + bdaID.ToString();

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "BDA_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public DataSet SourcetelBDAIndividualErrorFind(DateTime startTime, DateTime stopTime, string strError, int muID, int ruID, int bdaID)
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                if (bdaID == 0) strSQL = "select dateTime, muID, ruID, bdaID, " + strError + " from Sourcetel_BDA_Table where MUID = " + muID.ToString() + "and RUID = " + ruID.ToString();
                else strSQL = "select dateTime, muID, ruID, bdaID, " + strError + " from Sourcetel_BDA_Table where MUID = " + muID.ToString() + "and RUID = " + ruID.ToString() + "and BDAID = " + bdaID.ToString();
                
                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Sourcetel_BDA_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public DataSet FMIndividualErrorFind(DateTime startTime, DateTime stopTime, string strError, int muID, int ruID, bool flagRuA)
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                if (ruID == 0) strSQL = "select dateTime, muID, ruID, " + strError + " from Ru_Fm where MUID = " + muID.ToString();
                else strSQL = "select dateTime, muID, ruID, " + strError + " from Ru_Fm where MUID = " + muID.ToString() + "and RUID = " + ruID.ToString();

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);

                adpt.Fill(ds, "Ru_Fm");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region CCE DataBase 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// CCP Data를 저장한다.
        /// </summary>
        public bool CCPInsert(ccpStInfo tmpStInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into CCP_Table ( CCE_ID, CCP_ID, Comm, PcComm, dateTime ) " +
                                        "values ( @CCE_ID, @CCP_ID, @Comm, @PcComm, @dateTime )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@CCE_ID", FbDbType.SmallInt).Value = tmpStInfo.cce_id;
                fbCMD_Insert.Parameters.Add("@CCP_ID", FbDbType.SmallInt).Value = tmpStInfo.ccp_id;
                fbCMD_Insert.Parameters.Add("@Comm", FbDbType.Char).Value = tmpStInfo.comm;
                fbCMD_Insert.Parameters.Add("@PcComm", FbDbType.Char).Value = tmpStInfo.pcComm;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// CCP Data를 모두 삭제한다.
        /// </summary>
        public bool CCPDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from CCP_Table";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// Console I/F Data를 저장한다.
        /// </summary>
        public bool ConsoleIFInsert(consoleStInfo tmpStInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into Console_Table ( CCE_ID, IF_ID, Comm, Ch, Ptt, Broad, dateTime ) " +
                                            "values ( @CCE_ID, @IF_ID, @Comm, @Ch, @Ptt, @Broad, @dateTime )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@CCE_ID", FbDbType.SmallInt).Value = tmpStInfo.cce_id;
                fbCMD_Insert.Parameters.Add("@IF_ID", FbDbType.SmallInt).Value = tmpStInfo.if_id;
                fbCMD_Insert.Parameters.Add("@Comm", FbDbType.Char).Value = tmpStInfo.comm;
                fbCMD_Insert.Parameters.Add("@Ch", FbDbType.Char).Value = tmpStInfo.ch;
                fbCMD_Insert.Parameters.Add("@Ptt", FbDbType.Char).Value = tmpStInfo.ptt;
                fbCMD_Insert.Parameters.Add("@Broad", FbDbType.Char).Value = tmpStInfo.broad;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// Console I/F Data를 모두 삭제한다.
        /// </summary>
        public bool ConsoleDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from Console_Table";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// Broad I/F Data를 저장한다.
        /// </summary>
        public bool BroadIFInsert(broadStInfo tmpStInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into Broad_Table ( CCE_ID, broadEnable1, broadEnable2, broadEnable3, broadPtt1, broadPtt2, broadPtt3, dateTime ) " +
                                            "values ( @CCE_ID, @broadEnable1, @broadEnable2, @broadEnable3, @broadPtt1, @broadPtt2, @broadPtt3, @dateTime )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@CCE_ID", FbDbType.SmallInt).Value = tmpStInfo.cce_id;
                fbCMD_Insert.Parameters.Add("@broadEnable1", FbDbType.Char).Value = tmpStInfo.enabel1;
                fbCMD_Insert.Parameters.Add("@broadEnable2", FbDbType.Char).Value = tmpStInfo.enabel2;
                fbCMD_Insert.Parameters.Add("@broadEnable3", FbDbType.Char).Value = tmpStInfo.enabel3;
                fbCMD_Insert.Parameters.Add("@broadPtt1", FbDbType.Char).Value = tmpStInfo.ptt1;
                fbCMD_Insert.Parameters.Add("@broadPtt2", FbDbType.Char).Value = tmpStInfo.ptt2;
                fbCMD_Insert.Parameters.Add("@broadPtt3", FbDbType.Char).Value = tmpStInfo.ptt3;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// Broad I/F Data를 모두 삭제한다.
        /// </summary>
        public bool BroadDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from Broad_Table";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// Base I/F Data를 저장한다.
        /// </summary>
        public bool BaseIFInsert(baseStInfo tmpStInfo)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into Base_Table ( CCE_ID, IF_ID, Comm, Ch, Ptt, Busy, eBusy, Broad, tone1, tone2, dateTime ) " +
                                            "values ( @CCE_ID, @IF_ID, @Comm, @Ch, @Ptt, @Busy, @eBusy, @Broad, @faultTone1, @faultTone2, @dateTime )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@CCE_ID", FbDbType.SmallInt).Value = tmpStInfo.cce_id;
                fbCMD_Insert.Parameters.Add("@IF_ID", FbDbType.SmallInt).Value = tmpStInfo.if_id;
                fbCMD_Insert.Parameters.Add("@Comm", FbDbType.Char).Value = tmpStInfo.comm;
                fbCMD_Insert.Parameters.Add("@Ch", FbDbType.Char).Value = tmpStInfo.ch;
                fbCMD_Insert.Parameters.Add("@Ptt", FbDbType.Char).Value = tmpStInfo.ptt;
                fbCMD_Insert.Parameters.Add("@Busy", FbDbType.Char).Value = tmpStInfo.busy;
                fbCMD_Insert.Parameters.Add("@eBusy", FbDbType.Char).Value = tmpStInfo.eBusy;
                fbCMD_Insert.Parameters.Add("@Broad", FbDbType.Char).Value = tmpStInfo.broad;
                fbCMD_Insert.Parameters.Add("@faultTone1", FbDbType.Char).Value = tmpStInfo.faultTone1;
                fbCMD_Insert.Parameters.Add("@faultTone2", FbDbType.Char).Value = tmpStInfo.faultTone2;
                fbCMD_Insert.Parameters.Add("@dateTime", FbDbType.TimeStamp).Value = DateTime.Now;

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        /// <summary>
        /// Base I/F Data를 모두 삭제한다.
        /// </summary>
        public bool BaseDelete()
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "delete from Base_Table";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        public DataSet CcpAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from CCP_Table";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "CCP_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList CCPFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from CCP_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";
                //strSQL = "select * from CCP_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime and cceID == @cceID";
                //
                //if (ccpID != 99) strSQL += " and  ccpID == @ccpID";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                //fbCMD.Parameters.Add("@cceID", FbDbType.SmallInt).Value = cceID;
                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime;     //검색 종료 시간
                //if (ccpID != 99)
                //    fbCMD.Parameters.Add("@ccpID", FbDbType.SmallInt).Value = ccpID;

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    ccpStInfo tmpStInfo = new ccpStInfo();

                    tmpStInfo.index = Convert.ToInt32(fbReader["index"]);
                    tmpStInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpStInfo.cce_id = Convert.ToInt16(fbReader["cce_ID"]);
                    tmpStInfo.ccp_id = Convert.ToInt16(fbReader["ccp_ID"]);
                    tmpStInfo.comm = Convert.ToChar(fbReader["Comm"]);
                    tmpStInfo.pcComm = Convert.ToChar(fbReader["PcComm"]);

                    resultList.Add(tmpStInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public DataSet ConsoleAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Console_Table";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Console_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList ConsoleIFFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Console_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime;     //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    consoleStInfo tmpStInfo = new consoleStInfo();

                    tmpStInfo.index = Convert.ToInt32(fbReader["index"]);
                    tmpStInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpStInfo.cce_id = Convert.ToInt16(fbReader["cce_ID"]);
                    tmpStInfo.if_id = Convert.ToInt16(fbReader["IF_ID"]);
                    tmpStInfo.comm = Convert.ToChar(fbReader["Comm"]);
                    tmpStInfo.ch = Convert.ToChar(fbReader["Ch"]);
                    tmpStInfo.ptt = Convert.ToChar(fbReader["PTT"]);
                    tmpStInfo.broad = Convert.ToChar(fbReader["Broad"]);

                    resultList.Add(tmpStInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public DataSet BroadAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Broad_Table";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Broad_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList BroadIFFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Broad_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime;     //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    broadStInfo tmpStInfo = new broadStInfo();

                    tmpStInfo.index = Convert.ToInt32(fbReader["index"]);
                    tmpStInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpStInfo.cce_id = Convert.ToInt16(fbReader["cce_ID"]);
                    tmpStInfo.enabel1 = Convert.ToChar(fbReader["broadEnable1"]);
                    tmpStInfo.enabel2 = Convert.ToChar(fbReader["broadEnable2"]);
                    tmpStInfo.enabel3 = Convert.ToChar(fbReader["broadEnable3"]);
                    tmpStInfo.ptt1 = Convert.ToChar(fbReader["broadPtt1"]);
                    tmpStInfo.ptt2 = Convert.ToChar(fbReader["broadPtt2"]);
                    tmpStInfo.ptt3 = Convert.ToChar(fbReader["broadPtt3"]);

                    resultList.Add(tmpStInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }

        public DataSet BaseAllFind()
        {
            string strSQL = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Base_Table";

                FbDataAdapter adpt = new FbDataAdapter(strSQL, fbDBConn);
                adpt.Fill(ds, "Base_Table");
            }
            catch
            {
            }
            if (fbDBConn != null) fbDBConn.Close();

            return ds;
        }

        public ArrayList BaseIFFind(DateTime startTime, DateTime stopTime)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from Base_Table where dateTime >= @startDateTime and dateTime <= @stopDateTime";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime;     //검색 종료 시간

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    baseStInfo tmpStInfo = new baseStInfo();

                    tmpStInfo.index = Convert.ToInt32(fbReader["index"]);
                    tmpStInfo.datetime = (DateTime)fbReader["datetime"];
                    tmpStInfo.cce_id = Convert.ToInt16(fbReader["cce_ID"]);
                    tmpStInfo.if_id = Convert.ToInt16(fbReader["IF_ID"]);
                    tmpStInfo.comm = Convert.ToChar(fbReader["Comm"]);
                    tmpStInfo.ch = Convert.ToChar(fbReader["Ch"]);
                    tmpStInfo.ptt = Convert.ToChar(fbReader["PTT"]);
                    tmpStInfo.busy = Convert.ToChar(fbReader["Busy"]);
                    tmpStInfo.eBusy = Convert.ToChar(fbReader["eBusy"]);
                    tmpStInfo.broad = Convert.ToChar(fbReader["Broad"]);
                    tmpStInfo.faultTone1 = Convert.ToChar(fbReader["Tone1"]);
                    tmpStInfo.faultTone2 = Convert.ToChar(fbReader["Tone2"]);

                    resultList.Add(tmpStInfo);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
    }

    public class MuInfo
    {
        /// <summary> MU ID </summary>
        public Int16 mu_id;
        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        /// <summary> 자동/수동 </summary>
        public char autoManual;
        /// <summary> 주/예비 </summary>
        public char mainStby;
        /// <summary> 무전기형식 </summary>
        public char wideNarrow;
        /// <summary> AC 전원상태 </summary>
        public char ac;
        /// <summary> DC 전원상태 </summary>
        public char dc;
        /// <summary> TrxUnit(ModOpen) </summary>
        public char trxUnit;
        /// <summary> 구로 CCE PTT 상태 </summary>
        public char cce1Ptt;
        /// <summary> 대전 CCE PTT 상태 </summary>
        public char cce2Ptt;
        /// <summary> RC1 PTT 상태 </summary>
        public char rc1Ptt;
        /// <summary> RC2 PTT 상태 </summary>
        public char rc2Ptt;
        /// <summary> RC3 PTT 상태 </summary>
        public char rc3Ptt;
        /// <summary> 역용 주 PTT </summary>
        public char mainPtt;
        /// <summary> 역용 주 Busy </summary>
        public char mainBusy;
        /// <summary> 역용 예비 PTT </summary>
        public char stbyPtt;
        /// <summary> 역용 예비 Busy </summary>
        public char stbyBusy;
        /// <summary> 역용 감청 Busy </summary>
        public char monBusy;
        /// <summary> DC 전원값 </summary>
        public float dcValue;
        /// <summary> 역용 주 RF 출력 감시 </summary>
        public float mainRf;
        /// <summary> 역용 주 RSSI 수신 감도 </summary>
        public Int16 mainRssi;
        /// <summary> 역용 예비 RF 출력 감시 </summary>
        public float stbyRf;
        /// <summary> 역용 예비 RSSI 수신 감도 </summary>
        public Int16 stbyRssi;
        /// <summary> 역용 감청 RSSI 수신 감도 </summary>
        public Int16 monRssi;
        /// <summary> 역용 주 RF 출력 설정 </summary>
        public Int16 mainRfSet;
        /// <summary> 역용 예비 RF 출력 설정 </summary>
        public Int16 stbyRfSet;
        /// <summary> 역용 주 채널 </summary>
        public char mainCh;
        /// <summary> 역용 예비 채널 </summary>
        public char stbyCh;
        /// <summary> 역용 감청 채널 </summary>
        public char monCh;
        /// <summary> 역용 주 통신 감시 </summary>
        public char mainComm;
        /// <summary> 역용 예비 통신 감시 </summary>
        public char stbyComm;
        /// <summary> 역용 감청 통신 감시 </summary>
        public char monComm;
        /// <summary> MU TRX CPU 장착 여부 </summary>
        public char muTrxCpu;
        /// <summary> MU OPT CPU 장착여부 </summary>
        public char muOptCpu;
        /// <summary> MU UPS 연결여부 </summary>
        public char MuUps;
        /// <summary> 채널 복귀 시간 </summary>
        public Int16 chReturn;
        /// <summary> 역용 주 PLL LOCK 장애 </summary>
        public char mainPllLock;
        /// <summary> 역용 예비 PLL LOCK 장애 </summary>
        public char stbyPllLock;
        /// <summary> 역용 감청 PLL LOCK 장애 </summary>
        public char monPllLock;
        /// <summary> OPT DC 전원 상태 </summary>
        public char optDc;
        /// <summary> OPT ModOpen </summary>
        public char optModOpen;
        /// <summary> OPT CCE PTT 상태 </summary>
        public char optCcePtt;
        /// <summary> OPT DC 전원값 </summary>
        public float optDcValue;
        /// <summary> OPT 1 LD 알람 </summary>
        public char opt1Ld;
        /// <summary> OPT 2 LD 알람 </summary>
        public char opt2Ld;
        /// <summary> OPT 3 LD 알람 </summary>
        public char opt3Ld;
        /// <summary> OPT 4 LD 알람 </summary>
        public char opt4Ld;
        /// <summary> OPT 1 PD 알람 </summary>
        public char opt1Pd;
        /// <summary> OPT 2 PD 알람 </summary>
        public char opt2Pd;
        /// <summary> OPT 3 PD 알람 </summary>
        public char opt3Pd;
        /// <summary> OPT 4 PD 알람 </summary>
        public char opt4Pd;

        /// <summary> FM 재장송장치 Power </summary>
        public char fm_Power;
        /// <summary> FM 재장송장치 RF </summary>
        public char fm_Rf;
    }

    public class UpsInfo
    {
        /// <summary> MU ID </summary>
        public Int16 mu_id;
        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        /// <summary> 입력전압 </summary>
        public float inputVoltage;
        /// <summary> 과실전압 </summary>
        public float faultVoltage;
        /// <summary> 출력전압 </summary>
        public float outVoltage;
        /// <summary> 배터리전압 </summary>
        public float batteryVoltage;
        /// <summary> 출력전류 </summary>
        public short currentPercent;
        /// <summary> 주파수 </summary>
        public float frequency;
        /// <summary> 온도 </summary>
        public float temperature;
                
        /// <summary> 입력전원 </summary>
        public char upsFailed;
        /// <summary> 밧데리 </summary>
        public char batteryLow;
        /// <summary> Bypass </summary>
        public char bypass;
        /// <summary> UPS </summary>
        public char utilityFail;
    }

    public class RuInfo
    {
        /// <summary> MU ID </summary>
        public Int16 mu_id;
        /// <summary> RU ID </summary>
        public Int16 ru_id;
        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        /// <summary> 자동/수동 </summary>
        public char autoManual;
        /// <summary> 주/예비 </summary>
        public char mainStby;
        /// <summary> 무전기형식 </summary>
        public char wideNarrow;
        /// <summary> AC 전원상태 </summary>
        public char ac;
        /// <summary> DC 전원상태 </summary>
        public char dc;
        /// <summary> ModOpen </summary>
        public char modOpen;
        /// <summary> PTT 상태 </summary>
        public char ptt;
        /// <summary> Local/Remote </summary>
        public char localRemote;
        /// <summary> RU CPU </summary>
        public char ruCpu;
        /// <summary> 데이터 광접속 상태 </summary>
        public char data;
        /// <summary> OPT LD 알람 </summary>
        public char optLd;
        /// <summary> OPT PD 알람 </summary>
        public char optPd;
        /// <summary> XMTR PLL LOCK 장애 상태 </summary>
        public char xmtrPllLock;
        /// <summary> RCVR PLL LOCK 장애 상태 </summary>
        public char rcvrpllLock;
        /// <summary> DC 전원값 </summary>
        public float dcValue;
        /// <summary> RF 출력 감시 </summary>
        public float rf;
        /// <summary> RF 출력 설정 </summary>
        public Int16 rfSet;
        /// <summary> RSSI 감도 </summary>
        public Int16 rssi;

        /// <summary> FM 재장송장치 Power </summary>
        public char fm_Power;
        /// <summary> FM 재장송장치 RF </summary>
        public char fm_Rf;
    }

    public class BdaInfo
    {
        /// <summary> MU ID </summary>
        public Int16 mu_id;
        /// <summary> RU ID </summary>
        public Int16 ru_id;
        /// <summary> BDA ID </summary>
        public Int16 bda_id;
        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        /// <summary> Power 12V </summary>
        public char power12;
        /// <summary> Power 24V </summary>
        public char power24;
        /// <summary> Power 220V </summary>
        public char power220;
        /// <summary> 통신상태 </summary>
        public char comm;
        /// <summary> FM </summary>
        public char fm;
        /// <summary> VHF </summary>
        public char vhf;
        /// <summary> DMB </summary>
        public char dmb;
        /// <summary> Protection(방호) </summary>
        public char protection;
        /// <summary> TRS </summary>
        public char trs;
        /// <summary> UPS Bypass </summary>
        public char upsBypass;
        /// <summary> UPS 전원(AC) </summary>
        public char upsAC;
        /// <summary> UPS Fail </summary>
        public char upsFail;
        /// <summary> UPS Battery </summary>
        public char upsBattery;

        /// <summary> FM Gain값 </summary>
        public Int16 fmValue;
        /// <summary> VHF Gain값 </summary>
        public Int16 vhfValue;
        /// <summary> DMB Gain값 </summary>
        public Int16 dmbValue;
        /// <summary> 방호 Gain값 </summary>
        public Int16 protectionValue;
        /// <summary> TRS Gain값 </summary>
        public Int16 trsValue;
    }

    public class ccpStInfo
    {
        /// <summary> Index </summary>
        public int index;
        /// <summary> CCE ID </summary>
        public Int16 cce_id;

        /// <summary> CCP ID </summary>
        public Int16 ccp_id;
        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        /// <summary> 통신상태 </summary>
        public char comm;
        /// <summary> PC 통신상태 </summary>
        public char pcComm;
    }

    public class consoleStInfo
    {
        /// <summary> Index </summary>
        public int index;
        /// <summary> CCE ID </summary>
        public Int16 cce_id;

        /// <summary> Console I/F ID </summary>
        public Int16 if_id;
        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        /// <summary> 통신상태 </summary>
        public char comm;
        /// <summary> 채널 </summary>
        public char ch;
        /// <summary> PTT 상태 </summary>
        public char ptt;
        /// <summary> 방송상태 </summary>
        public char broad;
    }

    public class broadStInfo
    {
        /// <summary> Index </summary>
        public int index;
        /// <summary> CCE ID </summary>
        public Int16 cce_id;

        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        /// <summary> Broad Enable1 </summary>
        public char enabel1;
        /// <summary> Broad Enable2 </summary>
        public char enabel2;
        /// <summary> Broad Enable3 </summary>
        public char enabel3;
        /// <summary> Broad PTT1 </summary>
        public char ptt1;
        /// <summary> Broad PTT2 </summary>
        public char ptt2;
        /// <summary> Broad PTT3 </summary>
        public char ptt3;
    }

    public class baseStInfo
    {
        /// <summary> Index </summary>
        public int index;
        /// <summary> CCE ID </summary>
        public Int16 cce_id;

        /// <summary> Base I/F ID </summary>
        public Int16 if_id;
        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        /// <summary> 통신상태 </summary>
        public char comm;
        /// <summary> 채널 </summary>
        public char ch;
        /// <summary> PTT 상태 </summary>
        public char ptt;
        /// <summary> Busy 상태 </summary>
        public char busy;
        /// <summary> eBusy 상태 </summary>
        public char eBusy;
        /// <summary> 방송상태 </summary>
        public char broad;
        /// <summary> FaultTone1 상태 </summary>
        public char faultTone1;
        /// <summary> FaultTone2 상태 </summary>
        public char faultTone2;
    }

    public class clsStatusListDBMS : clsDBMS
    {
        public clsStatusListDBMS()
        {
        }

        /// <summary>
        /// 전체 Data를 저장한다.
        /// </summary>
        public bool Insert(statusListInfo status)
        {
            bool flagResult = true;
            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "insert into statusList ( datetime, content ) values ( @datetime, @content )";

                FbCommand fbCMD_Insert = new FbCommand(strSQL, fbDBConn);

                fbCMD_Insert.Parameters.Add("@datetime", FbDbType.TimeStamp).Value = status.datetime;    //날자,시간
                fbCMD_Insert.Parameters.Add("@content", FbDbType.Text).Value = status.content;      //내용

                fbCMD_Insert.ExecuteNonQuery();
                fbCMD_Insert.Dispose();
            }
            catch
            {
                flagResult = false;
            }

            if (fbDBConn != null) fbDBConn.Close();

            return flagResult;
        }

        public ArrayList Find(DateTime startTime, DateTime stopTime, string searchWord)
        {
            ArrayList resultList = new ArrayList();

            string strSQL = string.Empty;

            try
            {
                fbDBConn.Open();

                strSQL = "select * from statusList where datetime >= @startDateTime and datetime <= @stopDateTime";
                if ((searchWord != null) && (searchWord != "")) strSQL += " and content like @searchWord";

                FbCommand fbCMD = new FbCommand(strSQL, fbDBConn);

                fbCMD.Parameters.Add("@startDateTime", FbDbType.TimeStamp).Value = startTime;   //검색 시작 시간
                fbCMD.Parameters.Add("@stopDateTime", FbDbType.TimeStamp).Value = stopTime.AddDays(1);     //검색 종료 시간

                if ((searchWord != null) && (searchWord != ""))
                    fbCMD.Parameters.Add("@searchWord", FbDbType.Text).Value = "%" + searchWord + "%";      //검색단어

                fbCMD.CommandType = System.Data.CommandType.Text;
                FbDataReader fbReader = fbCMD.ExecuteReader();

                while (fbReader.Read())
                {
                    statusListInfo tmpStatust = new statusListInfo();

                    tmpStatust.index_id = Convert.ToInt32(fbReader["index_id"].ToString());
                    tmpStatust.datetime = (DateTime)fbReader["datetime"];
                    tmpStatust.content = fbReader["content"].ToString();

                    resultList.Add(tmpStatust);
                }
            }
            catch
            {
            }

            if (fbDBConn != null) fbDBConn.Close();

            return resultList;
        }
    }

    public class statusListInfo
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        public int index_id;
        /// <summary>
        /// 날자시간
        /// </summary>
        public DateTime datetime;
        /// <summary>
        /// 내용
        /// </summary>
        public string content;
    }
}
