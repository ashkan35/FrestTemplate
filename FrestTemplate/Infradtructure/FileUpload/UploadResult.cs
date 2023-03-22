namespace FrestTemplate.Infradtructure.FileUpload;

public class UploadResult
{
    public UploadResult()
    {
        Data = new();
    }
    public Data Data { get; set; }
    public bool IsSuccess { get; set; } = false;
    public int StatusCode { get; set; }
    public string Message { get; set; } = "";
    public string RequestId { get; set; } = "";   
}

public class Data
{
    public string FileGuid { get; set; } = "";
    public string FileExtention { get; set; } = "";
    public string FileName { get; set; } = "";
}
