namespace Simlap.Data
{
    public class Pegawai
    {
        public int Id { get; set; }
        public string Nip { get; set; }
        public string? GolPangkat { get; set; } = "-";
        public string Nama { get; set; }
        public string FotoUrl { get; set; } = "usericon.png";
    }
}
