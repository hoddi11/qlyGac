using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLgac.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QLgac.DAO
{
    public class DaiDoiDAO: DataProvider
    {
        public void themDD(DAIDOI dd)
        {
            string sql = $"EXEC PROC_ThemDaiDoi '{dd.MaDD}', '{dd.TenDD}', '{dd.DiaChi}', '{dd.QuanSo}', '1', 'TD01'";
            Excute(sql);
        }
        public DataTable loadDD()
        {
            string sql = "select MaDD as 'Mã đại đội', TenDD as 'Đại đội', QuanSo as 'Quân số', DiaChi as 'Địa chỉ' from DAIDOI";
            return GetData(sql);
        }
        public void suaDD(DAIDOI c)
        {
            string sql = $"EXEC PROC_SuaDaiDoi '{c.MaDD}', '{c.TenDD}', '{c.DiaChi}', '{c.QuanSo}', '1'";
            Excute(sql);
        }
        public void xoaDD(DAIDOI c)
        {
            string sql = $"EXEC PROC_XoaDaiDoi '{c.MaDD}'";
            Excute(sql);
        }
        public Int64 qsTD()
        {
            string sql = "select sum(d.QuanSo) from DAIDOI d where d.MaTD = 'TD01'";
            return GetCount(sql);
        }
        public string dcTD()
        {
            string sql = "select d.DiaChi from TIEUDOAN d where d.MaTD = 'TD01'";
            return GetString(sql);
        }
    }
}
