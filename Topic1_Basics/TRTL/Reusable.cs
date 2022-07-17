namespace TRTL
{
    public static class Reusable
    {
        public static int? IntTryParseOutNull(string? txt) => int.TryParse(txt, out int output) ? (int?)output : null;

        public static double? DoubleTryParseOutNull(string? txt) => double.TryParse(txt, out double output) ? (double?)output : null;

    }
}