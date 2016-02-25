using CasterDAL;
using CasterModel;
using System.Collections.Generic;

namespace CasterBLL
{
    public partial class ManagerInfoBLL
    {
        ManagerInfoDal miDal = new ManagerInfoDal();

        public List<ManagerInfo> GetList()
        {
            //获取数据
            return miDal.GetList();
        }

        public bool Add(ManagerInfo mi)
        {
            //插入数据
            return miDal.Insert(mi) > 0;
        }
    }

}
