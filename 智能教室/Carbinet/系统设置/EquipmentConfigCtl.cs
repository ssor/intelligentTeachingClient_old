using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Carbinet
{
    public class EquipmentConfigCtl
    {
        static string sqlInsert_SaveConfig = @"insert into T_EQUIPMENT_LOCATION_MAP(EQUIPEMNTID,IGROUP,IROW,ICOLUMN)
                    values('{0}',{1},{2},{3});";
        static string sqlSelect_CheckConfigExist = @"select EQUIPEMNTID from T_EQUIPMENT_LOCATION_MAP where 
                    IGROUP={0} and IROW = {1} and ICOLUMN = {2}";
        static string sqlSelect_GetAllMapConfigs =
            @"SELECT EQUIPEMNTID,IGROUP,IROW,ICOLUMN from T_EQUIPMENT_LOCATION_MAP";
        static string sqlUpdate_UpdateConfig = @"update T_EQUIPMENT_LOCATION_MAP set EQUIPEMNTID = '{0}' where 
                    IGROUP={1} and IROW = {2} and ICOLUMN = {3}";
        static string sql_select_room_configs =
            @"SELECT V_NAME,IGROUP,IROW,ICOLUMN,USED_NOW FROM T_ROOM_CONFIGS";
        static string sql_select_room_config =
            @"SELECT V_NAME,IGROUP,IROW,ICOLUMN,USED_NOW FROM T_ROOM_CONFIGS where V_NAME = '{0}'";
        static string sql_insert_room_configs =
            @"insert into T_ROOM_CONFIGS(V_NAME,IGROUP,IROW,ICOLUMN, USED_NOW) values('{0}', {1},{2},{3},'false')";
        static string sql_delete_room_configs =
            @"delete FROM T_ROOM_CONFIGS where V_NAME = '{0}'";
        static string sql_update_room_configs =
            @"update T_ROOM_CONFIGS set USED_NOW = '{0}'  where V_NAME = '{1}'";
        static string sql_update_room_configs_not_in =
    @"update T_ROOM_CONFIGS set USED_NOW = 'false'  where V_NAME not in('{0}')";
        //        static string sqlSelect_GetAllMapConfigs =
        //    @"SELECT EQUIPEMNTID,IGROUP,IROW,ICOLUMN from T_EQUIPMENT_LOCATION_MAP
        //                where IGROUP<=(select VVALUE from T_CONFIG where VKEY= 'group')
        //                and IROW<=(select VVALUE from T_CONFIG where VKEY= 'row') 
        //                and ICOLUMN<=(select VVALUE from T_CONFIG where VKEY= 'column')";

        //static string sqlUpdate_UpdateGroupNumber =
        //    @"update T_CONFIG set VVALUE = '{0}' where VKEY= 'group'";
        //static string sqlUpdate_UpdaterowNumber =
        //     @"update T_CONFIG set VVALUE = '{0}' where VKEY= 'row'";
        //static string sqlUpdate_UpdatecolumnNumber =
        //     @"update T_CONFIG set VVALUE = '{0}' where VKEY= 'column'";

        //static string sqlSelect_GetConfigGroupNumber =
        //    @"select VVALUE from T_CONFIG where VKEY= 'group'";
        //static string sqlSelect_GetConfigRowNumber =
        //    @"select VVALUE from T_CONFIG where VKEY= 'row'";
        //static string sqlSelect_GetConfigColumnNumber =
        //    @"select VVALUE from T_CONFIG where VKEY= 'column'";
        public bool SetConfigsNotUsed(string config_name)
        {
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(
                       sql_update_room_configs_not_in, new object[] { config_name });
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("查询数据库时出现错误：" + ex.Message);
            }
            return false;
        }
        public bool SetConfigsUsed(string config_name)
        {
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(
                       sql_update_room_configs, new object[] { "true", config_name });
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("查询数据库时出现错误：" + ex.Message);
            }
            return false;
        }
        public DataTable DeleteRoomConfig(string name)
        {
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(sql_delete_room_configs, new object[] { name });
                return dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("查询数据库时出现错误：" + ex.Message);
            }
            return null;
        }
        public bool AddConfigs(string config_name, int group, int row, int column)
        {
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(
                       sql_insert_room_configs, new object[] { config_name, group, row, column });
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("查询数据库时出现错误：" + ex.Message);
            }
            return false;
        }
        public DataTable getRoomConfig(string name)
        {
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(sql_select_room_config, new object[] { name });
                return dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("查询数据库时出现错误：" + ex.Message);
            }
            return null;
        }
        public DataTable getAllRoomConfigs()
        {
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(sql_select_room_configs, null);
                return dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("查询数据库时出现错误：" + ex.Message);
            }
            return null;
        }
        public DataTable getAllMapConfigs()
        {
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(sqlSelect_GetAllMapConfigs, null);
                return dt;
                //ds = SQLiteHelper.ExecuteDataSet(
                //          SQLiteHelper.connectString,
                //           sqlSelect_GetAllMapConfigs, null);
                //if (ds != null)
                //{
                //    if (ds.Tables.Count > 0)
                //    {
                //        return ds.Tables[0];
                //    }
                //}
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("查询数据库时出现错误：" + ex.Message);
            }
            return null;
        }

        //public int getClassroomConfig(int type)
        //{
        //    string sql = null;
        //    switch (type)
        //    {
        //        case 0:
        //            sql = sqlSelect_GetConfigGroupNumber;
        //            break;
        //        case 1:
        //            sql = sqlSelect_GetConfigRowNumber;
        //            break;
        //        case 2:
        //            sql = sqlSelect_GetConfigColumnNumber;
        //            break;
        //    }
        //    if (null == sql)
        //    {
        //        return 0;
        //    }
        //    DataSet ds = null;
        //    try
        //    {
        //        DataTable dt = CsharpSQLiteHelper.ExecuteTable(sql, null);
        //        if (dt.Rows.Count > 0)
        //        {
        //            DataRow dr = dt.Rows[0];
        //            return int.Parse(dr["VVALUE"].ToString());
        //        }
        //        //ds = SQLiteHelper.ExecuteDataSet(
        //        //          SQLiteHelper.connectString,
        //        //           sql, null);
        //        //if (ds != null)
        //        //{
        //        //    if (ds.Tables.Count > 0)
        //        //    {
        //        //        if (ds.Tables[0].Rows.Count > 0)
        //        //        {
        //        //            DataRow dr = ds.Tables[0].Rows[0];
        //        //            return int.Parse(dr["VVALUE"].ToString());
        //        //        }
        //        //    }
        //        //}
        //    }
        //    catch (System.Exception ex)
        //    {
        //        MessageBox.Show("查询数据库时出现错误：" + ex.Message);
        //    }
        //    return 0;
        //}

        /// <summary>
        /// 更新教师的座位配置
        /// </summary>
        /// <param name="number">数目</param>
        /// <param name="type">类型 0 group   1 row  2 column</param>
        /// <returns></returns>
        //public bool updateClassRoomConfig(int number, int type)
        //{
        //    string sql = null;
        //    switch (type)
        //    {
        //        case 0:
        //            sql = sqlUpdate_UpdateGroupNumber;
        //            break;
        //        case 1:
        //            sql = sqlUpdate_UpdaterowNumber;
        //            break;
        //        case 2:
        //            sql = sqlUpdate_UpdatecolumnNumber;
        //            break;
        //    }
        //    if (null == sql)
        //    {
        //        return false;
        //    }
        //    try
        //    {
        //        int result = int.Parse(CsharpSQLiteHelper.ExecuteNonQuery(sql
        //                     , new object[1]
        //                                            {
        //                                                number
        //                                            }).ToString());
        //        if (result > 0)
        //        {
        //            return true;
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {

        //        MessageBox.Show("更新数据时出现错误：" + ex.Message);
        //    }
        //    return false;
        //}

        public bool updateMapConfig(string equipID, int group, int row, int column)
        {
            try
            {
                int result = int.Parse(CsharpSQLiteHelper.ExecuteNonQuery(
                             sqlUpdate_UpdateConfig
                             , new object[4]
                                                    {
                                                        equipID
                                                        ,group
                                                        ,row
                                                        ,column
                                                    }).ToString());
                //int result = int.Parse(SQLiteHelper.ExecuteNonQuery(SQLiteHelper.connectString,
                //                             sqlUpdate_UpdateConfig
                //                             , new object[4]
                //                                    {
                //                                        equipID
                //                                        ,group
                //                                        ,row
                //                                        ,column
                //                                    }).ToString());
                if (result > 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("更新数据时出现错误：" + ex.Message);
            }
            return false;
        }
        public bool AddMapConfig(string equipID, int group, int row, int column)
        {
            try
            {
                int result = int.Parse(CsharpSQLiteHelper.ExecuteNonQuery(
                              sqlInsert_SaveConfig
                              , new object[4]
                                                    {
                                                        equipID
                                                        ,group
                                                        ,row
                                                        ,column
                                                    }).ToString());
                //int result = int.Parse(SQLiteHelper.ExecuteNonQuery(SQLiteHelper.connectString,
                //                             sqlInsert_SaveConfig
                //                             , new object[4]
                //                                    {
                //                                        equipID
                //                                        ,group
                //                                        ,row
                //                                        ,column
                //                                    }).ToString());
                if (result > 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("添加数据时出现错误：" + ex.Message);
            }
            return false;
        }
        public bool CheckExists(int group, int row, int column)
        {
            DataSet ds = null;
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(
                       sqlSelect_CheckConfigExist, new object[3] { group, row, column });
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                //ds = SQLiteHelper.ExecuteDataSet(
                //          SQLiteHelper.connectString,
                //           sqlSelect_CheckConfigExist, new object[3] { group, row, column });
                //if (ds != null)
                //{
                //    if (ds.Tables.Count > 0)
                //    {
                //        if (ds.Tables[0].Rows.Count > 0)
                //        {
                //            return true;
                //        }
                //    }
                //}
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("查询数据库时出现错误：" + ex.Message);
            }
            return false;
        }
    }
}
