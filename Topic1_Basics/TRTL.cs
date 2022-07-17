using System;

public class TRTL
{
	public TRTL()
	{
		public static int? IntTryParseNullable(string? txt) => int.TryParse(txt, out int output) ? (int?)output : null;

		public static double? DoubleTryParseNullable(string? txt) => double.TryParse(txt, out double output) ? (double?)output : null;

	}
}
