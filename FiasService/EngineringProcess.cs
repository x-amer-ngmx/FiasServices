using Chilkat;
using DownLoadFile;
using FiasService.FiasReference;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FiasService
{
    public static class EngineringProcess
    {
        public static T Deserialize<T>(XDocument doc)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(doc.CreateReader());

        }

        private static string unzipPatch = @"D:\temp\";
        private static string dirName;
        private static string Ddr = string.Empty;
        private static string zipFile;

        public static void DownloadFirs()
        {
            FiasReference.DownloadServiceSoapClient client = new DownloadServiceSoapClient();
            var res = client.GetLastDownloadFileInfo();
            var rrss = res;

            Regex re = new Regex(@"(.*)\/(.*)[^0-9]{8}/");
            string url = rrss.FiasDeltaXmlUrl;

            string ttt = re.Replace(url, "");
            dirName = ttt = ttt.Replace("/", "_");
            dirName = dirName.Replace(".", "_");

            zipFile = string.Format("{0}{1}", unzipPatch, ttt);

            Ddr = dirName;
            dirName = string.Format("{0}{1}\\", unzipPatch, dirName);

            if (Directory.Exists(dirName))
            {
                EventLoger.setEvent(string.Format("Пакет дельта обновлений ({0}). Уже был загружен!", url), EventLogEntryType.Information);
                return;
            }

            EventLoger.setEvent(string.Format("Пакет дельта обновлений ({0}). Попытка загрузить!", url), EventLogEntryType.Information);

            DownloadStream download = new DownloadStream(url);

            long size = download.iFileSize;

            if (size > 0)
            {
                download.Loade(zipFile);

                dload(download, zipFile, size);
            }
            EventLoger.setEvent(string.Format("Пакет дельта обновлений ({0}). Загружен успешно!", url), EventLogEntryType.SuccessAudit);
            unZiping();
        }

        private static void dload(DownloadStream download, string zFile, long size)
        {
            while (true)
            {
                if (File.Exists(zipFile))
                {
                    var lsizr = new FileInfo(zipFile);

                    if (lsizr.Length < size)
                    {
                        download.Loade(zFile);

                        continue;
                    }
                }
                break;
            }
        }

        private static void unZiping()
        {
            EventLoger.setEvent(string.Format("Попытка распаковки ({0}) в директорию {1}!", zipFile, dirName), EventLogEntryType.Information);
            try
            {
                Rar r = new Rar();

                if (r.Open(zipFile))
                {
                    if (r.Unrar(dirName))
                    {
                        EventLoger.setEvent(string.Format("Попытка распаковки ({0}) в директорию {1}! Удачно завершена.", zipFile, dirName), EventLogEntryType.SuccessAudit);

                        using (FiasUpdaterSRV.FiasRealClient client = new FiasUpdaterSRV.FiasRealClient())
                        {

                            try
                            {
                                EventLoger.setEvent(string.Format("Запуск службы миграции.", zipFile, dirName), EventLogEntryType.Information);
                                client.Open();
                                client.Runable(Ddr);
                                client.Close();
                                EventLoger.setEvent("Запуск службы миграции Завершён успешно.", EventLogEntryType.SuccessAudit);
                            }
                            catch (Exception ex)
                            {
                                EventLoger.setEvent(string.Format("Запуск службы миграции Завершился с следующей ошибкой: \n {0}.", ex.Message), EventLogEntryType.Error);
                            }
                        }
                    }
                    else
                    {
                        EventLoger.setEvent(string.Format("Попытка распаковки ({0}) в директорию {1}! Завершилась с ошибками.", zipFile, dirName), EventLogEntryType.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                EventLoger.setEvent(string.Format("В ходе выполнения задания возникло следующее исключение: \n {0}.", ex.Message), EventLogEntryType.Error);
            }
        }
        /*
                private static void moveDate()
                {
                    EventLoger.setEvent(string.Format("Попытка Актуализации базы адресов!", zipFile, dirName), EventLogEntryType.Information);

                    string direct = dirName;

                    string AS_HSTSTAT = Directory.GetFiles(direct, "AS_HSTSTAT_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_INTVSTAT = Directory.GetFiles(direct, "AS_INTVSTAT_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_CENTERST = Directory.GetFiles(direct, "AS_CENTERST_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_CURENTST = Directory.GetFiles(direct, "AS_CURENTST_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_SOCRBASE = Directory.GetFiles(direct, "AS_SOCRBASE_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_ACTSTAT = Directory.GetFiles(direct, "AS_ACTSTAT_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_OPERSTAT = Directory.GetFiles(direct, "AS_OPERSTAT_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_ESTSTAT = Directory.GetFiles(direct, "AS_ESTSTAT_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_STRSTAT = Directory.GetFiles(direct, "AS_STRSTAT_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_NDOCTYPE = Directory.GetFiles(direct, "AS_NDOCTYPE_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();

                    string AS_ADDROBJ = Directory.GetFiles(direct, "AS_ADDROBJ_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_HOUSE = Directory.GetFiles(direct, "AS_HOUSE_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_HOUSEINT = Directory.GetFiles(direct, "AS_HOUSEINT_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_LANDMARK = Directory.GetFiles(direct, "AS_LANDMARK_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_NORMDOC = Directory.GetFiles(direct, "AS_NORMDOC_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();

                    string AS_DEL_ADDROBJ = Directory.GetFiles(direct, "AS_DEL_ADDROBJ_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_DEL_HOUSE = Directory.GetFiles(direct, "AS_DEL_HOUSE_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_DEL_HOUSEINT = Directory.GetFiles(direct, "AS_DEL_HOUSEINT_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();
                    string AS_DEL_NORMDOC = Directory.GetFiles(direct, "AS_DEL_NORMDOC_*.XML", SearchOption.TopDirectoryOnly).FirstOrDefault();

                    Dictionary<string, string> block = new Dictionary<string, string>(){
                    {"AS_HSTSTAT", AS_HSTSTAT !=null ? AS_HSTSTAT:string.Empty},
                    {"AS_INTVSTAT",AS_INTVSTAT !=null ? AS_INTVSTAT : string.Empty},
                    {"AS_CENTERST",AS_CENTERST!=null ? AS_CENTERST : string.Empty},
                    {"AS_CURENTST",AS_CURENTST!=null ? AS_CURENTST : string.Empty},
                    {"AS_SOCRBASE",AS_SOCRBASE!=null ? AS_SOCRBASE : string.Empty},
                    {"AS_ACTSTAT",AS_ACTSTAT!=null ? AS_ACTSTAT : string.Empty},
                    {"AS_OPERSTAT",AS_OPERSTAT!=null ? AS_OPERSTAT : string.Empty},
                    {"AS_ESTSTAT",AS_ESTSTAT!=null ? AS_ESTSTAT : string.Empty},
                    {"AS_STRSTAT",AS_STRSTAT!=null ? AS_STRSTAT : string.Empty},
                    {"AS_NDOCTYPE", AS_NDOCTYPE!=null ? AS_NDOCTYPE:string.Empty},

                    {"AS_ADDROBJ", AS_ADDROBJ!=null?AS_ADDROBJ:string.Empty},
                    {"AS_HOUSE", AS_HOUSE!=null ? AS_HOUSE : string.Empty},
                    {"AS_HOUSEINT", AS_HOUSEINT!=null? AS_HOUSEINT:string.Empty},
                    {"AS_LANDMARK", AS_LANDMARK!=null? AS_LANDMARK:string.Empty},
                    {"AS_NORMDOC", AS_NORMDOC!=null ? AS_NORMDOC:string.Empty},

                    {"AS_DEL_ADDROBJ", AS_DEL_ADDROBJ!=null ? AS_DEL_ADDROBJ:string.Empty},
                    {"AS_DEL_HOUSE", AS_DEL_HOUSE!=null ? AS_DEL_HOUSE : string.Empty},
                    {"AS_DEL_HOUSEINT", AS_DEL_HOUSEINT!=null? AS_DEL_HOUSEINT : string.Empty},
                    {"AS_DEL_NORMDOC", AS_DEL_NORMDOC!=null ? AS_DEL_NORMDOC : string.Empty}
                    };


                    foreach (var patch in block)
                    {
                       #region kernel
                        #region AS_HSTSTAT
                        if (patch.Key.Equals("AS_HSTSTAT"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.HouseStateStatuses>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from status in contex.HouseStateStatuses where status.HOUSESTID == row.HOUSESTID select status.HOUSESTID;
                                if (u.Count() == 0)
                                {
                                    contex.HouseStateStatuses.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {

                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_INTVSTAT
                        if (patch.Key.Equals("AS_INTVSTAT"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.IntervalStatuses>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from intstatus in contex.IntervalStatuses where intstatus.INTVSTATID == row.INTVSTATID select intstatus.INTVSTATID;
                                if (u.Count() == 0)
                                {
                                    contex.IntervalStatuses.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {

                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_CENTERST
                        if (patch.Key.Equals("AS_CENTERST"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.CenterStatuses>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from center in contex.CenterStatuses where center.CENTERSTID == row.CENTERSTID select center.CENTERSTID;
                                if (u.Count() == 0)
                                {
                                    contex.CenterStatuses.InsertOnSubmit(row);
                                }
                            }
                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {

                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_CURENTST
                        if (patch.Key.Equals("AS_CURENTST"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.CurrentStatuses>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.CurrentStatuses where variable.CURENTSTID == row.CURENTSTID select variable.CURENTSTID;
                                if (u.Count() == 0)
                                {
                                    contex.CurrentStatuses.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_SOCRBASE
                        if (patch.Key.Equals("AS_SOCRBASE"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.AddressObjectTypes>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.AddressObjectTypes where variable.KOD_T_ST.Equals(row.KOD_T_ST) select variable.KOD_T_ST;
                                if (u.Count() == 0)
                                {
                                    contex.AddressObjectTypes.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_ACTSTAT
                        if (patch.Key.Equals("AS_ACTSTAT"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.ActualStatuses>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.ActualStatus where variable.ACTSTATID==row.ACTSTATID select variable.ACTSTATID;
                                if (u.Count() == 0)
                                {
                                    contex.ActualStatus.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_OPERSTAT
                        if (patch.Key.Equals("AS_OPERSTAT"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.OperationStatuses>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.OperationStatuses where variable.OPERSTATID == row.OPERSTATID select variable.OPERSTATID;
                                if (u.Count() == 0)
                                {
                                    contex.OperationStatuses.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_ESTSTAT
                        if (patch.Key.Equals("AS_ESTSTAT"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.EstateStatuses>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.EstateStatuses where variable.ESTSTATID == row.ESTSTATID select variable.ESTSTATID;
                                if (u.Count() == 0)
                                {
                                    contex.EstateStatuses.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_STRSTAT
                        if (patch.Key.Equals("AS_STRSTAT"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.StructureStatuses>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.StructureStatuses where variable.STRSTATID == row.STRSTATID select variable.STRSTATID;
                                if (u.Count() == 0)
                                {
                                    contex.StructureStatuses.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_DEL_ADDROBJ
                        if (patch.Key.Equals("AS_DEL_ADDROBJ"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.AddressObjects>(XDocument.Load(patch.Value)).DellBuild();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.DellAddressObjects where variable.AOID.Equals(row.AOID) select variable.AOID;
                                if (u.Count() == 0)
                                {
                                    contex.DellAddressObjects.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_DEL_HOUSE
                        if (patch.Key.Equals("AS_DEL_HOUSE"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.Houses>(XDocument.Load(patch.Value)).DellBuild();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.DellHouses where variable.HOUSEID.Equals(row.HOUSEID) select variable.HOUSEID;
                                if (u.Count() == 0)
                                {
                                    contex.DellHouses.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_DEL_HOUSEINT
                        if (patch.Key.Equals("AS_DEL_HOUSEINT"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.HouseIntervals>(XDocument.Load(patch.Value)).DellBuild();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.DellHouseIntervals where variable.HOUSEINTID.Equals(row.HOUSEINTID) select variable.HOUSEINTID;
                                if (u.Count() == 0)
                                {
                                    contex.DellHouseIntervals.InsertOnSubmit(row);
                                }
                            }
                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }

                        }
                        #endregion

                        #region AS_DEL_NORMDOC
                        if (patch.Key.Equals("AS_DEL_NORMDOC"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.NormativeDocumentes>(XDocument.Load(patch.Value)).DellBuild();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.DellNormativeDocument where variable.NORMDOCID.Equals(row.NORMDOCID) select variable.NORMDOCID;
                                if (u.Count() == 0)
                                {
                                    contex.DellNormativeDocument.InsertOnSubmit(row);
                                }
                            }
                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_ADDROBJ
                        if (patch.Key.Equals("AS_ADDROBJ"))
                        {
                            if (patch.Value == string.Empty) continue;
                            var dess = Deserialize<XmlStruct.AddressObjects>(XDocument.Load(patch.Value)).Build();
                    
                            DataStructDataContext keyKon = new DataStructDataContext(connect);
                            DataStructDataContext contex = new DataStructDataContext(connect);
                            foreach (var row in dess)
                            {
                                var iu = from variable in keyKon.AddressObjectsAllKey where variable.AOGUID.Equals(row.AOGUID) select variable.AOGUID;
                                if (iu.Count() == 0)
                                {
                                    keyKon.AddressObjectsAllKey.InsertOnSubmit(new AddressObjectsAllKey { AOGUID = row.AOGUID });
                                }

                                var u = from variable in contex.AddressObjects where variable.AOID == row.AOID select variable.AOID;
                                if (u.Count() == 0)
                                {
                                    contex.AddressObjects.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                keyKon.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }


                        }
                        #endregion

                        #region AS_HOUSE
                        if (patch.Key.Equals("AS_HOUSE"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.Houses>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.Houses where variable.HOUSEID.Equals(row.HOUSEID) select variable.HOUSEID;
                                if (u.Count() == 0)
                                {
                                    contex.Houses.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_HOUSEINT
                        if (patch.Key.Equals("AS_HOUSEINT"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.HouseIntervals>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.HouseIntervals where variable.HOUSEINTID.Equals(row.HOUSEINTID) select variable.HOUSEINTID;
                                if (u.Count() == 0)
                                {
                                    contex.HouseIntervals.InsertOnSubmit(row);
                                }
                            }
                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_LANDMARK
                        if (patch.Key.Equals("AS_LANDMARK"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.Landmarks>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.Landmarks where variable.LANDID.Equals(row.LANDID) select variable.LANDID;
                                if (u.Count() == 0)
                                {
                                    contex.Landmarks.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_NDOCTYPE
                        if (patch.Key.Equals("AS_NDOCTYPE"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.NormativeDocumentTypes>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.NormativeDocumentTypes where variable.NDTYPEID == row.NDTYPEID select variable.NDTYPEID;
                                if (u.Count() == 0)
                                {
                                    contex.NormativeDocumentTypes.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion

                        #region AS_NORMDOC
                        if (patch.Key.Equals("AS_NORMDOC"))
                        {
                            if (patch.Value == string.Empty) continue;

                            DataStructDataContext contex = new DataStructDataContext(connect);
                            var dess = Deserialize<XmlStruct.NormativeDocumentes>(XDocument.Load(patch.Value)).Build();

                            foreach (var row in dess)
                            {
                                var u = from variable in contex.NormativeDocument where variable.NORMDOCID.Equals(row.NORMDOCID) select variable.NORMDOCID;
                                if (u.Count() == 0)
                                {
                                    contex.NormativeDocument.InsertOnSubmit(row);
                                }
                            }

                            try
                            {
                                contex.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                            }
                            catch (Exception ex)
                            {
                                var res = ex.Message;
                            }
                        }
                        #endregion
                       #endregion
                    }



                    DataStructDataContext cont = new DataStructDataContext(connect);
                    cont.DELFROM();
                }
            }

            public class XmlRetriver<T>
            {
                public static T FromXml(XDocument xd)
                {
                    XmlSerializer s = new XmlSerializer(typeof(T));
                    return (T)s.Deserialize(xd.CreateReader());
                }
            }*/
    }
}