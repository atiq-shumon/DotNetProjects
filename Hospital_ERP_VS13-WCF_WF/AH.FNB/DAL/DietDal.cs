using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.FNB.MODEL;
using AH.DUtility;
using AH.OracleManager;
using AH.Shared.MODEL;

namespace AH.FNB.DAL
{
    public class DietDal
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.FnBMS);
        string packageName = string.Empty;


        public List<DietSubType> GetDietSubType()
        {
            string packageName = "PKG_DIET.GetDietType";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetMaterialRefNo(packageName, parameterList);
        }
        private List<DietSubType> GetMaterialRefNo(string packageName, OracleParameter[] parameterList)
        {
            List<DietSubType> objDiet = new List<DietSubType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DietSubType Diet = new DietSubType();

                if (rdr["DIET_TYPE_ID"].ToString() != "")
                {
                    Diet.DietSubID = rdr["DIET_TYPE_ID"].ToString();
                }
                else
                {
                    Diet.DietSubID = "";
                }
                if (rdr["DIET_TYPE_NAME"].ToString() != "")
                {
                    Diet.DietSubTypeName = rdr["DIET_TYPE_NAME"].ToString();
                }
                else
                {
                    Diet.DietSubTypeName = "";
                }

                objDiet.Add(Diet);
            }
            rdr.Close();
            return objDiet;
        }


        public string SaveDietSubType(DietSubType dst)
        {
            packageName = "PKG_DIET.InsertDietSubType";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pdietTypeid",OracleDbType.Varchar2,60,dst.DietTypeID,ParameterDirection.Input),
                new OracleParameter("pdietsubtypeName",OracleDbType.Varchar2,100,dst.DietSubTypeName,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,dst.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,dst.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,dst.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,dst.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return "1";
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }



        public List<DietSubType> DisplaySubType()
        {
            string packageName = "PKG_DIET.displaydiettype";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return DisplaySubType(packageName, parameterList);
        }
        private List<DietSubType> DisplaySubType(string packageName, OracleParameter[] parameterList)
        {
            List<DietSubType> objDiet = new List<DietSubType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DietSubType Diet = new DietSubType();
                if (rdr["sub_type_id"].ToString() != "")
                {
                    Diet.DietSubID = rdr["sub_type_id"].ToString();
                }
                else
                {
                    Diet.DietSubID = "";
                }


                if (rdr["DIET_TYPE_ID"].ToString() != "")
                {
                    Diet.DietTypeID = rdr["DIET_TYPE_ID"].ToString();
                }
                else
                {
                    Diet.DietTypeID = "";
                }
                if (rdr["sub_menu_name"].ToString() != "")
                {
                    Diet.DietSubTypeName = rdr["sub_menu_name"].ToString();
                }
                else
                {
                    Diet.DietSubTypeName = "";
                }

                objDiet.Add(Diet);
            }
            rdr.Close();
            return objDiet;
        }

        public string UpdateDietSubType(DietSubType dst)
        {
            packageName = "PKG_DIET.UpdateDietSubType";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pdietSubid",OracleDbType.Varchar2,60,dst.DietSubID ,ParameterDirection.Input),
                new OracleParameter("pdietTypeid",OracleDbType.Varchar2,60,dst.DietTypeID,ParameterDirection.Input),
                new OracleParameter("pdietsubtypeName",OracleDbType.Varchar2,100,dst.DietSubTypeName,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,dst.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,dst.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,dst.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,dst.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return "1";
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }



        public List<WeeklyDietSetup> GetSubType(string Where)
        {
            string packageName = "PKG_DIET.GetSubType";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where ,ParameterDirection.Input),
                };
            return GetSubType(packageName, parameterList);
        }
        private List<WeeklyDietSetup> GetSubType(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklyDietSetup> objDiet = new List<WeeklyDietSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklyDietSetup Diet = new WeeklyDietSetup();

                if (rdr["sub_type_id"].ToString() != "")
                {
                    Diet.DietSubID = rdr["sub_type_id"].ToString();
                }
                else
                {
                    Diet.DietSubID = "";
                }
                if (rdr["sub_menu_name"].ToString() != "")
                {
                    Diet.DietSubMenuName = rdr["sub_menu_name"].ToString();
                }
                else
                {
                    Diet.DietTypeMenuName = "";
                }

                objDiet.Add(Diet);
            }
            rdr.Close();
            return objDiet;
        }




        public string InsertWeeklyDietMenu(WeeklyDietSetup Wds)
        {
            packageName = "PKG_DIET.InsertWeeklyDietMenu";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pweeklyDietMenu",OracleDbType.Varchar2,60,Wds.DietSubMenuName,ParameterDirection.Input),
                new OracleParameter("pdayno",OracleDbType.Varchar2,100,Wds.WeekDayNo,ParameterDirection.Input),
                new OracleParameter("pdiettype",OracleDbType.Varchar2,100,Wds.DietTypeID,ParameterDirection.Input),
                new OracleParameter("psubmenuID",OracleDbType.Varchar2,100,Wds.WeeklyDietMenu,ParameterDirection.Input),
                new OracleParameter("pdietTime",OracleDbType.Varchar2 ,60,Wds.DietTime,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Wds.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Wds.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Wds.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Wds.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return "1";
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public string UpdatetWeeklyDietMenu(WeeklyDietSetup Wds)
        {
            packageName = "PKG_DIET.UpdateWeeklyDietMenu";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("DIET_MENU_ID",OracleDbType.Varchar2,60,Wds.DietMenuID,ParameterDirection.Input),
                new OracleParameter("pweeklyDietMenu",OracleDbType.Varchar2,60,Wds.DietSubMenuName,ParameterDirection.Input),
                new OracleParameter("pdayno",OracleDbType.Varchar2,100,Wds.WeekDayNo,ParameterDirection.Input),
                new OracleParameter("pdiettype",OracleDbType.Varchar2,100,Wds.DietTypeID,ParameterDirection.Input),
                new OracleParameter("psubmenuID",OracleDbType.Varchar2,100,Wds.WeeklyDietMenu,ParameterDirection.Input),
                new OracleParameter("pdietTime",OracleDbType.Varchar2 ,60,Wds.DietTime,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Wds.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Wds.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Wds.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Wds.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return "1";
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }


        public List<WeeklyDietSetup> GetWeeklyDietSetup(string Where)
        {
            string packageName = "PKG_DIET.GetLoadWeeklySetup";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where ,ParameterDirection.Input),
                };
            return GetWeeklyDietSetup(packageName, parameterList);
        }
        private List<WeeklyDietSetup> GetWeeklyDietSetup(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklyDietSetup> objDiet = new List<WeeklyDietSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklyDietSetup Diet = new WeeklyDietSetup();

                if (rdr["diet_menu_id"].ToString() != "")
                {
                    Diet.DietMenuID = rdr["diet_menu_id"].ToString();
                }
                else
                {
                    Diet.DietMenuID = "";
                }
                if (rdr["weekly_diet_menu"].ToString() != "")
                {
                    Diet.WeeklyDietMenu = rdr["weekly_diet_menu"].ToString();
                }
                else
                {
                    Diet.WeeklyDietMenu = "";
                }

                if (rdr["day_no"].ToString() != "")
                {
                    Diet.WeekDayNo = rdr["day_no"].ToString();
                }
                else
                {
                    Diet.WeekDayNo = "";
                }
                if (rdr["dayname"].ToString() != "")
                {
                    Diet.WeekDayName = rdr["dayname"].ToString();
                }
                else
                {
                    Diet.WeekDayName = "";
                }
                if (rdr["dayname"].ToString() != "")
                {
                    Diet.WeekDayName = rdr["dayname"].ToString();
                }
                else
                {
                    Diet.WeekDayName = "";
                }
                if (rdr["DIET_TYPE_NAME"].ToString() != "")
                {
                    Diet.DietTypeMenuName = rdr["DIET_TYPE_NAME"].ToString();
                }
                else
                {
                    Diet.DietTypeMenuName = "";
                }
                if (rdr["diet_type_id"].ToString() != "")
                {
                    Diet.DietTypeID = rdr["diet_type_id"].ToString();
                }
                else
                {
                    Diet.DietTypeID = "";
                }
                if (rdr["sub_menu_id"].ToString() != "")
                {
                    Diet.DietSubID = rdr["sub_menu_id"].ToString();
                }
                else
                {
                    Diet.DietSubID = "";
                }
                if (rdr["diet_time"].ToString() != "")
                {
                    Diet.DietTime  = rdr["diet_time"].ToString();
                }
                else
                {
                    Diet.DietTime = "";
                }


                objDiet.Add(Diet);
            }
            rdr.Close();
            return objDiet;
        }







    }
}
