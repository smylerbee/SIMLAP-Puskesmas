namespace Simlap.Data
{
    public class LapSpm
    {
        public int Id { get; set; }
        public int SpmInfoId { get; set; }
        public DateTime Mmodified { get; set; } = DateTime.Now;
        public int SpmId { get; set; }
        public int SpmReq { get; set; } = 0;
        public int SpmVal { get; set; } = 0;
    }
}
