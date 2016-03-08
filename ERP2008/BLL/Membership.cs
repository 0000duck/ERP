using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ERP.BLL
{
    public class Membership
    {
        private readonly ERP.DAL.Membership dal = new ERP.DAL.Membership();
        #region  BasicMethod

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }


        #endregion  BasicMethod
    }
}
