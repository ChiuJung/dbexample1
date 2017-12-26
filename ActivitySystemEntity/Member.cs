
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ActivitySystemEntity
{
    #region 別名：calss(類別)/object(物件)
    /// <summary>
    /// 成員   
    /// </summary>
    public class Member
    {
        #region 別名：state(狀態)/field(欄位)/parameter(參數)/attribute(屬性)
        [Display(Name = "流水號")]
        public int id { get; set; }
        [Display(Name = "單位")]
        public string department { get; set; }
        [Display(Name = "職號")]
        public string staffCard { get; set; }
        [Display(Name = "身分證字號")]
        public string idCard { get; set; }
        [Display(Name = "姓名")]
        public string userName { get; set; }
        [Display(Name = "通行碼")]
        public string userPassword { get; set; }
        [Display(Name = "權限")]
        public string role { get; set; }
        #endregion

        #region 別名：event(事件)/method(方法)/function(功能)/behavior(行為)
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="entity">成員</param>
        /// <returns></returns>
        public bool insert()
        {
            return true;
        }

        /// <summary>
        /// 查詢資料
        /// </summary>
        /// <returns></returns>
        public List<Member> selectMultiObjects()
        {
            List<Member> members = new List<Member>();
            return members;
        }

        /// <summary>
        /// 查詢單筆
        /// </summary>
        /// <param name="staffCard">職號</param>
        /// <returns></returns>
        public Member selectSingleObject(string staffCard)
        {
            Member member = new Member();
            return member;
        }

        /// <summary>
        /// 更新資料
        /// </summary>
        /// <returns></returns>
        public bool update()
        {
            return true;
        }

        /// <summary>
        /// 刪除資料-判斷職號
        /// </summary>
        /// <param name="staffCard">職號</param>
        /// <returns></returns>
        public bool delete(string staffCard)
        {
            return true;
        }
        #endregion
    }
    #endregion
}
