using Countries.Models;
using Countries.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.ViewModels
{
    class MainViewModel
    {
        #region Atributes and Properties
        private NetworkService networkService;
        private ApiService apiService;

        private List<Country> Countries;
        #endregion

        /// <summary>
        /// This is my constructor
        /// </summary>
        public MainViewModel()
        {
            // Instatiation of Services
            networkService = new NetworkService();
            apiService = new ApiService();

            // Loading all countries
            LoadCountries();
        }

        private async Task LoadCountries()
        {
            bool loadFromAPI;

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                //LoadCountriesDB();
                loadFromAPI = false;

            }
            else
            {
                await LoadCountriesAPI();
                loadFromAPI = true;
            }
        }

        private async Task LoadCountriesAPI()
        {
            // Implemente the ProgressBar https://restcountries.com/v3.1/all
            //var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");
            var response = await apiService.GetCountries("https://restcountries.com", "/v3.1/all");

            Countries = (List<Country>)response.Result;

            /* Update data to my local DB*/
            //dataService.DeleteData();
            //dataService.SaveData(Rates);
        }
    }
}
