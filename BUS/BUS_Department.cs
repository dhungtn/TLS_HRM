using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_Department
    {
        // ham lay du lieu trong bang bophan gan vao combobox bo phan
        public static List<Department> compoboxBophan()
        {
            return DAO_Department.compoboxBophan();
        }
        // Kiểm tra ma bo phan có tồn tại hay không
        #region Kiểm tra mã bộ phận có tồn tại hay không
        public static string KiemTraMabophan(string mabp)
        {
            return DAO_Department.KiemTraMabophan(mabp);
        }
        #endregion
        public static string KiemTraMabophan_sua(string macu, string mamoi)
        {
            return DAO_Department.KiemTraMabophan_sua(macu, mamoi);
        }
        public static string insert(string ma, string ten)
        {
            return DAO_Department.insert(ma, ten);
        }
        public static string update(string macu, string mamoi, string ten)
        {
            return DAO_Department.update(macu, mamoi, ten);
        }
        public static string delete(string ma)
        {
            return DAO_Department.delete(ma);
        }
    }
}
