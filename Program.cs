namespace Ramadan
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string token = "7016774166:AAHYY3UdrekdFb3m4ebdZ4a9GQxahx_Lb88";
            
            BotHandler handler = new BotHandler(token);
            
            try
            { 
                await handler.BotHandle();
            }
            catch (Exception ex)
            {
                throw new Exception("No error");
            }
        }
    }
}