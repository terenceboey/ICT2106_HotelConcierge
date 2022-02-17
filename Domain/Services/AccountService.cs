using _2106_Project.Domain.Interfaces;
using _2106_Project.Domain.Models;
using System.Collections.Generic;
using BCryptNet = BCrypt.Net.BCrypt;


namespace _2106_Project.Domain.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountRepository _account;

        public AccountService(IUnitOfWork unitOfWork , IAccountRepository account)
        {
            this._unitOfWork = unitOfWork;
            this._account = account;

        }

        public bool Login(Account account)
        {
            bool verified = false;
            if (account != null)
            {
                /*                var user = _unitOfWork.AccountRepository.GetById(account.Email);
                 *                
                */
                var abc = account.Password;
                var abca = account.Email;
                var user = _account.CheckEmail(account.Email);
                verified = BCryptNet.Verify(account.Password, user.Password);
            }
            return verified;

        }

        public void AddAccount(Account account, Guest guestDetails)
        {
            if (account != null)
            {
                account.Password = BCryptNet.HashPassword(account.Password);
                account.AccountStatus = "Pending Verification";
                _unitOfWork.AccountRepository.Insert(account);
                _unitOfWork.Save();
                _unitOfWork.Dispose();
                /*                var id = account.account_id;
                                var text = guestDetails.FirstName;
                                var textt = guestDetails.LastName;
                                var texttt = guestDetails.DOB;*/

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

        public void AddAccount(Account account)
        {
            throw new System.NotImplementedException();
        }
    }
}
