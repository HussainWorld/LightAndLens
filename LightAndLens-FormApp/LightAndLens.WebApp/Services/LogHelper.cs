using LightAndLensCL.Models;

namespace LightAndLens.WebApp.Services
{
    public class LogHelper
    {
        private readonly LightAndLensDBContext _context;

        public LogHelper(LightAndLensDBContext context)
        {
            _context = context;
        }

        public async Task LogActionAsync(int userId, string action)
        {
            var log = new Log
            {
                UserId = userId,
                Action = action,
                Timestamp = DateTime.Now
            };
            _context.Logs.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}
