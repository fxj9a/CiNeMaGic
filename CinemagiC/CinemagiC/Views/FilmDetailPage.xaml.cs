﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemagiC.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemagiC.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FilmDetailPage : ContentPage
	{
        private Movie tappedMovie;

        public FilmDetailPage ()
		{
			InitializeComponent ();
        }

        public FilmDetailPage(Movie tappedMovie)
        {
            InitializeComponent();
            this.tappedMovie = tappedMovie;
            this.Title = tappedMovie.Title;
            descriptionLabel.Text = tappedMovie.Overview;
            titleLabel.Text = tappedMovie.Title;
            image.Source = tappedMovie.PosterPath;
            rating.Text = tappedMovie.VoteAverage;



            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                Console.WriteLine("asdfsdf");
                System.Diagnostics.Debug.WriteLine("dsgfd");
                //var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                //player.Load("dirty-synth.mp3");
                //player.Play();
            };
            image.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}