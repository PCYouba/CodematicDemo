using System;
namespace rr2.Model
{
    /// <summary>
    /// userInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class userInfo
    {

        #region Model
        private int _userid;
        private string _userloginname;
        private string _usertruename;
        private string _userpass;
        private string _useremail;
        private string _usertel;
        private int _flag;
        private string _ext1;
        private string _ext2;
        private string _ext3;
        /// <summary>
        /// 
        /// </summary>
        public int userId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userLoginName
        {
            set { _userloginname = value; }
            get { return _userloginname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userTrueName
        {
            set { _usertruename = value; }
            get { return _usertruename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userPass
        {
            set { _userpass = value; }
            get { return _userpass; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userEmail
        {
            set { _useremail = value; }
            get { return _useremail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userTel
        {
            set { _usertel = value; }
            get { return _usertel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int flag
        {
            set { _flag = value; }
            get { return _flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext1
        {
            set { _ext1 = value; }
            get { return _ext1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext2
        {
            set { _ext2 = value; }
            get { return _ext2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext3
        {
            set { _ext3 = value; }
            get { return _ext3; }
        }
        #endregion Model

    }
}

