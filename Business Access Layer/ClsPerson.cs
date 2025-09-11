using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BusinessAccess
{//INSERT INTO[dbo].[PeopleID]
    //([NationalNo]
    //  ,[FirstName]
    //  ,[SecondName]
    //  ,[ThirdName]NULL
    //  ,[LastName]
    //  ,[DateOfBirth]
    //  ,[Gender]
    //  ,[Address]
    //  ,[Phone]
    //  ,[Email]NULL
    //  ,[NationalityCountryID]
    //  ,[ImagePath])NULL
    public class ClsPerson
    {
        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        enum enMode { Addnew = 1, Update };
        enMode _Mode = enMode.Update;
        public ClsPerson()
        {
            ID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = string.Empty;
            LastName = "";
            DateOfBirth = new DateTime();
            Gender =0;
            Address = "";
            Email = string.Empty;
            Phone = "";
            NationalityCountryID = -1;
            ImagePath = string.Empty;
            _Mode = enMode.Addnew;

        }
        private  ClsPerson(int ID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth
      , byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.ID = ID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.NationalityCountryID = NationalityCountryID; ;
            this.ImagePath = ImagePath; ;
            _Mode = enMode.Update;

        }
        private bool _AddPerson()
        {
          this.ID=ClsDataPerson.AddPerson(NationalNo, FirstName, SecondName, ThirdName,
                LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            return ID != -1;
        }
        private bool _Update()
        {
            return ClsDataPerson.UpdatePerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
        }
        static public DataTable GetAllPeopleWithCountry()
        {

            return ClsDataPerson.GetAllPeopleWithCountry();
        }

        static public DataTable GetAllPeople()
        {
        
            return ClsDataPerson.GetAllPeople();
        }
         public bool Delete()
        {
            return ClsDataPerson.Delete(this.ID);
        }
        public static bool Delete(int PersonID)
        {
            return ClsDataPerson.Delete(PersonID);
        }
        static public  ClsPerson FindByID(int ID)
        {

            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName =string.Empty;
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            string Address = "";
            string Email = string.Empty;
            string Phone = "";
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;
            if (ClsDataPerson.GetPersonByID(ID,ref NationalNo,ref FirstName,ref SecondName,ref ThirdName,ref LastName,ref DateOfBirth,ref Gender
                ,ref Address,ref Phone,ref Email,ref NationalityCountryID,ref ImagePath))
            {

                return new ClsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth
      , Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

            }
            else
            {
                return null;
            }
        }
        static public ClsPerson FindByNationalNo(string NationalNo)
        {

            int ID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = string.Empty;
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            string Address = "";
            string Email = string.Empty;
            string Phone = "";
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;
            if (ClsDataPerson.GetPersonByNationalNo(NationalNo,ref ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender
                , ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {

                return new ClsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth
      , Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

            }
            else
            {
                return null;
            }
        }
        public static bool isPersonExist(int ID)
        {
            return ClsDataPerson.IsPersonExistByID(ID);
        }
        public static bool isNationalNoExist(string NationalNo)
        {
            return ClsDataPerson.IsPersonExistByNationalNo(NationalNo);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Addnew:
                    {
                        _Mode = enMode.Update;
return _AddPerson();
                        
                    }
                    
               
                case enMode.Update:
                    return _Update();
                default:
                    return false;
            }

        }
     
    }
}
