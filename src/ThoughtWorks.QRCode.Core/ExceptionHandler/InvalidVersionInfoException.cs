using System;

namespace ThoughtWorks.QRCode.ExceptionHandler
{
	[Serializable]
	public class InvalidVersionInfoException : VersionInformationException
	{
		internal string message = null;

		public override string Message => message;

		public InvalidVersionInfoException(string message)
		{
			this.message = message;
		}
	}
}
