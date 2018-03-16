using LibaryData;
using LibaryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class CheckoutService : ICheckout
    {
        
        private LibraryContext _context;

        public CheckoutService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Checkout newCheckout)
        {
            _context.Add(newCheckout);
            _context.SaveChanges();
        }

        public void CheckInItem(int assetId, int libraryCardId)
        {
            var now = DateTime.Now;

            var item = _context.LibraryAssets
                .FirstOrDefault(a => a.Id == assetId);

            _context.Update(item);
        }

        public void CheckOutItem(int assetId, int libraryCardId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Checkout> GetAll()
        {
            return _context.Checkouts;
        }

        public Checkout GetById(int checkoutId)
        {
            return GetAll()
                .FirstOrDefault(Checkout => Checkout.Id == checkoutId);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int id)
        {
            return _context.CheckoutHistories
                .Include(h=>h.libraryAsset)
                .Include(h=>h.LibraryCard)
                .Where(h => h.libraryAsset.Id == id);
        }

        public string GetCurrentHoldPatronName(int id)
        {
            throw new NotImplementedException();
        }

        public DateTime GetCurrentHoldPlaced(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hold> GetCurrentHolds(int id)
        {
            return _context.Holds
                .Include(h => h.LibraryAsset)
                .Where(h => h.LibraryAsset.Id ==id);
        }
        public Checkout GetLatestCheckout(int assetId)
        {
            return _context.Checkouts
                .Where(c => c.libraryAsset.Id == assetId)
                .OrderByDescending(c=>c.Since)
                .FirstOrDefault();
        } 
        

        public void MarkFound(int assetId)
        {
            var now = DateTime.Now;
            

            UpdateAssetStatus(assetId, "Available");

            //remove any existing checkouts on the item
            RemoveExistingCheckouts(assetId);


            //close any existing checkout history
            CloseExistingCheckouts(assetId,now);
            

        }

        private void UpdateAssetStatus(int assetId, string v)
        {
            var item = _context.LibraryAssets
                .FirstOrDefault(a => a.Id == assetId);

            _context.Update(item);

            item.Status = _context.Status
                .FirstOrDefault(Status => Status.Name == "Available");
        }

        private void CloseExistingCheckouts(int assetId, DateTime now)
        {
            var history = _context.CheckoutHistories
                .FirstOrDefault(h => h.Id == assetId && h.CheckedIn == null);

            if (history != null)
            {
                _context.Update(history);
                history.CheckedIn = now;
            }

            _context.SaveChanges();
        }

        private void RemoveExistingCheckouts(int assetId)
        {
            var checkout = _context.Checkouts
                .FirstOrDefault(co => co.libraryAsset.Id == assetId);
            if (checkout != null)
            {
                _context.Remove(checkout);
            }
        }

        public void MarkLost(int assetId)
        {
            UpdateAssetStatus(assetId, "Lost");
            
            _context.SaveChanges();
        }

        public void PlaceHold(int assetId, int libraryCardId)
        {
            throw new NotImplementedException();
        }
    }
}
