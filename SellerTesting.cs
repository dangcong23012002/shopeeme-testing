using ShopeeMe.UnitTests.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeMe.UnitTests
{
    public class SellerTesting
    {
        private SellerRepository _sellerRepository;

        [SetUp]
        public void Setup()
        {
            _sellerRepository = new SellerRepository();
        }

        [Test]
        public void loginSellerAccount_Successfuly()
        {
            // Asign
            string phone = "0347797502";
            string password = "1";

            // Act 
            var result = _sellerRepository.loginSellerAccount(phone, password);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void loginSellerAccount_Failed()
        {
            // Asign
            string phone = "0347797502";
            string password = "10";

            // Act 
            var result = _sellerRepository.loginSellerAccount(phone, password);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void getSellerAccountByID_Successfully()
        {
            // Asign
            int sellerID = 1;

            // Act 
            var result = _sellerRepository.getSellerAccountByID(sellerID);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void getPasswordSellerAccountByPhone_Successfully()
        {
            // Asign
            string phone = "0347797502";

            // Act 
            var result = _sellerRepository.getPasswordSellerAccountByPhone(phone);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void getPasswordSellerAccountByPhone_Failed()
        {
            // Asign
            string phone = "0347797501";

            // Act 
            var result = _sellerRepository.getPasswordSellerAccountByPhone(phone);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void checkSellerAccountByIDAndPass_Failed()
        {
            // Asign
            int sellerID = 1;
            string password = "2";

            // Act 
            var result = _sellerRepository.checkSellerAccountByIDAndPass(sellerID, password);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void checkSellerAccountByIDAndPass_Successfully()
        {
            // Asign
            int sellerID = 1;
            string password = "1";

            // Act 
            var result = _sellerRepository.checkSellerAccountByIDAndPass(sellerID, password);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void changePasswordSellerAccount_Successfully()
        {
            // Asign
            int sellerID = 2;
            string password = "1";

            // Act 
            var result = _sellerRepository.changePasswordSellerAccount(sellerID, password);

            // Assert
            Assert.AreEqual(true, result);
        }
    }
}
