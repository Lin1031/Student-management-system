using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//返回数据类型
using System.Data.SqlClient;//连接数据库

namespace Demo
{
    
    class Dao
    {
        public SqlConnection connection()
        {
            string str = "Data Source=DESKTOP-5IE1GSB;Initial Catalog=Dome;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();//打开数据库链接
            return sc;
        }
        public SqlCommand command(string sql)//数据库的操作
        {
            SqlCommand sc = new SqlCommand(sql, connection());
            return sc;
        }
        //用于 delete update insert 返回受影响的行数
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();//对连接执行Transact- SQL语句并返回受影响的行数。
        }
        //用于 select 返回SqlDataReader对象，包含select的 Dao的数据
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }
}
