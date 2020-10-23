namespace ApiSample.Common
{
    // assumption: a large system would have a standard set of response messages
    public class SaveResponse
    {
        public int? Id {get; set;}
        public string ErrorMessage { get; set;}
    }
}
