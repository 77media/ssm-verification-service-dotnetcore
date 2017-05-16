public class VerifyRequest
{
    // This could be anything 
    // but if it has personal information 
    // it should only be sent in a POST not in the url of a GET
    public string ConfirmationNumber { get; set; }
    
    public string ScanCode { get; set; }

    public string LastName { get; set; }
}