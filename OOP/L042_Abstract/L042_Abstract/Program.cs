namespace L042_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Abstract class negali sukurti naujo instance
            //SearchEngine searchEngine = new SearchEngine();

            SearchEngine googleSearchEngine = new GoogleSearchEngine();
            SearchEngine duckDuckGoSearchEngine = new DuckDuckGoSearchEngine();

            string[] googleResults = googleSearchEngine.Search("aaa");
            string[] duckDuckGoResults = duckDuckGoSearchEngine.Search("bbb");
            Console.WriteLine($"google results: [{string.Join(", ", googleResults)}]");
            Console.WriteLine($"duckduckgo results: [{string.Join(", ", duckDuckGoResults)}]");



            string[] googleResults1 = googleSearchEngine.Result();
            string[] duckDuckGoResults1 = duckDuckGoSearchEngine.Result();
            Console.WriteLine($"google results: [{string.Join(", ", googleResults1)}]");
            Console.WriteLine($"duckduckgo results: [{string.Join(", ", duckDuckGoResults1)}]");











        }
    }
}