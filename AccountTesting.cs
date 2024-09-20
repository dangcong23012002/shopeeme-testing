using ShopeeMe.Tests.Repository;
using System.Data;

namespace ShopeeMe.UnitTests
{
    public class AccountTesting
    {
        private AccountRepository _accountRepository;
        [SetUp]
        public void Setup()
        {
            _accountRepository = new AccountRepository();
        }

        [Test]
        public void loginAccount_Successfully()
        {
            // Assign
            string email = "dangvancong2301@gmail.com";
            string password = "1";

            // Act
            var result = _accountRepository.loginAccount(email, password);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void loginAccount_Failded()
        {
            // Assign
            string email = "dangvancong@gmail.com";
            string password = "1";

            // Act
            var result = _accountRepository.loginAccount(email, password);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test] 
        public void checkLoginAccountByUserID_Successfully() 
        {
            // Assign
            int userID = 3;

            // Act
            var result = _accountRepository.checkLoginAccountByUserID(userID);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void checkEmailAccountIsRegis_Successfully()
        {
            // Assign
            string email = "cong@gmail.com";

            // Act
            var result = _accountRepository.checkEmailAccountIsRegis(email);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void createAccount_Successfully()
        {
            // Assign
            int roleID = 3;
            string userName = "Vinh Nguyễn";
            string email = "vinh123@gmail.com";
            DateTime createTime = DateTime.Now;
            string password = "1";

            // Act
            var result = _accountRepository.createAccount(roleID, userName, email, createTime, password);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void getPasswordAccountByEmail_Successfully()
        {
            // Assign
            string email = "vinh123@gmail.com";

            // Act
            var result = _accountRepository.getPasswordAccountByEmail(email);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void changePasswordByUserID_Successfully()
        {
            // Assign
            int userID = 21;
            string newPassword = "10";

            // Act
            var result = _accountRepository.changePasswordByUserID(userID, newPassword);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void checkUserInfoByUserID_Successfully()
        {
            // Assign
            int userID = 3;

            // Act
            var result = _accountRepository.checkUserInfoByUserID(userID);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void checkUserInfoByUserID_Failded()
        {
            // Assign
            int userID = 22;

            // Act
            var result = _accountRepository.checkUserInfoByUserID(userID);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void createAccountInfo_Successfully() 
        {
            // Assign
            int userID = 22;
            string fullName = "Phạm Thị Trang";
            int gender = 0;
            string birth = "2002/12/12";
            DateTime updateTime = DateTime.Now;
            string image = "no_user.jpg";

            // Act
            var result = _accountRepository.createAccountInfo(userID, fullName, gender, Convert.ToDateTime(birth), updateTime, image);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void getAccountInfoByUserID_Successfully()
        {
            // Assign
            int userID = 22;

            // Act
            var result = _accountRepository.getAccountInfoByUserID(userID);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void updateAccountInfo_Successfully()
        {
            // Assign
            int userID = 22;
            string fullName = "Phạm Thị Thu Trang";
            string birth = "1/12/2002";
            DateTime updateTime = DateTime.Now;
            int gender = 0;
            string image = "no_user.jpg";

            // Act
            var result = _accountRepository.updateAccountInfo(userID, fullName, Convert.ToDateTime(birth), updateTime, gender, image);

            // Assert
            Assert.AreEqual(true, result);
        }
    }
}