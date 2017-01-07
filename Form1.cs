using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Google.GData.Spreadsheets;
//using Google.GData;
//using Google.GData.Client;
//using Google.GData.Extensions;
using System.Net;
/**using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
**/
using System.IO;
using System.Threading;
/**
using Google.Apis.Vision.v1;
using Google.Apis.Oauth2.v2;
**/
using System.Data.OleDb;
using Microsoft.Win32;

using MetroFramework.Forms;
using MetroFramework.Components;

// Проверить совместимость с Windows 7


namespace ConstructSoftware_Final
{
    public partial class Form1 : MetroForm
    {
        //Stack<int> numbers;
        //List<DllManager> SharedDll;
        //int count = 1;
        //string DirectoryPath;
        //строка соединения
        //string strAccessConn;// = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logs.mdb";
        //OleDbConnection myAccessConn;
        //Табы
        //List<ManagerWindow> MW;
        //int MaxManagerTabsCount = 0;
        //bool canClose = true;

        // OAuth2Parameters holds all the parameters related to OAuth 2.0.
        //OAuth2Parameters parameters = new OAuth2Parameters();

        string CLIENT_ID;// = "229901477056-8hcinql2rearjj5hn7d0hep8r2r7qc24.apps.googleusercontent.com";

        string CLIENT_SECRET;// = "LZaDb-cvJg2HnwmQjDHkFAMg";

        //string SCOPE = "https://spreadsheets.google.com/feeds https://docs.google.com/feeds";

        //string REDIRECT_URI = "urn:ietf:wg:oauth:2.0:oob";

        string _Gmail;
        string _Gpass;

        //SpreadsheetsService service;

        string ProgramStart = DateTime.Now.ToString("MM'/'dd'/'yyyy HH:mm:ss");

        public Form1()
        {
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Green;
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        public Form1(string[] Params)
        {
           // SetPathFromRegystry();
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Green;
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Light;

            this.Text += string.Format("({0}. {1} Days left. User: {2}.)", Params[0], Params[2], Params[1]);
            SetProgramInterfaceByLicence(Params[0], Params);
        }

        void SetProgramInterfaceByLicence(string LicenceType, string[] Params)
        {
            switch (LicenceType)
            {
                case "Trial":
                    //MaxManagerTabsCount = 1;
                    break;
                case "Community":
                    //MaxManagerTabsCount = 3;
                    //KeyPicture.Image = Properties.Resources.Key as Bitmap;
                    //KeyToolTip.SetToolTip(this.KeyPicture, String.Format("Имя: {0}\nДействителен до: {1}\nВерсия: {2}\nGoogle: {3}", Params[1], Params[7], Params[0], Params[3]));
                    CLIENT_ID = Params[5];
                    CLIENT_SECRET = Params[6];
                    _Gmail = Params[3];
                    _Gpass = Params[4];
                    break;
                case "Professional":
                    //MaxManagerTabsCount = 7;
                    //KeyPicture.Image = Properties.Resources.Key as Bitmap;
                    //KeyToolTip.SetToolTip(this.KeyPicture, String.Format("Имя: {0}\nДействителен до: {1}\nВерсия: {2}\nGoogle: {3}\n", Params[1], Params[7], Params[0], Params[3]));
                    CLIENT_ID = Params[5];
                    CLIENT_SECRET = Params[6];
                    _Gmail = Params[3];
                    _Gpass = Params[4];
                    break;
                default:
                    break;
            }
        }
    }
}
