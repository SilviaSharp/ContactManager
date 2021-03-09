using System;

namespace ContactManager.Model
{
    [Serializable]
    public class Contact : Notifier
    {

        private Guid _id = Guid.Empty;

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private string _imagePath;

        public string ImagePath
        {
            get => _imagePath;
            set
            {
                _imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private string _organisation;
        public string Organisation
        {
            get => _organisation;
            set
            {
                _organisation = value;
                OnPropertyChanged("Organisation");
            }
        }

        private string _jobTitle;
        public string JobTitle
        {
            get => _jobTitle;
            set
            {
                _jobTitle = value;
                OnPropertyChanged("JobTitle");
            }
        }

        private string _homePhone;

        public string HomePhone
        {
            get => _homePhone;
            set
            {
                if (value != _homePhone)
                {
                    _homePhone = value;
                    OnPropertyChanged("HomePhone");
                }
            }
        }

        private string _officePhone;
        public string OfficePhone
        {
            get => _officePhone;
            set
            {
                _officePhone = value;
                OnPropertyChanged("OfficePhone");
            }
        }

        private string _cellPhone;
        public string CellPhone
        {
            get => _cellPhone;
            set
            {
                _cellPhone = value;
                OnPropertyChanged("CellPhone");
            }
        }

        private string _primaryEmail;
        public string PrimaryEmail
        {
            get => _primaryEmail;
            set
            {
                _primaryEmail = value;
                OnPropertyChanged("PrimaryEmail");
            }
        }

        private string _secondaryEmail;
        public string SecondaryEmail
        {
            get => _secondaryEmail;
            set
            {
                _secondaryEmail = value;
                OnPropertyChanged("SecondaryEmail");
            }
        }

        private Address _address = new Address();
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }

        public string LookUpName => $"{_lastName}, {_firstName}";

        #region Overrides of Object

        public override string ToString() => LookUpName;
#pragma warning disable 659
        public override bool Equals(object obj) => obj is Contact other && other.Id == Id;
#pragma warning restore 659

        #endregion
    }
}