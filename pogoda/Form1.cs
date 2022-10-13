using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;


namespace pogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

               
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //zmienna w której przechowywany jest API do serwisu pogodowego, jest to API płatny więc nie jestem w stanie udostępnić go więc w dokumentacji jest zakryty
        

        public object TXTSearch { get; private set; }

        public void BTNSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        public void getWeather()
        {

            /// <summary>
            /// ta metoda pobiera dane pogodowe z serwisu pogodowego z pliku JSON i przypisuje je do odpowiednich zmiennych
            /// </summary>
            /// <param name="url">https://api.openweathermap.org/data/2.5/weather?q=Katowice&appid=***********************************</param>
            using (WebClient web = new WebClient())
            {
                string APIkey = "*********************************";                                                                   /// tu wstawiamy klucz API z open Weather
                string url = String.Format("https://api.openweathermap.org/data/2.5/weather?q=" + TBCity.Text + "&appid=" + APIkey); //wstawiamy nazwę miasta(0) i klucz API (1)

                string json = web.DownloadString(url);                                                                                  /// <summary>
                                                                                                                                       ///pobieramy dane z serwisu pogodowego w formacie JSON
                WetherInfo.root Info = JsonConvert.DeserializeObject<WetherInfo.root>(json);                                         ///przypisujemy pobrane dane do zmiennej root
                labConditions.Text = Info.weather[0].main;                                                                           ///przypisujemy pobrane dane do zmiennej description
                labDetails.Text = Info.weather[0].description;
                labPressure.Text = Info.main.pressure.ToString() + " hPa";                                                               ///przypisujemy pobrane dane do zmiennej pressure
                labSunset.Text = convertDateTime(Info.sys.sunset).ToLongTimeString();                                                                         ///przypisujemy pobrane dane do zmiennej sunset
                labSunrise.Text = convertDateTime(Info.sys.sunrise).ToLongTimeString();                                                                       ///przypisujemy pobrane dane do zmiennej sunrise
                labWindSpeed.Text = Info.wind.speed.ToString() + " m/s";                                                               ///przypisujemy pobrane dane do zmiennej speed
                labTemp.Text = Info.main.temp.ToString() + " °K";                                                                     ///przypisujemy pobrane dane do zmiennej temp

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
            }
            
            ///<summary>
            ///ta metoda conwertuje liczby w milisekundach podane w zmiennej sunrice i sunset na datę UTC
            ///</summary>
            DateTime convertDateTime(long milisec)
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddMilliseconds(milisec).ToLocalTime();

                return day;
            }
            
            
        }





        



    }
}
