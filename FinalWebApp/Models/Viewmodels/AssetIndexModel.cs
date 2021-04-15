using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWebApp.Models
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetListingModel> Assets { get; set; }
    }
}
