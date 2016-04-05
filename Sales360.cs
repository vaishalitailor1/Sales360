using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UITest2
{
    [TestFixture]
    public class Tests
    {
        private string path = ""; //Will provide the apk path here.
        private AndroidApp app;

        [SetUp]
        public void LaunchAppTest()
        {

            app = ConfigureApp.Android.ApkFile(path).StartApp();   //To launch App.

        }
        [Test]
        public void TestLogin()

        {
            //app.Repl(); //REPL Read Evaluate Print loop.It will help me to find application structure and the UI elements.Like typing Tree i can get the detail of all the Ul element of the application
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            app.Tap(x => x.Id("").Css("#cred_Username_Inputtext"), "GardenAdmin");
            app.Screenshot("Tapped on Username field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"));
            app.Screenshot("Tapped on Password field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"), "GardenAdmin"));
            app.Tap(x => x.Text("Login"));
            app.Screenshot("Tapped on Login button");
            app.WaitForElement(SyncScreenQuery, "Time out");  //Wait till the flash screen appears.
        }

        public void settingscreen()
        {
            app.Tap(x = x.Text("Old Password"));
            app.EnterText("");
            app.Tap(x = x.Text("New Password"));
            app.EnterText("");
            app.Tap(x => x.Text("Confirm Password"));
            app.EnterText("");
            app.Tap(x => x.Text("Save"));
            Func<AppQuery, AppQuery> HomeScreenQuery = x => x.id(""); //Provide the element id from home screen.
            app.WaitForElement(HomeScreenQuery);
        }

        public void menuscreentest()
        {
            app.Tap(x => x.Id("")); //Enter the element Id of the menu screen button.
            Func<AppQuery, AppQuery> MenuScreenItem = x => x.Id(""); //Enter the element id for home,Setting or about icons.
            app.WaitForElement(MenuScreenItem);
            app.Tap(x => x.Id("About"));
            Func<AppQuery, AppQuery> AboutAutoVastQuery = x => x.Id("");
            app.WaitForElement(AboutAutoVastQuery);
            app.Tap(x => x.Id(""));//Enter the Id for the back button on the about screen.
            app.WaitForElement(MenuScreenItem);
            app.Tap(x => x.Text("Settings"));


        }
        public void intellisynctest()
        {
            //app.Repl(); //REPL Read Evaluate Print loop.It will help me to find application structure and the UI elements.Like typing Tree i can get the detail of all the Ul element of the application
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            app.Tap(x => x.Id("").Css("#cred_Username_Inputtext"), "GardenAdmin");
            app.Screenshot("Tapped on Username field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"));
            app.Screenshot("Tapped on Password field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"), "GardenAdmin"));
            app.Tap(x => x.Text("Login"));
            app.Screenshot("Tapped on Login button");
            app.WaitForElement(SyncScreenQuery, "Time out");  //Wait till the flash screen appears.
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            Func<AppQuery, AppQuery> HomeScreenQuery = x => x.id(""); //Provide the element id from home screen.
            app.SwipeLeft(SyncScreenQuery); //To swipe the intellisync button to left.
            app.SwipeRight(SyncScreenQuery);//To swipe the intellisync button to right.
            app.tap(x => x.Text("PROCEED TO HOME"));
            WaitForElement(HomeScreenQuery);

        }

        public void calenderprovidertest()
        {
            //app.Repl(); //REPL Read Evaluate Print loop.It will help me to find application structure and the UI elements.Like typing Tree i can get the detail of all the Ul element of the application
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            app.Tap(x => x.Id("").Css("#cred_Username_Inputtext"), "GardenAdmin");
            app.Screenshot("Tapped on Username field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"));
            app.Screenshot("Tapped on Password field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"), "GardenAdmin"));
            app.Tap(x => x.Text("Login"));
            app.Screenshot("Tapped on Login button");
            app.WaitForElement(SyncScreenQuery, "Time out");  //Wait till the flash screen appears.
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            Func<AppQuery, AppQuery> CalenderProviderScreenQuery = x => x.id(""); //Provide the element id for Contact provider screen.
            app.SwipeLeft(SyncScreenQuery); //To swipe the intellisync button to left.
            app.SwipeRight(SyncScreenQuery);//To swipe the intellisync button to right.
            WaitForElement(CalenderProviderScreenQuery);
            app.TouchAndHold(CalenderPRoviderScreenQuery); //Will select the radio button from calender provider flash.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> ContactProviderFlashQuery = x => x.Id("");//Enter the ID for any element on the Contact provider popup.
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Tap(x => x.Text("Cancel"));
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Flash(ContactProviderFlashQuery);
            app.TouchAndHold(ContactProviderFlashQuery); //Will select one option from contact provider selection.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            app.Tap(x => x.Text("PROCEED TO HOME"));
            Func<AppQuery, AppQuery> HomeScreenQuery = x => x.Id(""); //Enter the ID for any element on the home screen.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Text("Cancel"));  //Will save one option out of the so many option.
            app.WaitForElement(HomeScreenQuery, "Home");



        }

        public void Notestest()
        {
            //app.Repl(); //REPL Read Evaluate Print loop.It will help me to find application structure and the UI elements.Like typing Tree i can get the detail of all the Ul element of the application
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            app.Tap(x => x.Id("").Css("#cred_Username_Inputtext"), "GardenAdmin");
            app.Screenshot("Tapped on Username field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"));
            app.Screenshot("Tapped on Password field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"), "GardenAdmin"));
            app.Tap(x => x.Text("Login"));
            app.Screenshot("Tapped on Login button");
            app.WaitForElement(SyncScreenQuery, "Time out");  //Wait till the flash screen appears.
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            Func<AppQuery, AppQuery> CalenderProviderScreenQuery = x => x.id(""); //Provide the element id for Contact provider screen.
            app.SwipeLeft(SyncScreenQuery); //To swipe the intellisync button to left.
            app.SwipeRight(SyncScreenQuery);//To swipe the intellisync button to right.
            app.Tap(x => x.Text("PROCEED TO HOME"));
            WaitForElement(CalenderProviderScreenQuery);
            app.TouchAndHold(CalenderPRoviderScreenQuery); //Will select the radio button from calender provider flash.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> ContactProviderFlashQuery = x => x.Id("");//Enter the ID for any element on the Contact provider popup.
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Tap(x => x.Text("Cancel"));
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Flash(ContactProviderFlashQuery);
            app.TouchAndHold(ContactProviderFlashQuery); //Will select one option from contact provider selection.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> HomeScreenQuery = x => x.Id(""); //Enter the ID for any element on the home screen.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Text("Cancel"));  //Will save one option out of the so many option.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Text("Notes"));
            Func<AppQuery, AppQuery> NotesScreenQuery = x => x.Id(""); //Enter the ID for any element on the add nptes popup.
            app.WaitForElement(NotesScreenQuery, "Add Note");
            app.Screenshot("Add Notes Popup");
            app.Tap(x => x.Text("Notes");//Set the focus on the edit field of the notes.
            app.EnterText("Meeting is for testing purpose");
            app.Tap(x => x.Text("Submit");
            Func<AppQuery, AppQuery> AppointmentsNotesTabQuery = x => x.Id("");
            app.WaitForElement(AppointmentsNotesTabQuery, "Home");
            app.Tap(x => x.Text("Cancel");
            app.WaitForElement(AppointmentsNotesTabQuery, "Home");


        }

        public void Appointment()
        {
            //app.Repl(); //REPL Read Evaluate Print loop.It will help me to find application structure and the UI elements.Like typing Tree i can get the detail of all the Ul element of the application
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            app.Tap(x => x.Id("").Css("#cred_Username_Inputtext"), "GardenAdmin");
            app.Screenshot("Tapped on Username field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"));
            app.Screenshot("Tapped on Password field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"), "GardenAdmin"));
            app.Tap(x => x.Text("Login"));
            app.Screenshot("Tapped on Login button");
            app.WaitForElement(SyncScreenQuery, "Time out");  //Wait till the flash screen appears.
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            Func<AppQuery, AppQuery> CalenderProviderScreenQuery = x => x.id(""); //Provide the element id for Contact provider screen.
            app.SwipeLeft(SyncScreenQuery); //To swipe the intellisync button to left.
            app.SwipeRight(SyncScreenQuery);//To swipe the intellisync button to right.
            app.Tap(x => x.Text("PROCEED TO HOME"));
            WaitForElement(CalenderProviderScreenQuery);
            app.TouchAndHold(CalenderPRoviderScreenQuery); //Will select the radio button from calender provider flash.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> ContactProviderFlashQuery = x => x.Id("");//Enter the ID for any element on the Contact provider popup.
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Tap(x => x.Text("Cancel"));
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Flash(ContactProviderFlashQuery);
            app.TouchAndHold(ContactProviderFlashQuery); //Will select one option from contact provider selection.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> HomeScreenQuery = x => x.Id(""); //Enter the ID for any element on the home screen.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Text("Cancel"));  //Will save one option out of the so many option.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Text("PDF"));
            Func<AppQuery, AppQuery> NewAppointmentFlashQuery = x => x.id(""); //Will add the id of any object which is there on the screens
            Func<AppQuery, AppQuery> BackToAppointmentScreenQuery = x => x.Id("");//Enter the ID for any element on the appointment screen.
                                                                                  //Test Cases for creating a new appointment.
            app.Tap(x => x.Id("")); //DOnt know the id of that floating button.
            app.WaitForElement(NewAppointmentFlashQuery, "New Appointment Window");
            app.Flash(x => x.Id("")); //Will flash the add new appointment on screen.
            app.Tap(x => x.Text("Contact")); //Will Tap on the contact field
            app.EnterText("vaishali.tailor@walkingtree.in"); //Will enter the text in contact field.
            app.Tap(x => x.Text("Description")); //Will tap on description field..
            app.EnterText("Lorem Ipsum is si"); //Will enter the text in Description field.
            app.Tap("Submit");//It will click on the submit button.
            app.WaitForElement(BackToAppointmentScreenQuery, "Appointmentscreen"); //Wait until the appointment screens appears.
            app.screenshot("Followup appointment");
            app.Tap(x => x.Id("")); //Enter the ID for delete button on the screen.

        }

        public void PdfTest()
        {
            //app.Repl(); //REPL Read Evaluate Print loop.It will help me to find application structure and the UI elements.Like typing Tree i can get the detail of all the Ul element of the application
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            app.Tap(x => x.Id("").Css("#cred_Username_Inputtext"), "GardenAdmin");
            app.Screenshot("Tapped on Username field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"));
            app.Screenshot("Tapped on Password field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"), "GardenAdmin"));
            app.Tap(x => x.Text("Login"));
            app.Screenshot("Tapped on Login button");
            app.WaitForElement(SyncScreenQuery, "Time out");  //Wait till the flash screen appears.
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            Func<AppQuery, AppQuery> CalenderProviderScreenQuery = x => x.id(""); //Provide the element id for Contact provider screen.
            app.SwipeLeft(SyncScreenQuery); //To swipe the intellisync button to left.
            app.SwipeRight(SyncScreenQuery);//To swipe the intellisync button to right.
            app.Tap(x => x.Text("PROCEED TO HOME"));
            WaitForElement(CalenderProviderScreenQuery);
            app.TouchAndHold(CalenderPRoviderScreenQuery); //Will select the radio button from calender provider flash.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> ContactProviderFlashQuery = x => x.Id("");//Enter the ID for any element on the Contact provider popup.
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Tap(x => x.Text("Cancel"));
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Flash(ContactProviderFlashQuery);
            app.TouchAndHold(ContactProviderFlashQuery); //Will select one option from contact provider selection.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> HomeScreenQuery = x => x.Id(""); //Enter the ID for any element on the home screen.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Text("Cancel"));  //Will save one option out of the so many option.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Text("PDF"));
            Func<AppQuery, AppQuery> AttachmentPageViewQuery = x => x.Id("");//Enter the ID for any element on the Detail page of the attachement.
            app.WaitForElement(AttachmentPageViewQuery, "PDF Attachemnt");
            app.Tap(x => x.Id("")); // Tap on the ">" icon to view the detail of attachment.
            Func<AppQuery, AppQuery> AttachmentDetailPageQuery = x => x.Id(""); //Enter the element Id which is available on the detail attachment view.
            app.Tap(AttachmentDetailPageQuery, "Attachment");
            app.Tap(x => x.Id("")); //Enter the element Id of the back button.
            app.WaitForElement(AttachmentPageViewQuery);
            app.Tap(x => x.Id("")); //Enter the element Id of the back button.
            app.WaitForElement(HomeScreenQuery);

        }

        public void GooglemapTest()
        {
            //app.Repl(); //REPL Read Evaluate Print loop.It will help me to find application structure and the UI elements.Like typing Tree i can get the detail of all the Ul element of the application
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            app.Tap(x => x.Id("").Css("#cred_Username_Inputtext"), "GardenAdmin");
            app.Screenshot("Tapped on Username field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"));
            app.Screenshot("Tapped on Password field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"), "GardenAdmin"));
            app.Tap(x => x.Text("Login"));
            app.Screenshot("Tapped on Login button");
            app.WaitForElement(SyncScreenQuery, "Time out");  //Wait till the flash screen appears.
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            Func<AppQuery, AppQuery> CalenderProviderScreenQuery = x => x.id(""); //Provide the element id for Contact provider screen.
            app.SwipeLeft(SyncScreenQuery); //To swipe the intellisync button to left.
            app.SwipeRight(SyncScreenQuery);//To swipe the intellisync button to right.
            app.Tap(x => x.Text("PROCEED TO HOME"));
            WaitForElement(CalenderProviderScreenQuery);
            app.TouchAndHold(CalenderPRoviderScreenQuery); //Will select the radio button from calender provider flash.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> ContactProviderFlashQuery = x => x.Id("");//Enter the ID for any element on the Contact provider popup.
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Tap(x => x.Text("Cancel"));
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Flash(ContactProviderFlashQuery);
            app.TouchAndHold(ContactProviderFlashQuery); //Will select one option from contact provider selection.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> HomeScreenQuery = x => x.Id(""); //Enter the ID for any element on the home screen.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Text("Cancel"));  //Will save one option out of the so many option.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Id("")); //Enter the Id of google go icon or '<' icon id.
            Func<AppQuery, AppQuery> ViewGoogleMapQuery = x => x.Id("");//Enter the Id of the element on the google map.
            Func<AppQuery, AppQery> GoogleCallPageQuery = x => x.Id(""); //Object element Id for the page which display when user clicks on call.
            Func<AppQuery, AppQuery> GoogleMapDirectionsQuery = x => x.Id(""); //Enter the object id which is there on navigation page.
            app.WaitForElement(ViewGoogleMapQuery);
            app.Tap(x => x.Text("Call"));
            app.WaitForElement(GoogleCallPageQuery);
            app.Tap(x => x.Text("Directions"));
            app.WaitForElement(GoogleMapDirectionsQuery);


        }

        public void salesdetailtest()
        {
            //app.Repl(); //REPL Read Evaluate Print loop.It will help me to find application structure and the UI elements.Like typing Tree i can get the detail of all the Ul element of the application
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            app.Tap(x => x.Id("").Css("#cred_Username_Inputtext"), "GardenAdmin");
            app.Screenshot("Tapped on Username field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"));
            app.Screenshot("Tapped on Password field");
            app.Tap(x => x.Id("").Css("#cred_Password_Inputtext"), "GardenAdmin"));
            app.Tap(x => x.Text("Login"));
            app.Screenshot("Tapped on Login button");
            app.WaitForElement(SyncScreenQuery, "Time out");  //Wait till the flash screen appears.
            Func<AppQuery, AppQuery> SyncScreenQuery = x => x.Id("");//Enter the ID for any element on the intellisync screen.
            Func<AppQuery, AppQuery> CalenderProviderScreenQuery = x => x.id(""); //Provide the element id for Contact provider screen.
            app.SwipeLeft(SyncScreenQuery); //To swipe the intellisync button to left.
            app.SwipeRight(SyncScreenQuery);//To swipe the intellisync button to right.
            app.Tap(x => x.Text("PROCEED TO HOME"));
            WaitForElement(CalenderProviderScreenQuery);
            app.TouchAndHold(CalenderPRoviderScreenQuery); //Will select the radio button from calender provider flash.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> ContactProviderFlashQuery = x => x.Id("");//Enter the ID for any element on the Contact provider popup.
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Tap(x => x.Text("Cancel"));
            WaitForElement(ContactProviderFlashQuery, "Select any one");
            app.Flash(ContactProviderFlashQuery);
            app.TouchAndHold(ContactProviderFlashQuery); //Will select one option from contact provider selection.
            app.Tap(x => x.Text("Save"));  //Will save one option out of the so many option.
            Func<AppQuery, AppQuery> HomeScreenQuery = x => x.Id(""); //Enter the ID for any element on the home screen.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Text("Cancel"));  //Will save one option out of the so many option.
            app.WaitForElement(HomeScreenQuery, "Home");
            app.Tap(x => x.Id("")); //Enter the object element id for the sales detail row.
            Func<AppQuery, AppQuery> ProductListViewQuery = x => x.Id(""); //Enter the for any object on the list view of the product
            app.WaitForElement(ProductListViewQuery, "Products for the store");
            app.Tap(x => x.Id(""));// enter the ID of "<" icon for product category view.
            Func<AppQuery, AppQuery> ProductCategoryViewQuery = x => x.Id(""); //Element Id for the grid view on/off button.
            app.SwipeLeft(ProductCategoryViewQuery); //To swipe the intellisync button to left.
            app.WaitForElement(ProductCategoryViewQuery, "List View");
            Func<AppQuery, AppQuery> ProductCategoryGridViewQuery = x => x.Id("");
            app.SwipeRight(ProductCategoryViewQuery);//To swipe the intellisync button to right.
            app.WaitForElement(ProductCategoryGridViewQuery, "Grid view");
        }
        