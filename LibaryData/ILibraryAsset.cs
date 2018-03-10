using LibaryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibaryData
{
    public interface ILibraryAsset
    {
        IEnumerable<LibraryAsset> GetAll();
        LibraryAsset GetById(int id);

        void Add(LibraryAsset newAsset);
        string GetAuthorOrDirector(int id);
        string GetDeweyIndex(int id);
        string GetType(int id);
        string GetTitle(int id);
        String GetIsbn(int id);

        LibraryBranch GetCurrentLocation(int id);
    }
}
