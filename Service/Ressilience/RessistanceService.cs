using System.Collections.Generic;
using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;
using System.Text;
using System.Runtime.Intrinsics.X86;
using System.IO;
using System.Security.Cryptography;
using System;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Ressillence
{
	public class RessistanceService
	{
		IAppConfig conf;
		public RessistanceService(IAppConfig conf)
		{
			this.conf = conf;
		}
		
		public string Enc(string text, string keyString)
		{
		    return null;
		}

		public string Dec(string cipherText, string keyString)
		{
		    return null;
		}

	}
}
