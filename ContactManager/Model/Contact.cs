using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManager.Model
{
    public class Contact : Notifier
    {
        [Serializable]
        private Address _address = new Address();
        private string _cellPhone;
        private string _firstName;
        private string _homePhone;
        private Guid _id = Guid.Empty;
        private string _imagePath;
        private string _jobTitle;
        private string _lastName;
        private string _officePhone;
        private string _organisation;
        private string _primaryEmail;
        private string _secondaryEmail;

        public Guid Id
        {
            get { return _id; }
            set { _id = value;
                OnPropertyChanged("Id");
            }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string Organisation
        {
            get { return _organisation; }
            set
            {
                _organisation = value;
                OnPropertyChanged("Organisation");
            }
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set
            {
                _jobTitle = value;
                OnPropertyChanged("JobTitle");
            }
        }

        public string OfficePhone
        {
            get { return _officePhone; }
            set
            {
                _officePhone = value;
                OnPropertyChanged("OfficePhone");
            }
        }

        public string CellPhone
        {
            get { return _cellPhone; }
            set
            {
                _cellPhone = value;
                OnPropertyChanged("CellPhone");
            }
        }
        public string PrimaryEmail
        {
            get { return _primaryEmail; }
            set
            {
                _primaryEmail = value;
                OnPropertyChanged("PrimaryEmail");
            }
        }

        public string SecondaryEmail
        {
            get { return _secondaryEmail; }
            set
            {
                _secondaryEmail = value;
                OnPropertyChanged("SecondaryEmail");
            }
        }

        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }

        public string LookUpName
        {
            get {  return string.Format }
        }


    }
}
