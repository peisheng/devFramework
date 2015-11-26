//=====================================================================================
// All Rights Reserved , Copyright @ Learun 2015
// Software Developers @ Learun 2015
//=====================================================================================

using LeaRun.DataAccess.Attributes;
using LeaRun.Utilities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeaRun.Entity
{
    /// <summary>
    /// TestTable
    /// <author>
    ///		<name>she</name>
    ///		<date>2015.11.25 23:30</date>
    /// </author>
    /// </summary>
    [Description("TestTable")]
    [PrimaryKey("TestId")]
    public class TestTable : BaseEntity
    {
        #region 获取/设置 字段值
        /// <summary>
        /// TestId
        /// </summary>
        /// <returns></returns>
        [DisplayName("TestId")]
        public int? TestId { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        /// <returns></returns>
        [DisplayName("编码")]
        public int? Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        /// <returns></returns>
        [DisplayName("名称")]
        public string FullName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        /// <returns></returns>
        [DisplayName("创建时间")]
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <returns></returns>
        [DisplayName("创建用户")]
        public string CreateUserName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        [DisplayName("备注")]
        public string Remark { get; set; }
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public override void Create()
        {
            this.TestId = CommonHelper.GetGuid;
            this.CreateDate = DateTime.Now;
                        this.CreateUserName = ManageProvider.Provider.Current().UserName;
        }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="KeyValue"></param>
        public override void Modify(string KeyValue)
        {
            this.TestId = KeyValue;
                                            }
        #endregion
    }
}