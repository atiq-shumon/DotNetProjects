using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.ATMS.MODEL;
using AH.DUtility;
using AH.OracleManager;

namespace AH.ATMS.DAL
{
    public class CollectionDal
    {
        //private string connstring = Utility.GetConnectionString(Utility.Module.ATMS);
        private string connstring = Utility.GetConnectionString(Utility.Module.INVMS);
        string packageName = string.Empty;
        //public List<AssetsGroup> GetAssetsGroupTree()
        //{
        //    string packageName = "PKG_ASSETS.GetStockgroupTree";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            //new OracleParameter("ParamVoucherNo",OracleDbType.Varchar2,60,strRefNo,ParameterDirection.Input)
        //        };
        //    return GetAssetsGroupTree(packageName, parameterList);
        //}
        //private List<AssetsGroup> GetAssetsGroupTree(string packageName, OracleParameter[] parameterList)
        //{
        //    List<AssetsGroup> objGrpTree = new List<AssetsGroup>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        AssetsGroup grp = new AssetsGroup();
        //        grp.GroupID = rdr["group_id"].ToString();
        //        grp.GroupName = rdr["group_name"].ToString();
        //        objGrpTree.Add(grp);
        //    }
        //    rdr.Close();
        //    return objGrpTree;
        //}

        //public List<AssetsGroup> Gegroup(string Control,string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return Gegroup(packageName, parameterList);
        //}
        //private List<AssetsGroup> Gegroup(string packageName, OracleParameter[] parameterList)
        //{
        //    List<AssetsGroup> objGrpTree = new List<AssetsGroup>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        AssetsGroup grp = new AssetsGroup();
        //        grp.GroupID = rdr["group_id"].ToString();
        //        grp.GroupName = rdr["group_name"].ToString();
        //        objGrpTree.Add(grp);
        //    }
        //    rdr.Close();
        //    return objGrpTree;
        //}


        //public List<Brand> GeBrandTree(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return GeBrandTree(packageName, parameterList);
        //}
        //private List<Brand> GeBrandTree(string packageName, OracleParameter[] parameterList)
        //{
        //    List<Brand> objGrpTree = new List<Brand>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        Brand brnd = new Brand();
        //        brnd.BrandID = rdr["brand_id"].ToString();
        //        brnd.BrandName = rdr["brand_name"].ToString();
        //        objGrpTree.Add(brnd);
        //    }
        //    rdr.Close();
        //    return objGrpTree;
        //}

        //public List<MaterialReceipt> GeAgsinstRefNo(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return GeAgsinstRefNo(packageName, parameterList);
        //}
        //private List<MaterialReceipt> GeAgsinstRefNo(string packageName, OracleParameter[] parameterList)
        //{
        //    List<MaterialReceipt> objAgnst = new List<MaterialReceipt>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        MaterialReceipt mrr = new MaterialReceipt();
        //        mrr.MrrNo = rdr["mrr_id"].ToString();
        //        objAgnst.Add(mrr);
        //    }
        //    rdr.Close();
        //    return objAgnst;
        //}


        //public List<MaterialReceipt> DisplayDetailsAgainsrRef(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return DisplayDetailsAgainsrRef(packageName, parameterList);
        //}
        //private List<MaterialReceipt> DisplayDetailsAgainsrRef(string packageName, OracleParameter[] parameterList)
        //{
        //    List<MaterialReceipt> objAgnst = new List<MaterialReceipt>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        MaterialReceipt mrr = new MaterialReceipt();
        //        mrr.againstDate = rdr["MRR_Date"].ToString();
        //        mrr.ProductID  = rdr["item_id"].ToString();
        //        mrr.ProductName  = rdr["product"].ToString();
        //        mrr.UnitID = rdr["unit_id"].ToString();
        //        mrr.UnitName = rdr["unit"].ToString();
        //        mrr.supplierCode = rdr["supp_id"].ToString();
        //        mrr.ChallanNo  = rdr["challanno"].ToString();
        //        mrr.ChallanDate  = rdr["challan_date"].ToString();
        //        mrr.brandCode  = rdr["prod_brnd_id"].ToString();
        //        mrr.ModelId = rdr["prod_model_id"].ToString();
        //        mrr.ModelName  = rdr["name"].ToString();
        //        mrr.dblQty = Convert.ToDouble(rdr["mrr_qty"]);
        //        objAgnst.Add(mrr);
        //    }
        //    rdr.Close();
        //    return objAgnst;
        //}

        //public List<Supplier> GetSupplierID(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return GetSupplierID(packageName, parameterList);
        //}
        //private List<Supplier> GetSupplierID(string packageName, OracleParameter[] parameterList)
        //{
        //    List<Supplier> objSupp = new List<Supplier>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        Supplier Supp = new Supplier();
        //        Supp.supplierID = rdr["id"].ToString();
        //        Supp.supplierName = rdr["name"].ToString();

        //        objSupp.Add(Supp);
        //    }
        //    rdr.Close();
        //    return objSupp;
        //}

        //public List<AssetsUser> GetDepartment(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return GetDepartment(packageName, parameterList);
        //}
        //private List<AssetsUser> GetDepartment(string packageName, OracleParameter[] parameterList)
        //{
        //    List<AssetsUser> objAssets = new List<AssetsUser>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        AssetsUser Assets = new AssetsUser();
        //        if (rdr["dept_id"].ToString() != "")
        //        {
        //            Assets.DepID = rdr["dept_id"].ToString();
        //        }
        //        else
        //        {
        //            Assets.DepID = "";
        //        }
        //        if (rdr["dept_title"].ToString() != "")
        //        {
        //            Assets.DepName = rdr["dept_title"].ToString();
        //        }
        //        else
        //        {
        //            Assets.DepName = "";
        //        }

        //        objAssets.Add(Assets);
        //    }
        //    rdr.Close();
        //    return objAssets;
        //}

        //public List<AssetsUser> GetLastNo(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return GetLastNo(packageName, parameterList);
        //}
        //private List<AssetsUser> GetLastNo(string packageName, OracleParameter[] parameterList)
        //{
        //    List<AssetsUser> objAssets = new List<AssetsUser>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    if  (rdr.Read())
        //    {
        //        AssetsUser Assets = new AssetsUser();
        //        Assets.LaetNo = rdr["LastNo"].ToString();
        //        objAssets.Add(Assets);
        //    }
        //    rdr.Close();
        //    return objAssets;
        //}

        //public List<AssetsUser> GetAssetsUserStatus(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return GetAssetsUserStatus(packageName, parameterList);
        //}
        //private List<AssetsUser> GetAssetsUserStatus(string packageName, OracleParameter[] parameterList)
        //{
        //    List<AssetsUser> objAssets = new List<AssetsUser>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while  (rdr.Read())
        //    {
        //        AssetsUser Assets = new AssetsUser();
        //        Assets.UserId = rdr["user_id"].ToString();
        //        Assets.UserName = rdr["user_name"].ToString();
        //        Assets.intStatus = Convert.ToInt16( rdr["asstatus"].ToString());

        //        objAssets.Add(Assets);
        //    }
        //    rdr.Close();
        //    return objAssets;
        //}

        //public List<MaterialReceipt> DisplayBrandDetails(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return DisplayBrandDetails(packageName, parameterList);
        //}
        //private List<MaterialReceipt> DisplayBrandDetails(string packageName, OracleParameter[] parameterList)
        //{
        //    List<MaterialReceipt> objAgnst = new List<MaterialReceipt>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        MaterialReceipt mrr = new MaterialReceipt();
        //        mrr.TagNo = rdr["tran_id"].ToString();
        //        mrr.ProductID = rdr["itemid"].ToString();
        //        mrr.ProductName = rdr["itemname"].ToString();
        //        mrr.brandCode  = rdr["brandid"].ToString();
        //        mrr.brandName = rdr["brandname"].ToString();
        //        mrr.ModelId  = rdr["modelid"].ToString();
        //        mrr.ModelName  = rdr["modelname"].ToString();
        //        mrr.WarrentyDate = rdr["warrenty_date"].ToString();
        //        mrr.SerialNo = rdr["serial_no"].ToString();
        //        mrr.supplierCode = rdr["supplierid"].ToString();
        //        mrr.supplierName  = rdr["suppname"].ToString();
        //        mrr.ChallanNo  = rdr["challan_no"].ToString();
        //        mrr.ChallanDate  = rdr["challan_date"].ToString();
        //        mrr.agiaintRefNo  = rdr["against_ref_no"].ToString();
        //        mrr.againstDate = rdr["ref_date"].ToString();
        //        mrr.GroupCode = rdr["groupid"].ToString();
        //        mrr.UnitID = rdr["productunit"].ToString(); 
        //        objAgnst.Add(mrr);
        //    }
        //    rdr.Close();
        //    return objAgnst;
        //}

        //public List<AdditionalInformation> DisplayAddInformation(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return DisplayAddInformation(packageName, parameterList);
        //}
        //private List<AdditionalInformation> DisplayAddInformation(string packageName, OracleParameter[] parameterList)
        //{
        //    List<AdditionalInformation> objAdd = new List<AdditionalInformation>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        AdditionalInformation add = new AdditionalInformation();
        //        add.color = rdr["color"].ToString();
        //        add.condition = rdr["condition"].ToString();
        //        add.contactperson = rdr["contactperson"].ToString();
        //        add.manufacturername  = rdr["manufacturername"].ToString();
        //        add.serviceprovidername = rdr["serviceprovidername"].ToString();
        //        add.mobileno  = rdr["mobileno"].ToString();
        //        add.componentname  = rdr["componentname"].ToString();
        //        add.description  = rdr["description"].ToString();
        //        add.notes  = rdr["notes"].ToString();
        //        objAdd.Add(add);
        //    }
        //    rdr.Close();
        //    return objAdd;
        //}

        //public List<AssetsUser> GetAssetsUsertoDep(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return GetAssetsUsertoDep(packageName, parameterList);
        //}
        //private List<AssetsUser> GetAssetsUsertoDep(string packageName, OracleParameter[] parameterList)
        //{
        //    List<AssetsUser> objAssets = new List<AssetsUser>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        AssetsUser Assets = new AssetsUser();
        //        Assets.UserId = rdr["user_id"].ToString();
        //        Assets.UserName = rdr["user_name"].ToString();
        //        //ssets.intStatus = Convert.ToInt16(rdr["asstatus"].ToString());
        //        objAssets.Add(Assets);
        //    }
        //    rdr.Close();
        //    return objAssets;
        //}

        //public List<MaterialReceipt> GetTotalQty(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return GetTotalQty(packageName, parameterList);
        //}
        //private List<MaterialReceipt> GetTotalQty(string packageName, OracleParameter[] parameterList)
        //{
        //    List<MaterialReceipt> objAssets = new List<MaterialReceipt>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    if  (rdr.Read())
        //    {
        //        MaterialReceipt mrr = new MaterialReceipt();
        //        mrr.dblQty = Convert.ToDouble(rdr["quantity"]);
        //        //ssets.intStatus = Convert.ToInt16(rdr["asstatus"].ToString());
        //        objAssets.Add(mrr);
        //    }
        //    rdr.Close();
        //    return objAssets;
        //}
        public List<ServiceWarrenty> GetwarrentyService(string Control, string Where)
        {
            string packageName = "PKG_ASSETS.Getstockinformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
                };
            return GetwarrentyService(packageName, parameterList);
        }
        private List<ServiceWarrenty> GetwarrentyService(string packageName, OracleParameter[] parameterList)
        {
            List<ServiceWarrenty> objService = new List<ServiceWarrenty>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while  (rdr.Read())
            {
                ServiceWarrenty service = new ServiceWarrenty();
                service.TagNo  = rdr["tag_no"].ToString();
                service.productCode = rdr["item_id"].ToString();
                service.productName = rdr["product"].ToString();
                service.voucherDate = rdr["voucher_date"].ToString();
                service.ServiceStartDate = rdr["service_start_date"].ToString();
                service.ServiceEndDate = rdr["service_end_date"].ToString();
                service.WarrentyDate = rdr["warrenty_date"].ToString();
                service.RecivedDate = rdr["receipt_date"].ToString();
                service.Notes = rdr["notes"].ToString();
                service.WarrentyStatus = Convert.ToInt16 (rdr["w_status"]);
                objService.Add(service);
            }
            rdr.Close();
            return objService;
        }

        //public List<MaterialReceipt> DisplayvoucherDetails(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return DisplayvoucherDetails(packageName, parameterList);

        //}
        //private List<MaterialReceipt> DisplayvoucherDetails(string packageName, OracleParameter[] parameterList)
        //{
        //    List<MaterialReceipt> objAgnst = new List<MaterialReceipt>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        MaterialReceipt mrr = new MaterialReceipt();
        //        mrr.MrrNo  = rdr["mrr_no"].ToString();
        //        mrr.TagNo = rdr["tran_id"].ToString();
        //        mrr.mrrdate = rdr["mrr_date"].ToString();
        //        //mrr.supplierCode = rdr["supplierid"].ToString();
        //        //mrr.ch = rdr["challan_no"].ToString();
        //        //mrr.ChallanDate = rdr["challan_date"].ToString();
        //        //mrr.agiaintRefNo = rdr["against_ref_no"].ToString();
        //        //mrr.againstDate = rdr["ref_date"].ToString();
        //        mrr.Notes = rdr["notes"].ToString();
        //        mrr.assetsUser = rdr["assets_user"].ToString();
        //        mrr.DepID = rdr["dept_id"].ToString();
        //        mrr.ProductID = rdr["product_id"].ToString();
        //        mrr.ProductName = rdr["itemname"].ToString();
        //        mrr.brandCode = rdr["brand_id"].ToString();
        //        mrr.ModelId = rdr["model_id"].ToString();
        //        //mrr.ModelName = rdr["modelname"].ToString();
        //        //mrr.WarrentyDate = rdr["warrenty_date"].ToString();
        //        mrr.SerialNo = rdr["serial_no"].ToString();
        //       // mrr.supplierName = rdr["suppname"].ToString();
        //       // mrr.GroupCode = rdr["groupid"].ToString();
        //        mrr.UnitID = rdr["productunit"].ToString();
        //        mrr.dblQty = Convert.ToDouble(rdr["quantity"]);

        //        objAgnst.Add(mrr);
        //    }
        //    rdr.Close();
        //    return objAgnst;
        //}
        //public List<MaterialReceipt> DisplayDetaialstoMrr(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return DisplayDetaialstoMrr(packageName, parameterList);
        //}
        //private List<MaterialReceipt> DisplayDetaialstoMrr(string packageName, OracleParameter[] parameterList)
        //{
        //    List<MaterialReceipt> objAgnst = new List<MaterialReceipt>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        MaterialReceipt mrr = new MaterialReceipt();
        //        mrr.MrrNo = rdr["mrr_no"].ToString();
        //        mrr.TagNo = rdr["tran_id"].ToString();
        //        mrr.mrrdate = rdr["mrr_date"].ToString();
        //        if (rdr["supplier_id"].ToString() != "")
        //        {
        //            mrr.supplierCode = rdr["supplier_id"].ToString();
        //        }
        //        else
        //        {
        //            mrr.supplierCode = "";
        //        }
        //        if (rdr["challan_no"].ToString() != "")
        //        {
        //            mrr.ChallanNo = rdr["challan_no"].ToString();
        //        }
        //        else
        //        {
        //            mrr.ChallanNo = "";
        //        }
        //        if (rdr["challan_date"].ToString() != "")
        //        {
        //            mrr.ChallanDate = rdr["challan_date"].ToString();
        //        }
        //        else
        //        {
        //            mrr.ChallanDate = "";
        //        }
        //        if (rdr["against_ref_no"].ToString() != "")
        //        {
        //            mrr.agiaintRefNo = rdr["against_ref_no"].ToString();
        //        }
        //        else
        //        {
        //            mrr.agiaintRefNo = "";
        //        }
        //        if (rdr["ref_date"].ToString() != "")
        //        {
        //            mrr.againstDate = rdr["ref_date"].ToString();
        //        }
        //        else
        //        {
        //            mrr.againstDate = "";
        //        }

        //        if (rdr["notes"].ToString() != "")
        //        {
        //            mrr.Notes = rdr["notes"].ToString();
        //        }
        //        else
        //        {
        //            mrr.Notes = "";
        //        }
        //        if (rdr["assets_user"].ToString() != "")
        //        {
        //            mrr.assetsUser = rdr["assets_user"].ToString();
        //        }
        //        else
        //        {
        //            mrr.assetsUser = "";
        //        }
        //        if (rdr["dept_id"].ToString() != "")
        //        {
        //            mrr.DepID = rdr["dept_id"].ToString();
        //        }
        //        else
        //        {
        //            mrr.DepID = "";
        //        }
        //        if (rdr["product_id"].ToString() != "")
        //        {
        //            mrr.ProductID = rdr["product_id"].ToString();
        //        }
        //        if (rdr["itemname"].ToString() != "")
        //        {
        //            mrr.ProductName = rdr["itemname"].ToString();
        //        }
        //        else
        //        {
        //            mrr.ProductName = "";
        //        }
        //        if (rdr["brand_id"].ToString() != "")
        //        {
        //            mrr.brandCode = rdr["brand_id"].ToString();
        //        }
        //        else
        //        {
        //            mrr.brandCode = "";
        //        }
        //        if (rdr["model_id"].ToString() != "")
        //        {
        //            mrr.ModelId = rdr["model_id"].ToString();
        //        }
        //        else
        //        {
        //            mrr.ModelId = "";
        //        }
        //        if (rdr["modelname"].ToString() != "")
        //        {
        //            mrr.ModelName = rdr["modelname"].ToString();
        //        }
        //        else
        //        {
        //             mrr.ModelName="";
        //        }
        //        if (rdr["warrenty_date"].ToString() != "")
        //        {
        //            mrr.WarrentyDate = rdr["warrenty_date"].ToString();
        //        }
        //        else
        //        {
        //            mrr.WarrentyDate="";
        //        }
        //        if (rdr["serial_no"].ToString() != "")
        //        {
        //            mrr.SerialNo = rdr["serial_no"].ToString();
        //        }
        //        else
        //        {
        //            mrr.SerialNo = "";
        //        }

        //        if (rdr["des1"].ToString() != "")
        //        {
        //            mrr.Des1 = rdr["des1"].ToString();
        //        }
        //        else
        //        {
        //            mrr.Des1 = "";
        //        }
        //        if (rdr["des2"].ToString() != "")
        //        {
        //            mrr.Des2 = rdr["des2"].ToString();
        //        }
        //        else
        //        {
        //            mrr.Des2 = "";
        //        }
        //        if (rdr["des3"].ToString() != "")
        //        {
        //            mrr.Des3 = rdr["des3"].ToString();
        //        }
        //        else
        //        {
        //            mrr.Des3 = "";
        //        }



        //        //if (rdr["suppname"].ToString() != "")
        //        //{
        //        //    mrr.supplierName = rdr["suppname"].ToString();
        //        //}
        //        //else
        //        //{
        //        //    mrr.supplierName = "";
        //        //}
        //        //if (rdr["groupid"].ToString() != "")
        //        //{
        //        //    mrr.GroupCode = rdr["groupid"].ToString();
        //        //}
        //        //else
        //        //{
        //        //    mrr.GroupCode = "";
        //        //}
        //        if (rdr["productunit"].ToString() != "")
        //        {
        //            mrr.UnitID = rdr["productunit"].ToString();
        //        }
        //        else
        //        {
        //            mrr.UnitID = "";
        //        }
        //        if (rdr["unitname"].ToString() != "")
        //        {
        //            mrr.UnitName = rdr["unitname"].ToString();
        //        }
        //        else
        //        {
        //            mrr.UnitName = "";
        //        }

        //        mrr.dblQty = Convert.ToDouble(rdr["quantity"]);

        //        if (rdr["warrenty_date"].ToString() != "")
        //        {
        //            mrr.WarrentyDate  = rdr["warrenty_date"].ToString();
        //        }
        //        else
        //        {
        //            mrr.WarrentyDate = "";
        //        }
        //        objAgnst.Add(mrr);
        //    }
        //    rdr.Close();
        //    return objAgnst;
        //}

        //public List<MaterialReceipt> GetMrrNo(string Control, string Where)
        //{
        //    string packageName = "PKG_ASSETS.Getstockinformation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //        };
        //    return GetMrrNo(packageName, parameterList);
        //}
        //private List<MaterialReceipt> GetMrrNo(string packageName, OracleParameter[] parameterList)
        //{
        //    List<MaterialReceipt> objAgnst = new List<MaterialReceipt>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        MaterialReceipt mrr = new MaterialReceipt();
        //        if (rdr["mrr_no"].ToString() != "")
        //        {
        //            mrr.MrrNo = rdr["mrr_no"].ToString();
        //        }
        //        else
        //        {
        //            mrr.MrrNo = "";
        //        }
        //        if (rdr["against_ref_no"].ToString() != "")
        //        {
        //            mrr.agiaintRefNo = rdr["against_ref_no"].ToString();
        //        }
        //        else
        //        {
        //            mrr.agiaintRefNo = "";
        //        }
        //        objAgnst.Add(mrr);
        //    }
        //    rdr.Close();
        //    return objAgnst;
        //}

        //public List<AssetsIssue> GetAssetsUserInfo(string Control, string Where, string Where1)
        //{
        //    string packageName = "PKG_ASSETS.GetAssetsUserDetails";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
        //            new OracleParameter("Where1",OracleDbType.Varchar2,60,Where1,ParameterDirection.Input),
        //        };
        //    return GetAssetsUserInfo(packageName, parameterList);
        //}
        //private List<AssetsIssue> GetAssetsUserInfo(string packageName, OracleParameter[] parameterList)
        //{
        //    List<AssetsIssue> objAgnst = new List<AssetsIssue>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        AssetsIssue user = new AssetsIssue();
        //        user.IssueNo = rdr["tran_id"].ToString();
        //        user.Issudate = rdr["mrr_date"].ToString();
        //        user.ProductName = rdr["itemname"].ToString();
        //        user.brandName = rdr["brandname"].ToString();
        //        user.ModelName = rdr["modelname"].ToString();
        //        user.UnitName = rdr["unitname"].ToString();
        //        user.dblQty =  Convert.ToDouble(rdr["quantity"].ToString()) *-1;
        //        objAgnst.Add(user);
        //    }
        //    rdr.Close();
        //    return objAgnst;
        //}


        public List<VoucherRo> DisplayvoucherReport(string Control, int  Where, string Where1)
        {
            string packageName = "PKG_ASSETS_REPORT.getvoucherdetails";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Int32,2,Where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,60,Where1,ParameterDirection.Input),
                };
            return DisplayvoucherReport(packageName, parameterList);
        }
        private List<VoucherRo> DisplayvoucherReport(string packageName, OracleParameter[] parameterList)
        {
            List<VoucherRo> objAgnst = new List<VoucherRo>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                VoucherRo mrr = new VoucherRo();
                mrr.MrrNo = rdr["mrr_no"].ToString();
                mrr.TagNo = rdr["tran_id"].ToString();
                mrr.mrrdate = rdr["mrr_date"].ToString();
                if (rdr["supplier_id"].ToString() != "")
                {
                    mrr.supplierCode = rdr["supplier_id"].ToString();
                }
                else
                {
                    mrr.supplierCode = "";
                }
                if (rdr["challan_no"].ToString() != "")
                {
                    mrr.ChallanNo = rdr["challan_no"].ToString();
                }
                else
                {
                    mrr.ChallanNo = "";
                }
                if (rdr["challan_date"].ToString() != "")
                {
                    mrr.ChallanDate = rdr["challan_date"].ToString();
                }
                else
                {
                    mrr.ChallanDate = "";
                }
                if (rdr["against_ref_no"].ToString() != "")
                {
                    mrr.agiaintRefNo = rdr["against_ref_no"].ToString();
                }
                else
                {
                    mrr.agiaintRefNo = "";
                }
                if (rdr["ref_date"].ToString() != "")
                {
                    mrr.againstDate = rdr["ref_date"].ToString();
                }
                else
                {
                    mrr.againstDate = "";
                }

                if (rdr["notes"].ToString() != "")
                {
                    mrr.Notes = rdr["notes"].ToString();
                }
                else
                {
                    mrr.Notes = "";
                }
                //if (rdr["user_name"].ToString() != "")
                //{
                //    mrr.assetsUser = rdr["user_name"].ToString();
                //}
                //else
                //{
                //    mrr.assetsUser = "";
                //}
                //if (rdr["dept_title"].ToString() != "")
                //{
                //    mrr.DepName = rdr["dept_title"].ToString();
                //}
                //else
                //{
                //    mrr.DepName = "";
                //}
                if (rdr["dept_id"].ToString() != "")
                {
                    mrr.DepID = rdr["dept_id"].ToString();
                }
                else
                {
                    mrr.DepID = "";
                }
                if (rdr["product_id"].ToString() != "")
                {
                    mrr.ProductID = rdr["product_id"].ToString();
                }
                if (rdr["itemname"].ToString() != "")
                {
                    mrr.ProductName = rdr["itemname"].ToString();
                }
                else
                {
                    mrr.ProductName = "";
                }
                if (rdr["brand_id"].ToString() != "")
                {
                    mrr.brandCode = rdr["brand_id"].ToString();
                }
                else
                {
                    mrr.brandCode = "";
                }
                if (rdr["model_id"].ToString() != "")
                {
                    mrr.ModelId = rdr["model_id"].ToString();
                }
                else
                {
                    mrr.ModelId = "";
                }
                if (rdr["modelname"].ToString() != "")
                {
                    mrr.ModelName = rdr["modelname"].ToString();
                }
                else
                {
                    mrr.ModelName = "";
                }
                if (rdr["warrenty_date"].ToString() != "")
                {
                    mrr.WarrentyDate = rdr["warrenty_date"].ToString();
                }
                else
                {
                    mrr.WarrentyDate = "";
                }
                if (rdr["serial_no"].ToString() != "")
                {
                    mrr.SerialNo = rdr["serial_no"].ToString();
                }
                else
                {
                    mrr.SerialNo = "";
                }

                if (rdr["des1"].ToString() != "")
                {
                    mrr.Des1 = rdr["des1"].ToString();
                }
                else
                {
                    mrr.Des1 = "";
                }
                if (rdr["des2"].ToString() != "")
                {
                    mrr.Des2 = rdr["des2"].ToString();
                }
                else
                {
                    mrr.Des2 = "";
                }
                if (rdr["des3"].ToString() != "")
                {
                    mrr.Des3 = rdr["des3"].ToString();
                }
                else
                {
                    mrr.Des3 = "";
                }
                if (rdr["productunit"].ToString() != "")
                {
                    mrr.UnitID = rdr["productunit"].ToString();
                }
                else
                {
                    mrr.UnitID = "";
                }
                if (rdr["unitname"].ToString() != "")
                {
                    mrr.UnitName = rdr["unitname"].ToString();
                }
                else
                {
                    mrr.UnitName = "";
                }

                mrr.dblQty = Convert.ToDouble(rdr["quantity"]);

                if (rdr["warrenty_date"].ToString() != "")
                {
                    mrr.WarrentyDate = rdr["warrenty_date"].ToString();
                }
                else
                {
                    mrr.WarrentyDate = "";
                }
                objAgnst.Add(mrr);
            }
            rdr.Close();
            return objAgnst;
        }


        public List<VoucherRo> DisplayvoucherIssueReport(string Control, int Where, string Where1)
        {
            string packageName = "PKG_ASSETS_REPORT.getvoucherdetails";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Int32,2,Where,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,60,Where1,ParameterDirection.Input),
                };
            return DisplayvoucherIssueReport(packageName, parameterList);
        }
        private List<VoucherRo> DisplayvoucherIssueReport(string packageName, OracleParameter[] parameterList)
        {
            List<VoucherRo> objAgnst = new List<VoucherRo>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                VoucherRo mrr = new VoucherRo();
                mrr.MrrNo = rdr["mrr_no"].ToString();
                mrr.TagNo = rdr["tran_id"].ToString();
                mrr.mrrdate = rdr["mrr_date"].ToString();
                if (rdr["supplier_id"].ToString() != "")
                {
                    mrr.supplierCode = rdr["supplier_id"].ToString();
                }
                else
                {
                    mrr.supplierCode = "";
                }
                if (rdr["challan_no"].ToString() != "")
                {
                    mrr.ChallanNo = rdr["challan_no"].ToString();
                }
                else
                {
                    mrr.ChallanNo = "";
                }
                if (rdr["challan_date"].ToString() != "")
                {
                    mrr.ChallanDate = rdr["challan_date"].ToString();
                }
                else
                {
                    mrr.ChallanDate = "";
                }
                if (rdr["against_ref_no"].ToString() != "")
                {
                    mrr.agiaintRefNo = rdr["against_ref_no"].ToString();
                }
                else
                {
                    mrr.agiaintRefNo = "";
                }
                if (rdr["ref_date"].ToString() != "")
                {
                    mrr.againstDate = rdr["ref_date"].ToString();
                }
                else
                {
                    mrr.againstDate = "";
                }

                if (rdr["notes"].ToString() != "")
                {
                    mrr.Notes = rdr["notes"].ToString();
                }
                else
                {
                    mrr.Notes = "";
                }
                if (rdr["user_name"].ToString() != "")
                {
                    mrr.assetsUser = rdr["user_name"].ToString();
                }
                else
                {
                    mrr.assetsUser = "";
                }
                if (rdr["dept_title"].ToString() != "")
                {
                    mrr.DepName = rdr["dept_title"].ToString();
                }
                else
                {
                    mrr.DepName = "";
                }
                if (rdr["dept_id"].ToString() != "")
                {
                    mrr.DepID = rdr["dept_id"].ToString();
                }
                else
                {
                    mrr.DepID = "";
                }
                if (rdr["product_id"].ToString() != "")
                {
                    mrr.ProductID = rdr["product_id"].ToString();
                }
                if (rdr["itemname"].ToString() != "")
                {
                    mrr.ProductName = rdr["itemname"].ToString();
                }
                else
                {
                    mrr.ProductName = "";
                }
                if (rdr["brand_id"].ToString() != "")
                {
                    mrr.brandCode = rdr["brand_id"].ToString();
                }
                else
                {
                    mrr.brandCode = "";
                }
                if (rdr["model_id"].ToString() != "")
                {
                    mrr.ModelId = rdr["model_id"].ToString();
                }
                else
                {
                    mrr.ModelId = "";
                }
                if (rdr["modelname"].ToString() != "")
                {
                    mrr.ModelName = rdr["modelname"].ToString();
                }
                else
                {
                    mrr.ModelName = "";
                }
                if (rdr["warrenty_date"].ToString() != "")
                {
                    mrr.WarrentyDate = rdr["warrenty_date"].ToString();
                }
                else
                {
                    mrr.WarrentyDate = "";
                }
                if (rdr["serial_no"].ToString() != "")
                {
                    mrr.SerialNo = rdr["serial_no"].ToString();
                }
                else
                {
                    mrr.SerialNo = "";
                }

                if (rdr["des1"].ToString() != "")
                {
                    mrr.Des1 = rdr["des1"].ToString();
                }
                else
                {
                    mrr.Des1 = "";
                }
                if (rdr["des2"].ToString() != "")
                {
                    mrr.Des2 = rdr["des2"].ToString();
                }
                else
                {
                    mrr.Des2 = "";
                }
                if (rdr["des3"].ToString() != "")
                {
                    mrr.Des3 = rdr["des3"].ToString();
                }
                else
                {
                    mrr.Des3 = "";
                }
                if (rdr["productunit"].ToString() != "")
                {
                    mrr.UnitID = rdr["productunit"].ToString();
                }
                else
                {
                    mrr.UnitID = "";
                }
                if (rdr["unitname"].ToString() != "")
                {
                    mrr.UnitName = rdr["unitname"].ToString();
                }
                else
                {
                    mrr.UnitName = "";
                }

                mrr.dblQty = Convert.ToDouble(rdr["quantity"]);

                if (rdr["warrenty_date"].ToString() != "")
                {
                    mrr.WarrentyDate = rdr["warrenty_date"].ToString();
                }
                else
                {
                    mrr.WarrentyDate = "";
                }
                objAgnst.Add(mrr);
            }
            rdr.Close();
            return objAgnst;
        }

        //public List<TermsandCondition> GetStoreID()
        //{
        //    string packageName = "PKG_INVENTORY_SETUP.GET_STORE_LOCATION";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                   
        //        };
        //    return GetStoreID(packageName, parameterList);
        //}
        //private List<TermsandCondition> GetStoreID(string packageName, OracleParameter[] parameterList)
        //{
        //    List<TermsandCondition> objTermscon = new List<TermsandCondition>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        TermsandCondition Terms = new TermsandCondition();
        //        Terms.storeID = rdr["StoreID"].ToString();
        //        Terms.storeName = rdr["StoreName"].ToString();
        //        objTermscon.Add(Terms);
        //    }
        //    rdr.Close();
        //    return objTermscon;
        //}

    }
}
