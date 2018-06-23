﻿using CinemagiC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemagiC.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstPage : ContentPage
	{
		public FirstPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            string json = Services.HttpRequest.HttpRequester();
            Movies movies = JsonConvert.DeserializeObject<Movies>(json);
            //movies.Add(new Movie() { Title = "Film1", imagepath = "https://image.tmdb.org/t/p/w200/ePyN2nX9t8SOl70eRW47Q29zUFO.jpg" });
            
            foreach (var item in movies.results)
            {
                item.PosterPath = "https://image.tmdb.org/t/p/w200" + item.PosterPath;
            };
            filmListView.ItemsSource = movies.results;
        }
    }
}