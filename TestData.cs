namespace Zuc.OmnisharpVimBugRepro;

public static class TestData
{
	public static IEnumerable<object[]> Strings
	=> new[]
	{
		new[] { "foo" },
		new[] { "bar" },
	};
}
