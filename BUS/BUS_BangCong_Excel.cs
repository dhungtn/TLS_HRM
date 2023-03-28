using System;
using System.Collections.Generic;
using DTO;
using DAO;
using System.Text;

namespace BUS
{
    public class BUS_Timesheet_Excel
    {
        public static bool KT_TonTaiBangCong(BangCong_Excel bc)
        {
            return DAO_Timesheet_Excel.KT_TonTaiBangCong(bc);
        }

        //insert du lieu vao bang cong
        public static bool insert(BangCong_Excel bc)
        {
            return DAO_Timesheet_Excel.insert(bc);
        }
    }
}
