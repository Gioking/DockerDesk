namespace DockerDesk.Models
{
    public class DockerImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Tag { get; set; }
        public string ImageId { get; set; }
        public string Created { get; set; }
        public string Size { get; set; }
    }

}
