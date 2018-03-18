using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibaryData;
using Library_Management_System.Models.Catalog;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class CatalogController : Controller
    {
        private ILibraryAsset _assets;
        private ICheckout _checkouts;

        public CatalogController(ILibraryAsset assets, ICheckout checkouts)
        {
            _assets = assets;
            _checkouts = checkouts;
        }
        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();

            var listingResult = assetModels
                .Select(result => new AssetIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                    DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                    Title = result.Title,
                    Type = _assets.GetType(result.Id)
                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var asset = _assets.GetById(id);
            var currentHolds = _checkouts.GetCurrentHolds(id)
                .Select(a => new AssetHoldModel {
                    HoldPLaced = _checkouts.GetCurrentHoldPlaced(a.Id).ToString("d"),
                    PatronName = _checkouts.GetCurrentHoldPatronName(a.Id)

                });
            var model = new AssetDetailModel
            {
                AssetId = id,
                Title = asset.Title,
                Type = _assets.GetType(id),
                Year = asset.Year,
                Cost = asset.Cost,
                Status = asset.Status.Name,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = _assets.GetAuthorOrDirector(id),
                CurrentLocation = _assets.GetCurrentLocation(id).Name,
                DeweyCallNumber = _assets.GetDeweyIndex(id),
                CheckoutHistory = _checkouts.GetCheckoutHistory(id),
                ISBN = _assets.GetIsbn(id),
                LatestCheckout = _checkouts.GetLatestCheckout(id),
                PatronName = _checkouts.GetCurrentCheckoutPatron(id),
                CurrentHolds = currentHolds.


            };
            return View(model);
        }
    }
}