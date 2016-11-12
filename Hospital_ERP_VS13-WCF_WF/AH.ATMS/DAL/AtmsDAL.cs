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
    public class AtmsDAL
    {
        //private string connstring = Utility.GetConnectionString(Utility.Module.ATMS);
        private string connstring = Utility.GetConnectionString(Utility.Module.INVMS);
        string packageName = string.Empty;

        #region "Comments"
        //public short SaveDepartment(Department Dept)
        //{

        //    packageName = "AGH_ATMS.PKG_ASSETS.insert_department";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("p_dept_name",OracleDbType.Varchar2,60,Dept.DepName,ParameterDirection.Input),
        //        new OracleParameter("p_remarks",OracleDbType.Varchar2 ,60,Dept.Remarks,ParameterDirection.Input),
        //        new OracleParameter("p_form_name",OracleDbType.Varchar2,60,Dept.FormName,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Dept.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,Dept.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,Dept.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,Dept.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,Dept.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}

        //public short SaveGroup(AssetsGroup group)
        //{

        //    packageName = "PKG_ASSETS.Insert_Group";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("p_group_name",OracleDbType.Varchar2,60,group.GroupName,ParameterDirection.Input),
        //        new OracleParameter("p_form_name",OracleDbType.Varchar2,60,group.FormName,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,group.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,group.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,group.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,group.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,group.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}


        //public short SaveBrand(Brand  Brnd)
        //{

        //    packageName = "PKG_ASSETS.Insert_Brand";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("p_Brand_name",OracleDbType.Varchar2,60,Brnd.BrandName,ParameterDirection.Input),
        //        new OracleParameter("p_group_id",OracleDbType.Varchar2,60,Brnd.groupid,ParameterDirection.Input),
        //        new OracleParameter("p_form_name",OracleDbType.Varchar2,60,Brnd.FormName,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Brnd.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,Brnd.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,Brnd.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,Brnd.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,Brnd.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}

        //public short ProcessGenerated(ProcessGenerated Process)
        //{

        //    packageName = "PKG_ASSETS.ProcessGenerated";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("p_form_name",OracleDbType.Varchar2,60,Process.FormName,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Process.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,Process.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("Pcomid",OracleDbType.Varchar2,2,Process.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("Plocid",OracleDbType.Varchar2,2,Process.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,Process.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}

        //public string  SaveMaterialReceipt(MaterialReceipt mrr)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.insert_mrr_master_new";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("ref_no_out",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
        //        new OracleParameter("p_mrr_date",OracleDbType.Varchar2 ,60,mrr.mrrdate,ParameterDirection.Input),
        //        new OracleParameter("p_supplier_id",OracleDbType.Varchar2 ,60,mrr.supplierCode,ParameterDirection.Input),
        //        new OracleParameter("p_challan_no",OracleDbType.Varchar2 ,60,mrr.ChallanNo,ParameterDirection.Input),
        //        new OracleParameter("p_challan_date",OracleDbType.Varchar2 ,60,mrr.ChallanDate,ParameterDirection.Input),
        //        new OracleParameter("p_Agnst_Ref_no",OracleDbType.Varchar2 ,60,mrr.agiaintRefNo,ParameterDirection.Input),
        //        new OracleParameter("p_Ref_date",OracleDbType.Varchar2 ,60,mrr.againstDate,ParameterDirection.Input),
        //        new OracleParameter("p_voucher_type",OracleDbType.Varchar2 ,60,mrr.intVtype,ParameterDirection.Input),
        //        new OracleParameter("p_other_fare_add",OracleDbType.Double ,8,0,ParameterDirection.Input),
        //        new OracleParameter("p_other_fare_less",OracleDbType.Double ,30,0,ParameterDirection.Input),
        //        new OracleParameter("p_net_amount",OracleDbType.Double ,10,0,ParameterDirection.Input),
        //        new OracleParameter("p_notes",OracleDbType.Varchar2 ,60,mrr.Notes,ParameterDirection.Input),
        //        new OracleParameter("p_form_name",OracleDbType.Varchar2,60,mrr.FormName,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,mrr.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,mrr.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,mrr.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    OracleParameter prm = parameterList[0];
        //    if ((OracleString)prm.Value != "")
        //        return prm.Value.ToString();
        //    else return "0"; 
        //}

        //public short  SaveMaterialReceiptTran(string strMrrNo,int vType,string strProductID,string strBarndID,string strModelNo,
        //                                        string strUnit,string strSlNo,string des1,string des2,string des3,double dblQty,
        //                                            double dblRate,double dblAmount,string strExpDate, MaterialReceipt mrr)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.insert_mrr_transaction_new";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("pmrrNo",OracleDbType.Varchar2 ,60,strMrrNo,ParameterDirection.Input),
        //        new OracleParameter("p_voucher_type",OracleDbType.Int16 ,2,vType,ParameterDirection.Input),
        //        new OracleParameter("p_product_id",OracleDbType.Varchar2 ,60,strProductID,ParameterDirection.Input),
        //        new OracleParameter("p_brand_id",OracleDbType.Varchar2 ,60,strBarndID,ParameterDirection.Input),
        //        new OracleParameter("p_model_no",OracleDbType.Varchar2 ,60,strModelNo,ParameterDirection.Input),
        //        new OracleParameter("p_product_unit",OracleDbType.Varchar2 ,60,strUnit,ParameterDirection.Input),
        //        new OracleParameter("p_serial_no",OracleDbType.Varchar2 ,60,strSlNo,ParameterDirection.Input),
        //        new OracleParameter("p_des_1",OracleDbType.Varchar2 ,100,des1,ParameterDirection.Input),
        //        new OracleParameter("p_des_2",OracleDbType.Varchar2 ,100,des2,ParameterDirection.Input),
        //        new OracleParameter("p_des_3",OracleDbType.Varchar2 ,100,des3,ParameterDirection.Input),
        //        new OracleParameter("p_quantity",OracleDbType.Double  ,30,dblQty,ParameterDirection.Input),
        //        new OracleParameter("p_rate",OracleDbType.Double ,30,dblRate,ParameterDirection.Input),
        //        //new OracleParameter("p_vat",OracleDbType.Varchar2 ,60,null,ParameterDirection.Input),
        //        new OracleParameter("p_net_amount",OracleDbType.Double ,30,dblAmount,ParameterDirection.Input),
        //        new OracleParameter("p_warranty_expire_date",OracleDbType.Varchar2 ,60,strExpDate,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryBy ,ParameterDirection.Input),
        //       // new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,mrr.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,mrr.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,mrr.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleString)prm.Value != "")
        //    //    return prm.Value.ToString();
        //    //else return "0";
        //    return 1;
        //}

        //public short SaveAssetsUser(string strDepID,string strUserID,long lngUerNo,string formName,  AssetsUser assets)
        //{

        //    packageName = "AGH_ATMS.PKG_ASSETS.Insert_AsetsUser";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("p_dep_id",OracleDbType.Varchar2,60,strDepID,ParameterDirection.Input),
        //        new OracleParameter("passetsuser",OracleDbType.Varchar2 ,60,strUserID,ParameterDirection.Input),
        //        new OracleParameter("userno",OracleDbType.Varchar2 ,60,lngUerNo,ParameterDirection.Input),

        //        new OracleParameter("p_form_name",OracleDbType.Varchar2,60,formName,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,assets.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,assets.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,assets.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,assets.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,assets.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}

        //public short SaveAdditionalInfo(AdditionalInformation  Addiinfo)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.Insert_AdditionalInfo";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("p_tag_no",OracleDbType.Varchar2,60,Addiinfo.tagNo ,ParameterDirection.Input),
        //        new OracleParameter("p_product_code",OracleDbType.Varchar2,60,Addiinfo.ProductCode ,ParameterDirection.Input),
        //        new OracleParameter("p_color",OracleDbType.Varchar2 ,60,Addiinfo.color ,ParameterDirection.Input),
        //        new OracleParameter("p_condition",OracleDbType.Varchar2,60,Addiinfo.condition ,ParameterDirection.Input),
        //        new OracleParameter("p_manufacturer",OracleDbType.Varchar2,60,Addiinfo.manufacturername ,ParameterDirection.Input),
        //        new OracleParameter("p_serviceprovidername",OracleDbType.Varchar2,60,Addiinfo.serviceprovidername ,ParameterDirection.Input),
        //        new OracleParameter("p_contactperson",OracleDbType.Varchar2,60,Addiinfo.contactperson,ParameterDirection.Input),
        //        new OracleParameter("p_mobileNo",OracleDbType.Varchar2,60,Addiinfo.mobileno ,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Addiinfo.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,Addiinfo.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,Addiinfo.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,Addiinfo.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,Addiinfo.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}
        //public short SaveAdditionalCompInfo(AdditionalInformation Addiinfo)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.Insert_Additionalcomponent";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("p_tag_no",OracleDbType.Varchar2,60,Addiinfo.tagNo ,ParameterDirection.Input),
        //        new OracleParameter("p_product_code",OracleDbType.Varchar2,60,Addiinfo.ProductCode ,ParameterDirection.Input),
        //        new OracleParameter("p_componentName",OracleDbType.Varchar2 ,60,Addiinfo.componentname ,ParameterDirection.Input),
        //        new OracleParameter("p_Description",OracleDbType.Varchar2,60,Addiinfo.description  ,ParameterDirection.Input),
        //        new OracleParameter("p_Notes",OracleDbType.Varchar2,60,Addiinfo.notes ,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Addiinfo.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,Addiinfo.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,Addiinfo.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,Addiinfo.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,Addiinfo.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}
        //public string SaveMatIssue(AssetsIssue issue)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.insert_Issue_master_new";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("ref_no_out",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
        //        new OracleParameter("p_mrr_date",OracleDbType.Varchar2 ,60,issue.Issudate,ParameterDirection.Input),
        //        new OracleParameter("p_voucher_type",OracleDbType.Varchar2 ,60,issue.intVtype,ParameterDirection.Input),
        //        new OracleParameter("p_notes",OracleDbType.Varchar2 ,60,issue.Notes,ParameterDirection.Input),
        //        new OracleParameter("p_depID",OracleDbType.Varchar2 ,60,issue.DepID,ParameterDirection.Input),
        //        new OracleParameter("p_assetsUser",OracleDbType.Varchar2 ,60,issue.AssetsUser ,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,issue.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,issue.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,issue.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,issue.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,issue.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    OracleParameter prm = parameterList[0];
        //    if ((OracleString)prm.Value != "")
        //        return prm.Value.ToString();
        //    else return "0";
        //}

        //public short SaveMaterialIssueTran(string strIssueNo, int vType, string strProductID, string strBarndID, string strModelNo,
        //                                       string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
        //                                           double dblRate, double dblAmount, string strExpDate, AssetsIssue Issue)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.insert_issue_tran_new";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("pmrrNo",OracleDbType.Varchar2 ,60,strIssueNo,ParameterDirection.Input),
        //        new OracleParameter("p_voucher_type",OracleDbType.Int16 ,2,vType,ParameterDirection.Input),
        //        new OracleParameter("p_product_id",OracleDbType.Varchar2 ,60,strProductID,ParameterDirection.Input),
        //        new OracleParameter("p_brand_id",OracleDbType.Varchar2 ,60,strBarndID,ParameterDirection.Input),
        //        new OracleParameter("p_model_no",OracleDbType.Varchar2 ,60,strModelNo,ParameterDirection.Input),
        //        new OracleParameter("p_product_unit",OracleDbType.Varchar2 ,60,strUnit,ParameterDirection.Input),
        //        new OracleParameter("p_serial_no",OracleDbType.Varchar2 ,60,strSlNo,ParameterDirection.Input),
        //        new OracleParameter("p_des_1",OracleDbType.Varchar2 ,100,des1,ParameterDirection.Input),
        //        new OracleParameter("p_des_2",OracleDbType.Varchar2 ,100,des2,ParameterDirection.Input),
        //        new OracleParameter("p_des_3",OracleDbType.Varchar2 ,100,des3,ParameterDirection.Input),
        //        new OracleParameter("p_quantity",OracleDbType.Double  ,30,dblQty,ParameterDirection.Input),
        //        new OracleParameter("p_rate",OracleDbType.Double ,30,dblRate,ParameterDirection.Input),
        //        //new OracleParameter("p_vat",OracleDbType.Varchar2 ,60,null,ParameterDirection.Input),
        //        new OracleParameter("p_net_amount",OracleDbType.Double ,30,dblAmount,ParameterDirection.Input),
        //        new OracleParameter("p_warranty_expire_date",OracleDbType.Varchar2 ,60,strExpDate,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Issue.EntryParameter.EntryBy ,ParameterDirection.Input),
        //       // new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,Issue.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,Issue.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,Issue.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleString)prm.Value != "")
        //    //    return prm.Value.ToString();
        //    //else return "0";
        //    return 1;
        //}
        #endregion
        #region "Warrenty"
        public short SaveServiceWarrenty(ServiceWarrenty service)
        {
            packageName = "AGH_ATMS.PKG_ASSETS.Insert_warrenty";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_tag_no",OracleDbType.Varchar2,60,service.TagNo,ParameterDirection.Input),
                new OracleParameter("p_product_code",OracleDbType.Varchar2 ,60,service.productCode,ParameterDirection.Input),
                new OracleParameter("p_voucher_date",OracleDbType.Varchar2 ,60,service.voucherDate ,ParameterDirection.Input),
                new OracleParameter("p_service_fdate",OracleDbType.Varchar2 ,60,service.ServiceStartDate,ParameterDirection.Input),
                new OracleParameter("p_service_tdate",OracleDbType.Varchar2 ,60,service.ServiceEndDate,ParameterDirection.Input),
                new OracleParameter("p_service_Wdate",OracleDbType.Varchar2 ,60,service.WarrentyDate,ParameterDirection.Input),
                new OracleParameter("p_Receipt_date",OracleDbType.Varchar2 ,60,service.RecivedDate,ParameterDirection.Input),
                new OracleParameter("p_notes",OracleDbType.Varchar2 ,60,service.Notes,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,service.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,service.EntryParameter.EntryDate ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,service.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,service.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,service.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
        }
        public short DeleteServiceWarrenty(string strTagNo)
        {
            packageName = "AGH_ATMS.PKG_ASSETS.Delete_warrenty";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_tag_no",OracleDbType.Varchar2,60,strTagNo,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }
        #endregion
        #region "Coments"
        //public short UpdatevoucherMaster(AssetsIssue issue)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.Update_Issue_master";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("ref_no_out",OracleDbType.Varchar2,60,issue.IssueNo,ParameterDirection.Input),
        //        new OracleParameter("p_mrr_date",OracleDbType.Varchar2 ,60,issue.Issudate,ParameterDirection.Input),
        //        new OracleParameter("p_voucher_type",OracleDbType.Varchar2 ,60,issue.intVtype,ParameterDirection.Input),
        //        new OracleParameter("p_notes",OracleDbType.Varchar2 ,60,issue.Notes,ParameterDirection.Input),
        //        new OracleParameter("p_depID",OracleDbType.Varchar2 ,60,issue.DepID,ParameterDirection.Input),
        //        new OracleParameter("p_assetsUser",OracleDbType.Varchar2 ,60,issue.AssetsUser ,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,issue.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,issue.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,issue.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,issue.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,issue.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleString)prm.Value != "")
        //    //    return prm.Value.ToString();
        //    //else return "0";
        //    return 1;
        //}

        //public short UpdatevoucherTran(AssetsIssue Issue)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.insert_issue_tran_new";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("pmrrNo",OracleDbType.Varchar2 ,60,Issue.IssueNo,ParameterDirection.Input),
        //        new OracleParameter("p_voucher_type",OracleDbType.Int16 ,2,Issue.intVtype,ParameterDirection.Input),
        //        new OracleParameter("p_product_id",OracleDbType.Varchar2 ,60,Issue.ProductID,ParameterDirection.Input),
        //        new OracleParameter("p_brand_id",OracleDbType.Varchar2 ,60,Issue.brandCode,ParameterDirection.Input),
        //        new OracleParameter("p_model_no",OracleDbType.Varchar2 ,60,Issue.ModelId,ParameterDirection.Input),
        //        new OracleParameter("p_product_unit",OracleDbType.Varchar2 ,60,Issue.UnitID,ParameterDirection.Input),
        //        new OracleParameter("p_serial_no",OracleDbType.Varchar2 ,60,Issue.SerialNo,ParameterDirection.Input),
        //        new OracleParameter("p_des_1",OracleDbType.Varchar2 ,100,null,ParameterDirection.Input),
        //        new OracleParameter("p_des_2",OracleDbType.Varchar2 ,100,null,ParameterDirection.Input),
        //        new OracleParameter("p_des_3",OracleDbType.Varchar2 ,100,null,ParameterDirection.Input),
        //        new OracleParameter("p_quantity",OracleDbType.Double  ,30,Issue.dblQty *-1,ParameterDirection.Input),
        //        new OracleParameter("p_rate",OracleDbType.Double ,30,0,ParameterDirection.Input),
        //        //new OracleParameter("p_vat",OracleDbType.Varchar2 ,60,null,ParameterDirection.Input),
        //        new OracleParameter("p_net_amount",OracleDbType.Double ,30,0,ParameterDirection.Input),
        //        new OracleParameter("p_warranty_expire_date",OracleDbType.Varchar2 ,60,null,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Issue.EntryParameter.EntryBy ,ParameterDirection.Input),
        //       // new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,Issue.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,Issue.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,Issue.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleString)prm.Value != "")
        //    //    return prm.Value.ToString();
        //    //else return "0";
        //    return 1;
        //}

        //public int UpdateMaterialReceipt(MaterialReceipt mrr)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.Update_mrr_master";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("ref_no_out",OracleDbType.Varchar2,60,mrr.MrrNo,ParameterDirection.Input),
        //        new OracleParameter("p_mrr_date",OracleDbType.Varchar2 ,60,mrr.mrrdate,ParameterDirection.Input),
        //        new OracleParameter("p_supplier_id",OracleDbType.Varchar2 ,60,mrr.supplierCode,ParameterDirection.Input),
        //        new OracleParameter("p_challan_no",OracleDbType.Varchar2 ,60,mrr.ChallanNo,ParameterDirection.Input),
        //        new OracleParameter("p_challan_date",OracleDbType.Varchar2 ,60,mrr.ChallanDate,ParameterDirection.Input),
        //        new OracleParameter("p_Agnst_Ref_no",OracleDbType.Varchar2 ,60,mrr.agiaintRefNo,ParameterDirection.Input),
        //        new OracleParameter("p_Ref_date",OracleDbType.Varchar2 ,60,mrr.againstDate,ParameterDirection.Input),
        //        new OracleParameter("p_voucher_type",OracleDbType.Varchar2 ,60,mrr.intVtype,ParameterDirection.Input),
        //        new OracleParameter("p_other_fare_add",OracleDbType.Double ,8,0,ParameterDirection.Input),
        //        new OracleParameter("p_other_fare_less",OracleDbType.Double ,30,0,ParameterDirection.Input),
        //        new OracleParameter("p_net_amount",OracleDbType.Double ,10,0,ParameterDirection.Input),
        //        new OracleParameter("p_notes",OracleDbType.Varchar2 ,60,mrr.Notes,ParameterDirection.Input),
        //        new OracleParameter("p_form_name",OracleDbType.Varchar2,60,mrr.FormName,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,mrr.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,mrr.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,mrr.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleString)prm.Value != "")
        //    //    return prm.Value.ToString();
        //    //else return "0";
        //    return 1;
        //}
        //public short UpdateMaterialReceiptTran(string strMrrNo, string strTranID, int vType, string strProductID, string strBarndID, string strModelNo,
        //                                       string strUnit, string strSlNo, string des1, string des2, string des3, double dblQty,
        //                                           double dblRate, double dblAmount, string strExpDate, MaterialReceipt mrr)
        //{
        //    packageName = "AGH_ATMS.PKG_ASSETS.Update_mrr_transaction";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("pmrrNo",OracleDbType.Varchar2 ,60,strMrrNo,ParameterDirection.Input),
        //        new OracleParameter("ptranid",OracleDbType.Varchar2 ,60,strTranID,ParameterDirection.Input),
        //        new OracleParameter("p_voucher_type",OracleDbType.Int16 ,2,vType,ParameterDirection.Input),
        //        new OracleParameter("p_product_id",OracleDbType.Varchar2 ,60,strProductID,ParameterDirection.Input),
        //        new OracleParameter("p_brand_id",OracleDbType.Varchar2 ,60,strBarndID,ParameterDirection.Input),
        //        new OracleParameter("p_model_no",OracleDbType.Varchar2 ,60,strModelNo,ParameterDirection.Input),
        //        new OracleParameter("p_product_unit",OracleDbType.Varchar2 ,60,strUnit,ParameterDirection.Input),
        //        new OracleParameter("p_serial_no",OracleDbType.Varchar2 ,60,strSlNo,ParameterDirection.Input),
        //        new OracleParameter("p_des_1",OracleDbType.Varchar2 ,100,des1,ParameterDirection.Input),
        //        new OracleParameter("p_des_2",OracleDbType.Varchar2 ,100,des2,ParameterDirection.Input),
        //        new OracleParameter("p_des_3",OracleDbType.Varchar2 ,100,des3,ParameterDirection.Input),
        //        new OracleParameter("p_quantity",OracleDbType.Double  ,30,dblQty,ParameterDirection.Input),
        //        new OracleParameter("p_rate",OracleDbType.Double ,30,dblRate,ParameterDirection.Input),
        //        //new OracleParameter("p_vat",OracleDbType.Varchar2 ,60,null,ParameterDirection.Input),
        //        new OracleParameter("p_net_amount",OracleDbType.Double ,30,dblAmount,ParameterDirection.Input),
        //        new OracleParameter("p_warranty_expire_date",OracleDbType.Varchar2 ,60,strExpDate,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryBy ,ParameterDirection.Input),
        //       // new OracleParameter("Pentrydate",OracleDbType.Varchar2,60,mrr.EntryParameter.EntryDate ,ParameterDirection.Input),
        //        new OracleParameter("PcomID",OracleDbType.Varchar2,2,mrr.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("PlocID",OracleDbType.Varchar2,2,mrr.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,mrr.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleString)prm.Value != "")
        //    //    return prm.Value.ToString();
        //    //else return "0";
        //    return 1;
        //}

        ////*********************Service Provider
        #endregion
        #region "Save/Update ServiceProvider"
        public short SaveServiceProviderInfor(ServiceProvider Sp)
        {

            packageName = "AGH_INVMS.PKG_MRR.Insert_serviceProvider";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_service_pro_name",OracleDbType.Varchar2,60,Sp.ServiceProviderName ,ParameterDirection.Input),
                new OracleParameter("p_address",OracleDbType.Varchar2 ,60,Sp.Address ,ParameterDirection.Input),
                new OracleParameter("p_web",OracleDbType.Varchar2,60,Sp.Web ,ParameterDirection.Input),
                new OracleParameter("p_phone",OracleDbType.Varchar2,60,Sp.Phone ,ParameterDirection.Input),
                new OracleParameter("p_fax",OracleDbType.Varchar2,60,Sp.Fax ,ParameterDirection.Input),
                new OracleParameter("p_email",OracleDbType.Varchar2,60,Sp.Email ,ParameterDirection.Input),
                new OracleParameter("p_contact_person",OracleDbType.Varchar2,60,Sp.ContactPerson ,ParameterDirection.Input),
                new OracleParameter("p_acc_code",OracleDbType.Varchar2,60,Sp.Acccode ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,60,Sp.Remarks ,ParameterDirection.Input),
                new OracleParameter("p_Proority",OracleDbType.Varchar2,1,Sp.Priority ,ParameterDirection.Input),
                new OracleParameter("p_Active",OracleDbType.Varchar2,2,Sp.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Sp.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,Sp.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,Sp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,Sp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Sp.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short UpdateServiceProviderInfor(ServiceProvider Sp)
        {

            packageName = "AGH_INVMS.PKG_MRR.Update_serviceProvider";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pid",OracleDbType.Varchar2,60,Sp.ID ,ParameterDirection.Input),
                new OracleParameter("p_service_pro_name",OracleDbType.Varchar2,60,Sp.ServiceProviderName ,ParameterDirection.Input),
                new OracleParameter("p_address",OracleDbType.Varchar2 ,60,Sp.Address ,ParameterDirection.Input),
                new OracleParameter("p_web",OracleDbType.Varchar2,60,Sp.Web ,ParameterDirection.Input),
                new OracleParameter("p_phone",OracleDbType.Varchar2,60,Sp.Phone ,ParameterDirection.Input),
                new OracleParameter("p_fax",OracleDbType.Varchar2,60,Sp.Fax ,ParameterDirection.Input),
                new OracleParameter("p_email",OracleDbType.Varchar2,60,Sp.Email ,ParameterDirection.Input),
                new OracleParameter("p_contact_person",OracleDbType.Varchar2,60,Sp.ContactPerson ,ParameterDirection.Input),
                new OracleParameter("p_acc_code",OracleDbType.Varchar2,60,Sp.Acccode ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,60,Sp.Remarks ,ParameterDirection.Input),
                new OracleParameter("p_Proority",OracleDbType.Varchar2,1,Sp.Priority ,ParameterDirection.Input),
                new OracleParameter("p_Active",OracleDbType.Varchar2,2,Sp.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Sp.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,Sp.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,Sp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,Sp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Sp.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion
        #region "Details information"
        public List<ServiceProvider> GetDetailsInformation(string Control, string Where)
        {
            string packageName = "AGH_INVMS.PKG_MRR.GetDetailsInformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input),
                };
            return GetDetailsInformation(packageName, parameterList);
        }
        private List<ServiceProvider> GetDetailsInformation(string packageName, OracleParameter[] parameterList)
        {
            List<ServiceProvider> objService = new List<ServiceProvider>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ServiceProvider SP = new ServiceProvider();
                SP.ID = rdr["id"].ToString();
                SP.ServiceProviderName = rdr["name"].ToString();
                SP.Address = rdr["address"].ToString();
                SP.Web = rdr["web"].ToString();
                SP.Phone = rdr["phone"].ToString();
                SP.Fax = rdr["fax"].ToString();
                SP.Email = rdr["email"].ToString();
                SP.ContactPerson = rdr["cont_person"].ToString();
                SP.Acccode = rdr["acc_code"].ToString();
                SP.Remarks = rdr["remarks"].ToString();
                SP.Priority = rdr["priority"].ToString();
                SP.Active = rdr["active"].ToString();
                objService.Add(SP);
            }
            rdr.Close();
            return objService;
        }
        #endregion
        #region "Get ServiceProivider"
        public List<ServiceProvider> GetServiceProviderInfo(string Control, string Where)
        {
            string packageName = "AGH_INVMS.PKG_MRR.GetDetailsInformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input)
                };
            return GetServiceProviderInfo(packageName, parameterList);
        }
        private List<ServiceProvider> GetServiceProviderInfo(string packageName, OracleParameter[] parameterList)
        {
            List<ServiceProvider> objService = new List<ServiceProvider>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ServiceProvider SP = new ServiceProvider();
                if (rdr["item_id"].ToString() != "")
                {
                    SP.itemId = rdr["item_id"].ToString();
                }
                if (rdr["name"].ToString() != "")
                {
                    SP.itemName = rdr["name"].ToString();
                }
                if (rdr["id"].ToString() != "")
                {
                    SP.ID = rdr["id"].ToString();
                }
                if (rdr["serviceprovider"].ToString() != "")
                {
                    SP.ServiceProviderName = rdr["serviceprovider"].ToString();
                }
                objService.Add(SP);
            }
            rdr.Close();
            return objService;

        }
        #endregion
        #region "Save"
        public short SaveServiceProviderDetails(ServiceProvider Sp)
        {

            packageName = "AGH_INVMS.PKG_SERVICE_PROVIDER.Insert_serviceProvider";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_service_pro_name",OracleDbType.Varchar2,60,Sp.ServiceProviderName ,ParameterDirection.Input),
                new OracleParameter("p_address",OracleDbType.Varchar2 ,60,Sp.Address ,ParameterDirection.Input),
                new OracleParameter("p_web",OracleDbType.Varchar2,60,Sp.Web ,ParameterDirection.Input),
                new OracleParameter("p_phone",OracleDbType.Varchar2,60,Sp.Phone ,ParameterDirection.Input),
                new OracleParameter("p_fax",OracleDbType.Varchar2,60,Sp.Fax ,ParameterDirection.Input),
                new OracleParameter("p_email",OracleDbType.Varchar2,60,Sp.Email ,ParameterDirection.Input),
                new OracleParameter("p_contact_person",OracleDbType.Varchar2,60,Sp.ContactPerson ,ParameterDirection.Input),
                new OracleParameter("p_acc_code",OracleDbType.Varchar2,60,Sp.Acccode ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,60,Sp.Remarks ,ParameterDirection.Input),
                new OracleParameter("p_Proority",OracleDbType.Varchar2,1,Sp.Priority ,ParameterDirection.Input),
                new OracleParameter("p_Active",OracleDbType.Varchar2,2,Sp.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Sp.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,Sp.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,Sp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,Sp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Sp.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short SaveServiceDetails(string strSLNo, string strservID, string strServdate, string strReturnDate,
                                        string strExperetdate, string strRemarks, int status, ServiceDetails Sd)
        {

            packageName = "AGH_INVMS.PKG_SERVICE_PROVIDER.Insert_ServiceDetails";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_serialno",OracleDbType.Varchar2,60,strSLNo ,ParameterDirection.Input),
                new OracleParameter("p_service_id",OracleDbType.Varchar2 ,60,strservID  ,ParameterDirection.Input),
                new OracleParameter("p_serviceDate",OracleDbType.Varchar2,60,strServdate ,ParameterDirection.Input),
                new OracleParameter("p_ReturnDate",OracleDbType.Varchar2,60,strReturnDate  ,ParameterDirection.Input),
                new OracleParameter("p_expectedreturnDate",OracleDbType.Varchar2,60,strExperetdate ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,60,strRemarks ,ParameterDirection.Input),
                new OracleParameter("p_priority",OracleDbType.Varchar2,60,"1" ,ParameterDirection.Input),
                new OracleParameter("p_intstatus",OracleDbType.Int16,2,status ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Sd.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,Sd.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,Sd.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,Sd.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Sd.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion
        #region "Get Service Details"
        public List<ServiceProvider> GetServiceDetailsofSlno(string Control, string Where)
        {
            string packageName = "AGH_INVMS.PKG_SERVICE_PROVIDER.GetDetailsInformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input)
                };
            return GetServiceDetailsofSlno(packageName, parameterList);
        }
        private List<ServiceProvider> GetServiceDetailsofSlno(string packageName, OracleParameter[] parameterList)
        {
            List<ServiceProvider> objService = new List<ServiceProvider>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ServiceProvider SP = new ServiceProvider();
                if (rdr["prod_serial"].ToString() != "")
                {
                    SP.SerialNo = rdr["prod_serial"].ToString();
                }
                else
                {
                    SP.SerialNo = "";
                }

                if (rdr["item_id"].ToString() != "")
                {
                    SP.itemId = rdr["item_id"].ToString();
                }
                if (rdr["name"].ToString() != "")
                {
                    SP.itemName = rdr["name"].ToString();
                }
                if (rdr["id"].ToString() != "")
                {
                    SP.ID = rdr["id"].ToString();
                }
                if (rdr["serviceprovider"].ToString() != "")
                {
                    SP.ServiceProviderName = rdr["serviceprovider"].ToString();
                }
                if (rdr["phone"].ToString() != "")
                {
                    SP.Phone = rdr["phone"].ToString();
                }

                if (rdr["expected_return_date"].ToString() != "")
                {
                    SP.expectedReturnDate = rdr["expected_return_date"].ToString();
                }
                if (rdr["service_date"].ToString() != "")
                {
                    SP.servicedate = rdr["service_date"].ToString();
                }

                if (rdr["return_date"].ToString() != "")
                {
                    SP.returndate = rdr["return_date"].ToString();
                }

                if (rdr["remarks"].ToString() != "")
                {
                    SP.Remarks = rdr["remarks"].ToString();
                }
                SP.Status = Convert.ToInt16(rdr["ACTIVE"]);
                objService.Add(SP);
            }
            rdr.Close();
            return objService;

        }
        #endregion
        #region "Delete Servicedetails"
        public short DeleteServiceDetails(string strSLNo)
        {
            packageName = "AGH_INVMS.PKG_SERVICE_PROVIDER.Delete_ServiceDetails";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_serialno",OracleDbType.Varchar2,60,strSLNo ,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion
        #region "Get ServiceProvider"
        public List<ServiceProvider> GetServiceProvider(string Control, string Where)
        {
            string packageName = "AGH_INVMS.PKG_SERVICE_PROVIDER.GetDetailsInformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input)
                };
            return GetServiceProvider(packageName, parameterList);
        }
        private List<ServiceProvider> GetServiceProvider(string packageName, OracleParameter[] parameterList)
        {
            List<ServiceProvider> objService = new List<ServiceProvider>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ServiceProvider SP = new ServiceProvider();
                if (rdr["id"].ToString() != "")
                {
                    SP.ID = rdr["id"].ToString();
                }
                if (rdr["name"].ToString() != "")
                {
                    SP.ServiceProviderName = rdr["name"].ToString();
                }
                objService.Add(SP);
            }
            rdr.Close();
            return objService;
        }
        #endregion
        #region "Get InvGroup"
        public List<AssetsGroup> GetInvGroup(string Control, string Where)
        {
            string packageName = "AGH_INVMS.PKG_SERVICE_PROVIDER.GetDetailsInformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input)
                };
            return GetInvGroup(packageName, parameterList);
        }
        private List<AssetsGroup> GetInvGroup(string packageName, OracleParameter[] parameterList)
        {
            List<AssetsGroup> objGroup = new List<AssetsGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AssetsGroup gp = new AssetsGroup();
                if (rdr["groupid"].ToString() != "")
                {
                    gp.GroupID = rdr["groupid"].ToString();
                }
                if (rdr["groupname"].ToString() != "")
                {
                    gp.GroupName = rdr["groupname"].ToString();
                }
                objGroup.Add(gp);
            }
            rdr.Close();
            return objGroup;
        }
        public List<AssetsIssue> GetProductIssue(string Control, string Where)
        {
            string packageName = "AGH_INVMS.PKG_SERVICE_PROVIDER.GetDetailsInformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input)
                };
            return GetProductIssue(packageName, parameterList);
        }
        private List<AssetsIssue> GetProductIssue(string packageName, OracleParameter[] parameterList)
        {
            List<AssetsIssue> objAssets = new List<AssetsIssue>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AssetsIssue AI = new AssetsIssue();
                AI.EmpID = rdr["emp_id"].ToString();
                if (rdr["Full_Name"].ToString() != "")
                {
                    AI.AssetsUser = rdr["Full_Name"].ToString();
                }
                if (rdr["dept_title"].ToString() != "")
                {
                    AI.DepName = rdr["dept_title"].ToString();
                }
                if (rdr["received_date"].ToString() != "")
                {
                    AI.Receiptdate = rdr["received_date"].ToString();
                }
                objAssets.Add(AI);
            }
            rdr.Close();
            return objAssets;
        }
        #endregion
        #region "Save Terms Condition"
        public short SaveTermsNCondition(TermsandCondition tc)
        {

            packageName = "PKG_TERMS_CONDITION.Insert_TermsCondition";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_store_id",OracleDbType.Char,2,tc.storeID ,ParameterDirection.Input),
                new OracleParameter("p_name",OracleDbType.Varchar2 ,500,tc.Name  ,ParameterDirection.Input),
                new OracleParameter("p_auto_selected",OracleDbType.Char,2,tc.isAutoSelected ,ParameterDirection.Input),
                new OracleParameter("p_bold",OracleDbType.Char,2,tc.isBold  ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,200,tc.Remarks ,ParameterDirection.Input),
                new OracleParameter("p_priority",OracleDbType.Char,2,tc.Priority ,ParameterDirection.Input),
                new OracleParameter("p_active",OracleDbType.Char,2,tc.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,tc.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,tc.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,tc.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,tc.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,tc.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short UpdateTermsNCondition(TermsandCondition tc)
        {

            packageName = "PKG_TERMS_CONDITION.Update_TermsCondition";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Punique",OracleDbType.Char,6,tc.ID ,ParameterDirection.Input),
                new OracleParameter("p_store_id",OracleDbType.Char,2,tc.storeID ,ParameterDirection.Input),
                new OracleParameter("p_name",OracleDbType.Varchar2 ,500,tc.Name  ,ParameterDirection.Input),
                new OracleParameter("p_auto_selected",OracleDbType.Char,2,tc.isAutoSelected ,ParameterDirection.Input),
                new OracleParameter("p_bold",OracleDbType.Char,2,tc.isBold  ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,200,tc.Remarks ,ParameterDirection.Input),
                new OracleParameter("p_priority",OracleDbType.Char,2,tc.Priority ,ParameterDirection.Input),
                new OracleParameter("p_active",OracleDbType.Char,2,tc.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,tc.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,tc.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,tc.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,tc.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,tc.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public List<TermsandCondition> GetTermsNCondtion()
        {
            string packageName = "PKG_TERMS_CONDITION.GetTermscondition";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetTermsNCondtion(packageName, parameterList);
        }
        private List<TermsandCondition> GetTermsNCondtion(string packageName, OracleParameter[] parameterList)
        {
            List<TermsandCondition> objAssets = new List<TermsandCondition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                TermsandCondition tc = new TermsandCondition();
                tc.ID = rdr["id"].ToString();
                if (rdr["store_id"].ToString() != "")
                {
                    tc.storeID = rdr["store_id"].ToString();
                }
                else
                {
                    tc.storeID = "";
                }
                if (rdr["name"].ToString() != "")
                {
                    tc.Name = rdr["name"].ToString();
                }
                if (rdr["is_auto_selected"].ToString() != "")
                {
                    tc.isAutoSelected = Convert.ToChar(rdr["is_auto_selected"]);
                }
                if (rdr["is_bold"].ToString() != "")
                {
                    tc.isBold = Convert.ToChar(rdr["is_bold"]);
                }
                if (rdr["remarks"].ToString() != "")
                {
                    tc.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    tc.Remarks = "";
                }
                if (rdr["priority"].ToString() != "")
                {
                    tc.Priority = Convert.ToChar(rdr["priority"]);
                }

                if (rdr["active"].ToString() != "")
                {
                    tc.Active = Convert.ToChar(rdr["active"]);
                }
                objAssets.Add(tc);
            }
            rdr.Close();
            return objAssets;
        }
        #endregion
        #region "Coments"
        //public short SaveStoreType(StoreType St)
        //{

        //    packageName = "PKG_STORE_TYPE.Insert_Storetype";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("p_name",OracleDbType.Varchar2 ,500,St.TypeTitle  ,ParameterDirection.Input),
        //        new OracleParameter("p_remarks",OracleDbType.Varchar2,200,St.Remarks ,ParameterDirection.Input),
        //        new OracleParameter("p_active",OracleDbType.Char,2,St.Active ,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,St.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pversion",OracleDbType.Varchar2,60,St.EntryParameter.Version ,ParameterDirection.Input),
        //        new OracleParameter("Pcomid",OracleDbType.Varchar2,2,St.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("Plocid",OracleDbType.Varchar2,2,St.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,St.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}

        //public short UpdateStoreType(StoreType St)
        //{

        //    packageName = "PKG_STORE_TYPE.Update_Storetype";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("Punique",OracleDbType.Varchar2 ,2,St.strTypeID ,ParameterDirection.Input),
        //        new OracleParameter("p_name",OracleDbType.Varchar2 ,500,St.TypeTitle  ,ParameterDirection.Input),
        //        new OracleParameter("p_remarks",OracleDbType.Varchar2,200,St.Remarks ,ParameterDirection.Input),
        //        new OracleParameter("p_active",OracleDbType.Char,2,St.Active ,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,St.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pversion",OracleDbType.Varchar2,60,St.EntryParameter.Version ,ParameterDirection.Input),
        //        new OracleParameter("Pcomid",OracleDbType.Varchar2,2,St.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("Plocid",OracleDbType.Varchar2,2,St.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,St.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}

        //public List<StoreType> GetStoreType()
        //{
        //    string packageName = "PKG_STORE_TYPE.GetStoreType";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //        };
        //    return GetStoreType(packageName, parameterList);
        //}
        //private List<StoreType> GetStoreType(string packageName, OracleParameter[] parameterList)
        //{
        //    List<StoreType> objStoretype = new List<StoreType>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        StoreType St = new StoreType();
        //        St.strTypeID = rdr["str_type_id"].ToString();
        //        if (rdr["str_type_title"].ToString() != "")
        //        {
        //            St.TypeTitle = rdr["str_type_title"].ToString();
        //        }
        //        else
        //        {
        //            St.TypeTitle = "";
        //        }
        //        if (rdr["remarks"].ToString() != "")
        //        {
        //            St.Remarks = rdr["remarks"].ToString();
        //        }
              
              
        //        if (rdr["active"].ToString() != "")
        //        {
        //            St.Active = Convert.ToChar(rdr["active"]);
        //        }
        //        objStoretype.Add(St);
        //    }
        //    rdr.Close();
        //    return objStoretype;
        //}


        //public short SaveMajorGrp(Majorgroup Mg)
        //{

        //    packageName = "PKG_MAJOR_GROUP.Insert_Majorgroup";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("p_type_id",OracleDbType.Varchar2 ,4,Mg.storeTypeID ,ParameterDirection.Input),
        //        new OracleParameter("p_name",OracleDbType.Varchar2 ,500,Mg.Name  ,ParameterDirection.Input),
        //        new OracleParameter("p_remarks",OracleDbType.Varchar2,200,Mg.Remarks ,ParameterDirection.Input),
        //        new OracleParameter("p_active",OracleDbType.Char,2,Mg.Active ,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Mg.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pversion",OracleDbType.Varchar2,60,Mg.EntryParameter.Version ,ParameterDirection.Input),
        //        new OracleParameter("Pcomid",OracleDbType.Varchar2,2,Mg.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("Plocid",OracleDbType.Varchar2,2,Mg.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,Mg.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}

        //public short Update_Majorgroup(Majorgroup Mg)
        //{

        //    packageName = "PKG_MAJOR_GROUP.Update_Majorgroup";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //        new OracleParameter("Punique",OracleDbType.Varchar2 ,4,Mg.MajorgrpID ,ParameterDirection.Input),
        //        new OracleParameter("p_type_id",OracleDbType.Varchar2 ,4,Mg.storeTypeID ,ParameterDirection.Input),
        //        new OracleParameter("p_name",OracleDbType.Varchar2 ,500,Mg.Name  ,ParameterDirection.Input),
        //        new OracleParameter("p_remarks",OracleDbType.Varchar2,200,Mg.Remarks ,ParameterDirection.Input),
        //        new OracleParameter("p_active",OracleDbType.Char,2,Mg.Active ,ParameterDirection.Input),
        //        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Mg.EntryParameter.EntryBy ,ParameterDirection.Input),
        //        new OracleParameter("Pversion",OracleDbType.Varchar2,60,Mg.EntryParameter.Version ,ParameterDirection.Input),
        //        new OracleParameter("Pcomid",OracleDbType.Varchar2,2,Mg.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("Plocid",OracleDbType.Varchar2,2,Mg.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("PmacID",OracleDbType.Varchar2,30,Mg.EntryParameter.MachineID,ParameterDirection.Input),
        //    };

        //    short i = DALHelper.Insert(connstring, packageName, parameterList);
        //    //OracleParameter prm = parameterList[0];
        //    //if ((OracleDecimal)prm.Value == -1)
        //    return 1;
        //    //return 1;
        //    //else return 0;
        //}
        //public List<Majorgroup> GetMajorGrp()
        //{
        //    string packageName = "PKG_MAJOR_GROUP.GetMajorgroup";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //        };
        //    return GetMajorGrp(packageName, parameterList);
        //}
        //private List<Majorgroup> GetMajorGrp(string packageName, OracleParameter[] parameterList)
        //{
        //    List<Majorgroup> objStoretype = new List<Majorgroup>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        Majorgroup Mg = new Majorgroup();
        //        Mg.storeTypeID = rdr["str_type_id"].ToString();
        //        Mg.MajorgrpID = rdr["marjor_grp_id"].ToString();
        //        if (rdr["name"].ToString() != "")
        //        {
        //            Mg.Name = rdr["name"].ToString();
        //        }
        //        else
        //        {
        //            Mg.Name = "";
        //        }
        //        if (rdr["remarks"].ToString() != "")
        //        {
        //            Mg.Remarks = rdr["remarks"].ToString();
        //        }


        //        if (rdr["active"].ToString() != "")
        //        {
        //            Mg.Active = Convert.ToChar(rdr["active"]);
        //        }
        //        objStoretype.Add(Mg);
        //    }
        //    rdr.Close();
        //    return objStoretype;
        //}

        //public List<Majorgroup> GetStoreTypeofGroup()
        //{
        //    string packageName = "PKG_MAJOR_GROUP.GetStoretype";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
        //        };
        //    return GetStoreTypeofGroup(packageName, parameterList);
        //}
        //private List<Majorgroup> GetStoreTypeofGroup(string packageName, OracleParameter[] parameterList)
        //{
        //    List<Majorgroup> objGroup = new List<Majorgroup>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        Majorgroup gp = new Majorgroup();
        //        if (rdr["str_type_id"].ToString() != "")
        //        {
        //            gp.storeTypeID = rdr["str_type_id"].ToString();
        //        }
        //        if (rdr["str_type_title"].ToString() != "")
        //        {
        //            gp.Name  = rdr["str_type_title"].ToString();
        //        }
        //        objGroup.Add(gp);
        //    }
        //    rdr.Close();
        //    return objGroup;
        //}
        #endregion
        #region "Save Warehoustype"
        public short Savewarehousetype(Warehouse Wh)
        {
            packageName = "PKG_WAREHOUSE.insertWarehousetype";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pWarehouseName",OracleDbType.Varchar2,60,Wh.TypeName,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2 ,60,Wh.Remarks,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,60,Wh.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Wh.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,Wh.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,Wh.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Wh.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short Updatewarehousetype(Warehouse Wh)
        {
            packageName = "PKG_WAREHOUSE.updateWarehousetype";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ptypeid",OracleDbType.Varchar2,60,Wh.TypeID,ParameterDirection.Input),
                new OracleParameter("pWarehouseName",OracleDbType.Varchar2,60,Wh.TypeName,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2 ,60,Wh.Remarks,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,60,Wh.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Wh.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,Wh.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,Wh.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Wh.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public List<Warehouse> GetWarehousetype()
        {
            string packageName = "PKG_WAREHOUSE.Getwarehousetype";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                };
            return GetWarehousetype(packageName, parameterList);
        }
        private List<Warehouse> GetWarehousetype(string packageName, OracleParameter[] parameterList)
        {
            List<Warehouse> objWH = new List<Warehouse>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Warehouse wh = new Warehouse();
                if (rdr["type_id"].ToString() != "")
                {
                    wh.TypeID = rdr["type_id"].ToString();
                }
                if (rdr["name"].ToString() != "")
                {
                    wh.TypeName = rdr["name"].ToString();
                }
                if (rdr["remarks"].ToString() != "")
                {
                    wh.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    wh.Remarks = "";
                }
                if (rdr["active"].ToString() != "")
                {
                    wh.Active =  Convert.ToChar(rdr["active"]);
                }
                objWH.Add(wh);
            }
            rdr.Close();
            return objWH;
        }
        #endregion
        #region "Save Warehouse"
        public short Savewarehouse(WarehouseConfig Wh)
        {
            packageName = "PKG_WAREHOUSE.insertwarehouse";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Buildid",OracleDbType.Varchar2,3,Wh.BuildID,ParameterDirection.Input),
                new OracleParameter("floorNo",OracleDbType.Varchar2,2,Wh.FloorNo,ParameterDirection.Input),
                new OracleParameter("BlockNo",OracleDbType.Varchar2,30,Wh.BlockNo,ParameterDirection.Input),
                new OracleParameter("depID",OracleDbType.Varchar2,5,Wh.DepID,ParameterDirection.Input),
                new OracleParameter("unitid",OracleDbType.Varchar2,60,Wh.UnitID,ParameterDirection.Input),
                new OracleParameter("nursestationid",OracleDbType.Varchar2,3,Wh.NurseStationID,ParameterDirection.Input),
                new OracleParameter("categoryid",OracleDbType.Varchar2,7,Wh.CostCategoryID,ParameterDirection.Input),
                new OracleParameter("costCenterid",OracleDbType.Varchar2,7,Wh.CostCenterID,ParameterDirection.Input),
                new OracleParameter("ptypeid",OracleDbType.Varchar2,4,Wh.Typeid,ParameterDirection.Input),
                new OracleParameter("pwhname",OracleDbType.Varchar2,300,Wh.WhName,ParameterDirection.Input),
                new OracleParameter("phoneNo",OracleDbType.Varchar2,100,Wh.phoneNo,ParameterDirection.Input),
                new OracleParameter("pcontactPerson",OracleDbType.Varchar2,30,Wh.Contactperson,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2 ,200,Wh.Remarks,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,60,Wh.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Wh.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,Wh.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,Wh.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Wh.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short Updatewarehouse(WarehouseConfig Wh)
        {
            packageName = "PKG_WAREHOUSE.Updatewarehouse";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Buildid",OracleDbType.Varchar2,3,Wh.BuildID,ParameterDirection.Input),
                new OracleParameter("floorNo",OracleDbType.Varchar2,2,Wh.FloorNo,ParameterDirection.Input),
                new OracleParameter("BlockNo",OracleDbType.Varchar2,30,Wh.BlockNo,ParameterDirection.Input),
                new OracleParameter("depID",OracleDbType.Varchar2,5,Wh.DepID,ParameterDirection.Input),
                new OracleParameter("unitid",OracleDbType.Varchar2,60,Wh.UnitID,ParameterDirection.Input),
                new OracleParameter("nursestationid",OracleDbType.Varchar2,3,Wh.NurseStationID,ParameterDirection.Input),
                new OracleParameter("categoryid",OracleDbType.Varchar2,7,Wh.CostCategoryID,ParameterDirection.Input),
                new OracleParameter("costCenterid",OracleDbType.Varchar2,7,Wh.CostCenterID,ParameterDirection.Input),
                new OracleParameter("ptypeid",OracleDbType.Varchar2,60,Wh.Typeid,ParameterDirection.Input),
                new OracleParameter("pwhid",OracleDbType.Varchar2,60,Wh.Whid,ParameterDirection.Input),
                new OracleParameter("pwhname",OracleDbType.Varchar2,300,Wh.WhName,ParameterDirection.Input),
                new OracleParameter("phoneNo",OracleDbType.Varchar2,100,Wh.phoneNo,ParameterDirection.Input),
                new OracleParameter("pcontactPerson",OracleDbType.Varchar2,30,Wh.Contactperson,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2 ,200,Wh.Remarks,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,60,Wh.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Wh.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,Wh.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,Wh.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Wh.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public List<WarehouseConfig> GetWarehouse()
        {
            string packageName = "PKG_WAREHOUSE.Getwarehouse";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                };
            return GetWarehouse(packageName, parameterList);
        }
        private List<WarehouseConfig> GetWarehouse(string packageName, OracleParameter[] parameterList)
        {
            List<WarehouseConfig> objWH = new List<WarehouseConfig>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WarehouseConfig wh = new WarehouseConfig();

                if (rdr["build_id"].ToString() != "")
                {
                    wh.BuildID = rdr["build_id"].ToString();
                }
                else
                {
                    wh.BuildID = "";
                }
                if (rdr["floor_no"].ToString() != "")
                {
                    wh.FloorNo = rdr["floor_no"].ToString();
                }
                else
                {
                    wh.FloorNo = "";
                }
                if (rdr["dept_id"].ToString() != "")
                {
                    wh.DepID = rdr["dept_id"].ToString();
                }
                else
                {
                    wh.DepID = "";
                }
                if (rdr["unit_id"].ToString() != "")
                {
                    wh.UnitID = rdr["unit_id"].ToString();
                }
                else
                {
                    wh.UnitID = "";
                }
                if (rdr["ns_stn_id"].ToString() != "")
                {
                    wh.NurseStationID = rdr["ns_stn_id"].ToString();
                }
                else
                {
                    wh.NurseStationID = "";
                }
                if (rdr["cost_category_id"].ToString() != "")
                {
                    wh.CostCategoryID = rdr["cost_category_id"].ToString();
                }
                else
                {
                    wh.CostCategoryID = "";
                }
                if (rdr["cost_center_id"].ToString() != "")
                {
                    wh.CostCenterID = rdr["cost_center_id"].ToString();
                }
                else
                {
                    wh.CostCenterID = "";
                }
                if (rdr["phone_no"].ToString() != "")
                {
                    wh.phoneNo = rdr["phone_no"].ToString();
                }
                else
                {
                    wh.phoneNo = "";
                }
                if (rdr["cont_person"].ToString() != "")
                {
                    wh.Contactperson  = rdr["cont_person"].ToString();
                }
                else
                {
                    wh.Contactperson = "";
                }
                if (rdr["type_id"].ToString() != "")
                {
                    wh.Typeid = rdr["type_id"].ToString();
                }
                else
                {
                    wh.Typeid = "";
                }
                if (rdr["wh_id"].ToString() != "")
                {
                    wh.Whid = rdr["wh_id"].ToString();
                }
                else
                {
                    wh.Whid = "";
                }

                if (rdr["wh_name"].ToString() != "")
                {
                    wh.WhName = rdr["wh_name"].ToString();
                }
                else
                {
                    wh.WhName = "";
                }

                if (rdr["remarks"].ToString() != "")
                {
                    wh.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    wh.Remarks = "";
                }
                if (rdr["active"].ToString() != "")
                {
                    wh.Active = Convert.ToChar(rdr["active"]);
                }
                objWH.Add(wh);
            }
            rdr.Close();
            return objWH;
        }
        public List<WarehouseConfig> LoadWarehouse()
        {
            string packageName = "PKG_WAREHOUSE.Loadwarehousetype";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                };
            return LoadWarehouse(packageName, parameterList);
        }
        private List<WarehouseConfig> LoadWarehouse(string packageName, OracleParameter[] parameterList)
        {
            List<WarehouseConfig> objWH = new List<WarehouseConfig>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WarehouseConfig wh = new WarehouseConfig();
                if (rdr["type_id"].ToString() != "")
                {
                    wh.Typeid = rdr["type_id"].ToString();
                }
                if (rdr["name"].ToString() != "")
                {
                    wh.TypeName = rdr["name"].ToString();
                }
              
                objWH.Add(wh);
            }
            rdr.Close();
            return objWH;
        }
        #endregion
        //**************************************
        #region "Storewarehousetype"
        public List<StoreType> GetStoreWhstoretype()
        {
            string packageName = "PKG_HOUSE_KEEPING.GetStoretype";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                };
            return GetStoreWhstoretype(packageName, parameterList);
        }
        private List<StoreType> GetStoreWhstoretype(string packageName, OracleParameter[] parameterList)
        {
            List<StoreType> objType = new List<StoreType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                StoreType gp = new StoreType();
                if (rdr["str_type_id"].ToString() != "")
                {
                    gp.strTypeID = rdr["str_type_id"].ToString();
                }
                else
                {
                    gp.strTypeID = "";
                }
                if (rdr["str_type_title"].ToString() != "")
                {
                    gp.TypeTitle = rdr["str_type_title"].ToString();
                }
                else
                {
                    gp.TypeTitle = "";
                }
                objType.Add(gp);
            }
            rdr.Close();
            return objType;
        }
        #endregion
        #region "Warehousegroup"
        public List<InvGroups> GetStockWHGroup()
        {
            string packageName = "PKG_HOUSE_KEEPING.GetInvGroups";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    //new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
                    //new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input)
                };
            return GetStockWHGroup(packageName, parameterList);
        }
        private List<InvGroups> GetStockWHGroup(string packageName, OracleParameter[] parameterList)
        {
            List<InvGroups> objGroup = new List<InvGroups>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                InvGroups gp = new InvGroups();
                if (rdr["groupid"].ToString() != "")
                {
                    gp.GroupID = rdr["groupid"].ToString();
                }
                else
                {
                    gp.GroupID = "";
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
        #endregion
        //public List<InvLocation> GetStockWHLocation()
        //{
        //    string packageName = "PKG_HOUSE_KEEPING.GetInvlocation";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //            //new OracleParameter("pcontrol",OracleDbType.Varchar2,60,Control,ParameterDirection.Input),
        //            //new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input)
        //        };
        //    return GetStockWHLocation(packageName, parameterList);
        //}
        //private List<InvLocation> GetStockWHLocation(string packageName, OracleParameter[] parameterList)
        //{
        //    List<InvLocation> objLoc = new List<InvLocation>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        InvLocation gp = new InvLocation();
        //        if (rdr["store_id"].ToString() != "")
        //        {
        //            gp.storeId  = rdr["store_id"].ToString();
        //        }
        //        else
        //        {
        //            gp.storeId = "";
        //        }
        //        if (rdr["store_title"].ToString() != "")
        //        {
        //            gp.storeTitle  = rdr["store_title"].ToString();
        //        }
        //        else
        //        {
        //            gp.storeTitle="";
        //        }
        //        objLoc.Add(gp);
        //    }
        //    rdr.Close();
        //    return objLoc;
        //}
        #region "Warehouse type"
        public List<WarehouseConfig> GetHkwarehouseType(string whtype)
        {
            string packageName = "PKG_HOUSE_KEEPING.Getwarehousetype";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pmtype",OracleDbType.Varchar2,2,whtype,ParameterDirection.Input),
                };
            return GetHkwarehouseType(packageName, parameterList);
        }
        private List<WarehouseConfig> GetHkwarehouseType(string packageName, OracleParameter[] parameterList)
        {
            List<WarehouseConfig> objWH = new List<WarehouseConfig>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WarehouseConfig wh = new WarehouseConfig();
                if (rdr["type_id"].ToString() != "")
                {
                    wh.Typeid = rdr["type_id"].ToString();
                }
                else
                {
                    wh.Typeid = "";
                }
                if (rdr["name"].ToString() != "")
                {
                    wh.TypeName = rdr["name"].ToString();
                }
                else
                {
                    wh.TypeName = "";
                }

                objWH.Add(wh);
            }
            rdr.Close();
            return objWH;
        }
        #endregion 
        #region "GetWarehouse"
        public List<Warehouse> GeHktwarehouse(string where)
        {
            string packageName = "PKG_HOUSE_KEEPING.getwarehouse";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,where,ParameterDirection.Input),
                };
            return GeHktwarehouse(packageName, parameterList);
        }
        private List<Warehouse> GeHktwarehouse(string packageName, OracleParameter[] parameterList)
        {
            List<Warehouse> objWH = new List<Warehouse>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Warehouse wh = new Warehouse();
                if (rdr["wh_id"].ToString() != "")
                {
                    wh.TypeID = rdr["wh_id"].ToString();
                }
                else
                {
                    wh.TypeID = "";
                }
                if (rdr["wh_name"].ToString() != "")
                {
                    wh.TypeName = rdr["wh_name"].ToString();
                }
                else
                {
                    wh.TypeName = "";
                }
                objWH.Add(wh);
            }
            rdr.Close();
            return objWH;
        }
        #endregion
        #region "GetItem"
        public List<HkItem> GethkItem(string strGroup,string strType,string strLocation)
        {
            string packageName = "PKG_HOUSE_KEEPING.getItemInformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pgroupid",OracleDbType.Varchar2,60,strGroup,ParameterDirection.Input),
                    new OracleParameter("pstoretype",OracleDbType.Varchar2,60,strType,ParameterDirection.Input),
                    new OracleParameter("plocationid",OracleDbType.Varchar2,60,strLocation,ParameterDirection.Input),

                };
            return GethkItem(packageName, parameterList);
        }
        private List<HkItem> GethkItem(string packageName, OracleParameter[] parameterList)
        {
            List<HkItem> objType = new List<HkItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                HkItem hkitm = new HkItem();
                if (rdr["itemid"].ToString() != "")
                {
                    hkitm.ItemCode = rdr["itemid"].ToString();
                }
                if (rdr["itemname"].ToString() != "")
                {
                    hkitm.ItemName = rdr["itemname"].ToString();
                }
                objType.Add(hkitm);
            }
            rdr.Close();
            return objType;
        }
        #endregion
        #region "Save IOmaster"
        public string SaveIomaster(IOmaster IOmaster)
        {
            packageName = "PKG_HOUSE_KEEPING.insertIomaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                
                new OracleParameter("ref_no_out",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
                new OracleParameter("pgrpid",OracleDbType.Varchar2,60,IOmaster.Grpid,ParameterDirection.Input),
                new OracleParameter("pmoduletype",OracleDbType.Varchar2,60,IOmaster.Moduletype,ParameterDirection.Input),
                new OracleParameter("pstoretype",OracleDbType.Varchar2,60,IOmaster.Storeid,ParameterDirection.Input),
                new OracleParameter("pwhtype",OracleDbType.Varchar2,60,IOmaster.WhType,ParameterDirection.Input),
                new OracleParameter("pwhid",OracleDbType.Varchar2 ,60,IOmaster.Whid,ParameterDirection.Input),
                new OracleParameter("piodate",OracleDbType.Varchar2,60,IOmaster.Iodate,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2,60,IOmaster.Remarks,ParameterDirection.Input),
                new OracleParameter("pioflag",OracleDbType.Varchar2,60,IOmaster.Ioflag,ParameterDirection.Input), //0 receipt 1 issue
                new OracleParameter("pactive",OracleDbType.Varchar2,60,IOmaster.Active,ParameterDirection.Input),
                new OracleParameter("pstationId",OracleDbType.Varchar2,60,IOmaster.NursingStationId,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,IOmaster.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,IOmaster.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,IOmaster.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,IOmaster.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0"; 
        }
        public short SaveIoDetails(string RefID, string itemCode, double dblqty, int statustype, string strRemarks, string Istatus, IOmaster IOmaster)
        {
            packageName = "PKG_HOUSE_KEEPING.insertIodetails";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pref_ID",OracleDbType.Varchar2,60,RefID,ParameterDirection.Input),
                new OracleParameter("pitemCode",OracleDbType.Varchar2,60,itemCode,ParameterDirection.Input),
                new OracleParameter("pqty",OracleDbType.Varchar2,60,dblqty,ParameterDirection.Input),
                new OracleParameter("pstatustype",OracleDbType.Varchar2 ,60,statustype,ParameterDirection.Input), //0 clean 1 dirty 2 maintainence
                new OracleParameter("premarks",OracleDbType.Varchar2,60,strRemarks,ParameterDirection.Input),
                new OracleParameter("pstatus",OracleDbType.Varchar2,2,Istatus,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,IOmaster.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,IOmaster.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,IOmaster.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,IOmaster.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            return 1;
        }
        #endregion
        #region "Get Hk Information"
        public List<IOmaster> GetHkDirtyItem(string strWhi,int intstatus)
        {
            string packageName = "PKG_HOUSE_KEEPING.GetHkitemDetails";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pstatus",OracleDbType.Int16,2,intstatus,ParameterDirection.Input),
                    new OracleParameter("pwhi",OracleDbType.Varchar2,60,strWhi,ParameterDirection.Input),

                };
            return GetHkDirtyItem(packageName, parameterList);
        }
        private List<IOmaster> GetHkDirtyItem(string packageName, OracleParameter[] parameterList)
        {
            List<IOmaster> objType = new List<IOmaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IOmaster hkitm = new IOmaster();
                if (rdr["item_code"].ToString() != "")
                {
                    hkitm.ItemCode = rdr["item_code"].ToString();
                }
                else
                {
                    hkitm.ItemCode = "";
                }
                if (rdr["itemname"].ToString() != "")
                {
                    hkitm.ItemName = rdr["itemname"].ToString();
                }
                else
                {
                    hkitm.ItemName = "";
                }
                if (rdr["groupid"].ToString() != "")
                {
                    hkitm.Grpid = rdr["groupid"].ToString();
                }
                else
                {
                    hkitm.Grpid = "";
                }
                if (rdr["storetype"].ToString() != "")
                {
                    hkitm.Storeid = rdr["storetype"].ToString();
                }
                else
                {
                    hkitm.Storeid = "";
                }

                if (rdr["unitid"].ToString() != "")
                {
                    hkitm.UnitCode = rdr["unitid"].ToString();
                }
                else
                {
                    hkitm.UnitCode = "";
                }
                if (rdr["unitname"].ToString() != "")
                {
                    hkitm.UnitName = rdr["unitname"].ToString();
                }
                else
                {
                    hkitm.UnitName = "";
                }
                if (rdr["QTY"].ToString() != "")
                {
                    hkitm.Qty = Convert.ToInt64(rdr["QTY"].ToString());
                }
                hkitm.IntMtype = Convert.ToInt16(rdr["module_type"].ToString());

                objType.Add(hkitm);
            }
            rdr.Close();
            return objType;
        }
        public List<IOmaster> GetHkArchiveLog(string strWhi)
        {
            string packageName = "PKG_HOUSE_KEEPING.GetHkarchievelog";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                   // new OracleParameter("pstatus",OracleDbType.Int16,2,intstatus,ParameterDirection.Input),
                    new OracleParameter("pwhi",OracleDbType.Varchar2,60,strWhi,ParameterDirection.Input),

                };
            return GetHkArchiveLog(packageName, parameterList);
        }
        private List<IOmaster> GetHkArchiveLog(string packageName, OracleParameter[] parameterList)
        {
            List<IOmaster> objType = new List<IOmaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IOmaster Ioitm = new IOmaster();
                if (rdr["item_code"].ToString() != "")
                {
                    Ioitm.ItemCode = rdr["item_code"].ToString();
                }
                else
                {
                    Ioitm.ItemCode = "";
                }
                if (rdr["itemname"].ToString() != "")
                {
                    Ioitm.ItemName = rdr["itemname"].ToString();
                }
                else
                {
                    Ioitm.ItemName = "";
                }
                if (rdr["groupid"].ToString() != "")
                {
                    Ioitm.Grpid = rdr["groupid"].ToString();
                }
                else
                {
                    Ioitm.Grpid = "";
                }
                if (rdr["storetype"].ToString() != "")
                {
                    Ioitm.Storeid = rdr["storetype"].ToString();
                }
                else
                {
                    Ioitm.Storeid = "";
                }

                if (rdr["unitid"].ToString() != "")
                {
                    Ioitm.UnitCode = rdr["unitid"].ToString();
                }
                else
                {
                    Ioitm.UnitCode = "";
                }
                if (rdr["unitname"].ToString() != "")
                {
                    Ioitm.UnitName = rdr["unitname"].ToString();
                }
                else
                {
                    Ioitm.UnitName = "";
                }
                if (rdr["QTY"].ToString() != "")
                {
                    Ioitm.Qty = Convert.ToInt64(rdr["QTY"].ToString());
                }
                Ioitm.IntMtype = Convert.ToInt16(rdr["module_type"].ToString());

                objType.Add(Ioitm);
            }
            rdr.Close();
            return objType;
        }
        #endregion
        #region "Warehouse Report"
        public List<WarehouseStoreRO> GetWarehouseStoreReport(string pFadte,string pTdate, string  strStoreType)
        {
            string packageName = "PKG_WAREHOUSE_REPORT.GetstockInformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Pfdate",OracleDbType.Varchar2,60,pFadte,ParameterDirection.Input),
                    new OracleParameter("pTdate",OracleDbType.Varchar2,60,pTdate,ParameterDirection.Input),
                    new OracleParameter("ptype",OracleDbType.Varchar2,2,strStoreType,ParameterDirection.Input),

                };
            return GetWarehouseStoreReport(packageName, parameterList);
        }
        private List<WarehouseStoreRO> GetWarehouseStoreReport(string packageName, OracleParameter[] parameterList)
        {
            List<WarehouseStoreRO> objType = new List<WarehouseStoreRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                WarehouseStoreRO wh = new WarehouseStoreRO();
                if (rdr["itemid"].ToString() != "")
                {
                    wh.ItemCode = rdr["itemid"].ToString();
                }
                else
                {
                    wh.ItemCode = "";
                }
                if (rdr["itemname"].ToString() != "")
                {
                    wh.ItemName = rdr["itemname"].ToString();
                }
                else
                {
                    wh.ItemName = "";
                }

                if (rdr["unitid"].ToString() != "")
                {
                    wh.UnitId = rdr["unitid"].ToString();
                }
                else
                {
                    wh.UnitId = "";
                }
                if (rdr["unitname"].ToString() != "")
                {
                    wh.UnitName = rdr["unitname"].ToString();
                }
                else
                {
                    wh.UnitName = "";
                }

                if (rdr["wh_id"].ToString() != "")
                {
                    wh.WarehouseId = rdr["wh_id"].ToString();
                }
                else
                {
                    wh.WarehouseId = "";
                }
                if (rdr["wh_name"].ToString() != "")
                {
                    wh.WarehouseName = rdr["wh_name"].ToString();
                }
                else
                {
                    wh.WarehouseName = "";
                }
                if (rdr["inward"].ToString() != "")
                {
                    wh.InwardQnty = Convert.ToInt64(rdr["inward"].ToString());
                }
                else
                {
                    wh.InwardQnty = 0;
                }
                if (rdr["maintainence"].ToString() != "")
                {
                    wh.OutwardQnty = Convert.ToInt64(rdr["maintainence"].ToString());
                }
                else
                {
                    wh.OutwardQnty = 0;
                }
                if (rdr["closing"].ToString() != "")
                {
                    wh.ClosingQnty = Convert.ToInt64(rdr["closing"].ToString());
                }
                else
                {
                    wh.ClosingQnty = 0;
                }
                objType.Add(wh);
            }
            rdr.Close();
            return objType;
        }
        #endregion
        #region "Display "
        public List<IOmaster> DisplayReceiptInformation(string strStoreType,string where)
        {
            string packageName = "PKG_HOUSE_KEEPING.DisplayReceiptItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,2,strStoreType,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,30,where,ParameterDirection.Input),

                };
            return DisplayReceiptInformation(packageName, parameterList);
        }
        private List<IOmaster> DisplayReceiptInformation(string packageName, OracleParameter[] parameterList)
        {
            List<IOmaster> objType = new List<IOmaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IOmaster wh = new IOmaster();
                if (rdr["io_id"].ToString() != "")
                {
                    wh.IoRefNo = rdr["io_id"].ToString();
                }
                else
                {
                    wh.IoRefNo = "";
                }


                if (rdr["item_code"].ToString() != "")
                {
                    wh.ItemCode = rdr["item_code"].ToString();
                }
                else
                {
                    wh.ItemCode = "";
                }

                if (rdr["itemname"].ToString() != "")
                {
                    wh.ItemName = rdr["itemname"].ToString();
                }
                else
                {
                    wh.ItemName = "";
                }

                if (rdr["unit_id"].ToString() != "")
                {
                    wh.UnitCode = rdr["unit_id"].ToString();
                }
                else
                {
                    wh.UnitCode = "";
                }

                if (rdr["type_id"].ToString() != "")
                {
                    wh.WhType = rdr["type_id"].ToString();
                }
                else
                {
                    wh.WhType = "";
                }

                if (rdr["wh_id"].ToString() != "")
                {
                    wh.Whid = rdr["wh_id"].ToString();
                }
                else
                {
                    wh.Whid = "";
                }

                if (rdr["group_id"].ToString() != "")
                {
                    wh.Grpid = rdr["group_id"].ToString();
                }
                else
                {
                    wh.Grpid = "";
                }

                if (rdr["store_id"].ToString() != "")
                {
                    wh.Storeid = rdr["store_id"].ToString();
                }
                else
                {
                    wh.Storeid = "";
                }


                if (rdr["io_date"].ToString() != "")
                {
                    wh.Iodate = rdr["io_date"].ToString();
                }
                else
                {
                    wh.Iodate = "";
                }

                if (rdr["remarks"].ToString() != "")
                {
                    wh.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    wh.Remarks = "";
                }

                if (rdr["qty"].ToString() != "")
                {
                    wh.Qty = Convert.ToInt64(rdr["qty"]);
                }
                else
                {
                    wh.Qty = 0;
                }
                if (rdr["module_type"].ToString() != "")
                {
                    wh.IntMtype = Convert.ToInt16(rdr["module_type"]);
                }
                if (rdr["nursing_sta_id"].ToString() != "")
                {
                    wh.NursingStationId = rdr["nursing_sta_id"].ToString();
                }
                else
                {
                    wh.NursingStationId = "";
                }

                if (rdr["IO_FLAG"].ToString() != "")
                {
                    wh.Ioflag = rdr["IO_FLAG"].ToString();
                }
                else
                {
                    wh.Ioflag = "0";
                }


                objType.Add(wh);
            }
            rdr.Close();
            return objType;
        }
        public List<IOmaster> DisplayIssueInformation(string strStoreType, string where)
        {
            string packageName = "PKG_HOUSE_KEEPING.DisplayIssueItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    //new OracleParameter("pwhere",OracleDbType.Varchar2,2,strStoreType,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,30,where,ParameterDirection.Input),

                };
            return DisplayIssueInformation(packageName, parameterList);
        }
        private List<IOmaster> DisplayIssueInformation(string packageName, OracleParameter[] parameterList)
        {
            List<IOmaster> objType = new List<IOmaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IOmaster wh = new IOmaster();
                if (rdr["io_id"].ToString() != "")
                {
                    wh.IoRefNo = rdr["io_id"].ToString();
                }
                else
                {
                    wh.IoRefNo = "";
                }


                if (rdr["item_code"].ToString() != "")
                {
                    wh.ItemCode = rdr["item_code"].ToString();
                }
                else
                {
                    wh.ItemCode = "";
                }

                if (rdr["itemname"].ToString() != "")
                {
                    wh.ItemName = rdr["itemname"].ToString();
                }
                else
                {
                    wh.ItemName = "";
                }

                if (rdr["unit_id"].ToString() != "")
                {
                    wh.UnitCode = rdr["unit_id"].ToString();
                }
                else
                {
                    wh.UnitCode = "";
                }

                if (rdr["unitName"].ToString() != "")
                {
                    wh.UnitName = rdr["unitName"].ToString();
                }
                else
                {
                    wh.UnitName = "";
                }

                if (rdr["type_id"].ToString() != "")
                {
                    wh.WhType = rdr["type_id"].ToString();
                }
                else
                {
                    wh.WhType = "";
                }

                if (rdr["wh_id"].ToString() != "")
                {
                    wh.Whid = rdr["wh_id"].ToString();
                }
                else
                {
                    wh.Whid = "";
                }

                if (rdr["group_id"].ToString() != "")
                {
                    wh.Grpid = rdr["group_id"].ToString();
                }
                else
                {
                    wh.Grpid = "";
                }

                if (rdr["store_id"].ToString() != "")
                {
                    wh.Storeid = rdr["store_id"].ToString();
                }
                else
                {
                    wh.Storeid = "";
                }


                if (rdr["io_date"].ToString() != "")
                {
                    wh.Iodate = rdr["io_date"].ToString();
                }
                else
                {
                    wh.Iodate = "";
                }

                if (rdr["remarks"].ToString() != "")
                {
                    wh.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    wh.Remarks = "";
                }

                if (rdr["qty"].ToString() != "")
                {
                    wh.Qty = Convert.ToInt64(rdr["qty"]);
                }
                else
                {
                    wh.Qty = 0;
                }
                if (rdr["module_type"].ToString() != "")
                {
                    wh.IntMtype = Convert.ToInt16(rdr["module_type"]);
                }
                if (rdr["nursing_sta_id"].ToString() != "")
                {
                    wh.NursingStationId = rdr["nursing_sta_id"].ToString();
                }
                else
                {
                    wh.NursingStationId = "";
                }

                if (rdr["IO_FLAG"].ToString() != "")
                {
                    wh.Ioflag = rdr["IO_FLAG"].ToString();
                }
                else
                {
                    wh.Ioflag = "0";
                }


                objType.Add(wh);
            }
            rdr.Close();
            return objType;
        }
        #endregion
        #region "WarehouseItem"
        public List<IOmaster> GetWarehouseItem(string strStoreType)
        {
            string packageName = "PKG_HOUSE_KEEPING.GetWarehouseItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,2,strStoreType,ParameterDirection.Input),

                };
            return GetWarehouseItem(packageName, parameterList);
        }
        private List<IOmaster> GetWarehouseItem(string packageName, OracleParameter[] parameterList)
        {
            List<IOmaster> objType = new List<IOmaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IOmaster wh = new IOmaster();
                if (rdr["io_id"].ToString() != "")
                {
                    wh.IoRefNo = rdr["io_id"].ToString();
                }
                else
                {
                    wh.IoRefNo = "";
                }

                if (rdr["io_date"].ToString() != "")
                {
                    wh.Iodate = rdr["io_date"].ToString();
                }
                else
                {
                    wh.Iodate = "";
                }

                if (rdr["status_type"].ToString() != "")
                {
                    wh.Ioflag = rdr["status_type"].ToString();
                }
                else
                {
                    wh.Ioflag = "0";
                }


                objType.Add(wh);
            }
            rdr.Close();
            return objType;
        }
        public List<IOmaster> GetWarehouseIssueItem(string strStoreType,string strActive)
        {
            string packageName = "PKG_HOUSE_KEEPING.GetWarehouseIssueItem";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,2,strStoreType,ParameterDirection.Input),
                    new OracleParameter("pwhere1",OracleDbType.Varchar2,2,strActive,ParameterDirection.Input),

                };
            return GetWarehouseIssueItem(packageName, parameterList);
        }
        private List<IOmaster> GetWarehouseIssueItem(string packageName, OracleParameter[] parameterList)
        {
            List<IOmaster> objType = new List<IOmaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IOmaster wh = new IOmaster();
                if (rdr["io_id"].ToString() != "")
                {
                    wh.IoRefNo = rdr["io_id"].ToString();
                }
                else
                {
                    wh.IoRefNo = "";
                }

                if (rdr["io_date"].ToString() != "")
                {
                    wh.Iodate = rdr["io_date"].ToString();
                }
                else
                {
                    wh.Iodate = "";
                }

                if (rdr["status_type"].ToString() != "")
                {
                    wh.Ioflag = rdr["status_type"].ToString();
                }
                else
                {
                    wh.Ioflag = "0";
                }


                objType.Add(wh);
            }
            rdr.Close();
            return objType;
        }
        #endregion
        #region "Update IoMaster"
        public int  UpdateIomaster(IOmaster IOmaster)
        {
            packageName = "PKG_HOUSE_KEEPING.UpdateIomaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                
                new OracleParameter("Pref_ID",OracleDbType.Varchar2,60,IOmaster.IoRefNo,ParameterDirection.Input),
                new OracleParameter("pgrpid",OracleDbType.Varchar2,60,IOmaster.Grpid,ParameterDirection.Input),
                new OracleParameter("pmoduletype",OracleDbType.Varchar2,60,IOmaster.Moduletype,ParameterDirection.Input),
                new OracleParameter("pstoretype",OracleDbType.Varchar2,60,IOmaster.Storeid,ParameterDirection.Input),
                new OracleParameter("pwhtype",OracleDbType.Varchar2,60,IOmaster.WhType,ParameterDirection.Input),
                new OracleParameter("pwhid",OracleDbType.Varchar2 ,60,IOmaster.Whid,ParameterDirection.Input),
                new OracleParameter("piodate",OracleDbType.Varchar2,60,IOmaster.Iodate,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2,60,IOmaster.Remarks,ParameterDirection.Input),
                new OracleParameter("pioflag",OracleDbType.Varchar2,60,IOmaster.Ioflag,ParameterDirection.Input), //0 receipt 1 issue
                new OracleParameter("pactive",OracleDbType.Varchar2,60,IOmaster.Active,ParameterDirection.Input),
                new OracleParameter("pstationId",OracleDbType.Varchar2,60,IOmaster.NursingStationId,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,IOmaster.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,IOmaster.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,IOmaster.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,IOmaster.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            return 1;
        }
        public short UpdateIoDetails(string RefID, string itemCode, double dblqty, int statustype, string strRemarks, string Istatus, IOmaster IOmaster)
        {
            packageName = "PKG_HOUSE_KEEPING.UpdateIodetails";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pref_ID",OracleDbType.Varchar2,60,RefID,ParameterDirection.Input),
                new OracleParameter("pitemCode",OracleDbType.Varchar2,60,itemCode,ParameterDirection.Input),
                new OracleParameter("pqty",OracleDbType.Varchar2,60,dblqty,ParameterDirection.Input),
                new OracleParameter("pstatustype",OracleDbType.Varchar2 ,60,statustype,ParameterDirection.Input), //0 clean 1 dirty 2 maintainence
                new OracleParameter("premarks",OracleDbType.Varchar2,60,strRemarks,ParameterDirection.Input),
                new OracleParameter("pstatus",OracleDbType.Varchar2,2,Istatus,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,IOmaster.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,IOmaster.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,IOmaster.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,IOmaster.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            return 1;
        }
        #endregion


    }

}
