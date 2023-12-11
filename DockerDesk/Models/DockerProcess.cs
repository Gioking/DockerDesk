namespace DockerDesk.Models
{
    public class DockerProcess
    {
        public int Id { get; set; }
        public string UID { get; set; }
        public int PID { get; set; }
        public int PPID { get; set; }
        public int C { get; set; }
        public string STIME { get; set; }
        public string TTY { get; set; }
        public string TIME { get; set; }
        public string CMD { get; set; }
    }
}
