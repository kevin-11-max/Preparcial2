﻿namespace AppParcial2.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public CountryViewModel Countries { get; set; }

        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.Countries = new CountryViewModel();
        }

        #endregion
    }
}
