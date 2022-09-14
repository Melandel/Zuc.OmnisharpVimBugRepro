namespace Zuc.OmnisharpVimBugRepro;

public class Tests
{
	[Test]
	public void Test1()
	{
		Assert.Pass();
	}

	[TestCaseSource(typeof(TestData), nameof(TestData.Strings))]
	public void Test2(string str)
	{
		Assert.That(str, Is.Not.Null);
	}

	[TestCaseSource(typeof(TestData), nameof(TestData.Strings))]
	public void Test3(string str)
	{
		Assert.That(str, Is.Not.Null);
	}
}
