using LibaryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibaryData
{
    public interface ILibraryBranch
    {
        IEnumerable<ILibraryBranch> GetAll();
        IEnumerable<Patron> GetPatron(int branchId);
        IEnumerable<LibraryAsset> GetAssets(int branchId);
        IEnumerable<string> GetBranchHours(int branchId);
        LibraryBranch Get(int branchId);
        void Add(LibraryBranch newBranch);
        void IsBranchOpen(int branchId);
    }
}
