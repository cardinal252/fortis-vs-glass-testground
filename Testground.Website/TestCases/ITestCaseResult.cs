namespace Testground.Website.TestCases
{
	public interface ITestCaseResult
	{
		decimal SitecoreResult { get; }
		decimal GlassResult { get; }
		decimal FortisResult { get; }
		string CaseName { get; }
	}
}
