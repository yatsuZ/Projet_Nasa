using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Projet_Nasa;

class Program
{
//    private readonly string key = "xegfhwLdY6O1L48WNPnLgF4nkeAZXL1mJDp1cBGi";
//    private readonly string url_Apod = "https://api.nasa.gov/planetary/apod?api_key=xegfhwLdY6O1L48WNPnLgF4nkeAZXL1mJDp1cBGi";
//    private readonly string url_Api = "https://api.nasa.gov/neo/rest/v1/feed?api_key=xegfhwLdY6O1L48WNPnLgF4nkeAZXL1mJDp1cBGi";

    static void Main(string[] args)
    {
        string key = "xegfhwLdY6O1L48WNPnLgF4nkeAZXL1mJDp1cBGi";
        NasaAPI nasaAPI = new NasaAPI(key);//api key est une constante
        //var jsonData = nasaAPI.GetNeoData().Result;
        Data_this_page? info_of_this_page = nasaAPI.getThisPage().Result;
        // if (info_of_this_page == null)
        //     Console.WriteLine("KO");
        // else
        //     info_of_this_page.Affichage_des_infos(0);
        //////
        NasaAPOD pomme = new NasaAPOD(key);
        pomme.affichage();
    }
}
