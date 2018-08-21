using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClientWPF.Models;

namespace WebClientWPF.Services.Impl
{
    public class MockArtistService : IArtistService
    {
        public ArtistSearch Search(string query)
        {
            throw new NotImplementedException();
        }

        public ArtistInfo GetInfo(string mbid)
        {
            throw new NotImplementedException();
        }
    }
}
