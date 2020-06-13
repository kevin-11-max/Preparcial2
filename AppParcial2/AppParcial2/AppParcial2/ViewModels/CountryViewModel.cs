using AppParcial2.Services;
using AppParcial2.Models;

namespace AppParcial2.ViewModels
{
    public class CountryViewModel: BaseViewModel
    {
        #region Services

        private ApiService apiService;

        #endregion

        #region Attributes
        private string name;
        private string capital;
        private string alpha2code;

        #endregion

        #region Properties
        public string Name
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }
        public string Capital
        {
            get { return this.capital; }
            set { SetValue(ref this.capital, value); }
        }
        public string Alpha2Code
        {
            get { return this.alpha2code; }
            set { SetValue(ref this.alpha2code, value); }
        }

        #endregion

        #region Constructor

        public CountryViewModel()
        {
           
            this.apiService = new ApiService();
       
            this.LoadCountry();

        }
        #endregion

        #region Methods
        private async void LoadCountry()
        {
            var country = await this.apiService.Get<Country>(
                "https://restcountries.eu/rest/v2/",
              "name/",
            "bolivia"
                );
            this.Name = country[0].Name;
            this.Capital = country[0].Capital;
            this.Alpha2Code = country[0].Alpha2Code;
        }


        #endregion
    }
}
