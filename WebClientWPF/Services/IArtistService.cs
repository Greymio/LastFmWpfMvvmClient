using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClientWPF.Models;

namespace WebClientWPF.Services
{
    public interface IArtistService
    {
        ArtistSearch Search(string query);

        ArtistInfo GetInfo(string mbid);
    }
}
