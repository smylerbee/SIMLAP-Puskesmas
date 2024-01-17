namespace Simlap.Data
{
    public class SpmInfo
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Tahun { get; set; } = DateTime.Now.Year;
        public int Triwulan { get; set; }
        public bool Locked { get; set; } = true;
        public bool Verified { get; set; } = false;
    }
}
