using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewa_Lapangan.Models
{
    public class JenisLapanganItem
    {
        public int Id { get; set; }
        public string Nama { get; set; }

        public override string ToString() => Nama;
    }
}
