using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Json_Parsing;
using System.Threading;
using CefSharp.WinForms;
using CefSharp;

namespace GoogleMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }
        public ChromiumWebBrowser chromeBrowser;
        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://maps.google.com/maps");
            // Add it to the form and fill it to the form window.
            this.panel2.Controls.Add(chromeBrowser);
           // chromeBrowser.Dock = DockStyle.Fill;
        }
        const string API_KEY = "AIzaSyCUq-MMkWIaCDn0Bl6gBlVo40KGgWd1rd0";
        public static string myIP = "";

        private void BtnSearchByAddress_Click(object sender, EventArgs e)
        {
            string url = "";
            if (rbAddress.Checked)
            {
                 url = " http://maps.google.com/maps?q=" + System.Web.HttpUtility.UrlEncode(tbAddress.Text);
                // webBrowser1.Navigate(url);
              
            }
            else if (rbCoordinate.Checked)
            {
                 url = " http://maps.google.com/maps?q=" + System.Web.HttpUtility.UrlEncode(tbLat.Text)+"%2C"+ System.Web.HttpUtility.UrlEncode(tbLong.Text);
              //  webBrowser1.Navigate(url);
            }

            chromeBrowser.Load(url);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            FindMyIP();
        }

        private async void FindMyIP()
        {
            try
            {
            string url = "https://api.ipify.org/?format=json";

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            string result = await response.Content.ReadAsStringAsync();

            IP root = JsonConvert.DeserializeObject<IP>(result);

                myIP =  root.ip +"";
                RbMyIP.Text = "From My IP to Coordinate \r\n" + myIP.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void btn_Click_Click(object sender, EventArgs e)
        {

            if (RbAddressToCoordinate.Checked)
            {
                FindCoordinate();
            }
            else if (RbCoordinateToAddress.Checked)
            {
                FindAddress();
            }
            else if (RbMyIP.Checked)
            {
                string url = "http://freegeoip.net/json/" +myIP;

                // webBrowser1.Navigate(url);
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();

                Geolocation root = JsonConvert.DeserializeObject<Geolocation>(result);

                tbLat.Text = root.latitude +"";
                tbLong.Text= root.longitude+"";

                rbCoordinate.Checked = true;

                FindAddress();
            }  
        }

        private  async void FindAddress()
        {
            string url = "https://maps.googleapis.com/maps/api/geocode/json?latlng=" + System.Web.HttpUtility.UrlEncode(tbLat.Text) + "," + System.Web.HttpUtility.UrlEncode(tbLong.Text) + "&key=" + API_KEY;

            // webBrowser1.Navigate(url);
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            string result = await response.Content.ReadAsStringAsync();

            MyObject root = JsonConvert.DeserializeObject<MyObject>(result);
            if (!root.status.Equals("OK")) return;
            foreach (var item in root.results)
            {

                if (item.formatted_address.Length > 0)
                    tbAddress.Text = item.formatted_address;
                break;
            }
            BtnSearchByAddress.PerformClick();
        }

        private async void FindCoordinate()
        {
            string url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + System.Web.HttpUtility.UrlEncode(tbAddress.Text) + "&key=" + API_KEY;

            // webBrowser1.Navigate(url);
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            string result = await response.Content.ReadAsStringAsync();

            MyObject root = JsonConvert.DeserializeObject<MyObject>(result);
            double Latitude = 0.0;
            double Longitude = 0.0;
            if (!root.status.Equals("OK")) return;

            foreach (var item in root.results)
            {
                Latitude = item.geometry.location.lat;
                Longitude = item.geometry.location.lng;
                if (Latitude > 0 || Longitude > 0)
                    break;
            }
            tbLat.Text = Latitude + "";
            tbLong.Text = Longitude + "";
            BtnSearchByAddress.PerformClick();
        }

        private void rbAddress_CheckedChanged(object sender, EventArgs e)
        {
               if(rbAddress.Checked)
            {
                tbAddress.Enabled = true;
                gbCoordinate.Enabled = false;

            }
            else 
            {
                tbAddress.Enabled = false;
                gbCoordinate.Enabled = true;
            }
          
        }

        private void RbAddressToCoordinate_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAddressToCoordinate.Checked)
            {
                tbAddress.Enabled = true;
                gbCoordinate.Enabled = false;
            }
             else if (RbCoordinateToAddress.Checked)
            {
                tbAddress.Enabled = false;
                gbCoordinate.Enabled = true;
            } else
            {
                tbAddress.Enabled = false;
                gbCoordinate.Enabled = false;
            }

        }
    }
}
