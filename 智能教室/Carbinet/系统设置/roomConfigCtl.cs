using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Carbinet
{
    public class roomConfigCtl
    {
        public static string sqlSelect_allRoomConfig =
            @"SELECT IGROUP,IROW,ICOLUMN from T_ROOM_CONFIG;";
        public static string sqlSelect_SpecifiedRoomConfig =
            @"SELECT IGROUP,IROW,ICOLUMN from T_ROOM_CONFIG  where IGROUP = {0} ;";

        public static string sqlUpdate_updateRoomConfigRow =
            @"update T_ROOM_CONFIG set IROW = {0} where IGROUP = {1}";
        public static string sqlUpdate_updateRoomConfigColumn =
             @"update T_ROOM_CONFIG set ICOLUMN = {0} where IGROUP = {1}";
        public static string sqlInsert_addConfig =
            @"insert into T_ROOM_CONFIG(IGROUP,IROW,ICOLUMN) values({0},{1},{2})";
        public static string sqlDelete_allNotExistedGroups =
            @"delete from T_ROOM_CONFIG where IGROUP not in({0})";
        public static string sql_delete_all_config =
            @"delete from T_ROOM_CONFIG";


        public bool DeleteAllConfig()
        {
            try
            {
                int result = int.Parse(CsharpSQLiteHelper.ExecuteNonQuery(
                                             sql_delete_all_config
                                             , null).ToString());
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
        public int GetGroupCount()
        {
            int count = 0;
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(sqlSelect_allRoomConfig, null);
                count = dt.Rows.Count;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("查询数据库时出现错误：" + ex.Message);
            }
            return count;
        }
        public bool DeleteNotExistedGroup(List<int> groups)
        {
            string str_not_in = string.Empty;
            for (int i = 0; i < groups.Count; i++)
            {
                if (str_not_in == string.Empty)
                {
                    str_not_in = groups[i].ToString();
                }
                else
                {
                    str_not_in = str_not_in + "," + groups[i].ToString();
                }
            }

            try
            {
                int result = int.Parse(CsharpSQLiteHelper.ExecuteNonQuery(
                                             sqlDelete_allNotExistedGroups
                                             , new object[1]
                                                    {
                                                        str_not_in
                                                    }).ToString());
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
        public bool AddNewConfig(int group, int row, int column)
        {
            try
            {
                int result = int.Parse(CsharpSQLiteHelper.ExecuteNonQuery(
                                             sqlInsert_addConfig
                                             , new object[3]
                                                    {
                                                        group
                                                        ,row
                                                        ,column
                                                    }).ToString());
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

        public bool ConfigExists(int group)
        {
            //DataSet ds = null;
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(sqlSelect_SpecifiedRoomConfig, new object[1] { group });
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                //ds = SQLiteHelper.ExecuteDataSet(
                //          SQLiteHelper.connectString,
                //           sqlSelect_SpecifiedRoomConfig, new object[1] { group });
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
        /// <summary>
        /// 更新配置信息
        /// </summary>
        /// <param name="group"></param>
        /// <param name="value"></param>
        /// <param name="type">0，row   1 column</param>
        /// <returns></returns>
        public bool updateRoomConfig(int group, int value, int type)
        {
            string sql = null;
            switch (type)
            {
                case 0:
                    sql = sqlUpdate_updateRoomConfigRow;
                    break;
                case 1:
                    sql = sqlUpdate_updateRoomConfigColumn;
                    break;
            }
            if (null == sql)
            {
                return false;
            }
            try
            {
                int result = int.Parse(CsharpSQLiteHelper.ExecuteNonQuery(
                             sql
                             , new object[2]
                                                    {
                                                        value
                                                        ,group
                                                    }).ToString());
                //int result = int.Parse(SQLiteHelper.ExecuteNonQuery(SQLiteHelper.connectString,
                //                             sql
                //                             , new object[2]
                //                                    {
                //                                        value
                //                                        ,group
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

        public DataTable getAllRoomConfigInfo()
        {
            DataSet ds = null;
            try
            {
                DataTable dt = CsharpSQLiteHelper.ExecuteTable(sqlSelect_allRoomConfig, null);
                return dt;
                //ds = SQLiteHelper.ExecuteDataSet(
                //          SQLiteHelper.connectString,
                //           sqlSelect_allRoomConfig, null);
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
    }
}
