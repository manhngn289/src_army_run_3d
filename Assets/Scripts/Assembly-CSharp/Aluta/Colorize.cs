using UnityEngine;

namespace Aluta
{
	public class Colorize
	{
		public static Colorize Red;

		public static Colorize Yellow;

		public static Colorize Green;

		public static Colorize Blue;

		public static Colorize Cyan;

		public static Colorize Magenta;

		public static Colorize Orange;

		public static Colorize Olive;

		public static Colorize Purple;

		public static Colorize DarkRed;

		public static Colorize DarkGreen;

		public static Colorize DarkOrange;

		public static Colorize Gold;

		private readonly string _prefix;

		private const string Suffix = "</color>";

		public Colorize(Color color)
		{
		}

		private Colorize(string hexColor)
		{
		}

		public static string operator %(string text, Colorize color)
		{
			return null;
		}
	}
}
