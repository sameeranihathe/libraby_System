using System.Collections.Generic;
using System.Linq;
using LibaryData;
using LibaryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryServices
{
    public class PatronService : IPatron
    {

        private LibraryContext _context;
        public PatronService(LibraryContext context)
        {
            _context = context;
        }


        public void Add(Patron newPatron)
        {
            _context.Add(newPatron);
            _context.SaveChanges();
        }

        public Patron Get(int id)
        {
            return GetAll()
                .FirstOrDefault(patron => patron.Id == id);
        }

        public IEnumerable<Patron> GetAll()
        {
            return _context.Patrons
               .Include(patron => patron.LibraryCard)
               .Include(patron => patron.HomeLibraryBranch);
               
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId)
        {
            var cardId = _context.Patrons
               .Include(a => a.LibraryCard)
               .FirstOrDefault(a => a.Id == patronId)?
               .LibraryCard.Id;

            return _context.CheckoutHistories
                .Include(a => a.LibraryCard)
                .Include(a => a.libraryAsset)
                .Where(a => a.LibraryCard.Id == cardId)
                .OrderByDescending(a => a.CheckOut);
        }

        public IEnumerable<Checkout> GetCheckouts(int patronId)
        {
            var patronCardId = Get(patronId).LibraryCard.Id;
            return _context.Checkouts
                .Include(a => a.LibraryCard)
                .Include(a => a.libraryAsset)
                .Where(v => v.LibraryCard.Id == patronCardId);

        }

        public IEnumerable<Hold> GetHolds(int patronId)
        {
            var cardId = _context.Patrons
               .Include(a => a.LibraryCard)
               .FirstOrDefault(a => a.Id == patronId)?
               .LibraryCard.Id;

            return _context.Holds
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(a => a.LibraryCard.Id == cardId)
                .OrderByDescending(a => a.HoldPlaced);
        }
    }
}
