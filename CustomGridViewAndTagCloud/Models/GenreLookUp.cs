using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomGridViewAndTagCloud.Models
{
    /// <summary>
    /// List of Genres
    /// </summary>
    public partial class GenreLookUp
    {
        /// <summary>
        /// Unique ID for Genre
        /// </summary>
        public int GenreLookUpId { get; set; } // GenreLookUpId (Primary key)

        /// <summary>
        /// Genre Name
        /// </summary>
        public string GenreName { get; set; } // GenreName

    }
}
