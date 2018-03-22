using LibaryData;
using LibaryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class LibraryBranchService : ILibraryBranch
    {
        private readonly LibraryContext _context;

        public LibraryBranchService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(LibraryBranch newBranch)
        {
            _context.Add(newBranch);
            _context.SaveChanges();
        }

        public LibraryBranch Get(int branchId)
        {
            return _context.LibraryBranches
                .Include(b => b.Patrons)
                .Include(b => b.LibraryAsset)
                .FirstOrDefault(p => p.Id == branchId);
        }

        public IEnumerable<LibraryBranch> GetAll()
        {
            return _context.LibraryBranches.Include(a => a.Patrons).Include(a => a.LibraryAsset);
        }

        public int GetAssetCount(int branchId)
        {
            return Get(branchId).LibraryAsset.Count();
        }

        public IEnumerable<LibraryAsset> GetAssets(int branchId)
        {
            return _context.LibraryBranches.Include(a => a.LibraryAsset)
                .First(b => b.Id == branchId).LibraryAsset;
        }

        public decimal GetAssetsValue(int branchId)
        {
            var assetsValue = GetAssets(branchId).Select(a => a.Cost);
            return assetsValue.Sum();
        }

        public IEnumerable<string> GetBranchHours(int branchId)
        {
            var branchHours = _context.BranchHours.Where(a => a.Branch.Id == branchId);

            var displayHours =
                DataHelpers.HumanizeBusinessHours(branchHours);

            return displayHours;
        }

        public IEnumerable<Patron> GetPatron(int branchId)
        {
            throw new NotImplementedException();
        }

        public int GetPatronCount(int branchId)
        {
            return Get(branchId).Patrons.Count();
        }

        public IEnumerable<Patron> GetPatrons(int branchId)
        {
            return _context.LibraryBranches.Include(a => a.Patrons).First(b => b.Id == branchId).Patrons;
        }

         
        public bool IsBranchOpen(int branchId)
        {
            var currentTimeHour = DateTime.Now.Hour;
            var currentDayOfWeek = (int)DateTime.Now.DayOfWeek+1;
            var hours = _context.BranchHours.Where(h => h.Branch.Id == branchId);
            var dayHours = hours.FirstOrDefault(h => h.DayOfWeek == currentDayOfWeek);

            return currentTimeHour < dayHours.CloseTime && currentTimeHour > dayHours.OpenTime;
            
        }

        IEnumerable<ILibraryBranch> ILibraryBranch.GetAll()
        {
            throw new NotImplementedException();
        }

        void ILibraryBranch.IsBranchOpen(int branchId)
        {
            throw new NotImplementedException();
        }
    }
}
