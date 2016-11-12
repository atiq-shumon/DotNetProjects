using System;
using System.Data;
using System.Collections.Generic;
using AH.DUtility;
using Oracle.DataAccess.Client;
using AH.OracleManager;
using AH.OPD.MODEL;
using System.Text.RegularExpressions;
using AH.Shared.MODEL;


namespace AH.OPD.DAL
{
    public class OpdPrescriptionReportDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.OPDMIS);
        public List<string> MedicineNames = new List<string>();
        string packageName = string.Empty;
        private int count = 0;
        #region Search
        public List<OPDPrescriptionReportNewRO> GetOPDPrescription(string WhereCondition)
        {
            string packageName = "AGH_OPD.Pkg_OPD_Reports.Get_OPD_Prescription";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_whereCondition",OracleDbType.Varchar2,30,WhereCondition,ParameterDirection.Input) 
            };
           // return GetOPDPrescriptionDetails(packageName, parameterList);
            return GetPrescriptionDetails(packageName, parameterList);
        }
        #region chekDuplicateMedicine
       // public string medicineCheck = "";

       
        public bool MedicneCheck(string medicineCheck)
        {
            bool isFound = false;
            if (MedicineNames.Count == 0)
            {
                MedicineNames.Add(medicineCheck);
                isFound=false ;

                if(medicineCheck != "")
                {
                    count = 1;
                }
                
                return isFound;
            }
            if (MedicineNames.Count > 0)
            {
                for (int i = 0; i < MedicineNames.Count; i++)
                {
                if (MedicineNames[i].ToString().Trim() == medicineCheck.Trim())
                {
                   isFound = true;
                   return isFound;
                  //  isFound = false;
                }
            }
          }
            if (MedicineNames.Count > 0 && !isFound)
            {
                MedicineNames.Add(medicineCheck);
                count++;
                isFound= false;

            }
            //if (oMedicineChecks.Count > 0)
            //{
            //    if (oMedicineChecks[i].MedicineName.ToString().Trim() != medicineCheck.Trim())
            //    {
            //        MedicineCheck oMedicineCheck = new MedicineCheck();
            //        oMedicineCheck.MedicineName = medicineCheck;
            //        oMedicineChecks.Add(oMedicineCheck);
            //        return true;
            //    }
            //    if (oMedicineChecks[i].MedicineName.ToString().Trim() == medicineCheck.Trim())
            //    {
            //        return false;
            //    }

            return isFound;
        }
        #endregion
        private List<OPDPrescriptionReportNewRO> GetPrescriptionDetails(string packageName, OracleParameter[] parameterList)
        {
            List<OPDPrescriptionReportNewRO> lsPrescription = new List<OPDPrescriptionReportNewRO>();
            OracleDataReader oReader;
            oReader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (oReader.Read())
            {
                OPDPrescriptionReportNewRO oDRS = new OPDPrescriptionReportNewRO();
                oDRS.PatientName = (oReader["PatientName"] == DBNull.Value ? string.Empty : (string)oReader["PatientName"]);
                oDRS.TicketNo =  (oReader["TicketNo"] == DBNull.Value ? string.Empty : (string)oReader["TicketNo"]);
                oDRS.HCN =  (oReader["HCN"] == DBNull.Value ? string.Empty : (string)oReader["HCN"]);
                oDRS.BloodGroup = (oReader["BloodGroup"] == DBNull.Value ? string.Empty : (string)oReader["BloodGroup"]);
                oDRS.Sex = (oReader["Sex"] == DBNull.Value ? string.Empty : (string)oReader["Sex"]);
                oDRS.Age = (oReader["Age"] == DBNull.Value ? string.Empty : (string)oReader["Age"]);

                oDRS.Height = (oReader["Height"] == DBNull.Value ? string.Empty : (string)oReader["Height"]);
                oDRS.Weight = (oReader["Weight"] == DBNull.Value ? string.Empty : (string)oReader["Weight"]);
                oDRS.BP = (oReader["BP"] == DBNull.Value ? string.Empty : (string)oReader["BP"]);
                oDRS.Temparature = (oReader["Temparature"] == DBNull.Value ? string.Empty : (string)oReader["Temparature"]);
                oDRS.SPOTWO = (oReader["SPOTWO"] == DBNull.Value ? string.Empty : Convert.ToString((string)oReader["SPOTWO"]));
                oDRS.OFC = (oReader["OFC"] == DBNull.Value ? string.Empty : Convert.ToString((string)oReader["OFC"]));

                oDRS.Unit = (oReader["UNIT"] == DBNull.Value ? string.Empty : (string)oReader["UNIT"]);
                oDRS.DeptUnit =   (oReader["deptUnit"] == DBNull.Value ? string.Empty : (string)oReader["deptUnit"]);
                oDRS.DoctorName = (oReader["DoctorName"] == DBNull.Value ? string.Empty : (string)oReader["DoctorName"]);
                oDRS.DegreeLn1 =  (oReader["DEGREE_LINE1"] == DBNull.Value ? string.Empty : (string)oReader["DEGREE_LINE1"]);
                oDRS.DegreeLn2 =  (oReader["DEGREE_LINE2"] == DBNull.Value ? string.Empty : (string)oReader["DEGREE_LINE2"]);
                oDRS.DegreeLn3 =  (oReader["DEGREE_LINE3"] == DBNull.Value ? string.Empty : (string)oReader["DEGREE_LINE3"]);
                oDRS.DegreeLn4 =  (oReader["DEGREE_LINE4"] == DBNull.Value ? string.Empty : (string)oReader["DEGREE_LINE4"]);

                oDRS.VisitDate = Convert.ToString(((DateTime)oReader["VisitDate"]).ToString("dd/MM/yyyy"));//Convert.ToString((DateTime)oReader["VisitDate"]); 

                if (oReader["NextVisitDate"].ToString() == "" || oReader["NextVisitDate"].ToString() == null)
                {
                    oDRS.NextVisitDate = null;
                }
                if (oReader["NextVisitDate"].ToString() != "" && oReader["NextVisitDate"].ToString()  != null)
                {
                    oDRS.NextVisitDate = Convert.ToString(((DateTime)oReader["NextVisitDate"]).ToString("dd/MM/yyyy"));
                   
                }

                oDRS.ComplaintsTitle = (oReader["ComplaintTitle"] == DBNull.Value ? string.Empty : (string)oReader["ComplaintTitle"]);
                oDRS.OtherComplaintsTitle = (oReader["OTHERCOMPLAINTTITLE"] == DBNull.Value ? string.Empty : (string)oReader["OTHERCOMPLAINTTITLE"]);

                oDRS.Diagnosis = (oReader["Diagnosis"] == DBNull.Value ? string.Empty : (string)oReader["Diagnosis"]);
                if (oDRS.Diagnosis == "Diagnosis :  ; Remarks: ")
                {
                    oDRS.Diagnosis = "";
                }

              //  oDRS.TestGroup = (oReader["TestGroup"] == DBNull.Value ? string.Empty : (string)oReader["TestGroup"]);
                oDRS.TestDetailsName = (oReader["TestDetailsName"] == DBNull.Value ? string.Empty : (string)oReader["TestDetailsName"]);
                //oDRS.TestMain = oReader.GetString("TestMain");

                string medicineCheck = (oReader["Medicine"] == DBNull.Value ? string.Empty : (string)oReader["Medicine"]);
                if (medicineCheck != " :  ")
                {
                    if (!MedicneCheck(medicineCheck))
                    {
                        if (count != 0)
                        {
                            oDRS.GenericName = Convert.ToString(count) + "." + (oReader["GENERICNAME"] == DBNull.Value ? string.Empty : (string)oReader["GENERICNAME"]);
                            oDRS.Medicine = (oReader["Medicine"] == DBNull.Value ? string.Empty : (string)oReader["Medicine"]);
                            oDRS.MedicineDose = (oReader["MedicineDose"] == DBNull.Value ? string.Empty : (string)oReader["MedicineDose"]);
                            if (oDRS.Medicine == " :  ")
                            {
                                oDRS.Medicine = "";
                            }
                        }
                        if (count == 0)
                        {
                            oDRS.GenericName = (oReader["GENERICNAME"] == DBNull.Value ? string.Empty : (string)oReader["GENERICNAME"]);
                            oDRS.Medicine = (oReader["Medicine"] == DBNull.Value ? string.Empty : (string)oReader["Medicine"]);
                            oDRS.MedicineDose = (oReader["MedicineDose"] == DBNull.Value ? string.Empty : (string)oReader["MedicineDose"]);
                            if (oDRS.Medicine == " :  ")
                            {
                                oDRS.Medicine = "";
                            }
                        }
                    }
                }
               
              // oDRS.CFcategory =  (oReader["CF_CATEGORY_TITLE"] == DBNull.Value ? string.Empty : (string)oReader["CF_CATEGORY_TITLE"]);
              // oDRS.ClinicalFindingsGroup =  (oReader["CF_GRP_TITLE"] == DBNull.Value ? string.Empty : (string)oReader["CF_GRP_TITLE"]);
                oDRS.ClinicalFindings =  (oReader["CLINICALFINDINGSDETAILS"] == DBNull.Value ? string.Empty : (string)oReader["CLINICALFINDINGSDETAILS"]);
                oDRS.ComorbidIllness =  (oReader["COMORBIDILLNESS"] == DBNull.Value ? string.Empty : (string)oReader["COMORBIDILLNESS"]);
                oDRS.Advice = (oReader["Advice"] == DBNull.Value ? string.Empty : (string)oReader["Advice"]);

                //string tempTstGrp = (oReader["Test_group_String"] == DBNull.Value ? string.Empty : (string)oReader["Test_group_String"]);
                //oDRS.TestGroupString = GetStringValue(tempTstGrp); 
                
                  
                oDRS.PastMedHis =  (oReader["PASTMEDICALHIS"] == DBNull.Value ? string.Empty : (string)oReader["PASTMEDICALHIS"]);
                oDRS.PastSurgHis = (oReader["PASTSURGICALHIS"] == DBNull.Value ? string.Empty : (string)oReader["PASTSURGICALHIS"]);
                oDRS.FamilyHis =  (oReader["FamilyHis"] == DBNull.Value ? string.Empty : (string)oReader["FamilyHis"]);
                oDRS.HistoryTogether =  (oReader["HistoryTogether"] == DBNull.Value ? string.Empty : (string)oReader["HistoryTogether"]);
                oDRS.PaediatricHisTogether = (oReader["PAEDHISTOGETHER"] == DBNull.Value ? string.Empty : (string)oReader["PAEDHISTOGETHER"]);
                oDRS.GynObsHistory = (oReader["GynObsHistory"] == DBNull.Value ? string.Empty : (string)oReader["GynObsHistory"]);

              //  oDRS.ClinicalFindings = (oReader["FINALCFLIST"] == DBNull.Value ? string.Empty : (string)oReader["FINALCFLIST"]);
              //  oDRS.TestDetailsName = (oReader["TESTDETAILS"] == DBNull.Value ? string.Empty : (string)oReader["TESTDETAILS"]);


                oDRS.RefDept =  (oReader["REFD_DEPT"] == DBNull.Value ? string.Empty : (string)oReader["REFD_DEPT"]);
                oDRS.RefUnit =  (oReader["REFD_UNIT"] == DBNull.Value ? string.Empty : (string)oReader["REFD_UNIT"]);
                oDRS.RefDoc =  (oReader["REFD_DOC"] == DBNull.Value ? string.Empty : (string)oReader["REFD_DOC"]);

                lsPrescription.Add(oDRS);
            }
            oReader.Close();
            return lsPrescription;
        }

        private static string GetStringValue(string strText)
        {
            string bc = "", ac = "";
            List<string> myCollection = new List<string>();
            myCollection.Add(strText);
            foreach (string b in myCollection)
            {
                string[] tt = b.Split(',');
                foreach (string word1 in tt)
                {

                    string[] aa = word1.Split(',');
                    int intlen = aa[0].ToString().Length;
                    bc = aa[0].ToString();
                    ac = ac + "'" + bc.ToString().Substring(1, intlen - 2) + "'" + ",";
                }
            }
            int length = ac.Length - 2;
            ac =  "'"+ ac.Substring(1, length);
            return  ac;

        }



        private List<OPDPrescriptionReportNewRO> GetOPDPrescriptionDetails(string packageName, OracleParameter[] parameterList)
        {
            List<OPDPrescriptionReportNewRO> rDRSs = new List<OPDPrescriptionReportNewRO>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjects(reader);
                }
            }

            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
            return rDRSs;
        }
        #endregion
  

        


        #region DataReaderMappingwithNUll
        private OPDPrescriptionReportNewRO MapObject(NullHandler oReader)
        {
            OPDPrescriptionReportNewRO oDRS = new OPDPrescriptionReportNewRO();
            oDRS.PatientName = oReader.GetString("PatientName");
            oDRS.TicketNo = oReader.GetString("TicketNo");
            oDRS.HCN = oReader.GetString("HCN");
            oDRS.BloodGroup = oReader.GetString("BloodGroup");
            oDRS.Sex = oReader.GetString("Sex");
            oDRS.TestGroup = oReader.GetString("TestGroup");
            oDRS.TestDetailsName = oReader.GetString("TestDetailsName");
            //oDRS.TestMain = oReader.GetString("TestMain");

            oDRS.DeptUnit = oReader.GetString("deptUnit");
            oDRS.DoctorName = oReader.GetString("DoctorName");
            oDRS.DegreeLn1 = oReader.GetString("DEGREE_LINE1");
            oDRS.DegreeLn2 = oReader.GetString("DEGREE_LINE2");
            oDRS.DegreeLn3 = oReader.GetString("DEGREE_LINE3");
            oDRS.DegreeLn4 = oReader.GetString("DEGREE_LINE4");
            oDRS.Age = oReader.GetString("Age");
            oDRS.Height = oReader.GetString("Height");
            oDRS.Weight = oReader.GetString("Weight");
            oDRS.BP = oReader.GetString("BP");
            oDRS.Temparature = oReader.GetString("Temparature");
            oDRS.SPOTWO =Convert.ToString(oReader.GetString("SPOTWO"));
            oDRS.OFC = Convert.ToString(oReader.GetString("OFC"));
            

            oDRS.VisitDate = oReader.GetDateTime("VisitDate").ToString("dd/MM/yyyy");
            if (oReader.GetString("NextVisitDate").ToString() =="")
            {
                oDRS.NextVisitDate = null;
            }
            if (oReader.GetString("NextVisitDate").ToString() != "")
            {
                oDRS.NextVisitDate = Convert.ToDateTime(oReader.GetString("NextVisitDate")).ToString("dd/MM/yyyy");
            } 
            oDRS.Advice = oReader.GetString("Advice");
            oDRS.Diagnosis = oReader.GetString("Diagnosis");
            if (oDRS.Diagnosis == "Diagnosis :  ; Remarks: ")
            {
                oDRS.Diagnosis = "";
            }

            //medicineCheck = oReader.GetString("Medicine");
            //if (medicineCheck != " :  ")
            //{
            //    if (MedicneCheck(medicineCheck))
            //    {
            //        oDRS.GenericName = oReader.GetString("GENERICNAME");
            //        oDRS.Medicine = oReader.GetString("Medicine");
            //        oDRS.MedicineDose = oReader.GetString("MedicineDose");
            //        if (oDRS.Medicine == " :  ")
            //        {
            //            oDRS.Medicine = "";
            //        }
            //    }
            //}
            oDRS.ComplaintsTitle = oReader.GetString("ComplaintTitle");
            oDRS.OtherComplaintsTitle = oReader.GetString("OTHERCOMPLAINTTITLE");
            oDRS.CFcategory = oReader.GetString("CF_CATEGORY_TITLE");
            oDRS.ClinicalFindingsGroup = oReader.GetString("CF_GRP_TITLE");
            oDRS.ClinicalFindings = oReader.GetString("CLINICALFINDINGSDETAILS");
            oDRS.ComorbidIllness = oReader.GetString("COMORBIDILLNESS");
            oDRS.PastMedHis = oReader.GetString("PASTMEDICALHIS");
            oDRS.PastSurgHis = oReader.GetString("PASTSURGICALHIS");
            oDRS.FamilyHis = oReader.GetString("FamilyHis");
            oDRS.HistoryTogether = oReader.GetString("HistoryTogether");
            oDRS.RefDept = oReader.GetString("REFD_DEPT");
            oDRS.RefUnit = oReader.GetString("REFD_UNIT");
            oDRS.RefDoc = oReader.GetString("REFD_DOC");
            return oDRS;
        }

        private OPDPrescriptionReportNewRO CreateObject(NullHandler oReader)
        {
            OPDPrescriptionReportNewRO oDRS = new OPDPrescriptionReportNewRO();
            oDRS = MapObject(oReader);
            return oDRS;
        }

        private List<OPDPrescriptionReportNewRO> CreateObjects(IDataReader oReader)
        {
            List<OPDPrescriptionReportNewRO> rDRSs = new List<OPDPrescriptionReportNewRO>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                OPDPrescriptionReportNewRO oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
    }
}

