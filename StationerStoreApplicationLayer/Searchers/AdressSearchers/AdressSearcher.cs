using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAdressId;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAlley;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByCity;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByHouseNumber;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByStree;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserId;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserName;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdresssSearchersByPostalCode;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers
{
    public class AdressSearcher : IAdressSearcher,
        IAdressSearcherByAdressId,
        IAdressSearcherByUserId,
        IAdressSearcherByUserName,
        IAdressSearcherByCity,
        IAdressSearcherByStreet,
        IAdressSearcherByAlley,
        IAdressSearcherByHouseNumber,
        IAdressSearcherByPostalCode
    {
        private IAdressSearcherByAdressId _adressSearcherByAdressId;
        private IAdressSearcherByUserId _adressSearcherByUserId;
        private IAdressSearcherByUserName _adressSearcherByUserName;
        private IAdressSearcherByCity _adressSearcherByCity;
        private IAdressSearcherByStreet _adressSearcherByStreet;
        private IAdressSearcherByAlley _adressSearcherByAlley;
        private IAdressSearcherByHouseNumber _adressSearcherByHouseNumber;
        private IAdressSearcherByPostalCode _adressSearcherByPostalCode;

        public AdressSearcher(
            IAdressSearcherByAdressId adressSearcherByAdressId,
            IAdressSearcherByUserId adressSearcherByUserId,
            IAdressSearcherByUserName adressSearcherByUserName,
            IAdressSearcherByCity adressSearcherByCity,
            IAdressSearcherByStreet adressSearcherByStreet,
            IAdressSearcherByAlley adressSearcherByAlley,
            IAdressSearcherByHouseNumber adressSearcherByHouseNumber,
            IAdressSearcherByPostalCode adressSearcherByPostalCode
            )
        {
            _adressSearcherByAdressId = adressSearcherByAdressId;
            _adressSearcherByUserId = adressSearcherByUserId;
            _adressSearcherByUserName = adressSearcherByUserName;
            _adressSearcherByCity = adressSearcherByCity;
            _adressSearcherByStreet = adressSearcherByStreet;
            _adressSearcherByAlley = adressSearcherByAlley;
            _adressSearcherByHouseNumber = adressSearcherByHouseNumber;
            _adressSearcherByPostalCode = adressSearcherByPostalCode;
        }

        public List<AdressTable> SearchInAdresses(IEnumerable<AdressTable> adresses, object? adressId = null, object? userId = null, string? userName = null, string? city = null, string? street = null, string? alley = null, string? houseCode = null, long? postalCode = null)
        {
            var UserIdFiltered = SerachInAdressesByUserId(adresses,userId);
            var UserNameFiltered = SerachInAdressesByUserName(UserIdFiltered, userName);
            var CityFiltered =  SearchInAdressesByCity(UserNameFiltered, city);
            var StreetFiltered = SerachInAdressesByStreet(CityFiltered, street);
            var AlleyFiltered = SearchInAdressesByAlley(StreetFiltered, alley);
            var HouseNumberFiltered = SerachInAdressesByHouseNumber(AlleyFiltered,houseCode);
            var PostalCodeFiltered = SerachInAdressesByPostalCode(HouseNumberFiltered, postalCode);
            var Filtered = SearchInAdressesById(PostalCodeFiltered,adressId);
            
            return Filtered.ToList();
        }

        public IEnumerable<AdressTable> SearchInAdressesByAlley(IEnumerable<AdressTable> adresses, string? AlleyName = null)
        {
            return _adressSearcherByAlley.SearchInAdressesByAlley(adresses, AlleyName);
        }

        public IEnumerable<AdressTable> SearchInAdressesByCity(IEnumerable<AdressTable> adresses, string? City = null)
        {
            return _adressSearcherByCity.SearchInAdressesByCity(adresses, City);
        }

        public IEnumerable<AdressTable> SearchInAdressesById(IEnumerable<AdressTable> adresses, object? adressId = null)
        {
            return _adressSearcherByAdressId.SearchInAdressesById(adresses, adressId);
        }

        public IEnumerable<AdressTable> SerachInAdressesByHouseNumber(IEnumerable<AdressTable> adresses, string? houseNumber = null)
        {
            return _adressSearcherByHouseNumber.SerachInAdressesByHouseNumber(adresses, houseNumber);
        }

        public IEnumerable<AdressTable> SerachInAdressesByPostalCode(IEnumerable<AdressTable> adresses, long? PostalCode = null)
        {
            return _adressSearcherByPostalCode.SerachInAdressesByPostalCode(adresses,PostalCode);
        }

        public IEnumerable<AdressTable> SerachInAdressesByStreet(IEnumerable<AdressTable> adresses, string? street = null)
        {
            return _adressSearcherByStreet.SerachInAdressesByStreet(adresses, street);
        }


        public IEnumerable<AdressTable> SerachInAdressesByUserId(IEnumerable<AdressTable> adresses, object? userId = null)
        {
            return _adressSearcherByUserId.SerachInAdressesByUserId(adresses, userId);

        }

        public IEnumerable<AdressTable> SerachInAdressesByUserName(IEnumerable<AdressTable> adresses, string? UserName = null)
        {
            return _adressSearcherByUserName.SerachInAdressesByUserName(adresses, UserName);
        }
    }
}
