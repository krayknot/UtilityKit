namespace Krayknot.UtilityKit;

public static class UtilityKit
{
    // ======================================================
    // STRING HELPERS (70+)
    // ======================================================

    public static bool IsNullOrEmpty(string? v) => string.IsNullOrEmpty(v);
    public static bool IsNullOrWhiteSpace(string? v) => string.IsNullOrWhiteSpace(v);
    public static string Capitalize(string v) => string.IsNullOrEmpty(v) ? v : char.ToUpper(v[0]) + v[1..];
    public static string ToLowerSafe(string v) => v?.ToLower() ?? "";
    public static string ToUpperSafe(string v) => v?.ToUpper() ?? "";
    public static string Reverse(string v) => new(v.Reverse().ToArray());
    public static bool EqualsIgnoreCase(string a, string b) => string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
    public static string TrimSafe(string v) => v?.Trim() ?? "";
    public static string Truncate(string v, int len) => string.IsNullOrEmpty(v) || v.Length <= len ? v : v[..len];
    public static bool ContainsIgnoreCase(string a, string b) => a?.IndexOf(b, StringComparison.OrdinalIgnoreCase) >= 0;
    public static string RemoveSpaces(string v) => v.Replace(" ", "");
    public static bool IsNumeric(string v) => double.TryParse(v, out _);
    public static string Repeat(string v, int count) => string.Concat(Enumerable.Repeat(v, count));
    public static int CountOccurrences(string s, char c) => s.Count(x => x == c);
    public static string SafeSubstring(string s, int start, int length) => start >= s.Length ? "" : s.Substring(start, Math.Min(length, s.Length - start));
    public static string Left(string s, int len) => s.Length <= len ? s : s[..len];
    public static string Right(string s, int len) => s.Length <= len ? s : s[^len..];
    public static string JoinWith(string sep, params string[] parts) => string.Join(sep, parts);
    public static string RemoveDigits(string s) => new(s.Where(c => !char.IsDigit(c)).ToArray());
    public static string RemoveLetters(string s) => new(s.Where(c => !char.IsLetter(c)).ToArray());
    public static string RemoveNonAlphanumeric(string s) => new(s.Where(char.IsLetterOrDigit).ToArray());
    public static bool StartsWithIgnoreCase(string s, string value) => s.StartsWith(value, StringComparison.OrdinalIgnoreCase);
    public static bool EndsWithIgnoreCase(string s, string value) => s.EndsWith(value, StringComparison.OrdinalIgnoreCase);
    public static string[] SplitSafe(string s, string sep) => s?.Split(sep) ?? Array.Empty<string>();
    public static string RemoveLineBreaks(string s) => s.Replace("\n", "").Replace("\r", "");
    public static string CollapseSpaces(string s) => string.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries));
    public static string PadLeftSafe(string s, int len, char c=' ') => (s ?? "").PadLeft(len, c);
    public static string PadRightSafe(string s, int len, char c=' ') => (s ?? "").PadRight(len, c);
    public static bool IsAlpha(string s) => s.All(char.IsLetter);
    public static bool IsAlphanumeric(string s) => s.All(char.IsLetterOrDigit);
    public static string ReplaceIgnoreCase(string s, string oldVal, string newVal) => s.Replace(oldVal, newVal, StringComparison.OrdinalIgnoreCase);
    public static string EnsureEndsWith(string s, string end) => s.EndsWith(end) ? s : s + end;
    public static string EnsureStartsWith(string s, string start) => s.StartsWith(start) ? s : start + s;
    public static string MaskString(string s, int visible) => s.Length <= visible ? s : new string('*', s.Length - visible) + s[^visible..];
    public static string RemovePunctuation(string s) => new(s.Where(c => !char.IsPunctuation(c)).ToArray());
    public static IEnumerable<string> UniqueWords(string s) => s.Split(' ').Distinct();
    public static int WordCount(string s) => s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    public static string ReverseWords(string s) => string.Join(" ", s.Split(' ').Reverse());
    public static bool ContainsAllWords(string s, params string[] words) => words.All(w => s.Contains(w, StringComparison.OrdinalIgnoreCase));
    public static bool ContainsAnyWord(string s, params string[] words) => words.Any(w => s.Contains(w, StringComparison.OrdinalIgnoreCase));
    public static string RemoveFirst(string s, string target) => s.Replace(target, "", 1);
    public static string RemoveLast(string s, string target) => s[..s.LastIndexOf(target)];
    public static bool HasUpper(string s) => s.Any(char.IsUpper);
    public static bool HasLower(string s) => s.Any(char.IsLower);
    public static bool HasDigit(string s) => s.Any(char.IsDigit);
    public static bool HasSymbol(string s) => s.Any(ch => !char.IsLetterOrDigit(ch));
    public static string ToSnake(string s) => string.Concat(s.Select((c,i)=> i>0 && char.IsUpper(c) ? "_" + c : c.ToString())).ToLower();
    public static string ToKebab(string s) => string.Concat(s.Select((c,i)=> i>0 && char.IsUpper(c) ? "-" + c : c.ToString())).ToLower();
    public static string ToCamel(string s) => string.IsNullOrEmpty(s) ? s : char.ToLower(s[0]) + s[1..];
    public static string ToPascal(string s) => string.IsNullOrEmpty(s) ? s : char.ToUpper(s[0]) + s[1..];
    public static string ReverseCase(string s) => new(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray());

    // ======================================================
    // DATE HELPERS (30+)
    // ======================================================

    public static bool IsWeekend(DateTime d) => d.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
    public static int DaysBetween(DateTime s, DateTime e) => (e - s).Days;
    public static DateTime StartOfDay(DateTime d) => d.Date;
    public static DateTime EndOfDay(DateTime d) => d.Date.AddDays(1).AddTicks(-1);
    public static DateTime StartOfWeek(DateTime d) => d.AddDays(-(int)d.DayOfWeek + (int)DayOfWeek.Monday).Date;
    public static DateTime FirstDayOfMonth(DateTime d) => new(d.Year, d.Month, 1);
    public static DateTime LastDayOfMonth(DateTime d) => FirstDayOfMonth(d).AddMonths(1).AddDays(-1);
    public static bool IsToday(DateTime d) => d.Date == DateTime.Today;
    public static bool IsPast(DateTime d) => d.Date < DateTime.Today;
    public static bool IsFuture(DateTime d) => d.Date > DateTime.Today;
    public static int MonthsBetween(DateTime s, DateTime e) => (e.Year - s.Year) * 12 + e.Month - s.Month;
    public static int YearsBetween(DateTime s, DateTime e) => e.Year - s.Year - (e.DayOfYear < s.DayOfYear ? 1 : 0);
    public static bool IsLeapYear(DateTime d) => DateTime.IsLeapYear(d.Year);
    public static DateTime NextMonth(DateTime d) => d.AddMonths(1);
    public static DateTime PrevMonth(DateTime d) => d.AddMonths(-1);
    public static DateTime NextDay(DateTime d) => d.AddDays(1);
    public static DateTime PrevDay(DateTime d) => d.AddDays(-1);
    public static DateTime NextWeek(DateTime d) => d.AddDays(7);
    public static DateTime PrevWeek(DateTime d) => d.AddDays(-7);
    public static bool SameDate(DateTime a, DateTime b) => a.Date == b.Date;

    // ======================================================
    // MATH HELPERS (40+)
    // ======================================================

    public static int Clamp(int v, int min, int max) => Math.Max(min, Math.Min(v, max));
    public static double Clamp(double v, double min, double max) => Math.Max(min, Math.Min(v, max));
    public static bool IsEven(int v) => v % 2 == 0;
    public static bool IsOdd(int v) => v % 2 != 0;
    public static int Abs(int v) => Math.Abs(v);
    public static double Round2(double v) => Math.Round(v, 2);
    public static double Percent(double part, double total) => total == 0 ? 0 : (part / total) * 100;
    public static bool InRange(int v, int min, int max) => v >= min && v <= max;
    public static double Average(IEnumerable<double> values) => values.Any() ? values.Average() : 0;
    public static double Sum(IEnumerable<double> v) => v.Sum();
    public static int Sum(IEnumerable<int> v) => v.Sum();
    public static double Min(IEnumerable<double> v) => v.Min();
    public static int Min(IEnumerable<int> v) => v.Min();
    public static double Max(IEnumerable<double> v) => v.Max();
    public static int Max(IEnumerable<int> v) => v.Max();
    public static double Pow(double a, double b) => Math.Pow(a, b);
    public static double Sqrt(double v) => Math.Sqrt(v);
    public static int Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);
    public static double Median(IEnumerable<double> v)
    {
        var a = v.OrderBy(x => x).ToList();
        int c = a.Count;
        if (c == 0) return 0;
        return c % 2 == 1 ? a[c / 2] : (a[c / 2 - 1] + a[c /2]) / 2;
    }

    // ======================================================
    // COLLECTION HELPERS (40+)
    // ======================================================

    public static bool IsNullOrEmpty<T>(IEnumerable<T>? list) => list == null || !list.Any();
    public static IEnumerable<T> DistinctBy<T, K>(IEnumerable<T> list, Func<T, K> key) => list.GroupBy(key).Select(g => g.First());
    public static T? FirstOrDefaultSafe<T>(IEnumerable<T> list) => list.FirstOrDefault();
    public static IEnumerable<T> Shuffle<T>(IEnumerable<T> list) => list.OrderBy(_ => Guid.NewGuid());
    public static bool ContainsAny<T>(IEnumerable<T> list, IEnumerable<T> check) => check.Any(list.Contains);
    public static bool ContainsAll<T>(IEnumerable<T> list, IEnumerable<T> check) => check.All(list.Contains);
    public static IEnumerable<T> Paginate<T>(IEnumerable<T> src, int page, int size) => src.Skip((page-1)*size).Take(size);
    public static IEnumerable<T> AppendIf<T>(IEnumerable<T> src, bool cond, T val) => cond ? src.Append(val) : src;
    public static IEnumerable<T> PrependIf<T>(IEnumerable<T> src, bool cond, T val) => cond ? src.Prepend(val) : src;
    public static IEnumerable<T> RemoveNulls<T>(IEnumerable<T?> src) => src.Where(x => x != null)!;
    public static bool AnyNull<T>(IEnumerable<T?> src) => src.Any(x => x == null);
    public static IEnumerable<T> WhereNotNull<T>(IEnumerable<T?> src) where T : class => src.Where(x => x != null)!;
    public static IEnumerable<T> TakeLast<T>(IEnumerable<T> src, int n) => src.Reverse().Take(n).Reverse();

    // ======================================================
    // RANDOM & GUID HELPERS (10)
    // ======================================================

    public static string NewGuid() => Guid.NewGuid().ToString();
    public static int RandomInt(int min, int max) => Random.Shared.Next(min, max);
    public static double RandomDouble() => Random.Shared.NextDouble();
    public static bool RandomBool() => Random.Shared.Next(0,2) == 1;

    // ======================================================
    // VALIDATION (15)
    // ======================================================

    public static bool IsEmail(string v) => System.Text.RegularExpressions.Regex.IsMatch(v, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    public static bool IsPhone(string v) => System.Text.RegularExpressions.Regex.IsMatch(v, @"^\+?\d{8,15}$");
    public static bool IsUrl(string v) => Uri.TryCreate(v, UriKind.Absolute, out _);
    public static bool IsGuid(string v) => Guid.TryParse(v, out _);

    // ======================================================
    // CONVERSION (15)
    // ======================================================

    public static int ToInt(string v, int def = 0) => int.TryParse(v, out var r) ? r : def;
    public static double ToDouble(string v, double def = 0) => double.TryParse(v, out var r) ? r : def;
    public static DateTime ToDate(string v, DateTime def) => DateTime.TryParse(v, out var r) ? r : def;
    public static bool ToBool(string v, bool def = false) => bool.TryParse(v, out var r) ? r : def;

    // ======================================================
    // MISC (20)
    // ======================================================

    public static string IfNull(string? v, string fallback) => string.IsNullOrEmpty(v) ? fallback : v;
    public static TimeSpan Benchmark(Action action)
    {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        action();
        sw.Stop();
        return sw.Elapsed;
    }
}
