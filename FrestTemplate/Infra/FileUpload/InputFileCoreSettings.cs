namespace FrestTemplate.Infra.FileUpload;


public record InputFileCoreSettings
{

	public long? MaxFileSize { get; set; }

	public int? MaxParallelUploads { get; set; }
}
