using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByAdminiSatate;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByEmail;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByPassword;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserId;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserName;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers
{
    public class UserSeacher : IUserSeacher,
        IUserSearcherByUserId,
        IUserSearcherByUserName,
        IUserSearcherByPassword,
        IUserSearcherByEmail,
        IUserSearcherByAdminiState
    {
        private IUserSearcherByUserName _userSearcherByUserName;
        private IUserSearcherByUserId _userSearcherByUserId;
        private IUserSearcherByPassword _userSearcherByPassword;
        private IUserSearcherByEmail _userSearcherByEmail;
        private IUserSearcherByAdminiState _userSearcherByAdminiState;


        public UserSeacher(
            IUserSearcherByUserName userSearcherByUserName,
            IUserSearcherByUserId userSearcherByUserId,
            IUserSearcherByPassword userSearcherByPassword,
            IUserSearcherByEmail userSearcherByEmail,
            IUserSearcherByAdminiState userSearcherByAdminiState)
        {
            _userSearcherByUserName = userSearcherByUserName;
            _userSearcherByUserId = userSearcherByUserId;
            _userSearcherByPassword = userSearcherByPassword;
            _userSearcherByEmail = userSearcherByEmail;
            _userSearcherByAdminiState = userSearcherByAdminiState;
        }

        public IEnumerable<UserTable> SearchInUserByEmail(IEnumerable<UserTable> users, string? email)
        {
            return _userSearcherByEmail.SearchInUserByEmail(users, email);
        }

        public IEnumerable<UserTable> SearchInUserByPassword(IEnumerable<UserTable> users, string? password)
        {
           return _userSearcherByPassword.SearchInUserByPassword(users, password);
        }

        public List<UserTable> SearchInUsers(IEnumerable<UserTable> users, int? userId = null, string? username = null, string? userPassword = null, string? userEmail = null, bool? isAdmin = null)
        {
            var IdFiltered = SearchInUsersByUserId(users, userId);
            var UserNameFiltered = SearchInUsersByUserName(IdFiltered, username);
            var AdminiStateFiltered = SearchInUsersByAdminiState(UserNameFiltered, isAdmin);
            var EmailFiltered = SearchInUserByEmail(AdminiStateFiltered, userEmail);
            var Filtered =  SearchInUserByPassword(EmailFiltered,userPassword);

            return Filtered.ToList();
        }

        public IEnumerable<UserTable> SearchInUsersByAdminiState(IEnumerable<UserTable> users, bool? adminiState)
        {
            return _userSearcherByAdminiState.SearchInUsersByAdminiState(users, adminiState);
        }

        public IEnumerable<UserTable> SearchInUsersByUserId(IEnumerable<UserTable> users, int? userId)
        {
            return _userSearcherByUserId.SearchInUsersByUserId(users,userId);
        }

        public IEnumerable<UserTable> SearchInUsersByUserName(IEnumerable<UserTable> users, string? userName)
        {
            return _userSearcherByUserName.SearchInUsersByUserName(users,userName);

        }

    }
}
