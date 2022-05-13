using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaavouriteApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacts : ContentPage
    {
        private List<ContactList> _contactslist = new List<ContactList>();
        public List<ContactList> Contactslist
        {
            get { return _contactslist; }
            set { _contactslist = value; }
        }
        public Contacts()
        {
            InitializeComponent();

        /*    SearchBar searchBar = new SearchBar
            {
                Placeholder = "Search Contract....",
                PlaceholderColor = Color.LightGray,
                TextColor = Color.LightGray,
                TextTransform = TextTransform.Lowercase,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(SearchBar)),
                FontAttributes = FontAttributes.Italic
            };
        */
            var contactList = new ContactList();
            contactList.ContactTitle = "Asinne Mukundamago";
            contactList.ContactNumber = "0717587239";
            contactList.ContactImageName = "personicon.png";
                
            Contactslist.Add(contactList);

            contactList= new ContactList();
            contactList.ContactTitle = "Khanya Ndibaza";
            contactList.ContactNumber = "0711547078";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList) ;

            contactList = new ContactList();
            contactList.ContactTitle = "Noma Mxhasa";
            contactList.ContactNumber = "071984673";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList);

            contactList = new ContactList();
            contactList.ContactTitle = "Mahle Lawana";
            contactList.ContactNumber = "0717859078";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList);

            contactList = new ContactList();
            contactList.ContactTitle = "Onako Jozi";
            contactList.ContactNumber = "0711547678";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList);

            contactList = new ContactList();
            contactList.ContactTitle = "Somila Jozi";
            contactList.ContactNumber = "0713457678";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList);

            contactList = new ContactList();
            contactList.ContactTitle = "Snelizwi Jozi";
            contactList.ContactNumber = "0711547678";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList);

            contactList = new ContactList();
            contactList.ContactTitle = "Hlubi Jozi";
            contactList.ContactNumber = "0711547678";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList);

            contactList = new ContactList();
            contactList.ContactTitle = "Thando Ndamase";
            contactList.ContactNumber = "0711247678";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList);

            contactList = new ContactList();
            contactList.ContactTitle = "Thandile Ndamase";
            contactList.ContactNumber = "0711907678";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList);

            contactList = new ContactList();
            contactList.ContactTitle = "Ludwe Mthandzima";
            contactList.ContactNumber = "0711807678";
            contactList.ContactImageName = "personicon2.png";
            Contactslist.Add(contactList);







            BindingContext = this;

           
            
        }
    }
}