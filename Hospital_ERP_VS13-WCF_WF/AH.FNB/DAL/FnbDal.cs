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
    public class FnbDal
    {

        private string connstring = Utility.GetConnectionString(Utility.Module.FnBMS);
        string packageName = string.Empty;

        #region "CheckConnection"
        public int number()
        {
            
            string conn = "User ID=agh_fnbms; password=aghit; Data Source=HOSPITALERP;";
            //OracleConnection gcnmain = new OracleConnection();
            using (OracleConnection gcnmain = new OracleConnection(conn))
            {
                if (gcnmain.State == ConnectionState.Open)
                {
                    gcnmain.Close();
                }
                try
                {
                    gcnmain.Open();
                   // MessageBox.Show("ok");
                    return 1;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("CC");
                    return 0;
                }

            }

        }
        #endregion


        public List<Material_Receipt> GetMaterialRefNo(string Where)
        {
            string packageName = "PKG_FNB.LoadFnb";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pWhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
                };
            return GetMaterialRefNo(packageName, parameterList);
        }
        private List<Material_Receipt> GetMaterialRefNo(string packageName, OracleParameter[] parameterList)
        {
            List<Material_Receipt> objMrr = new List<Material_Receipt>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Material_Receipt Mrr = new Material_Receipt();
                if (rdr["mrr_id"].ToString() != "")
                {
                    Mrr.MrrNo = rdr["mrr_id"].ToString();
                }
                else
                {
                    Mrr.MrrNo = "";
                }
                objMrr.Add(Mrr);
            }
            rdr.Close();
            return objMrr;
        }


        public List<Material_Receipt> DisplayDetailsAgainsrRef(string Where)
        {
            string packageName = "PKG_FNB.GetStockDetails";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
                };
            return DisplayDetailsAgainsrRef(packageName, parameterList);
        }
        private List<Material_Receipt> DisplayDetailsAgainsrRef(string packageName, OracleParameter[] parameterList)
        {
            List<Material_Receipt> objAgnst = new List<Material_Receipt>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Material_Receipt mrr = new Material_Receipt();
                if (rdr["item_id"].ToString() != "")
                {
                    mrr.ProductID = rdr["item_id"].ToString();
                }
                else
                {
                    mrr.ProductID = "";
                }
                if (rdr["product"].ToString() != "")
                {
                    mrr.ProductName = rdr["product"].ToString();
                }
                else
                {
                    mrr.ProductName = "";
                }
                if (rdr["unit_id"].ToString() != "")
                {
                    mrr.Unitcode = rdr["unit_id"].ToString();
                }
                else
                {
                    mrr.Unitcode = "";
                }
                if (rdr["unit"].ToString() != "")
                {
                    mrr.UnitName = rdr["unit"].ToString();
                }
                else
                {
                    mrr.UnitName = "";
                }
                if (rdr["prod_brnd_id"].ToString() != "")
                {
                    mrr.BrandID = rdr["prod_brnd_id"].ToString();
                }
                else
                {
                    mrr.BrandID = "";
                }
                if (rdr["prod_model_id"].ToString() != "")
                {
                    mrr.ModelID = rdr["prod_model_id"].ToString();
                }
                else
                {
                    mrr.ModelID = "";
                }
                mrr.Quantity = Convert.ToDouble(rdr["mrr_qty"]);
                mrr.Rate = Convert.ToDouble(rdr["Urate"]);


                objAgnst.Add(mrr);
            }
            rdr.Close();
            return objAgnst;
        }

        public List<Material_Receipt> GetStockGroup()
        {
            string packageName = "PKG_FNB.GetInvGroups";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetStockGroup(packageName, parameterList);
        }
        private List<Material_Receipt> GetStockGroup(string packageName, OracleParameter[] parameterList)
        {
            List<Material_Receipt> objGroup = new List<Material_Receipt>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Material_Receipt gp = new Material_Receipt();
                if (rdr["groupid"].ToString() != "")
                {
                    gp.Groupcode = rdr["groupid"].ToString();
                }
                else
                {
                    gp.Groupcode = "";
                }
                if (rdr["groupname"].ToString() != "")
                {
                    gp.GroupName = rdr["groupname"].ToString();
                }
                else
                {
                    gp.GroupName = "";
                }
                objGroup.Add(gp);
            }
            rdr.Close();
            return objGroup;
        }

        public string SaveMrr(Material_Receipt Mrr)
        {
            packageName = "PKG_FNB.Insert_Mrr";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pRefNo",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
                new OracleParameter("p_mrr_date",OracleDbType.Varchar2,60,Mrr.MrrDate,ParameterDirection.Input),
                new OracleParameter("p_agnst_ref",OracleDbType.Varchar2 ,60,Mrr.AgainstRefNo,ParameterDirection.Input),
                new OracleParameter("p_group_id",OracleDbType.Varchar2 ,60,Mrr.Groupcode ,ParameterDirection.Input),
                new OracleParameter("p_Notes",OracleDbType.Varchar2 ,60,Mrr.Notes,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Mrr.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
        }


        public short SaveMrrTrans(string mrrNo,string ProductCode,string unitCode,string brandID,
                                    string modelId,double  dblQty,double dblRate,double  dblNetAmnount,
                                    Material_Receipt Mrr)
        {
            packageName = "PKG_FNB.Insert_Mrr_trans";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_mrr_no",OracleDbType.Varchar2,60,mrrNo,ParameterDirection.Input),
                new OracleParameter("p_productCode",OracleDbType.Varchar2,60,ProductCode,ParameterDirection.Input),
                new OracleParameter("p_unitCode",OracleDbType.Varchar2 ,60,unitCode,ParameterDirection.Input),
                new OracleParameter("p_BrandID",OracleDbType.Varchar2 ,60,brandID ,ParameterDirection.Input),
                new OracleParameter("p_modelcode",OracleDbType.Varchar2 ,60,modelId,ParameterDirection.Input),

                new OracleParameter("pQty",OracleDbType.Double ,60,dblQty,ParameterDirection.Input),
                new OracleParameter("pRate",OracleDbType.Double ,60,dblRate,ParameterDirection.Input),
                new OracleParameter("pnetamount",OracleDbType.Double ,60,dblNetAmnount,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Mrr.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<Material_Receipt> GetpopulatedList()
        {
            string packageName = "PKG_FNB.GetPopulateList";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetpopulatedList(packageName, parameterList);
        }
        private List<Material_Receipt> GetpopulatedList(string packageName, OracleParameter[] parameterList)
        {
            List<Material_Receipt> objMrr = new List<Material_Receipt>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Material_Receipt mr = new Material_Receipt();
                if (rdr["mrr_no"].ToString() != "")
                {
                    mr.MrrNo = rdr["mrr_no"].ToString();
                }
                else
                {
                    mr.MrrNo = "";
                }
                if (rdr["mrr_date"].ToString() != "")
                {
                    mr.MrrDate = rdr["mrr_date"].ToString();
                }
                else
                {
                    mr.MrrDate = "";
                }
                objMrr.Add(mr);
            }
            rdr.Close();
            return objMrr;
        }


        public List<Material_Receipt> Displaymaterialreceipt(string Where)
        {
            string packageName = "PKG_FNB.DisplayMaterialReceipt";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
                };
            return Displaymaterialreceipt(packageName, parameterList);
        }
        private List<Material_Receipt> Displaymaterialreceipt(string packageName, OracleParameter[] parameterList)
        {
            List<Material_Receipt> objAgnst = new List<Material_Receipt>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Material_Receipt mrr = new Material_Receipt();
                if (rdr["mrr_no"].ToString() != "")
                {
                    mrr.MrrNo = rdr["mrr_no"].ToString();
                }
                else
                {
                    mrr.MrrNo = "";
                }

                if (rdr["mrr_date"].ToString() != "")
                {
                    mrr.MrrDate = rdr["mrr_date"].ToString();
                }
                else
                {
                    mrr.MrrDate = "";
                }

                if (rdr["groupid"].ToString() != "")
                {
                    mrr.Groupcode = rdr["groupid"].ToString();
                }
                else
                {
                    mrr.Groupcode = "";
                }
                if (rdr["against_ref_no"].ToString() != "")
                {
                    mrr.AgainstRefNo = rdr["against_ref_no"].ToString();
                }
                else
                {
                    mrr.AgainstRefNo = "";
                }

                if (rdr["notes"].ToString() != "")
                {
                    mrr.Notes = rdr["notes"].ToString();
                }
                else
                {
                    mrr.Notes = "";
                }

                if (rdr["product_id"].ToString() != "")
                {
                    mrr.ProductID = rdr["product_id"].ToString();
                }
                else
                {
                    mrr.ProductID = "";
                }
                if (rdr["product"].ToString() != "")
                {
                    mrr.ProductName = rdr["product"].ToString();
                }
                else
                {
                    mrr.ProductName = "";
                }
                if (rdr["productunit"].ToString() != "")
                {
                    mrr.Unitcode = rdr["productunit"].ToString();
                }
                else
                {
                    mrr.Unitcode = "";
                }
                if (rdr["unit"].ToString() != "")
                {
                    mrr.UnitName = rdr["unit"].ToString();
                }
                else
                {
                    mrr.UnitName = "";
                }
                if (rdr["brand_id"].ToString() != "")
                {
                    mrr.BrandID = rdr["brand_id"].ToString();
                }
                else
                {
                    mrr.BrandID = "";
                }
                if (rdr["model_id"].ToString() != "")
                {
                    mrr.ModelID = rdr["model_id"].ToString();
                }
                else
                {
                    mrr.ModelID = "";
                }
                mrr.Quantity = Convert.ToDouble(rdr["quantity"]);
                mrr.Rate = Convert.ToDouble(rdr["rate"]);
                objAgnst.Add(mrr);
            }
            rdr.Close();
            return objAgnst;
        }


        public short UpdateMrr(Material_Receipt Mrr)
        {
            packageName = "PKG_FNB.Update_Mrr";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_mrr_no",OracleDbType.Varchar2,60,Mrr.MrrNo,ParameterDirection.Input),
                new OracleParameter("p_mrr_date",OracleDbType.Varchar2,60,Mrr.MrrDate,ParameterDirection.Input),
                new OracleParameter("p_Notes",OracleDbType.Varchar2 ,60,Mrr.Notes,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Mrr.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }


        public short UpdateMrrTrans(string mrrNo, string ProductCode, string unitCode, string brandID,
                                    string modelId, double dblQty, double dblRate, double dblNetAmnount,
                                    Material_Receipt Mrr)
        {
            packageName = "PKG_FNB.Insert_Mrr_trans";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_mrr_no",OracleDbType.Varchar2,60,mrrNo,ParameterDirection.Input),
                new OracleParameter("p_productCode",OracleDbType.Varchar2,60,ProductCode,ParameterDirection.Input),
                new OracleParameter("p_unitCode",OracleDbType.Varchar2 ,60,unitCode,ParameterDirection.Input),
                new OracleParameter("p_BrandID",OracleDbType.Varchar2 ,60,brandID ,ParameterDirection.Input),
                new OracleParameter("p_modelcode",OracleDbType.Varchar2 ,60,modelId,ParameterDirection.Input),

                new OracleParameter("pQty",OracleDbType.Double ,60,dblQty,ParameterDirection.Input),
                new OracleParameter("pRate",OracleDbType.Double ,60,dblRate,ParameterDirection.Input),
                new OracleParameter("pnetamount",OracleDbType.Double ,60,dblNetAmnount,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Mrr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Mrr.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<SetmenuItem> LoadsetMenuITem()
        {
            string packageName = "PKG_FNB.GetInvGroups";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadsetMenuITem(packageName, parameterList);
        }
        private List<SetmenuItem> LoadsetMenuITem(string packageName, OracleParameter[] parameterList)
        {
            List<SetmenuItem> objsetMenu = new List<SetmenuItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                SetmenuItem Sm = new SetmenuItem();
                if (rdr["product_id"].ToString() != "")
                {
                    Sm.ProductID = rdr["product_id"].ToString();
                }
                else
                {
                    Sm.Groupcode = "";
                }
                if (rdr["product"].ToString() != "")
                {
                    Sm.ProductName = rdr["product"].ToString();
                }
                else
                {
                    Sm.ProductName = "";
                }
                if (rdr["productunit"].ToString() != "")
                {
                    Sm.Unitcode = rdr["productunit"].ToString();
                }
                else
                {
                    Sm.Unitcode = "";
                }
                if (rdr["quantity"].ToString() != "")
                {
                    Sm.Quantity = Convert.ToDouble(rdr["quantity"]);
                }
                else
                {
                    Sm.Quantity = 0;
                }

                if (rdr["brand_id"].ToString() != "")
                {
                    Sm.BrandID = rdr["brand_id"].ToString();
                }
                else
                {
                    Sm.BrandID = "";
                }

                if (rdr["model_id"].ToString() != "")
                {
                    Sm.ModelID = rdr["model_id"].ToString();
                }
                else
                {
                    Sm.ModelID = "";
                }

                if (rdr["groupid"].ToString() != "")
                {
                    Sm.Groupcode = rdr["groupid"].ToString();
                }
                else
                {
                    Sm.Groupcode = "";
                }

                objsetMenu.Add(Sm);
            }
            rdr.Close();
            return objsetMenu;
        }


        public short InsertDietcat(DietCategory dietcat)
        {
            packageName = "PKG_FNB.InsertDietType";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("diet_type_name",OracleDbType.Varchar2,100,dietcat.dietcatName,ParameterDirection.Input),
                new OracleParameter("remarks",OracleDbType.Varchar2,300,dietcat.remarks ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,dietcat.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,dietcat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,dietcat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,dietcat.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public short UpdateDietcat(DietCategory dietcat)
        {
            packageName = "PKG_FNB.UpdateDietType";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pdietcatid",OracleDbType.Varchar2,60,dietcat.dietID,ParameterDirection.Input),
                new OracleParameter("pdietcatName",OracleDbType.Varchar2,100,dietcat.dietcatName,ParameterDirection.Input),
                new OracleParameter("remarks",OracleDbType.Varchar2,300,dietcat.remarks ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,dietcat.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,dietcat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,dietcat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,dietcat.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<DietCategory> LoadDietCategory()
        {
            string packageName = "PKG_FNB.LoadDietType";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadDietCategory(packageName, parameterList);
        }
        private List<DietCategory> LoadDietCategory(string packageName, OracleParameter[] parameterList)
        {
            List<DietCategory> objDietcat = new List<DietCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DietCategory dietcat = new DietCategory();
                if (rdr["DIET_TYPE_ID"].ToString() != "")
                {
                    dietcat.dietID = rdr["DIET_TYPE_ID"].ToString();
                }
                else
                {
                    dietcat.dietID = "";
                }
                if (rdr["DIET_TYPE_NAME"].ToString() != "")
                {
                    dietcat.dietcatName = rdr["DIET_TYPE_NAME"].ToString();
                }
                else
                {
                    dietcat.dietcatName = "";
                }
                if (rdr["remarks"].ToString() != "")
                {
                    dietcat.remarks = rdr["remarks"].ToString();
                }
                else
                {
                    dietcat.remarks = "";
                }

                objDietcat.Add(dietcat);
            }
            rdr.Close();
            return objDietcat;
        }



        public short InsertFoodcat(FoodCategory Foodcat)
        {
            packageName = "PKG_FNB.InsertFoodCategory";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pfoodcatName",OracleDbType.Varchar2,200,Foodcat.FoodcatName,ParameterDirection.Input),
                new OracleParameter("pfoodremarks",OracleDbType.Varchar2,300,Foodcat.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Foodcat.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Foodcat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Foodcat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Foodcat.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public short UpdateFoodcat(FoodCategory foodcat)
        {
            packageName = "PKG_FNB.UpdateFoodCategory";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pfoodcatid",OracleDbType.Varchar2,60,foodcat.FoodID,ParameterDirection.Input),
                new OracleParameter("pfoodcatName",OracleDbType.Varchar2,60,foodcat.FoodcatName,ParameterDirection.Input),
                new OracleParameter("pfoodremarks",OracleDbType.Varchar2,300,foodcat.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,foodcat.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,foodcat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,foodcat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,foodcat.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<FoodCategory> LoadFoodCategory()
        {
            string packageName = "PKG_FNB.LoadFoodCategory";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadFoodCategory(packageName, parameterList);
        }
        private List<FoodCategory> LoadFoodCategory(string packageName, OracleParameter[] parameterList)
        {
            List<FoodCategory> objDietcat = new List<FoodCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodCategory foodcat = new FoodCategory();
                if (rdr["CAT_ID"].ToString() != "")
                {
                    foodcat.FoodID = rdr["CAT_ID"].ToString();
                }
                else
                {
                    foodcat.FoodID = "";
                }
                if (rdr["CAT_NAME"].ToString() != "")
                {
                    foodcat.FoodcatName = rdr["CAT_NAME"].ToString();
                }
                else
                {
                    foodcat.FoodcatName = "";
                }

                if (rdr["remarks"].ToString() != "")
                {
                    foodcat.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    foodcat.Remarks = "";
                }
                objDietcat.Add(foodcat);
            }
            rdr.Close();
            return objDietcat;
        }

        public List<DietCategory> GetDietCategory()
        {
            string packageName = "PKG_FNB.GetDietCategory";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetDietCategory(packageName, parameterList);
        }
        private List<DietCategory> GetDietCategory(string packageName, OracleParameter[] parameterList)
        {
            List<DietCategory> objDietcat = new List<DietCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DietCategory dietcat = new DietCategory();
                if (rdr["diet_cat_id"].ToString() != "")
                {
                    dietcat.dietID = rdr["diet_cat_id"].ToString();
                }
                else
                {
                    dietcat.dietID = "";
                }
                if (rdr["diet_cat_name"].ToString() != "")
                {
                    dietcat.dietcatName = rdr["diet_cat_name"].ToString();
                }
                else
                {
                    dietcat.dietcatName = "";
                }

                objDietcat.Add(dietcat);
            }
            rdr.Close();
            return objDietcat;
        }

        public List<FoodCategory> GetFoodCategory()
        {
            string packageName = "PKG_FNB.GetFoodCategory";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetFoodCategory(packageName, parameterList);
        }
        private List<FoodCategory> GetFoodCategory(string packageName, OracleParameter[] parameterList)
        {
            List<FoodCategory> objFoodcat = new List<FoodCategory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodCategory foodCat = new FoodCategory();
                if (rdr["CAT_ID"].ToString() != "")
                {
                    foodCat.FoodID = rdr["CAT_ID"].ToString();
                }
                else
                {
                    foodCat.FoodID = "";
                }
                if (rdr["CAT_NAME"].ToString() != "")
                {
                    foodCat.FoodcatName = rdr["CAT_NAME"].ToString();
                }
                else
                {
                    foodCat.FoodcatName = "";
                }
                objFoodcat.Add(foodCat);
            }
            rdr.Close();
            return objFoodcat;
        }


        public short InsertFoodItem(FoodItem  Foodcat)
        {
            packageName = "PKG_FNB.Insert_Food_Item";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pfooditemName",OracleDbType.Varchar2,60,Foodcat.ItemName,ParameterDirection.Input),
                new OracleParameter("PdietCatid",OracleDbType.Varchar2,60,Foodcat.DietCatID,ParameterDirection.Input),
                new OracleParameter("PfoodCatid",OracleDbType.Varchar2,60,Foodcat.FoodCatID,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,60,Foodcat.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Foodcat.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Foodcat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Foodcat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Foodcat.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public short UpdateFoodItem(FoodItem foodcat)
        {
            packageName = "PKG_FNB.update_Food_Item";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pitemid",OracleDbType.Varchar2,60,foodcat.ItemID,ParameterDirection.Input),
                new OracleParameter("pfooditemName",OracleDbType.Varchar2,100,foodcat.ItemName,ParameterDirection.Input),
                new OracleParameter("PdietCatid",OracleDbType.Varchar2,60,foodcat.DietCatID,ParameterDirection.Input),
                new OracleParameter("PfoodCatid",OracleDbType.Varchar2,60,foodcat.FoodCatID,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,60,foodcat.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,foodcat.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,foodcat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,foodcat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,foodcat.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<FoodItem> LoadFoodItem()
        {
            string packageName = "PKG_FNB.LoadFoodItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadFoodItem(packageName, parameterList);
        }
        private List<FoodItem> LoadFoodItem(string packageName, OracleParameter[] parameterList)
        {
            List<FoodItem> objFood = new List<FoodItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodItem foodItem = new FoodItem();
                if (rdr["item_id"].ToString() != "")
                {
                    foodItem.ItemID = rdr["item_id"].ToString();
                }
                else
                {
                    foodItem.ItemID = "";
                }
                if (rdr["item_name"].ToString() != "")
                {
                    foodItem.ItemName = rdr["item_name"].ToString();
                }
                else
                {
                    foodItem.ItemName = "";
                }

                if (rdr["diet_cat_id"].ToString() != "")
                {
                    foodItem.DietCatID = rdr["diet_cat_id"].ToString();
                }
                else
                {
                    foodItem.DietCatID = "";
                }

                if (rdr["food_cat_id"].ToString() != "")
                {
                    foodItem.FoodCatID = rdr["food_cat_id"].ToString();
                }
                else
                {
                    foodItem.FoodCatID = "";
                }
                if (rdr["Remarks"].ToString() != "")
                {
                    foodItem.Remarks = rdr["Remarks"].ToString();
                }
                else
                {
                    foodItem.Remarks = "";
                }
                objFood.Add(foodItem);
            }
            rdr.Close();
            return objFood;
        }

        public string  InsertFoodMaster(FoodMaster Fm)
        {
            packageName = "PKG_FNB.InsertFoodMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("poodID",OracleDbType.Varchar2,100,null,ParameterDirection.Output),
                new OracleParameter("pfoodName",OracleDbType.Varchar2,100,Fm.FoodName,ParameterDirection.Input),
                new OracleParameter("pfoodcatid",OracleDbType.Varchar2,60,Fm.CatID,ParameterDirection.Input),
                new OracleParameter("punitid",OracleDbType.Varchar2,60,Fm.UnitId,ParameterDirection.Input),
                //new OracleParameter("pfoodimage",OracleDbType.Varchar2,60,Fm.FoodImage,ParameterDirection.Input),
                new OracleParameter("pisnormal",OracleDbType.Varchar2,60,Fm.IsNormal,ParameterDirection.Input),
                new OracleParameter("pdiabetic",OracleDbType.Varchar2,60,Fm.IsDiabetic,ParameterDirection.Input),
                new OracleParameter("phighprotein",OracleDbType.Varchar2,60,Fm.IsHighprotein,ParameterDirection.Input),
                new OracleParameter("plowprotein",OracleDbType.Varchar2,60,Fm.IsLowProtein,ParameterDirection.Input),
                new OracleParameter("prental",OracleDbType.Varchar2,60,Fm.IsRenal,ParameterDirection.Input),
                new OracleParameter("phighfat",OracleDbType.Varchar2,60,Fm.IsHighFat,ParameterDirection.Input),
                new OracleParameter("plowfat",OracleDbType.Varchar2,60,Fm.IsLowFat,ParameterDirection.Input),
                new OracleParameter("prate",OracleDbType.Double,60,Fm.Price,ParameterDirection.Input),
                new OracleParameter("pfoodremarks",OracleDbType.Varchar2,60,Fm.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Fm.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Fm.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Fm.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Fm.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
        }

        public short UpdateFoodMaster(FoodMaster Fm)
        {
            packageName = "PKG_FNB.updateFoodMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pfoodid",OracleDbType.Varchar2,10,Fm.FoodID,ParameterDirection.Input),
                new OracleParameter("pfoodName",OracleDbType.Varchar2,100,Fm.FoodName,ParameterDirection.Input),
                new OracleParameter("pfoodcatid",OracleDbType.Varchar2,60,Fm.CatID,ParameterDirection.Input),
                new OracleParameter("punitid",OracleDbType.Varchar2,60,Fm.UnitId,ParameterDirection.Input),
                //new OracleParameter("pfoodimage",OracleDbType.Varchar2,60,Fm.FoodImage,ParameterDirection.Input),
                new OracleParameter("pisnormal",OracleDbType.Varchar2,60,Fm.IsNormal,ParameterDirection.Input),
                new OracleParameter("pdiabetic",OracleDbType.Varchar2,60,Fm.IsDiabetic,ParameterDirection.Input),
                new OracleParameter("phighprotein",OracleDbType.Varchar2,60,Fm.IsHighprotein,ParameterDirection.Input),
                new OracleParameter("plowprotein",OracleDbType.Varchar2,60,Fm.IsLowProtein,ParameterDirection.Input),
                new OracleParameter("prental",OracleDbType.Varchar2,60,Fm.IsRenal,ParameterDirection.Input),
                new OracleParameter("phighfat",OracleDbType.Varchar2,60,Fm.IsHighFat,ParameterDirection.Input),
                new OracleParameter("plowfat",OracleDbType.Varchar2,60,Fm.IsLowFat,ParameterDirection.Input),
                new OracleParameter("prate",OracleDbType.Double,60,Fm.Price,ParameterDirection.Input),
                new OracleParameter("pfoodremarks",OracleDbType.Varchar2,60,Fm.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Fm.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Fm.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Fm.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Fm.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<FoodMaster> LoadFoodMaster()
        {
            string packageName = "PKG_FNB.LoadFoodMaster";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadFoodMaster(packageName, parameterList);
        }
        private List<FoodMaster> LoadFoodMaster(string packageName, OracleParameter[] parameterList)
        {
            List<FoodMaster> objFood = new List<FoodMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodMaster foodItem = new FoodMaster();
                if (rdr["FOOD_ID"].ToString() != "")
                {
                    foodItem.FoodID = rdr["FOOD_ID"].ToString();
                }
                else
                {
                    foodItem.FoodID = "";
                }
                if (rdr["FOOD_NAME"].ToString() != "")
                {
                    foodItem.FoodName = rdr["FOOD_NAME"].ToString();
                }
                else
                {
                    foodItem.FoodName = "";
                }
                if (rdr["cat_id"].ToString() != "")
                {
                    foodItem.CatID = rdr["cat_id"].ToString();
                }
                else
                {
                    foodItem.CatID = "";
                }

                if (rdr["GRP_ID"].ToString() != "")
                {
                    foodItem.GrpID = rdr["GRP_ID"].ToString();
                }
                else
                {
                    foodItem.GrpID = "";
                }

                if (rdr["UNIT_ID"].ToString() != "")
                {
                    foodItem.UnitId = rdr["UNIT_ID"].ToString();
                }
                else
                {
                    foodItem.UnitId = "";
                }
                if (rdr["FOOD_IMAGE"].ToString() != "")
                {
                    foodItem.FoodImage = rdr["FOOD_IMAGE"].ToString();
                }
                else
                {
                    foodItem.FoodImage = "";
                }
                if (rdr["IS_NORMAL"].ToString() != "")
                {
                    foodItem.IsNormal  = rdr["IS_NORMAL"].ToString();
                }
                
                if (rdr["IS_DIABETIC"].ToString() != "")
                {
                    foodItem.IsDiabetic = rdr["IS_DIABETIC"].ToString();
                }
                
                if (rdr["IS_HIGH_PROTEIN"].ToString() != "")
                {
                    foodItem.IsHighprotein = rdr["IS_HIGH_PROTEIN"].ToString();
                }
                
                if (rdr["IS_LOW_PROTEIN"].ToString() != "")
                {
                    foodItem.IsLowProtein = rdr["IS_LOW_PROTEIN"].ToString();
                }

                if (rdr["IS_RENAL"].ToString() != "")
                {
                    foodItem.IsRenal = rdr["IS_RENAL"].ToString();
                }

                if (rdr["IS_HIGH_FAT"].ToString() != "")
                {
                    foodItem.IsHighFat = rdr["IS_HIGH_FAT"].ToString();
                }

                if (rdr["IS_LOW_FAT"].ToString() != "")
                {
                    foodItem.IsLowFat = rdr["IS_LOW_FAT"].ToString();
                }
               
                if (rdr["PRICE"].ToString() != "")
                {
                    foodItem.Price  = Convert.ToDouble(rdr["PRICE"]);
                }
                else
                {
                    foodItem.Remarks = "";
                }
                if (rdr["REMARKS"].ToString() != "")
                {
                    foodItem.Remarks = rdr["REMARKS"].ToString();
                }
                else
                {
                    foodItem.Remarks = "";
                }

                objFood.Add(foodItem);
            }
            rdr.Close();
            return objFood;
        }


        public short InsertFoodMenuSetup(FoodMenuSetup FMS)
        {
            packageName = "PKG_FNB.insertfoodmenusetup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pfoodmenuName",OracleDbType.Varchar2,60,FMS.MenuName,ParameterDirection.Input),
                new OracleParameter("prate",OracleDbType.Double ,60,FMS.Rate,ParameterDirection.Input),
                new OracleParameter("pfoodremarks",OracleDbType.Varchar2,60,FMS.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,FMS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,FMS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public short UpdateMenuFoodItem(FoodMenuSetup FMS)
        {
            packageName = "PKG_FNB.UpdateFoodmenusetup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pfoodmenuid",OracleDbType.Varchar2,60,FMS.MenuID,ParameterDirection.Input),
                new OracleParameter("pfoodmenuName",OracleDbType.Varchar2,100,FMS.MenuName,ParameterDirection.Input),
                new OracleParameter("prate",OracleDbType.Double,30,FMS.Rate,ParameterDirection.Input),
                new OracleParameter("pfoodremarks",OracleDbType.Varchar2,60,FMS.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,FMS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,FMS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<FoodMenuSetup> LoadFoodMenuSetup()
        {
            string packageName = "PKG_FNB.LoadFoodMenuSetup";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadFoodMenuSetup(packageName, parameterList);
        }
        private List<FoodMenuSetup> LoadFoodMenuSetup(string packageName, OracleParameter[] parameterList)
        {
            List<FoodMenuSetup> objFood = new List<FoodMenuSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodMenuSetup foodItem = new FoodMenuSetup();
                if (rdr["menu_id"].ToString() != "")
                {
                    foodItem.MenuID = rdr["menu_id"].ToString();
                }
                else
                {
                    foodItem.MenuID = "";
                }
                if (rdr["menu_name"].ToString() != "")
                {
                    foodItem.MenuName = rdr["menu_name"].ToString();
                }
                else
                {
                    foodItem.MenuName = "";
                }

                if (rdr["remarks"].ToString() != "")
                {
                    foodItem.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    foodItem.Remarks = "";
                }

                foodItem.Rate = Convert.ToDouble(rdr["rate"].ToString());

                objFood.Add(foodItem);
            }
            rdr.Close();
            return objFood;
        }

        public short InsertServiceSetup(ServiceSetup FS)
        {
            packageName = "PKG_FNB.insertServiceSetup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pserviceName",OracleDbType.Varchar2,200,FS.ServiceName,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2,300,FS.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,FS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,FS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,FS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,FS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public short UpdateServiceSetup(ServiceSetup FS)
        {
            packageName = "PKG_FNB.UpdateServicemenusetup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pserviceid",OracleDbType.Varchar2,60,FS.ServiceID,ParameterDirection.Input),
                new OracleParameter("pserviceName",OracleDbType.Varchar2,200,FS.ServiceName,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,FS.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,FS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,FS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,FS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,FS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<ServiceSetup> LoadServiceSetup()
        {
            string packageName = "PKG_FNB.LoadServiceMenuSetup";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadServiceSetup(packageName, parameterList);
        }
        private List<ServiceSetup> LoadServiceSetup(string packageName, OracleParameter[] parameterList)
        {
            List<ServiceSetup> objFood = new List<ServiceSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ServiceSetup objSetup = new ServiceSetup();
                if (rdr["service_id"].ToString() != "")
                {
                    objSetup.ServiceID = rdr["service_id"].ToString();
                }
                else
                {
                    objSetup.ServiceID = "";
                }
                if (rdr["service_name"].ToString() != "")
                {
                    objSetup.ServiceName = rdr["service_name"].ToString();
                }
                else
                {
                    objSetup.ServiceName = "";
                }

                if (rdr["remarks"].ToString() != "")
                {
                    objSetup.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    objSetup.Remarks = "";
                }

                objFood.Add(objSetup);
            }
            rdr.Close();
            return objFood;
        }

        public List<FoodItemRO> GetFoodItem(string where)
        {
            string packageName = "PKG_FNB_REPORTS.GetFoodItems";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PWhere",OracleDbType.Varchar2,60,where,ParameterDirection.Input),

                };
            return GetFoodItem(packageName, parameterList);
        }
        private List<FoodItemRO> GetFoodItem(string packageName, OracleParameter[] parameterList)
        {
            List<FoodItemRO> objFood = new List<FoodItemRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodItemRO objFI = new FoodItemRO();
                if (rdr["food_id"].ToString() != "")
                {
                    objFI.FoodID = rdr["food_id"].ToString();
                }
                else
                {
                    objFI.FoodID = "";
                }
                if (rdr["food_name"].ToString() != "")
                {
                    objFI.FoodName = rdr["food_name"].ToString();
                }
                else
                {
                    objFI.FoodName = "";
                }

                if (rdr["price"].ToString() != "")
                {
                    objFI.NetPrice = Convert.ToDouble(rdr["price"].ToString());
                }
                else
                {
                    objFI.NetPrice = 0;
                }
                if (rdr["cat_name"].ToString() != "")
                {
                    objFI.CatName = rdr["cat_name"].ToString();
                }
                else
                {
                    objFI.CatName = "";
                }

                objFood.Add(objFI);
            }
            rdr.Close();
            return objFood;
        }



        public short InsertFoodTypeSetup(FoodMenuType FMS)
        {
            packageName = "PKG_FNB.InsertFoodMenuType";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ptypeName",OracleDbType.Varchar2,60,FMS.FoodTypeName,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,60,FMS.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,FMS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,FMS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public short UpdateFoodTypeSetup(FoodMenuType FMS)
        {
            packageName = "PKG_FNB.UpdateFoodMenuType";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pfoodid",OracleDbType.Varchar2,60,FMS.FoodTypeID,ParameterDirection.Input),
                new OracleParameter("ptypeName",OracleDbType.Varchar2,100,FMS.FoodTypeName,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,60,FMS.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,FMS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,FMS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<FoodMenuType> GetFoodMenuType()
        {
            string packageName = "PKG_FNB.LoadFoodType";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetFoodMenuType(packageName, parameterList);
        }
        private List<FoodMenuType> GetFoodMenuType(string packageName, OracleParameter[] parameterList)
        {
            List<FoodMenuType> objFood = new List<FoodMenuType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodMenuType objFI = new FoodMenuType();
                if (rdr["type_id"].ToString() != "")
                {
                    objFI.FoodTypeID = rdr["type_id"].ToString();
                }
                else
                {
                    objFI.FoodTypeID = "";
                }
                if (rdr["type_name"].ToString() != "")
                {
                    objFI.FoodTypeName = rdr["type_name"].ToString();
                }
                else
                {
                    objFI.FoodTypeName = "";
                }

                if (rdr["remarks"].ToString() != "")
                {
                    objFI.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    objFI.Remarks = "";
                }
               

                objFood.Add(objFI);
            }
            rdr.Close();
            return objFood;
        }


        public List<FoodMenuItemSetup> GetFoodMenuItemSetup()
        {
            string packageName = "PKG_FNB.GetMenuSetup";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetFoodMenuItemSetup(packageName, parameterList);
        }
        private List<FoodMenuItemSetup> GetFoodMenuItemSetup(string packageName, OracleParameter[] parameterList)
        {
            List<FoodMenuItemSetup> objFood = new List<FoodMenuItemSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodMenuItemSetup objFI = new FoodMenuItemSetup();
                if (rdr["menu_id"].ToString() != "")
                {
                    objFI.FoodMenuID = rdr["menu_id"].ToString();
                }
                else
                {
                    objFI.FoodMenuID = "";
                }
                if (rdr["menu_name"].ToString() != "")
                {
                    objFI.FoodMenuName = rdr["menu_name"].ToString();
                }
                else
                {
                    objFI.FoodTypeName = "";
                }

                objFood.Add(objFI);
            }
            rdr.Close();
            return objFood;
        }

        public List<FoodMenuItemSetup> GetFoodTypeSetup()
        {
            string packageName = "PKG_FNB.GetTypeSetup";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetFoodTypeSetup(packageName, parameterList);
        }
        private List<FoodMenuItemSetup> GetFoodTypeSetup(string packageName, OracleParameter[] parameterList)
        {
            List<FoodMenuItemSetup> objFood = new List<FoodMenuItemSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodMenuItemSetup objFI = new FoodMenuItemSetup();
                if (rdr["type_id"].ToString() != "")
                {
                    objFI.FoodTypeID = rdr["type_id"].ToString();
                }
                else
                {
                    objFI.FoodTypeID = "";
                }
                if (rdr["type_name"].ToString() != "")
                {
                    objFI.FoodTypeName = rdr["type_name"].ToString();
                }
                else
                {
                    objFI.FoodTypeName = "";
                }

                objFood.Add(objFI);
            }
            rdr.Close();
            return objFood;
        }


        public short InsertFoodRateItem(string strFoodId,double  dblRate,FoodMenuItemSetup FMS)
        {
            packageName = "PKG_FNB.InsertFoodMenuItem";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pmenuid",OracleDbType.Varchar2,60,FMS.FoodMenuID,ParameterDirection.Input),
                new OracleParameter("Ptypeid",OracleDbType.Varchar2,60,FMS.FoodTypeID,ParameterDirection.Input),
                new OracleParameter("Pfoodid",OracleDbType.Varchar2,60,strFoodId,ParameterDirection.Input),
                new OracleParameter("Pfoodrate",OracleDbType.Varchar2,60,dblRate,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,60,FMS.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,FMS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,FMS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public short UpdateFoodRateItem(string strFoodId,double  dblRate,FoodMenuItemSetup FMS)
        {
            packageName = "PKG_FNB.UpdateFoodMenuItem";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pmenuid",OracleDbType.Varchar2,60,FMS.FoodMenuID,ParameterDirection.Input),
                new OracleParameter("Ptypeid",OracleDbType.Varchar2,60,FMS.FoodTypeID,ParameterDirection.Input),
                new OracleParameter("Pfoodid",OracleDbType.Varchar2,60,strFoodId,ParameterDirection.Input),
                new OracleParameter("Pfoodrate",OracleDbType.Varchar2,60,dblRate,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,60,FMS.Remarks,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,FMS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,FMS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,FMS.EntryParameter.MachineID,ParameterDirection.Input),
           };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }


        public List<FoodMenuItemSetup> LoadFoodItemrate()
        {
            string packageName = "PKG_FNB.LoadFoodMenuItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LaodFoodItemrate(packageName, parameterList);
        }
        private List<FoodMenuItemSetup> LaodFoodItemrate(string packageName, OracleParameter[] parameterList)
        {
            List<FoodMenuItemSetup> objFood = new List<FoodMenuItemSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodMenuItemSetup objFI = new FoodMenuItemSetup();
                if (rdr["menu_id"].ToString() != "")
                {
                    objFI.FoodMenuID = rdr["menu_id"].ToString();
                }
                else
                {
                    objFI.FoodTypeID = "";
                }
                if (rdr["menu_name"].ToString() != "")
                {
                    objFI.FoodMenuName = rdr["menu_name"].ToString();
                }
                else
                {
                    objFI.FoodTypeName = "";
                }
                if (rdr["type_id"].ToString() != "")
                {
                    objFI.FoodTypeID = rdr["type_id"].ToString();
                }
                else
                {
                    objFI.FoodTypeID = "";
                }

                if (rdr["remarks"].ToString() != "")
                {
                    objFI.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    objFI.Remarks = "";
                }


                objFood.Add(objFI);
            }
            rdr.Close();
            return objFood;
        }

        public List<FoodMenuItemSetup> DisplayFoodItemrate(string where)
        {
            string packageName = "PKG_FNB.DisplayFoodMenu";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,where,ParameterDirection.Input),
                };
            return DisplayFoodItemrate(packageName, parameterList);
        }
        private List<FoodMenuItemSetup> DisplayFoodItemrate(string packageName, OracleParameter[] parameterList)
        {
            List<FoodMenuItemSetup> objFood = new List<FoodMenuItemSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodMenuItemSetup objFI = new FoodMenuItemSetup();
                if (rdr["menu_id"].ToString() != "")
                {
                    objFI.FoodMenuID = rdr["menu_id"].ToString();
                }
                else
                {
                    objFI.FoodMenuID = "";
                }
                if (rdr["type_id"].ToString() != "")
                {
                    objFI.FoodTypeID = rdr["type_id"].ToString();
                }
                else
                {
                    objFI.FoodTypeID = "";
                }
                if (rdr["remarks"].ToString() != "")
                {
                    objFI.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    objFI.Remarks = "";
                }
                if (rdr["food_id"].ToString() != "")
                {
                    objFI.FoodItemID = rdr["food_id"].ToString();
                }
                else
                {
                    objFI.FoodItemID = "";
                }


                objFood.Add(objFI);
            }
            rdr.Close();
            return objFood;
        }


        public short InsertMealsetup(MealSetup  ms)
        {
            packageName = "PKG_FNB.insertMealsettup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pmealName",OracleDbType.Varchar2,60,ms.MealName,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,60,ms.Remarks,ParameterDirection.Input),
                new OracleParameter("startTime",OracleDbType.Varchar2,60,ms.StartTime,ParameterDirection.Input),
                new OracleParameter("Endtime",OracleDbType.Varchar2,60,ms.EndTime,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,ms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,ms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,ms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,ms.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public short UpdateMealsetup(MealSetup ms)
        {
            packageName = "PKG_FNB.UpdatMealsettup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pmealID",OracleDbType.Varchar2,60,ms.MealID,ParameterDirection.Input),
                new OracleParameter("pmealName",OracleDbType.Varchar2,60,ms.MealName,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,60,ms.Remarks,ParameterDirection.Input),
                new OracleParameter("startTime",OracleDbType.Varchar2,60,ms.StartTime,ParameterDirection.Input),
                new OracleParameter("Endtime",OracleDbType.Varchar2,60,ms.EndTime,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,ms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,ms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,ms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,ms.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }


        public List<MealSetup>LoadmealSetup()
        {
            string packageName = "PKG_FNB.LoadmealSetup";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadmealSetup(packageName, parameterList);
        }
        private List<MealSetup> LoadmealSetup(string packageName, OracleParameter[] parameterList)
        {
            List<MealSetup> objFood = new List<MealSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MealSetup objMs = new MealSetup();
                if (rdr["meal_id"].ToString() != "")
                {
                    objMs.MealID = rdr["meal_id"].ToString();
                }
                else
                {
                    objMs.MealID = "";
                }
                if (rdr["meal_name"].ToString() != "")
                {
                    objMs.MealName = rdr["meal_name"].ToString();
                }
                else
                {
                    objMs.MealName = "";
                }
                if (rdr["remarks"].ToString() != "")
                {
                    objMs.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    objMs.Remarks = "";
                }

                if (rdr["meal_start_time"].ToString() != "")
                {
                    objMs.StartTime = rdr["meal_start_time"].ToString();
                }
                else
                {
                    objMs.StartTime = "";
                }


                if (rdr["meal_end_time"].ToString() != "")
                {
                    objMs.EndTime = rdr["meal_end_time"].ToString();
                }
                else
                {
                    objMs.EndTime = "";
                }

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }

        public List<MealSetup> GetMealID()
        {
            string packageName = "PKG_FNB.LoadmealSetup";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetMealID(packageName, parameterList);
        }
        private List<MealSetup> GetMealID(string packageName, OracleParameter[] parameterList)
        {
            List<MealSetup> objFood = new List<MealSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MealSetup objMs = new MealSetup();
                if (rdr["meal_id"].ToString() != "")
                {
                    objMs.MealID = rdr["meal_id"].ToString();
                }
                else
                {
                    objMs.MealID = "";
                }
                if (rdr["meal_name"].ToString() != "")
                {
                    objMs.MealName = rdr["meal_name"].ToString();
                }
                else
                {
                    objMs.MealName = "";
                }
                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }


        public List<WeeklySetupMeal> LoadWeeklyMealSetup()
        {
            string packageName = "PKG_FNB.GetMealId";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadWeeklyMealSetup(packageName, parameterList);
        }
        private List<WeeklySetupMeal> LoadWeeklyMealSetup(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklySetupMeal> objFood = new List<WeeklySetupMeal>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklySetupMeal objMs = new WeeklySetupMeal();
                if (rdr["meal_id"].ToString() != "")
                {
                    objMs.MealID = rdr["meal_id"].ToString();
                }
                else
                {
                    objMs.MealID = "";
                }
                if (rdr["meal_name"].ToString() != "")
                {
                    objMs.MealName = rdr["meal_name"].ToString();
                }
                else
                {
                    objMs.MealName = "";
                }
                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }

        public short InsertWeeklysetup(WeeklySetupMeal WS)
        {
            packageName = "PKG_FNB.insertempweeklysetupmenu";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pwkdayno",OracleDbType.Varchar2,60,WS.WeekDayNo,ParameterDirection.Input),
                new OracleParameter("psetmenutypeid",OracleDbType.Varchar2,60,WS.WeeklySetMenuTypeID,ParameterDirection.Input),
                new OracleParameter("pmealid",OracleDbType.Varchar2,60,WS.MealID,ParameterDirection.Input),
                new OracleParameter("psetmenuid",OracleDbType.Varchar2,60,WS.SetMenuID,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,WS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,WS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,WS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,WS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public short UpdateWeeklysetup(WeeklySetupMeal WS)
        {
            packageName = "PKG_FNB.Updatempweeklysetupmenu";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pweekdayno",OracleDbType.Varchar2,60,WS.WeekDayNo,ParameterDirection.Input),
                new OracleParameter("psetmenutypeid",OracleDbType.Varchar2,60,WS.WeeklySetMenuTypeID,ParameterDirection.Input),
                new OracleParameter("pmealid",OracleDbType.Varchar2,60,WS.MealID,ParameterDirection.Input),
                new OracleParameter("psetmenuid",OracleDbType.Varchar2,60,WS.SetMenuID,ParameterDirection.Input),

                new OracleParameter("poldWdayno",OracleDbType.Varchar2,60,WS.OldWeekDayNo,ParameterDirection.Input),
                new OracleParameter("poldsetmenutypeid",OracleDbType.Varchar2,60,WS.OldSetMenuTypeID,ParameterDirection.Input),
                new OracleParameter("poldmenuid",OracleDbType.Varchar2,60,WS.OldMealID,ParameterDirection.Input),
                new OracleParameter("poldsetmenuid",OracleDbType.Varchar2,60,WS.OldSetMenuID,ParameterDirection.Input),

                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,WS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,WS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,WS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,WS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }

        public List<WeeklySetupMeal> GetWeeklyMealSetup()
        {
            string packageName = "PKG_FNB.LoadweeklySetmenu";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetWeeklyMealSetup(packageName, parameterList);
        }
        private List<WeeklySetupMeal> GetWeeklyMealSetup(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklySetupMeal> objFood = new List<WeeklySetupMeal>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklySetupMeal objMs = new WeeklySetupMeal();
                if (rdr["wk_day_no"].ToString() != "")
                {
                    objMs.WeekDayNo = rdr["wk_day_no"].ToString();
                }
                else
                {
                    objMs.WeekDayNo = "";
                }
                if (rdr["meal_id"].ToString() != "")
                {
                    objMs.MealID  = rdr["meal_id"].ToString();
                }
                else
                {
                    objMs.MealID = "";
                }

                if (rdr["meal_name"].ToString() != "")
                {
                    objMs.MealName = rdr["meal_name"].ToString();
                }
                else
                {
                    objMs.MealName = "";
                }


                if (rdr["setmenu_id"].ToString() != "")
                {
                    objMs.SetMenuID = rdr["setmenu_id"].ToString();
                }
                else
                {
                    objMs.SetMenuID = "";
                }

                if (rdr["type_id"].ToString() != "")
                {
                    objMs.WeeklySetMenuTypeID = rdr["type_id"].ToString();
                }
                else
                {
                    objMs.WeeklySetMenuTypeID = "";
                }
                if (rdr["type_name"].ToString() != "")
                {
                    objMs.WeeklySetMenuTypeName = rdr["type_name"].ToString();
                }
                else
                {
                    objMs.WeeklySetMenuTypeName = "";
                }

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }

        public List<WeeklyEmpMealRegister> GetWeeklySetmenu()
        {
            string packageName = "PKG_FNB.GetSetmenu";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetWeeklyMealRegister(packageName, parameterList);
        }
        private List<WeeklyEmpMealRegister> GetWeeklyMealRegister(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklyEmpMealRegister> objFood = new List<WeeklyEmpMealRegister>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklyEmpMealRegister objMs = new WeeklyEmpMealRegister();
                if (rdr["setmenu_id"].ToString() != "")
                {
                    objMs.Setmenuid = rdr["setmenu_id"].ToString();
                }
                else
                {
                    objMs.Setmenuid = "";
                }
                

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }

        public List<WeeklyEmpMealRegister> DisplaySetmenuDetails(string Where)
        {
            string packageName = "PKG_FNB.DisplaymenuDetails";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,Where,ParameterDirection.Input)

                };
            return GetWeeklySetmenuDetails(packageName, parameterList);
        }
        private List<WeeklyEmpMealRegister> GetWeeklySetmenuDetails(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklyEmpMealRegister> objFood = new List<WeeklyEmpMealRegister>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklyEmpMealRegister objMs = new WeeklyEmpMealRegister();
                //if (rdr["wk_day_no"].ToString() != "")
                //{
                //    objMs.WeekDayNo = rdr["wk_day_no"].ToString();
                //}
                //else
                //{
                //    objMs.WeekDayNo = "";
                //}

                //if (rdr["meal_id"].ToString() != "")
                //{
                //    objMs.mealid = rdr["meal_id"].ToString();
                //}
                //else
                //{
                //    objMs.mealid = "";
                //}
                //if (rdr["meal_name"].ToString() != "")
                //{
                //    objMs.mealName = rdr["meal_name"].ToString();
                //}
                //else
                //{
                //    objMs.mealid = "";
                //}

                if (rdr["rate"].ToString() != "")
                {
                    objMs.Bill = Convert.ToDouble(rdr["rate"].ToString());
                }
                else
                {
                    objMs.Bill = 0;
                }

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }
        public string InsertMealRegistermaster(WeeklyEmpMealRegister WS)
        {
            packageName = "PKG_FNB.InsertMealRegistermaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_meal_id",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
                new OracleParameter("pempid",OracleDbType.Varchar2,60,WS.empId,ParameterDirection.Input),
                new OracleParameter("PNetAmount",OracleDbType.Double,60,WS.NetAmount,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,WS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,WS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,WS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,WS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
        }
        public string  InsertMealRegister(string strRefNo,string setMenu, double dblMealRate, WeeklyEmpMealRegister  WS)
        {
            packageName = "PKG_FNB.InsertMealRegister";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_meal_id",OracleDbType.Varchar2,60,strRefNo,ParameterDirection.Input),
                new OracleParameter("pMealdate",OracleDbType.Varchar2,60,WS.MealDate,ParameterDirection.Input),
                new OracleParameter("pweekdayno",OracleDbType.Varchar2,60,WS.WeekDayNo,ParameterDirection.Input),
                new OracleParameter("pmealid",OracleDbType.Varchar2,60,WS.mealid,ParameterDirection.Input),
                //new OracleParameter("psetmenuid",OracleDbType.Varchar2,60,WS.Setmenuid,ParameterDirection.Input),
                new OracleParameter("psetmenuid",OracleDbType.Varchar2,60,setMenu,ParameterDirection.Input),

                new OracleParameter("pempid",OracleDbType.Varchar2,60,WS.empId,ParameterDirection.Input),
                //new OracleParameter("pbill",OracleDbType.Varchar2,60,WS.Bill,ParameterDirection.Input),
                new OracleParameter("pbill",OracleDbType.Varchar2,60,dblMealRate,ParameterDirection.Input),
                new OracleParameter("psubsidy",OracleDbType.Varchar2,60,WS.subsidy,ParameterDirection.Input),
                //new OracleParameter("pBillPer",OracleDbType.Varchar2,60,WS.Billrate,ParameterDirection.Input),
                new OracleParameter("pBillPer",OracleDbType.Varchar2,60,WS.Billrate,ParameterDirection.Input),
                new OracleParameter("pNetAmount",OracleDbType.Double,60,WS.NetAmount,ParameterDirection.Input),

                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,WS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,WS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,WS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,WS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            return "1";
        }

        public List<WeeklyEmpMealRegister> GetWeeklySetupregister(string Where, string Where1)
        {
            string packageName = "PKG_FNB.LoadmenuDetails";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,Where,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,Where1,ParameterDirection.Input),

                };
            return GetWeeklySetupregister(packageName, parameterList);
        }
        private List<WeeklyEmpMealRegister> GetWeeklySetupregister(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklyEmpMealRegister> objFood = new List<WeeklyEmpMealRegister>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklyEmpMealRegister objMs = new WeeklyEmpMealRegister();
                if (rdr["MEAL_DATE"].ToString() != "")
                {
                    objMs.MealDate = rdr["MEAL_DATE"].ToString();
                }
                else
                {
                    objMs.MealDate = "";
                }

                if (rdr["WK_DAY_NO"].ToString() != "")
                {
                    objMs.WeekDayNo  = rdr["WK_DAY_NO"].ToString();
                }
                else
                {
                    objMs.WeekDayNo = "";
                }
                if (rdr["MEAL_ID"].ToString() != "")
                {
                    objMs.mealid = rdr["MEAL_ID"].ToString();
                }
                else
                {
                    objMs.mealid = "";
                }
                //if (rdr["SETMENU_ID"].ToString() != "")
                //{
                //    objMs.Setmenuid = rdr["SETMENU_ID"].ToString();
                //}
                //else
                //{
                //    objMs.Setmenuid = "";
                //}
                if (rdr["EMP_ID"].ToString() != "")
                {
                    objMs.empId  = rdr["EMP_ID"].ToString();
                }
                else
                {
                    objMs.empId = "";
                }
                //if (rdr["BILL"].ToString() != "")
                //{
                //    objMs.Bill  =Convert.ToDouble(rdr["BILL"].ToString());
                //}
                //else
                //{
                //    objMs.Bill = 0;
                //}

                //if (rdr["SUBSIDY"].ToString() != "")
                //{
                //    objMs.subsidy  = Convert.ToDouble(rdr["SUBSIDY"].ToString());
                //}
                //else
                //{
                //    objMs.subsidy = 0;
                //}

                if (rdr["meal_reg_id"].ToString() != "")
                {
                    objMs.MealRegID = rdr["meal_reg_id"].ToString();
                }
                else
                {
                    objMs.MealRegID = "";
                }
                //if (rdr["dis_rate"].ToString() != "")
                //{
                //    objMs.Billrate = rdr["dis_rate"].ToString();
                //}
                //else
                //{
                //    objMs.Billrate = "";
                //}


                if (rdr["net_amount"].ToString() != "")
                {
                    objMs.NetAmount = Convert.ToDouble(rdr["net_amount"]);
                }
                else
                {
                    objMs.NetAmount = 0;
                }


                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }

        public short UpdateMealRegister(WeeklyEmpMealRegister WS)
        {
            packageName = "PKG_FNB.UpdateMealRegister";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pMealdate",OracleDbType.Varchar2,60,WS.MealDate,ParameterDirection.Input),
                new OracleParameter("pweekdayno",OracleDbType.Varchar2,60,WS.WeekDayNo,ParameterDirection.Input),
                new OracleParameter("pmealid",OracleDbType.Varchar2,60,WS.mealid,ParameterDirection.Input),
                new OracleParameter("psetmenuid",OracleDbType.Varchar2,60,WS.Setmenuid,ParameterDirection.Input),
                new OracleParameter("psetmenuitem",OracleDbType.Varchar2,60,WS.SetmenuItem,ParameterDirection.Input),
                new OracleParameter("pempid",OracleDbType.Varchar2,60,WS.empId,ParameterDirection.Input),
                new OracleParameter("pbill",OracleDbType.Double,60,WS.Bill,ParameterDirection.Input),
                new OracleParameter("psubsidy",OracleDbType.Double,60,WS.subsidy,ParameterDirection.Input),
                new OracleParameter("pBillPer",OracleDbType.Varchar2,60,WS.Billrate,ParameterDirection.Input),
                new OracleParameter("pNetAmount",OracleDbType.Double,60,WS.NetAmount,ParameterDirection.Input),
                new OracleParameter("pMealRegID",OracleDbType.Varchar2,60,WS.MealRegID,ParameterDirection.Input),

                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,WS.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,WS.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,WS.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,WS.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }


        public List<WeeklySetupMeal> LaodWeeklySetMenuType()
        {
            string packageName = "PKG_FNB.loadsetmenutype";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),

                };
            return LaodWeeklySetMenuType(packageName, parameterList);
        }
        private List<WeeklySetupMeal> LaodWeeklySetMenuType(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklySetupMeal> objFood = new List<WeeklySetupMeal>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklySetupMeal objMs = new WeeklySetupMeal();
                if (rdr["type_id"].ToString() != "")
                {
                    objMs.WeeklySetMenuTypeID = rdr["type_id"].ToString();
                }
                else
                {
                    objMs.WeeklySetMenuTypeID = "";
                }

                if (rdr["type_name"].ToString() != "")
                {
                    objMs.WeeklySetMenuTypeName = rdr["type_name"].ToString();
                }
                else
                {
                    objMs.WeeklySetMenuTypeName = "";
                }
                


                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }



        public List<WeeklyChart> LaodWeeklyChart(string strSetMenuTypeID)
        {
            string packageName = "PKG_FNB.loadWeekSetupChart";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("psetmenuid",OracleDbType.Varchar2,60,strSetMenuTypeID,ParameterDirection.Input),
                };
            return LaodWeeklyChart(packageName, parameterList);
        }
        private List<WeeklyChart> LaodWeeklyChart(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklyChart> objFood = new List<WeeklyChart>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklyChart objMs = new WeeklyChart();
                if (rdr["dayname"].ToString() != "")
                {
                    objMs.Day = rdr["dayname"].ToString();
                }
                else
                {
                    objMs.Day = "";
                }

                if (rdr["meal_name"].ToString() != "")
                {
                    objMs.MealName = rdr["meal_name"].ToString();
                }
                else
                {
                    objMs.MealName = "";
                }

                if (rdr["menu_name"].ToString() != "")
                {
                    objMs.menu_name = rdr["menu_name"].ToString();
                }
                else
                {
                    objMs.menu_name = "";
                }


                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }


        public List<FoodMenuItemSetup> GetVisitorsMenuItem(string where)
        {
            string packageName = "PKG_FNB.GetMenuItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,where,ParameterDirection.Input),
                };
            return GetVisitorsMenuItem(packageName, parameterList);
        }
        private List<FoodMenuItemSetup> GetVisitorsMenuItem(string packageName, OracleParameter[] parameterList)
        {
            List<FoodMenuItemSetup> objFood = new List<FoodMenuItemSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodMenuItemSetup objFI = new FoodMenuItemSetup();
                if (rdr["food_id"].ToString() != "")
                {
                    objFI.FoodItemID = rdr["food_id"].ToString();
                }
                else
                {
                    objFI.FoodItemID = "";
                }
                if (rdr["food_name"].ToString() != "")
                {
                    objFI.FoodItemName = rdr["food_name"].ToString();
                }
                else
                {
                    objFI.FoodItemName = "";
                }
                if (rdr["price"].ToString() != "")
                {
                    objFI.ItemRate = Convert.ToDouble(rdr["price"]);
                }
                else
                {
                    objFI.ItemRate = 0;
                }

                objFood.Add(objFI);
            }
            rdr.Close();
            return objFood;
        }


        public string InsertVisitorsMaster(Visitors Vs)
        {
            packageName = "PKG_FNB.insertVisitorsMenu";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pInv",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
                new OracleParameter("pTransacNo",OracleDbType.Varchar2,60,Vs.TransNo,ParameterDirection.Input),
                new OracleParameter("pvisName",OracleDbType.Varchar2,100,Vs.VName,ParameterDirection.Input),
                new OracleParameter("pDiscounttype",OracleDbType.Varchar2,60,Vs.DisType,ParameterDirection.Input),
                new OracleParameter("pDiscountRef",OracleDbType.Varchar2,60,Vs.DisRef,ParameterDirection.Input),
                new OracleParameter("pDiscountAuthority",OracleDbType.Varchar2,60,Vs.DisAuthority,ParameterDirection.Input),
                new OracleParameter("pdiscount",OracleDbType.Double,20,Vs.Discount,ParameterDirection.Input),
                new OracleParameter("pvat",OracleDbType.Double,60,Vs.Vat,ParameterDirection.Input),
                new OracleParameter("pNetPaid",OracleDbType.Double,60,Vs.NetPaid,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,2,Vs.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Vs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Vs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Vs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Vs.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
        }

        public short InsertVisitorsTran(string strInvNo, string strFoodID, double dblQnty, double dblRate, double dblDiscount, double dblTotal, Visitors Vs)
        {
            packageName = "PKG_FNB.insertvisitorstran";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pinvoicno",OracleDbType.Varchar2,60, strInvNo,ParameterDirection.Input),
                new OracleParameter("psetmenuid",OracleDbType.Varchar2,100,Vs.SetMenuID,ParameterDirection.Input),
                new OracleParameter("pfoodid",OracleDbType.Varchar2,100,strFoodID,ParameterDirection.Input),
                new OracleParameter("pqty",OracleDbType.Double,20,dblQnty,ParameterDirection.Input),
                new OracleParameter("prate",OracleDbType.Double,60,dblRate,ParameterDirection.Input),
                new OracleParameter("pdiscount",OracleDbType.Double,60,dblDiscount,ParameterDirection.Input),
                new OracleParameter("total",OracleDbType.Double,60,dblTotal,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,2,Vs.Active,ParameterDirection.Input),

                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Vs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Vs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Vs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Vs.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }


        public string InsertVisitorsOrderTran( Visitors Vs)
        {
            packageName = "PKG_FNB.InsertVisitorsOrderTran";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pInv",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
                new OracleParameter("pvo",OracleDbType.Varchar2,1000,Vs.VisOrders,ParameterDirection.Input),
                new OracleParameter("p_purpose_id",OracleDbType.Varchar2,4,Vs.PurposeID,ParameterDirection.Input),
                new OracleParameter("p_payment_string",OracleDbType.Varchar2,10000,Vs.PaymentString,ParameterDirection.Input),
                new OracleParameter("p_net_amt",OracleDbType.Double,100,Vs.NetPaid,ParameterDirection.Input),

                new OracleParameter("pvisName",OracleDbType.Varchar2,100,Vs.VName,ParameterDirection.Input),
                new OracleParameter("pDiscounttype",OracleDbType.Varchar2,100,Vs.DisType,ParameterDirection.Input),
                new OracleParameter("pDiscountRef",OracleDbType.Varchar2,100,Vs.DisRef,ParameterDirection.Input),
                new OracleParameter("pDiscountAuthority",OracleDbType.Varchar2,100,Vs.DisAuthority,ParameterDirection.Input),

                new OracleParameter("pdiscount",OracleDbType.Double,100,Vs.Discount,ParameterDirection.Input),
                new OracleParameter("pvat",OracleDbType.Double,100,Vs.Vat,ParameterDirection.Input),
                new OracleParameter("pNetPaid",OracleDbType.Double,100,Vs.NetPaid,ParameterDirection.Input),

                new OracleParameter("pentryby",OracleDbType.Varchar2 ,60,Vs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Vs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Vs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Vs.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
        }





        public List<Visitors> GetVisitors(string where)
        {
            string packageName = "PKG_FNB.GetVisitorsMenu";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    //new OracleParameter("pwhere",OracleDbType.Varchar2,60,where,ParameterDirection.Input),
                };
            return GetVisitors(packageName, parameterList);
        }
        private List<Visitors> GetVisitors(string packageName, OracleParameter[] parameterList)
        {
            List<Visitors> objVs = new List<Visitors>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Visitors objFI = new Visitors();
                if (rdr["invoice_no"].ToString() != "")
                {
                    objFI.InvoiceNo = rdr["invoice_no"].ToString();
                }
                else
                {
                    objFI.InvoiceNo = "";
                }
                if (rdr["name"].ToString() != "")
                {
                    objFI.VName = rdr["name"].ToString();
                }
                else
                {
                    objFI.VName = "";
                }
                objVs.Add(objFI);
            }
            rdr.Close();
            return objVs;
        }

        public List<Visitors> DisplaytVisitors(string where)
        {
            string packageName = "PKG_FNB.DisplayVisitorsMenu";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,where,ParameterDirection.Input),
                };
            return DisplaytVisitors(packageName, parameterList);
        }
        private List<Visitors> DisplaytVisitors(string packageName, OracleParameter[] parameterList)
        {
            List<Visitors> objVs = new List<Visitors>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Visitors objFI = new Visitors();
                if (rdr["invoice_no"].ToString() != "")
                {
                    objFI.InvoiceNo = rdr["invoice_no"].ToString();
                }
                else
                {
                    objFI.InvoiceNo = "";
                }
                if (rdr["name"].ToString() != "")
                {
                    objFI.VName = rdr["name"].ToString();
                }
                else
                {
                    objFI.VName = "";
                }

                if (rdr["discount"].ToString() != "")
                {
                    objFI.Discount =  Convert.ToDouble(rdr["discount"].ToString());
                }
                else
                {
                    objFI.Discount = 0;
                }


                if (rdr["vat"].ToString() != "")
                {
                    objFI.Vat = rdr["vat"].ToString();
                }
                else
                {
                    objFI.Vat = "";
                }

                if (rdr["net_paid"].ToString() != "")
                {
                    objFI.NetPaid =Convert.ToDouble(rdr["net_paid"].ToString());
                }
                else
                {
                    objFI.NetPaid = 0;
                }

                if (rdr["set_menu_id"].ToString() != "")
                {
                    objFI.SetMenuID = rdr["set_menu_id"].ToString();
                }
                else
                {
                    objFI.SetMenuID = "";
                }

                if (rdr["food_id"].ToString() != "")
                {
                    objFI.FoodID = rdr["food_id"].ToString();
                }
                else
                {
                    objFI.FoodID = "";
                }

                if (rdr["food_name"].ToString() != "")
                {
                    objFI.FoodName = rdr["food_name"].ToString();
                }
                else
                {
                    objFI.FoodName = "";
                }
                if (rdr["qty"].ToString() != "")
                {
                    objFI.Qnty = Convert.ToDouble(rdr["qty"].ToString());
                }
                else
                {
                    objFI.Qnty = 0;
                }
                if (rdr["rate"].ToString() != "")
                {
                    objFI.Rate  =  Convert.ToDouble(rdr["rate"].ToString());
                }
                else
                {
                    objFI.Rate = 0;
                }
                if (rdr["disc"].ToString() != "")
                {
                    objFI.ItemDiscount = Convert.ToDouble( rdr["disc"].ToString());
                }
                else
                {
                    objFI.ItemDiscount = 0;
                }
                if (rdr["total"].ToString() != "")
                {
                    objFI.Total  = Convert.ToDouble(rdr["total"].ToString());
                }
                else
                {
                    objFI.Total = 0;
                }

                objVs.Add(objFI);
            }
            rdr.Close();
            return objVs;
        }


        public int UpdateVisitorsMaster(string strInvoiceNo, Visitors Vs)
        {
            packageName = "PKG_FNB.UpdateVisitors";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pinvoicNo",OracleDbType.Varchar2,60,strInvoiceNo,ParameterDirection.Input),
                new OracleParameter("pTransacNo",OracleDbType.Varchar2,60,Vs.TransNo,ParameterDirection.Input),
                new OracleParameter("pvisName",OracleDbType.Varchar2,100,Vs.VName,ParameterDirection.Input),
                new OracleParameter("pDiscounttype",OracleDbType.Varchar2,60,Vs.DisType,ParameterDirection.Input),
                new OracleParameter("pDiscountRef",OracleDbType.Varchar2,60,Vs.DisRef,ParameterDirection.Input),
                new OracleParameter("pDiscountAuthority",OracleDbType.Varchar2,60,Vs.DisAuthority,ParameterDirection.Input),
                new OracleParameter("pdiscount",OracleDbType.Double,20,Vs.Discount,ParameterDirection.Input),
                new OracleParameter("pvat",OracleDbType.Double,60,Vs.Vat,ParameterDirection.Input),
                new OracleParameter("pNetPaid",OracleDbType.Double,60,Vs.NetPaid,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,2,Vs.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,Vs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,Vs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,Vs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,Vs.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }
        public List<FoodMaster> LoadFoodItemFromCat(string where)
        {
            string packageName = "PKG_FNB.GetFoodMasterItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,where,ParameterDirection.Input),
                };
            return LoadFoodItemFromCat(packageName, parameterList);
        }
        private List<FoodMaster> LoadFoodItemFromCat(string packageName, OracleParameter[] parameterList)
        {
            List<FoodMaster> objFood = new List<FoodMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodMaster foodItem = new FoodMaster();
                if (rdr["FOOD_ID"].ToString() != "")
                {
                    foodItem.FoodID = rdr["FOOD_ID"].ToString();
                }
                else
                {
                    foodItem.FoodID = "";
                }
                if (rdr["FOOD_NAME"].ToString() != "")
                {
                    foodItem.FoodName = rdr["FOOD_NAME"].ToString();
                }
                else
                {
                    foodItem.FoodName = "";
                }
                if (rdr["cat_id"].ToString() != "")
                {
                    foodItem.CatID = rdr["cat_id"].ToString();
                }
                else
                {
                    foodItem.CatID = "";
                }

                if (rdr["GRP_ID"].ToString() != "")
                {
                    foodItem.GrpID = rdr["GRP_ID"].ToString();
                }
                else
                {
                    foodItem.GrpID = "";
                }

                if (rdr["UNIT_ID"].ToString() != "")
                {
                    foodItem.UnitId = rdr["UNIT_ID"].ToString();
                }
                else
                {
                    foodItem.UnitId = "";
                }
                if (rdr["FOOD_IMAGE"].ToString() != "")
                {
                    foodItem.FoodImage = rdr["FOOD_IMAGE"].ToString();
                }
                else
                {
                    foodItem.FoodImage = "";
                }
                if (rdr["IS_NORMAL"].ToString() != "")
                {
                    foodItem.IsNormal = rdr["IS_NORMAL"].ToString();
                }

                if (rdr["IS_DIABETIC"].ToString() != "")
                {
                    foodItem.IsDiabetic = rdr["IS_DIABETIC"].ToString();
                }

                if (rdr["IS_HIGH_PROTEIN"].ToString() != "")
                {
                    foodItem.IsHighprotein = rdr["IS_HIGH_PROTEIN"].ToString();
                }

                if (rdr["IS_LOW_PROTEIN"].ToString() != "")
                {
                    foodItem.IsLowProtein = rdr["IS_LOW_PROTEIN"].ToString();
                }

                if (rdr["IS_RENAL"].ToString() != "")
                {
                    foodItem.IsRenal = rdr["IS_RENAL"].ToString();
                }

                if (rdr["IS_HIGH_FAT"].ToString() != "")
                {
                    foodItem.IsHighFat = rdr["IS_HIGH_FAT"].ToString();
                }

                if (rdr["IS_LOW_FAT"].ToString() != "")
                {
                    foodItem.IsLowFat = rdr["IS_LOW_FAT"].ToString();
                }

                if (rdr["PRICE"].ToString() != "")
                {
                    foodItem.Price = Convert.ToDouble(rdr["PRICE"]);
                }
                else
                {
                    foodItem.Price = 0;
                }
                if (rdr["REMARKS"].ToString() != "")
                {
                    foodItem.Remarks = rdr["REMARKS"].ToString();
                }
                else
                {
                    foodItem.Remarks = "";
                }

                objFood.Add(foodItem);
            }
            rdr.Close();
            return objFood;
        }

      public List<FoodMaster> GetItemRate(string where)
        {
            string packageName = "PKG_FNB.GetItemRate";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,where,ParameterDirection.Input),
                };
            return GetItemRate(packageName, parameterList);
        }
          private List<FoodMaster> GetItemRate(string packageName, OracleParameter[] parameterList)
          {
              List<FoodMaster> objFood = new List<FoodMaster>();
              OracleDataReader rdr;
              rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
              while (rdr.Read())
              {
                  FoodMaster foodItem = new FoodMaster();
                  if (rdr["PRICE"].ToString() != "")
                  {
                      foodItem.Price = Convert.ToDouble(rdr["PRICE"]);
                  }
                  else
                  {
                      foodItem.Price = 0;
                  }
                  objFood.Add(foodItem);
              }

              rdr.Close();
              return objFood;
          }




          public List<FoodMenuItemSetup> GetFoodMenuItemSetupFromMenuID(string CallName,string Where)
          {
              string packageName = "PKG_FNB.GetMenuSetupFromMenuID";
              OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("callname",OracleDbType.Varchar2,60,CallName,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),

                };
              return GetFoodMenuItemSetupFromMenuID(packageName, parameterList);
          }
          private List<FoodMenuItemSetup> GetFoodMenuItemSetupFromMenuID(string packageName, OracleParameter[] parameterList)
          {
              List<FoodMenuItemSetup> objFood = new List<FoodMenuItemSetup>();
              OracleDataReader rdr;
              rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
              while (rdr.Read())
              {
                  FoodMenuItemSetup objFI = new FoodMenuItemSetup();
                  if (rdr["menu_id"].ToString() != "")
                  {
                      objFI.FoodMenuID = rdr["menu_id"].ToString();
                  }
                  else
                  {
                      objFI.FoodMenuID = "";
                  }
                  if (rdr["menu_name"].ToString() != "")
                  {
                      objFI.FoodMenuName = rdr["menu_name"].ToString();
                  }
                  else
                  {
                      objFI.FoodTypeName = "";
                  }

                  if (rdr["rate"].ToString() != "")
                  {
                      objFI.ItemRate =Convert.ToDouble(rdr["rate"].ToString());
                  }
                  else
                  {
                      objFI.ItemRate = 0;
                  }

                  objFood.Add(objFI);
              }
              rdr.Close();
              return objFood;
          }



          public List<VisitorsSlipRO> GetVisitorsSlipRo(string  Pcall ,string Where)
          {
              string packageName = "PKG_FNB_REPORTS.DisplayFooditem";
              OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PCall",OracleDbType.Varchar2,60,Pcall,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),


                };
              return GetVisitorsSlipRo(packageName, parameterList);
          }
          private List<VisitorsSlipRO> GetVisitorsSlipRo(string packageName, OracleParameter[] parameterList)
          {
              List<VisitorsSlipRO> objFood = new List<VisitorsSlipRO>();
              OracleDataReader rdr;
              rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
              while (rdr.Read())
              {
                  VisitorsSlipRO objFI = new VisitorsSlipRO();
                  if (rdr["invoice_no"].ToString() != "")
                  {
                      objFI.invoiceNo = rdr["invoice_no"].ToString();
                  }
                  else
                  {
                      objFI.invoiceNo = "";
                  }
                  if (rdr["food_id"].ToString() != "")
                  {
                      objFI.FoodID = rdr["food_id"].ToString();
                  }
                  else
                  {
                      objFI.FoodID = "";
                  }

                  if (rdr["food_name"].ToString() != "")
                  {
                      objFI.FoodName = rdr["food_name"].ToString();
                  }
                  else
                  {
                      objFI.FoodName = "";
                  }

                  if (rdr["qty"].ToString() != "")
                  {
                      objFI.Qty = Convert.ToDouble(rdr["qty"].ToString());
                  }
                  else
                  {
                      objFI.Qty = 0;
                  }

                  if (rdr["rate"].ToString() != "")
                  {
                      objFI.Rate = Convert.ToDouble(rdr["rate"].ToString());
                  }
                  else
                  {
                      objFI.Rate = 0;
                  }

                  if (rdr["itemdis"].ToString() != "")
                  {
                      objFI.Itemdisc = Convert.ToDouble(rdr["itemdis"].ToString());
                  }
                  else
                  {
                      objFI.Itemdisc = 0;
                  }

                  if (rdr["total"].ToString() != "")
                  {
                      objFI.Total = Convert.ToDouble(rdr["total"].ToString());
                  }
                  else
                  {
                      objFI.Total = 0;
                  }
                  if (rdr["discount"].ToString() != "")
                  {
                      objFI.TotalDis = Convert.ToDouble(rdr["discount"].ToString());
                  }
                  else
                  {
                      objFI.TotalDis = 0;
                  }

                  if (rdr["vat"].ToString() != "")
                  {
                      objFI.TotalVat = Convert.ToDouble(rdr["vat"].ToString());
                  }
                  else
                  {
                      objFI.TotalVat = 0;
                  }

                  if (rdr["NET_PAID"].ToString() != "")
                  {
                      objFI.NetPaid = Convert.ToDouble(rdr["NET_PAID"].ToString());
                  }
                  else
                  {
                      objFI.NetPaid = 0;
                  }

                  //if (rdr["NET_PAID"].ToString() != "")
                  //{
                  //    objFI.NetPaid = Convert.ToDouble(rdr["NET_PAID"].ToString());
                  //}
                  //else
                  //{
                  //    objFI.NetPaid = 0;
                  //}


                  if (rdr["debit_card_amt"].ToString() != "")
                  {
                      objFI.DrAmount = Convert.ToDouble(rdr["debit_card_amt"].ToString());
                  }
                  else
                  {
                      objFI.DrAmount = 0;
                  }


                  if (rdr["credit_card_amt"].ToString() != "")
                  {
                      objFI.CrAmount = Convert.ToDouble(rdr["credit_card_amt"].ToString());
                  }
                  else
                  {
                      objFI.CrAmount = 0;
                  }

                  if (rdr["cash_amt"].ToString() != "")
                  {
                      objFI.CashAmount = Convert.ToDouble(rdr["cash_amt"].ToString());
                  }
                  else
                  {
                      objFI.CashAmount = 0;
                  }

                  if (rdr["transac_no"].ToString() != "")
                  {
                      objFI.TransationNo = rdr["transac_no"].ToString();
                  }
                  else
                  {
                      objFI.TransationNo = "";
                  }

                  if (rdr["entry_by"].ToString() != "")
                  {
                      objFI.Entryby =rdr["entry_by"].ToString();
                  }
                  else
                  {
                      objFI.Entryby = "";
                  }

                  if (rdr["entry_date"].ToString() != "")
                  {
                      objFI.entry_date =Convert.ToDateTime(rdr["entry_date"].ToString());
                  }
                  else
                  {
                      objFI.entry_date = Convert.ToDateTime("01/01/1900");
                  }

                  if (rdr["emp_id"].ToString() != "")
                  {
                      objFI.empId = rdr["emp_id"].ToString();
                  }
                  
                  objFood.Add(objFI);
              }
              rdr.Close();
              return objFood;
          }





          public AccountsPayment GetCollectionAmount(string userID, string date)
          {
              string packageName = "PKG_FNB.Get_Amount_Ticket_Fee";
              OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("userID",OracleDbType.Varchar2,30,userID,ParameterDirection.Input),
                new OracleParameter("date",OracleDbType.Varchar2,30,date,ParameterDirection.Input)
            };
              OracleDataReader rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
              AccountsPayment tktObj = new AccountsPayment();
              while (rdr.Read())
              {
                  if (rdr["Collection"].ToString() != "")
                  {
                    tktObj.TotalCollection = Convert.ToDouble(rdr["Collection"]);
                  }
                  else
                  {
                      tktObj.TotalCollection = 0;
                  }

                  if (rdr["Refund"].ToString() != "")
                  {
                      tktObj.RefundAmount = Convert.ToDouble(rdr["Refund"]);
                  }
                  else
                  {
                      tktObj.RefundAmount = 0;
                  }
                  if (rdr["Total"].ToString() != "")
                  {
                      tktObj.PaymentAmount = Convert.ToDouble(rdr["Total"]);
                  }
                  else
                  {
                      tktObj.PaymentAmount = 0;
                  }

                  if (rdr["CASH_AMT"].ToString() != "")
                  {
                      tktObj.CashAmount = Convert.ToDouble(rdr["CASH_AMT"]);
                  }
                  else
                  {
                      tktObj.CashAmount = 0;
                  }

                  if (rdr["CREDIT_CARD_AMT"].ToString() != "")
                  {
                      tktObj.CreditCardAmount = Convert.ToDouble(rdr["CREDIT_CARD_AMT"]);
                  }
                  else
                  {
                      tktObj.CreditCardAmount = 0;
                  }
                  if (rdr["DEBIT_CARD_AMT"].ToString() != "")
                  {
                      tktObj.DebitCardAmount = Convert.ToDouble(rdr["DEBIT_CARD_AMT"]);
                  }
                  else
                  {
                      tktObj.DebitCardAmount = 0;
                  }
                  
             
              }
              rdr.Close();
              return tktObj;
          }



          public short InsertUserCloseRegister(AccountsPayment tktFee)//(Ticket tktFee)
          {
              string packageName = "PKG_FNB.INSERT_USER_CLOSE_REGISTER";
              OracleParameter[] parameterList = new OracleParameter[] 
            { 
                new OracleParameter("p_test_cursor",OracleDbType.Int32,5,null,ParameterDirection.Output), 
                new OracleParameter("userID",OracleDbType.Varchar2,30,tktFee.EntryParameter.EntryBy,ParameterDirection.Input),

                new OracleParameter("CASH_AMT",OracleDbType.Varchar2,300,tktFee.CashAmount,ParameterDirection.Input),
                new OracleParameter("CREDIT_CARD_AMT",OracleDbType.Varchar2,300,tktFee.CreditCardAmount,ParameterDirection.Input),
                new OracleParameter("DEBIT_CARD_AMT",OracleDbType.Varchar2,300,tktFee.DebitCardAmount,ParameterDirection.Input),

                new OracleParameter("Tkt_fee",OracleDbType.Varchar2,300,tktFee.PaymentAmount,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,300,tktFee.Remarks,ParameterDirection.Input),

                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tktFee.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tktFee.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,tktFee.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,tktFee.EntryParameter.MachineID,ParameterDirection.Input),
                new OracleParameter("date",OracleDbType.Varchar2,30,tktFee.CollectionDate,ParameterDirection.Input)
            };

              short i = DALHelper.Insert(connstring, packageName, parameterList);
              OracleParameter prm = parameterList[0];
              if ((OracleDecimal)prm.Value == 1)
                  return 1;
              else return 0;
          }




          public List<WeeklyEmpMealRegister> GetWeeklySetmenuDetiails(string whereMeal,string whereMealname)
          {
              string packageName = "PKG_FNB.GetFoodMenuDetails";
              OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhereMeal",OracleDbType.Varchar2,20,whereMeal,ParameterDirection.Input),
                    new OracleParameter("pwhereMealName",OracleDbType.Varchar2,20,whereMealname,ParameterDirection.Input),
                };
              return GetWeeklySetmenuDetiails(packageName, parameterList);
          }
          private List<WeeklyEmpMealRegister> GetWeeklySetmenuDetiails(string packageName, OracleParameter[] parameterList)
          {
              List<WeeklyEmpMealRegister> objFood = new List<WeeklyEmpMealRegister>();
              OracleDataReader rdr;
              rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
              while (rdr.Read())
              {
                  WeeklyEmpMealRegister objMs = new WeeklyEmpMealRegister();
                  if (rdr["menu_id"].ToString() != "")
                  {
                      objMs.Setmenuid = rdr["menu_id"].ToString();
                  }
                  else
                  {
                      objMs.Setmenuid = "";
                  }

                  if (rdr["menu_name"].ToString() != "")
                  {
                      objMs.SetmenuItem = rdr["menu_name"].ToString();
                  }
                  else
                  {
                      objMs.SetmenuItem = "";
                  }
                  objFood.Add(objMs);
              }
              rdr.Close();
              return objFood;
          }


          public List<MealSetup> GetMealTime()
          {
              string packageName = "PKG_FNB.GetMealIdTime";
              OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
              return GetMealTime(packageName, parameterList);
          }
          private List<MealSetup> GetMealTime(string packageName, OracleParameter[] parameterList)
          {
              List<MealSetup> objFood = new List<MealSetup>();
              OracleDataReader rdr;
              rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
              while (rdr.Read())
              {
                  MealSetup objMs = new MealSetup();
                  if (rdr["meal_start_time"].ToString() != "")
                  {
                      objMs.StartTime = rdr["meal_start_time"].ToString();
                  }
                  else
                  {
                      objMs.StartTime = "";
                  }

                  if (rdr["meal_end_time"].ToString() != "")
                  {
                      objMs.EndTime = rdr["meal_end_time"].ToString();
                  }
                  else
                  {
                      objMs.EndTime = "";
                  }

                  if (rdr["meal_id"].ToString() != "")
                  {
                      objMs.MealID = rdr["meal_id"].ToString();
                  }
                  else
                  {
                      objMs.MealID = "";
                  }

                  if (rdr["meal_name"].ToString() != "")
                  {
                      objMs.MealName = rdr["meal_name"].ToString();
                  }
                  else
                  {
                      objMs.MealName = "";
                  }



                  objFood.Add(objMs);
              }
              rdr.Close();
              return objFood;
          }



          public List<WeeklyEmpMealRegister> LoadSetmenu(string where ,string where1)
          {
              string packageName = "PKG_FNB.LoadSetmenu";
              OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhereMeal",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pwhereMealName",OracleDbType.Varchar2,20,where1,ParameterDirection.Input),

                };
              return LoadSetmenu(packageName, parameterList);
          }
          private List<WeeklyEmpMealRegister> LoadSetmenu(string packageName, OracleParameter[] parameterList)
          {
              List<WeeklyEmpMealRegister> objFood = new List<WeeklyEmpMealRegister>();
              OracleDataReader rdr;
              rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
              while (rdr.Read())
              {
                  WeeklyEmpMealRegister objMs = new WeeklyEmpMealRegister();
                  if (rdr["setmenu_id"].ToString() != "")
                  {
                      objMs.Setmenuid = rdr["setmenu_id"].ToString();
                  }
                  else
                  {
                      objMs.Setmenuid = "";
                  }
                  if (rdr["menu_name"].ToString() != "")
                  {
                      objMs.SetmenuItem = rdr["menu_name"].ToString();
                  }
                  else
                  {
                      objMs.SetmenuItem = "";
                  }


                  objFood.Add(objMs);
              }
              rdr.Close();
              return objFood;
          }

        public string GetBarcodeLevel(string strBarcode)
          {
              return strBarcode;
          }


        public short UpdateIssue(string strCardNo,string strMealID,string strDate)
        {
            string packageName = "PKG_FNB.UpdateIssue";
            OracleParameter[] parameterList = new OracleParameter[] 
            { 
                
                new OracleParameter("Pwhere",OracleDbType.Varchar2,30,strCardNo,ParameterDirection.Input),
                new OracleParameter("pWhere1",OracleDbType.Varchar2,100,strMealID,ParameterDirection.Input),
                new OracleParameter("pWhere2",OracleDbType.Varchar2,100,strDate,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;
        }



        public List<DailyCollectionRO> LoadDailyCollection(string where, string CallName,string Fdate,string Tdate)
        {
            string packageName = "PKG_FNB_REPORTS.ColectionFoodItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PCall",OracleDbType.Varchar2,20,CallName,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pFDate",OracleDbType.Varchar2,20,Fdate,ParameterDirection.Input),
                    new OracleParameter("pTDate",OracleDbType.Varchar2,20,Tdate,ParameterDirection.Input),
                };
            return LoadDailyCollection(packageName, parameterList);
        
        }
        private List<DailyCollectionRO> LoadDailyCollection(string packageName, OracleParameter[] parameterList)
        {
            List<DailyCollectionRO> objFood = new List<DailyCollectionRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DailyCollectionRO objMs = new DailyCollectionRO();
                if (rdr["meal_date"].ToString() != "")
                {
                    objMs.MealDate = Convert.ToDateTime(rdr["meal_date"]);
                }

                if (rdr["wk_day_no"].ToString() != "")
                {
                    objMs.WeekDayNo = rdr["wk_day_no"].ToString();
                }
                else
                {
                    objMs.WeekDayNo = "";
                }

                if (rdr["dayname"].ToString() != "")
                {
                    objMs.WeekDayName = rdr["dayname"].ToString();
                }
                else
                {
                    objMs.WeekDayName = "";
                }
                if (rdr["meal_id"].ToString() != "")
                {
                    objMs.MealID = rdr["meal_id"].ToString();
                }
                else
                {
                    objMs.MealID = "";
                }
                if (rdr["meal_name"].ToString() != "")
                {
                    objMs.MealName = rdr["meal_name"].ToString();
                }
                else
                {
                    objMs.MealName = "";
                }

                if (rdr["bill"].ToString() != "")
                {
                    objMs.BillAmount = Convert.ToDouble(rdr["bill"]);
                }
                else
                {
                    objMs.BillAmount =0;
                }
                if (rdr["subsidy"].ToString() != "")
                {
                    objMs.BillSubsidy = Convert.ToDouble(rdr["subsidy"]);
                }
                else
                {
                    objMs.BillSubsidy = 0;
                }

                if (rdr["net_amount"].ToString() != "")
                {
                    objMs.NetAmount = Convert.ToDouble(rdr["net_amount"]);
                }
                else
                {
                    objMs.NetAmount = 0;
                }


                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }


        public List<DailyCollectionRO> LoadStaffCollection(string where, string CallName, string Fdate, string Tdate)
        {
            string packageName = "PKG_FNB_REPORTS.ColectionFoodItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PCall",OracleDbType.Varchar2,20,CallName,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pFDate",OracleDbType.Varchar2,20,Fdate,ParameterDirection.Input),
                    new OracleParameter("pTDate",OracleDbType.Varchar2,20,Tdate,ParameterDirection.Input),
                };
            return LoadStaffCollection(packageName, parameterList);

        }
        private List<DailyCollectionRO> LoadStaffCollection(string packageName, OracleParameter[] parameterList)
        {
            List<DailyCollectionRO> objFood = new List<DailyCollectionRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DailyCollectionRO objMs = new DailyCollectionRO();

                //if (rdr["emp_id"].ToString() != "")
                //{
                //    objMs.CardNo = rdr["emp_id"].ToString();
                //}

                if (rdr["meal_date"].ToString() != "")
                {
                    objMs.MealDate = Convert.ToDateTime(rdr["meal_date"]);
                    objMs.strMealDate = Convert.ToDateTime(rdr["meal_date"]).ToString("dd/MM/yyyy");
                }



                if (rdr["wk_day_no"].ToString() != "")
                {
                    objMs.WeekDayNo = rdr["wk_day_no"].ToString();
                }
                else
                {
                    objMs.WeekDayNo = "";
                }

                if (rdr["dayname"].ToString() != "")
                {
                    objMs.WeekDayName = rdr["dayname"].ToString();
                }
                else
                {
                    objMs.WeekDayName = "";
                }
                if (rdr["meal_id"].ToString() != "")
                {
                    objMs.MealID = rdr["meal_id"].ToString();
                }
                else
                {
                    objMs.MealID = "";
                }
                if (rdr["meal_name"].ToString() != "")
                {
                    objMs.MealName = rdr["meal_name"].ToString();
                }
                else
                {
                    objMs.MealName = "";
                }

                if (rdr["bill"].ToString() != "")
                {
                    objMs.BillAmount = Convert.ToDouble(rdr["bill"]);
                }
                else
                {
                    objMs.BillAmount = 0;
                }
                if (rdr["subsidy"].ToString() != "")
                {
                    objMs.BillSubsidy = Convert.ToDouble(rdr["subsidy"]);
                }
                else
                {
                    objMs.BillSubsidy = 0;
                }
                if (rdr["entry_by"].ToString() != "")
                {
                    objMs.userID = rdr["entry_by"].ToString();
                }
                else
                {
                    objMs.userID = "";
                }
                if (rdr["net_amount"].ToString() != "")
                {
                    objMs.NetAmount = Convert.ToDouble(rdr["net_amount"]);
                }
                else
                {
                    objMs.NetAmount = 0;
                }




                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }

        public List<DailyCollectionRO> LoadStaffIssuesd(string where, string CallName, string Fdate, string Tdate)
        {
            string packageName = "PKG_FNB_REPORTS.ColectionFoodItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PCall",OracleDbType.Varchar2,20,CallName,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pFDate",OracleDbType.Varchar2,20,Fdate,ParameterDirection.Input),
                    new OracleParameter("pTDate",OracleDbType.Varchar2,20,Tdate,ParameterDirection.Input),
                };
            return LoadStaffIssuesd(packageName, parameterList);

        }
        private List<DailyCollectionRO> LoadStaffIssuesd(string packageName, OracleParameter[] parameterList)
        {
            List<DailyCollectionRO> objFood = new List<DailyCollectionRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DailyCollectionRO objMs = new DailyCollectionRO();

                if (rdr["emp_id"].ToString() != "")
                {
                    objMs.CardNo = rdr["emp_id"].ToString();
                }

                if (rdr["meal_date"].ToString() != "")
                {
                    objMs.MealDate = Convert.ToDateTime(rdr["meal_date"]);
                }

                //if (rdr["wk_day_no"].ToString() != "")
                //{
                //    objMs.WeekDayNo = rdr["wk_day_no"].ToString();
                //}
                //else
                //{
                //    objMs.WeekDayNo = "";
                //}

                if (rdr["dayname"].ToString() != "")
                {
                    objMs.WeekDayName = rdr["dayname"].ToString();
                }
                else
                {
                    objMs.WeekDayName = "";
                }
                //if (rdr["meal_id"].ToString() != "")
                //{
                //    objMs.MealID = rdr["meal_id"].ToString();
                //}
                //else
                //{
                //    objMs.MealID = "";
                //}
                //if (rdr["meal_name"].ToString() != "")
                //{
                //    objMs.MealName = rdr["meal_name"].ToString();
                //}
                //else
                //{
                //    objMs.MealName = "";
                //}

                if (rdr["bill"].ToString() != "")
                {
                    objMs.BillAmount = Convert.ToDouble(rdr["bill"]);
                }
                else
                {
                    objMs.BillAmount = 0;
                }
                if (rdr["subsidy"].ToString() != "")
                {
                    objMs.BillSubsidy = Convert.ToDouble(rdr["subsidy"]);
                }
                else
                {
                    objMs.BillSubsidy = 0;
                }
                if (rdr["entry_by"].ToString() != "")
                {
                    objMs.userID = rdr["entry_by"].ToString();
                }
                else
                {
                    objMs.userID = "";
                }
                if (rdr["net_amount"].ToString() != "")
                {
                    objMs.NetAmount = Convert.ToDouble(rdr["net_amount"]);
                }
                else
                {
                    objMs.NetAmount = 0;
                }




                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }


        public List<VisitorsSlipRO> GetFoodItemCollection(string where, string CallName, string Fdate, string Tdate)
          {
              string packageName = "PKG_FNB_REPORTS.ColectionFoodItem";
              OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PCall",OracleDbType.Varchar2,20,CallName,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,"",ParameterDirection.Input),
                    new OracleParameter("pFDate",OracleDbType.Varchar2,20,Fdate,ParameterDirection.Input),
                    new OracleParameter("pTDate",OracleDbType.Varchar2,20,Tdate,ParameterDirection.Input),


                };
              return GetFoodItemCollection(packageName, parameterList);
          }
        private List<VisitorsSlipRO> GetFoodItemCollection(string packageName, OracleParameter[] parameterList)
          {
              List<VisitorsSlipRO> objFood = new List<VisitorsSlipRO>();
              OracleDataReader rdr;
              rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
              while (rdr.Read())
              {
                  VisitorsSlipRO objFI = new VisitorsSlipRO();
                  if (rdr["invoice_no"].ToString() != "")
                  {
                      objFI.invoiceNo = rdr["invoice_no"].ToString();
                  }
                  else
                  {
                      objFI.invoiceNo = "";
                  }
                  if (rdr["food_id"].ToString() != "")
                  {
                      objFI.FoodID = rdr["food_id"].ToString();
                  }
                  else
                  {
                      objFI.FoodID = "";
                  }

                  if (rdr["food_name"].ToString() != "")
                  {
                      objFI.FoodName = rdr["food_name"].ToString();
                  }
                  else
                  {
                      objFI.FoodName = "";
                  }

                  if (rdr["qty"].ToString() != "")
                  {
                      objFI.Qty = Convert.ToDouble(rdr["qty"].ToString());
                  }
                  else
                  {
                      objFI.Qty = 0;
                  }

                  if (rdr["rate"].ToString() != "")
                  {
                      objFI.Rate = Convert.ToDouble(rdr["rate"].ToString());
                  }
                  else
                  {
                      objFI.Rate = 0;
                  }

                  if (rdr["itemdis"].ToString() != "")
                  {
                      objFI.Itemdisc = Convert.ToDouble(rdr["itemdis"].ToString());
                  }
                  else
                  {
                      objFI.Itemdisc = 0;
                  }

                  if (rdr["total"].ToString() != "")
                  {
                      objFI.Total = Convert.ToDouble(rdr["total"].ToString());
                  }
                  else
                  {
                      objFI.Total = 0;
                  }
                  if (rdr["discount"].ToString() != "")
                  {
                      objFI.TotalDis = Convert.ToDouble(rdr["discount"].ToString());
                  }
                  else
                  {
                      objFI.TotalDis = 0;
                  }

                  if (rdr["vat"].ToString() != "")
                  {
                      objFI.TotalVat = Convert.ToDouble(rdr["vat"].ToString());
                  }
                  else
                  {
                      objFI.TotalVat = 0;
                  }

                  if (rdr["NET_PAID"].ToString() != "")
                  {
                      objFI.NetPaid = Convert.ToDouble(rdr["NET_PAID"].ToString());
                  }
                  else
                  {
                      objFI.NetPaid = 0;
                  }

                  //if (rdr["NET_PAID"].ToString() != "")
                  //{
                  //    objFI.NetPaid = Convert.ToDouble(rdr["NET_PAID"].ToString());
                  //}
                  //else
                  //{
                  //    objFI.NetPaid = 0;
                  //}


                  if (rdr["debit_card_amt"].ToString() != "")
                  {
                      objFI.DrAmount = Convert.ToDouble(rdr["debit_card_amt"].ToString());
                  }
                  else
                  {
                      objFI.DrAmount = 0;
                  }


                  if (rdr["credit_card_amt"].ToString() != "")
                  {
                      objFI.CrAmount = Convert.ToDouble(rdr["credit_card_amt"].ToString());
                  }
                  else
                  {
                      objFI.CrAmount = 0;
                  }

                  if (rdr["cash_amt"].ToString() != "")
                  {
                      objFI.CashAmount = Convert.ToDouble(rdr["cash_amt"].ToString());
                  }
                  else
                  {
                      objFI.CashAmount = 0;
                  }

                  if (rdr["transac_no"].ToString() != "")
                  {
                      objFI.TransationNo = rdr["transac_no"].ToString();
                  }
                  else
                  {
                      objFI.TransationNo = "";
                  }

                  if (rdr["entry_by"].ToString() != "")
                  {
                      objFI.Entryby =rdr["entry_by"].ToString();
                  }
                  else
                  {
                      objFI.Entryby = "";
                  }

                  if (rdr["entry_date"].ToString() != "")
                  {
                      objFI.entry_date =Convert.ToDateTime(rdr["entry_date"].ToString());
                  }
                  else
                  {
                      objFI.entry_date = Convert.ToDateTime("01/01/1900");
                  }


                  objFood.Add(objFI);
              }
              rdr.Close();
              return objFood;
          }
        public List<VisitorsSlipRO> GetVisitorsCollection(string where, string CallName, string Fdate, string Tdate)
        {
            string packageName = "PKG_FNB_REPORTS.ColectionFoodItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PCall",OracleDbType.Varchar2,20,CallName,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,"",ParameterDirection.Input),
                    new OracleParameter("pFDate",OracleDbType.Varchar2,20,Fdate,ParameterDirection.Input),
                    new OracleParameter("pTDate",OracleDbType.Varchar2,20,Tdate,ParameterDirection.Input),


                };
            return GetVisitorsCollection(packageName, parameterList);
        }
        private List<VisitorsSlipRO> GetVisitorsCollection(string packageName, OracleParameter[] parameterList)
        {
            List<VisitorsSlipRO> objFood = new List<VisitorsSlipRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                VisitorsSlipRO objFI = new VisitorsSlipRO();
                if (rdr["entry_date"].ToString() != "")
                {
                    
                    string  strEntry = Convert.ToDateTime(rdr["entry_date"]).ToString("dd/MM/yyyy");
                    objFI.vdate = strEntry;
                }

                if (rdr["NET_PAID"].ToString() != "")
                {
                    objFI.NetPaid  =  Convert.ToDouble(rdr["NET_PAID"].ToString());
                }
                else
                {
                    objFI.NetPaid = 0;
                }

                

                objFood.Add(objFI);
            }
            rdr.Close();
            return objFood;
        }

        public List<Visitors> GetvisitorsHistory(string where)
        {
            string packageName = "PKG_FNB.GetVisitorsHistory";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,20,"",ParameterDirection.Input), 
                };
            return GetvisitorsHistory(packageName, parameterList);
        }
        private List<Visitors> GetvisitorsHistory(string packageName, OracleParameter[] parameterList)
        {
            List<Visitors> objFood = new List<Visitors>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Visitors objMs = new Visitors();
                if (rdr["transac_no"].ToString() != "")
                {
                    objMs.TransNo = rdr["transac_no"].ToString();
                }
                else
                {
                    objMs.TransNo = "";
                }
                if (rdr["invoice_no"].ToString() != "")
                {
                    objMs.InvoiceNo = rdr["invoice_no"].ToString();
                }
                else
                {
                    objMs.InvoiceNo = "";
                }
                if (rdr["entry_date"].ToString() != "")
                {
                    objMs.entryDate = Convert.ToDateTime(rdr["entry_date"]).ToString("dd/MM/yyyy");

                }

                if (rdr["entry_by"].ToString() != "")
                {
                    objMs.entryby = rdr["entry_by"].ToString();
                }
                else
                {
                    objMs.entryby = "";
                }
                objMs.empID = rdr["emp_id"].ToString();


               objMs.NetPaid = Convert.ToDouble(rdr["NET_PAID"]);

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }


        public long  GetTotalAttendance(string where)
        {
            string packageName = "PKG_FNB.GetTotalPresent";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhereMeal",OracleDbType.Varchar2,20,where,ParameterDirection.Input),

                };
            return GetTotalAttendance(packageName, parameterList);
        }
        private long  GetTotalAttendance(string packageName, OracleParameter[] parameterList)
        {
            OracleDataReader rdr;
            long lngattendace=0;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                lngattendace = Convert.ToInt64 (rdr["TP"]);

            }
            rdr.Close();
            return lngattendace;
        }


        public List<FoodItem> GetFoodID(string where)
        {
            string packageName = "PKG_FNB.GetFoodId";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    //new OracleParameter("pwhere1",OracleDbType.Varchar2,20,"",ParameterDirection.Input), 
                };
            return GetFoodID(packageName, parameterList);
        }
        private List<FoodItem> GetFoodID(string packageName, OracleParameter[] parameterList)
        {
            List<FoodItem> objFood = new List<FoodItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FoodItem objMs = new FoodItem();
                if (rdr["food_id"].ToString() != "")
                {
                    objMs.ItemID = rdr["food_id"].ToString();
                }
                else
                {
                    objMs.ItemID = "";
                }
                if (rdr["food_name"].ToString() != "")
                {
                    objMs.ItemName = rdr["food_name"].ToString();
                }
                else
                {
                    objMs.ItemName = "";
                }

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }




        public List<DailyCollectionRO> LoadUserwiseCollection(string where, string CallName, string Fdate, string Tdate)
        {
            string packageName = "PKG_FNB_REPORTS.UserWiseColection";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PCall",OracleDbType.Varchar2,20,CallName,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pFDate",OracleDbType.Varchar2,20,Fdate,ParameterDirection.Input),
                    new OracleParameter("pTDate",OracleDbType.Varchar2,20,Tdate,ParameterDirection.Input),
                };
            return LoadUserwiseCollection(packageName, parameterList);

        }
        private List<DailyCollectionRO> LoadUserwiseCollection(string packageName, OracleParameter[] parameterList)
        {
            List<DailyCollectionRO> objFood = new List<DailyCollectionRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DailyCollectionRO objMs = new DailyCollectionRO();

                //if (rdr["emp_id"].ToString() != "")
                //{
                //    objMs.CardNo = rdr["emp_id"].ToString();
                //}

                if (rdr["meal_date"].ToString() != "")
                {
                    objMs.MealDate = Convert.ToDateTime(rdr["meal_date"]);
                }

                //if (rdr["wk_day_no"].ToString() != "")
                //{
                //    objMs.WeekDayNo = rdr["wk_day_no"].ToString();
                //}
                //else
                //{
                //    objMs.WeekDayNo = "";
                //}

                //if (rdr["dayname"].ToString() != "")
                //{
                //    objMs.WeekDayName = rdr["dayname"].ToString();
                //}
                //else
                //{
                //    objMs.WeekDayName = "";
                //}
                //if (rdr["meal_id"].ToString() != "")
                //{
                //    objMs.MealID = rdr["meal_id"].ToString();
                //}
                //else
                //{
                //    objMs.MealID = "";
                //}
                //if (rdr["meal_name"].ToString() != "")
                //{
                //    objMs.MealName = rdr["meal_name"].ToString();
                //}
                //else
                //{
                //    objMs.MealName = "";
                //}

                //if (rdr["bill"].ToString() != "")
                //{
                //    objMs.BillAmount = Convert.ToDouble(rdr["bill"]);
                //}
                //else
                //{
                //    objMs.BillAmount = 0;
                //}
                //if (rdr["subsidy"].ToString() != "")
                //{
                //    objMs.BillSubsidy = Convert.ToDouble(rdr["subsidy"]);
                //}
                //else
                //{
                //    objMs.BillSubsidy = 0;
                //}
                if (rdr["entry_by"].ToString() != "")
                {
                    objMs.userID = rdr["entry_by"].ToString();
                }
                else
                {
                    objMs.userID = "";
                }
                if (rdr["net_amount"].ToString() != "")
                {
                    objMs.NetAmount = Convert.ToDouble(rdr["net_amount"]);
                }
                else
                {
                    objMs.NetAmount = 0;
                }




                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }


        public List<VisitorsSlipRO> GetVisitorsItemDetails(string where, string CallName, string Fdate, string Tdate)
        {
            string packageName = "PKG_FNB_REPORTS.VisitorsDetailsColection";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PCall",OracleDbType.Varchar2,20,CallName,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pFDate",OracleDbType.Varchar2,20,Fdate,ParameterDirection.Input),
                    new OracleParameter("pTDate",OracleDbType.Varchar2,20,Tdate,ParameterDirection.Input),


                };
            return GetVisitorsItemDetails(packageName, parameterList);
        }
        private List<VisitorsSlipRO> GetVisitorsItemDetails(string packageName, OracleParameter[] parameterList)
        {
            List<VisitorsSlipRO> objFood = new List<VisitorsSlipRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                VisitorsSlipRO objFI = new VisitorsSlipRO();
                if (rdr["entry_date"].ToString() != "")
                {

                    string strEntry = Convert.ToDateTime(rdr["entry_date"]).ToString("dd/MM/yyyy");
                    objFI.vdate = strEntry;
                }

                if (rdr["food_name"].ToString() != "")
                {
                    objFI.FoodName = rdr["food_name"].ToString();
                }

                if (rdr["qty"].ToString() != "")
                {
                    objFI.Qty  = Convert.ToDouble(rdr["qty"].ToString());
                }
                if (rdr["rate"].ToString() != "")
                {
                    objFI.Rate = Convert.ToDouble(rdr["rate"].ToString());
                }
                if (rdr["total"].ToString() != "")
                {
                    objFI.Total = Convert.ToDouble(rdr["total"].ToString());
                }

                if (rdr["vat"].ToString() != "")
                {
                    objFI.TotalVat = Convert.ToDouble(rdr["vat"].ToString());
                }
                if (rdr["discount"].ToString() != "")
                {
                    objFI.TotalDis = Convert.ToDouble(rdr["discount"].ToString());
                }

                if (rdr["net_paid"].ToString() != "")
                {
                    objFI.NetPaid = Convert.ToDouble(rdr["net_paid"].ToString());
                }
                if (rdr["entry_by"].ToString() != "")
                {
                    objFI.Entryby = rdr["entry_by"].ToString();
                }

                objFood.Add(objFI);
            }
            rdr.Close();
            return objFood;
        }


        public List<Visitors> GetvisitorsHistoryDateRange(string where, string where1, string where2)
        {
            string packageName = "PKG_FNB.GetVisitorsHistoryDetails";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,20,where1,ParameterDirection.Input), 
                    new OracleParameter("pwhere2",OracleDbType.Varchar2,20,where2,ParameterDirection.Input), 
                };
            return GetvisitorsHistoryDateRange(packageName, parameterList);
        }
        private List<Visitors> GetvisitorsHistoryDateRange(string packageName, OracleParameter[] parameterList)
        {
            List<Visitors> objFood = new List<Visitors>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Visitors objMs = new Visitors();
                if (rdr["transac_no"].ToString() != "")
                {
                    objMs.TransNo = rdr["transac_no"].ToString();
                }
                else
                {
                    objMs.TransNo = "";
                }
                if (rdr["invoice_no"].ToString() != "")
                {
                    objMs.InvoiceNo = rdr["invoice_no"].ToString();
                }
                else
                {
                    objMs.InvoiceNo = "";
                }
                if (rdr["entry_date"].ToString() != "")
                {
                    objMs.entryDate = Convert.ToDateTime(rdr["entry_date"]).ToString("dd/MM/yyyy");

                }

                if (rdr["entry_by"].ToString() != "")
                {
                    objMs.entryby = rdr["entry_by"].ToString();
                }
                else
                {
                    objMs.entryby = "";
                }
                objMs.empID = rdr["emp_id"].ToString();


                objMs.NetPaid = Convert.ToDouble(rdr["NET_PAID"]);

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }



        public List<VisitorsSlipRO > GetEmpStaffItem(string where, string where1, string where2)
        {
            string packageName = "PKG_FNB_REPORTS.GetStaffDetails";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PCall",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pFDate",OracleDbType.Varchar2,20,"",ParameterDirection.Input), 
                    new OracleParameter("pTDate",OracleDbType.Varchar2,20,"",ParameterDirection.Input), 
                };
            return GetEmpStaffItem(packageName, parameterList);
        }
        private List<VisitorsSlipRO> GetEmpStaffItem(string packageName, OracleParameter[] parameterList)
        {
            List<VisitorsSlipRO> objFood = new List<VisitorsSlipRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                VisitorsSlipRO objMs = new VisitorsSlipRO();
                if (rdr["meal_reg_id"].ToString() != "")
                {
                    objMs.TransationNo = rdr["meal_reg_id"].ToString();
                }
                else
                {
                    objMs.TransationNo = "";
                }
                if (rdr["emp_id"].ToString() != "")
                {
                    objMs.empId = rdr["emp_id"].ToString();
                }
                else
                {
                    objMs.empId = "";
                }
                if (rdr["entry_by"].ToString() != "")
                {
                    objMs.VisitorsName = rdr["entry_by"].ToString();
                }
                else
                {
                    objMs.VisitorsName = "";
                }

                 if (rdr["menu_name"].ToString() != "")
                {
                    objMs.FoodName = rdr["menu_name"].ToString();
                }
                else
                {
                    objMs.FoodName = "";
                }

                //if (rdr["entry_by"].ToString() != "")
                //{
                //    objMs.entryby = rdr["entry_by"].ToString();
                //}
                //else
                //{
                //    objMs.entryby = "";
                //}
                //objMs.empID = rdr["emp_id"].ToString();


                objMs.NetPaid = Convert.ToDouble(rdr["net_amount"]);

                objFood.Add(objMs);
            } 

            rdr.Close();
            return objFood;
        }

        public List<WeeklySetupMeal> GetWeeklyDayMeal(string where, string where1)
        {
            string packageName = "PKG_FNB.GetWeekDayMeal";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,20,where1,ParameterDirection.Input),

                };
            return GetWeeklyDayMeal(packageName, parameterList);
        }
        private List<WeeklySetupMeal> GetWeeklyDayMeal(string packageName, OracleParameter[] parameterList)
        {
            List<WeeklySetupMeal> objFood = new List<WeeklySetupMeal>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WeeklySetupMeal objMs = new WeeklySetupMeal();
                if (rdr["wk_day_no"].ToString() != "")
                {
                    objMs.WeekDayNo = rdr["wk_day_no"].ToString();
                }
                else
                {
                    objMs.WeekDayNo = "";
                }
                if (rdr["meal_id"].ToString() != "")
                {
                    objMs.MealID = rdr["meal_id"].ToString();
                }
                else
                {
                    objMs.MealID = "";
                }

                if (rdr["meal_name"].ToString() != "")
                {
                    objMs.MealName = rdr["meal_name"].ToString();
                }
                else
                {
                    objMs.MealName = "";
                }


                if (rdr["setmenu_id"].ToString() != "")
                {
                    objMs.SetMenuID = rdr["setmenu_id"].ToString();
                }
                else
                {
                    objMs.SetMenuID = "";
                }

                if (rdr["type_id"].ToString() != "")
                {
                    objMs.WeeklySetMenuTypeID = rdr["type_id"].ToString();
                }
                else
                {
                    objMs.WeeklySetMenuTypeID = "";
                }
                if (rdr["type_name"].ToString() != "")
                {
                    objMs.WeeklySetMenuTypeName = rdr["type_name"].ToString();
                }
                else
                {
                    objMs.WeeklySetMenuTypeName = "";
                }

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }


        public string InsertInventory(Inventory  inv)
        {
            packageName = "PKG_FNB_INV.InsertInventory";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pInv",OracleDbType.Varchar2,100,null,ParameterDirection.Output),
                new OracleParameter("pvDate",OracleDbType.Varchar2,100,inv.MrrDate,ParameterDirection.Input),
                new OracleParameter("pvtype",OracleDbType.Varchar2,60,inv.intVtype,ParameterDirection.Input),
                new OracleParameter("issue_ref_no",OracleDbType.Varchar2,60,inv.IssueRefNo,ParameterDirection.Input),

                new OracleParameter("p_payment_string",OracleDbType.Varchar2,50000,inv.strString,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,inv.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,inv.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,inv.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,inv.EntryParameter.MachineID,ParameterDirection.Input),
            };


            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
        }


        public string UpdateInventory(Inventory inv)
        {
            packageName = "PKG_FNB_INV.UpdateInventory";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pInv",OracleDbType.Varchar2,100,null,ParameterDirection.Output),
                new OracleParameter("pInvRef",OracleDbType.Varchar2,60,inv.MrrNo,ParameterDirection.Input),
                new OracleParameter("pvDate",OracleDbType.Varchar2,100,inv.MrrDate,ParameterDirection.Input),
                new OracleParameter("pvtype",OracleDbType.Varchar2,60,inv.intVtype,ParameterDirection.Input),
                new OracleParameter("issue_ref_no",OracleDbType.Varchar2,60,inv.IssueRefNo,ParameterDirection.Input),
                new OracleParameter("p_payment_string",OracleDbType.Varchar2,50000,inv.strString,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2 ,60,inv.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2 ,60,inv.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2 ,60,inv.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,60,inv.EntryParameter.MachineID,ParameterDirection.Input),
            };


            short i = DALHelper.Update(connstring, packageName, parameterList);
            //return 1;
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
        }

        public List<Inventory> GetMonthVoucher(int intVtype)
        {
            string packageName = "PKG_FNB_INV.LoadMonthVoucher";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                   new OracleParameter("pwhere",OracleDbType.Int32,2,intVtype,ParameterDirection.Input),

                };
            return GetMonthVoucher(packageName, parameterList);
        }
        private List<Inventory> GetMonthVoucher(string packageName, OracleParameter[] parameterList)
        {
            List<Inventory> objFood = new List<Inventory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Inventory objMs = new Inventory();
                if (rdr["mrr_no"].ToString() != "")
                {
                    objMs.MrrNo = rdr["mrr_no"].ToString();
                }
                else
                {
                    objMs.MrrNo = "";
                }
                if (rdr["mrr_date"].ToString() != "")
                {
                    objMs.MrrDate = rdr["mrr_date"].ToString();
                }
                else
                {
                    objMs.MrrDate = "";
                }

               

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }




        public List<Inventory> DisplayVoucher(string where)
        {
            string packageName = "PKG_FNB_INV.DisplayVoucher";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,100,where,ParameterDirection.Input),

                };
            return DisplayVoucher(packageName, parameterList);
        }
        private List<Inventory> DisplayVoucher(string packageName, OracleParameter[] parameterList)
        {
            List<Inventory> objFood = new List<Inventory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Inventory objMs = new Inventory();
                if (rdr["food_id"].ToString() != "")
                {
                    objMs.FoodID = rdr["food_id"].ToString();
                }
                else
                {
                    objMs.FoodID = "";
                }

                if (rdr["food_name"].ToString() != "")
                {
                    objMs.FoodName = rdr["food_name"].ToString();
                }
                else
                {
                    objMs.FoodName = "";
                }
                if (rdr["mrr_no"].ToString() != "")
                {
                    objMs.MrrNo = rdr["mrr_no"].ToString();
                }
                else
                {
                    objMs.MrrNo = "";
                }
                if (rdr["mrr_date"].ToString() != "")
                {
                    objMs.MrrDate = rdr["mrr_date"].ToString();
                }
                else
                {
                    objMs.MrrDate = "";
                }

                if (rdr["cat_id"].ToString() != "")
                {
                    objMs.CatID = rdr["cat_id"].ToString();
                }
                else
                {
                    objMs.CatID = "";
                }
                if (rdr["cat_name"].ToString() != "")
                {
                    objMs.CatName  = rdr["cat_name"].ToString();
                }
                else
                {
                    objMs.CatName = "";
                }

                if (rdr["tran_rate"].ToString() != "")
                {
                    objMs.dblTranRate =Convert.ToDouble(rdr["tran_rate"]);
                }
                else
                {
                    objMs.dblTranRate = 0;
                }

                if (rdr["opening_qty"].ToString() != "")
                {
                    objMs.dblopnqty  = Convert.ToDouble(rdr["opening_qty"]);
                }
                else
                {
                    objMs.dblopnqty = 0;
                }

                if (rdr["tran_qty"].ToString() != "")
                {
                    objMs.dblTranqty = Convert.ToDouble(rdr["tran_qty"]);
                }
                else
                {
                    objMs.dblTranqty = 0;
                }
                if (rdr["outward_qty"].ToString() != "")
                {
                    objMs.dblOutwardQty  = Convert.ToDouble(rdr["outward_qty"]);
                }
                else
                {
                    objMs.dblOutwardQty = 0;
                }

                if (rdr["inward_qty"].ToString() != "")
                {
                    objMs.dblInwardQty  = Convert.ToDouble(rdr["inward_qty"]);
                }
                else
                {
                    objMs.dblInwardQty = 0;
                }

                if (rdr["damage_qty"].ToString() != "")
                {
                    objMs.dbldamageQty  = Convert.ToDouble(rdr["damage_qty"]);
                }
                else
                {
                    objMs.dbldamageQty = 0;
                }

                if (rdr["net_amount"].ToString() != "")
                {
                    objMs.dblNetAmount = Convert.ToDouble(rdr["net_amount"]);
                }
                else
                {
                    objMs.dblNetAmount = 0;
                }

                if (rdr["issue_ref_no"].ToString() != "")
                {
                    objMs.IssueRefNo = rdr["issue_ref_no"].ToString();
                }
                else
                {
                    objMs.IssueRefNo = "";
                }

                objMs.PostStatus = rdr["post_status"].ToString();




                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }

        public List<Inventory> GetClosingQty(string where)
        {
            string packageName = "PKG_FNB_INV.ClosingQty";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,20,where,ParameterDirection.Input),
                    //new OracleParameter("pwhere1",OracleDbType.Varchar2,20,"",ParameterDirection.Input), 
                };
            return GetClosingQty(packageName, parameterList);
        }
        private List<Inventory> GetClosingQty(string packageName, OracleParameter[] parameterList)
        {
            List<Inventory> objFood = new List<Inventory>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                Inventory objMs = new Inventory();
                objMs.dblClosingQty = Convert.ToDouble( rdr["tran_qty"]);
                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }

        public List<InventoryRO> GetfnbInventoryDetails(string PfDate,string pTdate)
        {
            string packageName = "PKG_FNB_REPORTS.GetFnbInventory";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                   new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                   new OracleParameter("pwhere",OracleDbType.Varchar2,30,PfDate,ParameterDirection.Input),
                   new OracleParameter("pwhere1",OracleDbType.Varchar2,30,pTdate,ParameterDirection.Input),

                };
            return GetfnbInventoryDetails(packageName, parameterList);
        }
        private List<InventoryRO> GetfnbInventoryDetails(string packageName, OracleParameter[] parameterList)
        {
            List<InventoryRO> objFood = new List<InventoryRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
           while (rdr.Read())
            {
                InventoryRO objMs = new InventoryRO();
                if (rdr["food_id"].ToString() != "")
                {
                    objMs.FoodID = rdr["food_id"].ToString();
                }
                else
                {
                    objMs.FoodID = "";
                }

                if (rdr["food_name"].ToString() != "")
                {
                    objMs.FoodName = rdr["food_name"].ToString();
                }
                else
                {
                    objMs.FoodName = "";
                }

                if (rdr["opn_qty"].ToString() != "")
                {
                    objMs.dblopnqty = Convert.ToDouble(rdr["opn_qty"]);
                }
                else
                {
                    objMs.dblopnqty = 0;
                }
                if (rdr["receivedtoday"].ToString() != "")
                {
                    objMs.dblReceivedQnty = Convert.ToDouble(rdr["receivedtoday"]);
                }
                else
                {
                    objMs.dblReceivedQnty = 0;
                }

                if (rdr["inward_qty"].ToString() != "")
                {
                    objMs.dblInwardQty = Convert.ToDouble(rdr["inward_qty"]);
                }
                else
                {
                    objMs.dblInwardQty = 0;
                }

                if (rdr["outward_qty"].ToString() != "")
                {
                    objMs.dblOutwardQty = Convert.ToDouble(rdr["outward_qty"]);
                }
                else
                {
                    objMs.dblOutwardQty = 0;
                }

                if (rdr["damage_qty"].ToString() != "")
                {
                    objMs.dbldamageQty = Convert.ToDouble(rdr["damage_qty"]);
                }
                else
                {
                    objMs.dbldamageQty = 0;
                }

                if (rdr["return_qty"].ToString() != "")
                {
                    objMs.dblReturnQty = Convert.ToDouble(rdr["return_qty"]);
                }
                else
                {
                    objMs.dblReturnQty = 0;
                }


                if (rdr["net_amount"].ToString() != "")
                {
                    objMs.dblNetAmount = Convert.ToDouble(rdr["net_amount"]);
                }
                else
                {
                    objMs.dblNetAmount = 0;
                }

                if (rdr["price"].ToString() != "")
                {
                    objMs.dblTranRate  = Convert.ToDouble(rdr["price"]);
                }
                else
                {
                    objMs.dblTranRate = 0;
                }

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }



        public List<MonthwiseMealRegisterRO> GetMonthWiseMealRegister(string strGrpID, string strDepID,string fDate,string tDate)
        {
            
            string packageName = "PKG_FNB_REPORTS.GetMonthwiseMealRegister";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                   new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                   new OracleParameter("PCall",OracleDbType.Varchar2,30,"",ParameterDirection.Input),
                   new OracleParameter("pgrpId",OracleDbType.Varchar2,30,strGrpID,ParameterDirection.Input),
                   new OracleParameter("pDepID",OracleDbType.Varchar2,30,strDepID,ParameterDirection.Input),
                   new OracleParameter("punitid",OracleDbType.Varchar2,30,"",ParameterDirection.Input),
                   new OracleParameter("pfdate",OracleDbType.Varchar2,30,fDate,ParameterDirection.Input),
                   new OracleParameter("pTdate",OracleDbType.Varchar2,30,tDate,ParameterDirection.Input),

                };
            return GetMonthWiseMealRegister(packageName, parameterList);
        }
        private List<MonthwiseMealRegisterRO> GetMonthWiseMealRegister(string packageName, OracleParameter[] parameterList)
        {
            List<MonthwiseMealRegisterRO> objFood = new List<MonthwiseMealRegisterRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MonthwiseMealRegisterRO objMs = new MonthwiseMealRegisterRO();
                if (rdr["emp_id"].ToString() != "")
                {
                    objMs.empID  = rdr["emp_id"].ToString();
                }
                else
                {
                    objMs.empID = "";
                }

                if (rdr["entry_by"].ToString() != "")
                {
                    objMs.empName = rdr["entry_by"].ToString();
                }
                else
                {
                    objMs.empName = "";
                }

                if (rdr["qnty"].ToString() != "")
                {
                    objMs.qnty = Convert.ToDouble(rdr["qnty"]);
                }
                else
                {
                    objMs.qnty = 0;
                }

                if (rdr["bill"].ToString() != "")
                {
                    objMs.Rate = Convert.ToDouble(rdr["bill"]);
                }
                else
                {
                    objMs.Rate = 0;
                }

                if (rdr["subsidy"].ToString() != "")
                {
                    objMs.subsidy = Convert.ToDouble(rdr["subsidy"]);
                }
                else
                {
                    objMs.subsidy = 0;
                }

                if (rdr["dis_rate"].ToString() != "")
                {
                    objMs.disRate = Convert.ToDouble(rdr["dis_rate"]);
                }
                else
                {
                    objMs.disRate = 0;
                }


                if (rdr["net_amount"].ToString() != "")
                {
                    objMs.NetAmount = Convert.ToDouble(rdr["net_amount"]);
                }
                else
                {
                    objMs.NetAmount = 0;
                }


                if (rdr["group_title"].ToString() != "")
                {
                    objMs.grpTitle = rdr["group_title"].ToString();
                }
                else
                {
                    objMs.grpTitle = "";
                }
                if (rdr["dsig_title"].ToString() != "")
                {
                    objMs.desTitle = rdr["dsig_title"].ToString();
                }
                else
                {
                    objMs.desTitle = "";
                }
                if (rdr["dept_title"].ToString() != "")
                {
                    objMs.deptittle = rdr["dept_title"].ToString();
                }
                else
                {
                    objMs.deptittle = "";
                }
                
                
                if (rdr["unit_title"].ToString() != "")
                {
                    objMs.unitTitle = rdr["unit_title"].ToString();
                }
                else
                {
                    objMs.unitTitle = "";
                }

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }


        public List<MonthwiseMealRegisterRO> GetMonthWiseMealRegisterAll(string strGrpID, string strDepID, string fDate, string tDate)
        {

            string packageName = "PKG_FNB_REPORTS.GetMonthwiseMealRegisterAll";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                   new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                   new OracleParameter("PCall",OracleDbType.Varchar2,30,"",ParameterDirection.Input),
                   new OracleParameter("pgrpId",OracleDbType.Varchar2,30,strGrpID,ParameterDirection.Input),
                   new OracleParameter("pDepID",OracleDbType.Varchar2,30,strDepID,ParameterDirection.Input),
                   new OracleParameter("punitid",OracleDbType.Varchar2,30,"",ParameterDirection.Input),
                   new OracleParameter("pfdate",OracleDbType.Varchar2,30,fDate,ParameterDirection.Input),
                   new OracleParameter("pTdate",OracleDbType.Varchar2,30,tDate,ParameterDirection.Input),

                };
            return GetMonthWiseMealRegisterAll(packageName, parameterList);
        }
        private List<MonthwiseMealRegisterRO> GetMonthWiseMealRegisterAll(string packageName, OracleParameter[] parameterList)
        {
            List<MonthwiseMealRegisterRO> objFood = new List<MonthwiseMealRegisterRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                MonthwiseMealRegisterRO objMs = new MonthwiseMealRegisterRO();
                if (rdr["emp_id"].ToString() != "")
                {
                    objMs.empID = rdr["emp_id"].ToString();
                }
                else
                {
                    objMs.empID = "";
                }

                if (rdr["entry_by"].ToString() != "")
                {
                    objMs.empName = rdr["entry_by"].ToString();
                }
                else
                {
                    objMs.empName = "";
                }

                if (rdr["qnty"].ToString() != "")
                {
                    objMs.qnty = Convert.ToDouble(rdr["qnty"]);
                }
                else
                {
                    objMs.qnty = 0;
                }

                if (rdr["bill"].ToString() != "")
                {
                    objMs.Rate = Convert.ToDouble(rdr["bill"]);
                }
                else
                {
                    objMs.Rate = 0;
                }

                if (rdr["subsidy"].ToString() != "")
                {
                    objMs.subsidy = Convert.ToDouble(rdr["subsidy"]);
                }
                else
                {
                    objMs.subsidy = 0;
                }

                if (rdr["dis_rate"].ToString() != "")
                {
                    objMs.disRate = Convert.ToDouble(rdr["dis_rate"]);
                }
                else
                {
                    objMs.disRate = 0;
                }


                if (rdr["net_amount"].ToString() != "")
                {
                    objMs.NetAmount = Convert.ToDouble(rdr["net_amount"]);
                }
                else
                {
                    objMs.NetAmount = 0;
                }


                if (rdr["group_title"].ToString() != "")
                {
                    objMs.grpTitle = rdr["group_title"].ToString();
                }
                else
                {
                    objMs.grpTitle = "";
                }
                if (rdr["dsig_title"].ToString() != "")
                {
                    objMs.desTitle = rdr["dsig_title"].ToString();
                }
                else
                {
                    objMs.desTitle = "";
                }
                if (rdr["dept_title"].ToString() != "")
                {
                    objMs.deptittle = rdr["dept_title"].ToString();
                }
                else
                {
                    objMs.deptittle = "";
                }


                if (rdr["unit_title"].ToString() != "")
                {
                    objMs.unitTitle = rdr["unit_title"].ToString();
                }
                else
                {
                    objMs.unitTitle = "";
                }

                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }










        public List<Visitors> CheckEmpID(string where,string fDate,string  tDate)
        {
            string packageName = "PKG_FNB.CheckempId";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur1",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,30,where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,20,fDate,ParameterDirection.Input), 
                    new OracleParameter("pwhere2",OracleDbType.Varchar2,20,tDate,ParameterDirection.Input), 

                };
            return CheckEmpID(packageName, parameterList);
        }
        private List<Visitors> CheckEmpID(string packageName, OracleParameter[] parameterList)
        {
            List<Visitors> objFood = new List<Visitors>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                Visitors objMs = new Visitors();
                objMs.empID = rdr["emp_id"].ToString();
                objFood.Add(objMs);
            }
            rdr.Close();
            return objFood;
        }










    }
}
