namespace Testground.Website.TestCases
{
	public interface ITestCase : ITestCaseResult
	{
		void Execute();
	}
}