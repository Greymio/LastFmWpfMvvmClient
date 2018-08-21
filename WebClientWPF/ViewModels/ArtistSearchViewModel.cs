using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToolBox.MVVM;
using WebClientWPF.Models;
using WebClientWPF.Services;
using WebClientWPF.Services.Impl;

namespace WebClientWPF.ViewModels
{
    public class ArtistSearchViewModel : ViewModelBase
    {
        private IArtistService _artistService = new LastFmArtistService();
        private BackgroundWorker _worker;

        private string _queryText = "The Beatles";

        public string QueryText
        {
            get { return _queryText; }
            set
            {
                if (_queryText != value)
                {
                    _queryText = value;
                    RaisePropertyChanged(nameof(QueryText));
                }
            }
        }

        private bool _isLoadButtonEnabled = true;

        public bool IsLoadButtonEnabled
        {
            get { return _isLoadButtonEnabled; }
            set
            {
                if (_isLoadButtonEnabled != value)
                {
                    _isLoadButtonEnabled = value;
                    RaisePropertyChanged(nameof(IsLoadButtonEnabled));
                }

            }
        }

        private string _loadButtonContent = "Search";

        public string LoadButtonContent
        {
            get { return _loadButtonContent; }
            set
            {
                if (_loadButtonContent != value)
                {
                    _loadButtonContent = value;
                    RaisePropertyChanged(nameof(LoadButtonContent));
                }
            }
        }

        private string _statusText = "";

        public string StatusText
        {
            get { return _statusText; }
            set
            {
                if (_statusText != value)
                {
                    _statusText = value;
                    RaisePropertyChanged(nameof(StatusText));
                }
            }
        }

        private List<Artist> _artists;

        public List<Artist> Artists
        {
            get
            {
                if (_artists == null)
                {
                    LoadArtists();
                    return new List<Artist>();
                }
                else
                {
                    return _artists;
                }
            }
            private set
            {
                if (_artists != value)
                {
                    _artists = value;
                    RaisePropertyChanged(nameof(Artists));
                }
            }
        }

        private Artist _selectedArtist;

        public Artist SelectedArtist
        {
            get { return _selectedArtist; }
            set
            {
                if (value != null && _selectedArtist != value)
                {
                    _selectedArtist = value;
                    RaisePropertyChanged(nameof(SelectedArtist));
                }
            }
        }

        private Artist _detailedArtist;

        public Artist DetailedArtist
        {
            get
            {
                return _detailedArtist;
            }
            set
            {
                _detailedArtist = value;
                RaisePropertyChanged(nameof(DetailedArtist));
            }
        }

        public void LoadArtists()
        {
            StatusText = "Loading...";

            _worker = new BackgroundWorker();

            _worker.DoWork += (o, args) => args.Result = _artistService.Search(args.Argument.ToString());

            _worker.RunWorkerCompleted += (o, args) =>
            {
                IsLoadButtonEnabled = true;
                LoadButtonContent = "Search";

                if (args.Cancelled)
                {
                    StatusText = "Operation cancelled !";
                }
                else if (args.Error != null)
                {
                    StatusText = "Error : " + args.Error.Message;
                }
                else
                {
                    StatusText = "Result :";

                    ArtistSearch searchResult = (ArtistSearch)args.Result;
                    Artists = searchResult.Results.ArtistMatches.Artists.Where(a => a.Mbid != "").ToList();
                }
            };

            LoadButtonContent = "Loading...";
            IsLoadButtonEnabled = false;
            
            _worker.RunWorkerAsync(QueryText);
    }

        public void LoadDetailedArtist()
        {
            _worker = new BackgroundWorker();

            _worker.DoWork += (o, args) => args.Result = _artistService.GetInfo(args.Argument.ToString());

            _worker.RunWorkerCompleted += (o, args) =>
            {
                if (args.Error != null)
                {
                    StatusText = "Error : " + args.Error.Message;
                }
                else
                {
                    ArtistInfo searchResult = (ArtistInfo)args.Result;
                    DetailedArtist = searchResult.Artist;
                }
            };

            _worker.RunWorkerAsync(SelectedArtist.Mbid);
        }

        #region Commands

        /*
         * Commands
         */

        private ICommand _loadArtistsCommand;

        public ICommand LoadArtistsCommand
        {
            get { return _loadArtistsCommand = _loadArtistsCommand ?? new RelayCommand(LoadArtists); }
        }

        #endregion

        public ArtistSearchViewModel()
        {
            PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "SelectedArtist")
                {
                    LoadDetailedArtist();
                }
            };
        }
    }
}
