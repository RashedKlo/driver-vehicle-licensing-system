using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
namespace BusinessAccess
{
    //        USE[DVLD]
    //GO

    //INSERT INTO[dbo].[Users]
    //        ([PersonID]
    //          ,[UserName]
    //          ,[Password]
    //          ,[IsActive])
    //    VALUES
    //          (<PersonID, int,>
    //           ,<UserName, nvarchar(20),>
    //           ,<Password, nvarchar(20),>
    //           ,<IsActive, bit,>)
    //GO
   public class ClsUser
    {
        public int PersonID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
     private enum enMode { AddNew=1,Update=2 }
        enMode _Mode = enMode.Update;

        public ClsUser()
        {
            PersonID = -1;
            UserID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
            _Mode = enMode.AddNew;

        }
        private ClsUser(int UserID,int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            _Mode = enMode.Update;

        }
        private bool _Add()
        {
            this.UserID = ClsDataUsers.AddUser(this.PersonID, UserName, Password, IsActive);
            return UserID != -1;
        }
        private bool _Update()
        {
            return ClsDataUsers.UpdateUser(this.UserID, this.PersonID, UserName, Password, IsActive);
        }
        public bool Delete()
        {
            return ClsDataUsers.DeleteUser(this.UserID);
        }
       static  public bool Delete(int UserID)
        {
            return ClsDataUsers.DeleteUser(UserID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        return _Add();
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default:
                    return false;

            }
        }

     static   public DataTable GetAllUser()
        {
            return ClsDataUsers.GetAllUsers();
        }
        static public bool  IsUserNameExist(string UserName)
        {
            return ClsDataUsers.IsUserNameExist(UserName);
        }
        static public bool IsPersonIDExist(int PersonID)
        {
            return ClsDataUsers.IsPersonIDExist(PersonID);
        }
        static public ClsUser Find(int _UserID)
        {
            int _PersonID = -1;
            string _UserName = string.Empty;
            string _Password = string.Empty;
            bool _IsActive = false;
            if (ClsDataUsers.GetUserByID(_UserID, ref _PersonID, ref _UserName, ref _Password, ref _IsActive))
            {
                return new ClsUser(_UserID, _PersonID, _UserName, _Password, _IsActive);
            }
            else
                return null;
        }
        static public ClsUser Find(string _UserName)
        {
            int _PersonID = -1;
            int _UserID = -1;
            string _Password = string.Empty;
            bool _IsActive = false;
            if (ClsDataUsers.GetUserByUserName(_UserName, ref _UserID, ref _PersonID, ref _Password, ref _IsActive))
            {
                return new ClsUser(_UserID, _PersonID, _UserName, _Password, _IsActive);
            }
            else
                return null;
        }
    }
}
