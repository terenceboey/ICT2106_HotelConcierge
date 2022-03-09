using _2106_Project.Domain.Interfaces;
using _2106_Project.Domain.Models;
using System;
using System.Collections.Generic;
using BCryptNet = BCrypt.Net.BCrypt;


namespace _2106_Project.Domain.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountRepository _account;
        private readonly IGuestRepository _guest;

        public AccountService(IUnitOfWork unitOfWork , IAccountRepository account , IGuestRepository guest)
        {
            this._unitOfWork = unitOfWork;
            this._account = account;
            this._guest = guest;

        }

        public bool Login(Account account)
        {
            bool verified = false;
            if (account != null)
            {
                /*                var user = _unitOfWork.AccountRepository.GetById(account.Email);
                 *                
                */
                var user = _account.CheckEmail(account.Email);
                verified = BCryptNet.Verify(account.Password, user.Password);
            }
            return verified;

        }

        public void AddAccount(Account account, Guest guest, Staff staff)
        {
            if (account != null)
            {
                account.Password = BCryptNet.HashPassword(account.Password);
                account.AccountStatus = "Pending Verification";
                Guid ai = _account.AddAccount(account);
                if ( guest != null)
                {
                    guest.account_id = ai;
                    _unitOfWork.GuestRepository.Insert(guest);

                }

                if(staff != null)
                {

                }

                _unitOfWork.Save();
                _unitOfWork.Dispose();

            }
        }

        public void DeleteAccount(int account_id)
        {
            throw new System.NotImplementedException();
        }

        public Account GetAccountById(int account_id)
        {
            throw new System.NotImplementedException();
        }

        public List<Account> GetAllAccounts()
        {
            return _unitOfWork.AccountRepository.GetAll();
        }

        public void UpdateAccount(Account account)
        {
            throw new System.NotImplementedException();
        }


        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

    }
}
