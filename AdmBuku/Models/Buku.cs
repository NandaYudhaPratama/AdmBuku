using System;
using System.Collections.Generic;

namespace AdmBuku.Models
{
    public partial class Buku
    {
        public string Isbn { get; set; }
        public string JudulBuku { get; set; }
        public string Pengarang { get; set; }
        public string Penerbit { get; set; }
        public string TahunTerbit { get; set; }
    }
}
