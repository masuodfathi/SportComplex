using SportComplex.Data;

namespace SportComplex.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext _context;

        public TicketRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task<Ticket> GetTicketById(int id)
        {
            return await _context.Tickets.FindAsync(id);
        }

        public async Task AddTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTicket(Ticket ticket)
        {
            _context.Entry(ticket).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTicket(int id)
        {
            var ticketToDelete = await _context.Tickets.FindAsync(id);
            _context.Tickets.Remove(ticketToDelete);
            await _context.SaveChangesAsync();
        }
    }

}
