using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using DSL.POS.DTO.DTO;
using DSL.POS.DataAccessLayer.Interface;
using DSL.POS.DataAccessLayer.Common.Imp;

namespace DSL.POS.DataAccessLayer.Imp
{
    /// <summary>
    /// Summary description for ProductUnitDALImpl
    /// </summary>
    /// 

    public class ProductUnitDALImpl : CommonDALImp, IProductUnitDAL
    {
        // Error Handling Developed by Samad
        // 05/12/06

        private string Get_ProductUnitCode(ProductUnitInfoDTO Obj)
        {
            string pucode = null;
            int pucodeno = 0;
            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objcmd = new SqlCommand();

            objcmd.CommandText = "Select Isnull(Max(cast(PU_Code as int)),0 )+1 from ProductUnitInfo";
            
            objcmd.Connection = objmycon;
            try
            {
                objmycon.Open();
                pucodeno = (int)objcmd.ExecuteScalar();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objmycon.Close();
            }
            pucode = pucodeno.ToString("00");
            return pucode;
        }
        public override void Save(object Obj)
        {
            ProductUnitInfoDTO puInfo = (ProductUnitInfoDTO)Obj;

            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objcmd = new SqlCommand();

            if (puInfo.PrimaryKey.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                puInfo.PU_Code = Get_ProductUnitCode(puInfo);

                objcmd.CommandText = "Insert Into ProductUnitInfo(PU_Code,PU_Name,EntryBy,EntryDate) Values(@PU_Code,@PU_Name,@EntryBy,@EntryDate)";
                objcmd.Parameters.Add(new SqlParameter("@PU_Code", SqlDbType.VarChar, 2));
                objcmd.Parameters.Add(new SqlParameter("@PU_Name", SqlDbType.VarChar, 50));

                objcmd.Parameters.Add(new SqlParameter("@EntryBy", SqlDbType.VarChar, 5));
                objcmd.Parameters.Add(new SqlParameter("@EntryDate", SqlDbType.DateTime, 8));

                objcmd.Parameters["@PU_Code"].Value = (string)puInfo.PU_Code;
                objcmd.Parameters["@PU_Name"].Value = (string)puInfo.PU_Name;

                objcmd.Parameters["@EntryBy"].Value = (string)puInfo.EntryBy;
                objcmd.Parameters["@EntryDate"].Value = (DateTime)puInfo.EntryDate;

            }
            else
            {
                objcmd.CommandText = "Update ProductUnitInfo set PU_Name=@PU_Name where PU_PK=@PU_PK";
                objcmd.Parameters.Add(new SqlParameter("@PU_PK", SqlDbType.UniqueIdentifier, 16));
                objcmd.Parameters.Add(new SqlParameter("@PU_Name", SqlDbType.VarChar, 50));

                objcmd.Parameters["@PU_PK"].Value = (Guid)puInfo.PrimaryKey;
                objcmd.Parameters["@PU_Name"].Value = (string)puInfo.PU_Name;

            }
            objcmd.Connection = objmycon;
            try
            {
                objmycon.Open();
                objcmd.ExecuteNonQuery();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
            finally
            {
                objmycon.Close();
            }
        }

        public List<ProductUnitInfoDTO> GetProductUnitInfo()
        {
            List<ProductUnitInfoDTO> productUnitList = new List<ProductUnitInfoDTO>();

            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objcmd = new SqlCommand();
            objcmd.Connection = objmycon;
            objcmd.CommandText = "SELECT PU_PK,PU_Code,PU_Name,EntryBy,EntryDate FROM ProductUnitInfo ORDER BY PU_Code";
            
            try
            {
                objmycon.Open();
                SqlDataReader thisReader = objcmd.ExecuteReader();

                while (thisReader.Read())
                {
                    ProductUnitInfoDTO oProductUnitInfoDto = Populate(thisReader);
                    productUnitList.Add(oProductUnitInfoDto);
                }

                thisReader.Close();
                thisReader.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                objcmd.Dispose();
                objcmd.Cancel();
            }
            return productUnitList;
        }
        public override void Delete(object obj)
        {
            ProductUnitInfoDTO oProductUnitInfoDto = (ProductUnitInfoDTO)obj;

            SqlConnection objmycon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objcmd = new SqlCommand();
            objcmd.CommandText = "Delete From ProductUnitInfo WHERE PU_PK=@PU_PK";
            objcmd.Parameters.Add(new SqlParameter("@PU_PK", SqlDbType.UniqueIdentifier, 16));
            objcmd.Parameters["@PU_PK"].Value = (Guid)oProductUnitInfoDto.PrimaryKey;
            objcmd.Connection = objmycon;
            
            try
            {
                objmycon.Open();
                objcmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objmycon.Close();                
            }
        }

        public ArrayList GetData()
        {

            SqlConnection objMyCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCom = new SqlCommand();
            ArrayList subUnitList = new ArrayList();
            
            objCom.Connection = objMyCon;
            objCom.CommandText = "SELECT PU_PK, PU_Code, PU_Name FROM ProductUnitInfo ORDER BY PU_Code";
            
            try
            {
                objMyCon.Open();
                SqlDataReader reader = objCom.ExecuteReader();

                while (reader.Read())
                {
                    ProductUnitInfoDTO dto = Populate(reader);
                    subUnitList.Add(dto);
                }

                reader.Close();
                reader.Dispose();
            }
            catch (Exception Exp)
            {
               throw Exp;
            }
            return subUnitList;
        }

        public ProductUnitInfoDTO FindByPK(Guid pk)
        {
            ProductUnitInfoDTO puDTO = new ProductUnitInfoDTO();
            string sqlSelect = "SELECT PU_PK, PU_Code, PU_Name, EntryBy, EntryDate FROM ProductUnitInfo WHERE PU_PK=@PU_PK";
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DPOSConnectionString"].ToString());
            SqlCommand objCmd = sqlConn.CreateCommand();

            try
            {
                objCmd.CommandText = sqlSelect;
                objCmd.Connection = sqlConn;
                objCmd.Parameters.Add("@PU_PK", SqlDbType.UniqueIdentifier, 16);
                objCmd.Parameters["@PU_PK"].Value = pk;

                sqlConn.Open();
                SqlDataReader thisReader = objCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    puDTO = Populate(thisReader);
                }

                thisReader.Close();
                thisReader.Dispose();
            }
            catch (Exception Exp)
            {
                throw Exp;
            }

            finally
            {
                objCmd.Dispose();
                objCmd.Cancel();
                sqlConn.Dispose();
                sqlConn.Close();
            }
            return puDTO;
        }

        public ProductUnitInfoDTO Populate(SqlDataReader reader)
        {
            try
            {
                ProductUnitInfoDTO dto = new ProductUnitInfoDTO();

                dto.PrimaryKey = (Guid)reader["PU_PK"];
                dto.PU_Code = (string)reader["PU_Code"];
                dto.PU_Name = (string)reader["PU_Name"];
                dto.EntryBy = (string)reader["EntryBy"];
                dto.EntryDate = (DateTime)reader["EntryDate"];

                return dto;
            }
            catch (Exception Exp)
            {
                throw Exp;
            }
        }

        public ProductUnitDALImpl()
        {
            //
            // TODO: Add constructor logic here
            //
        }

    }
}