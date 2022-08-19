namespace notes_sync.Services.Ressillence.Interface
{
    public interface IRessistanceService
	{
		string Enc(string text, string keyString);
		string Dec(string cipherText, string keyString);
	}	
}
