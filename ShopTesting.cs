﻿using ShopeeMe.UnitTests.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeMe.UnitTests
{
    public class ShopTesting
    {
        private ShopRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = new ShopRepository();
        }

        [Test]
        public void getShops_Succsessfully() 
        {
            // Asign

            // Act
            bool result = _repository.getShops();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void getShopByID_Succsessfully()
        {
            // Asign
            int shopID = 1;

            // Act
            bool result = _repository.getShopByID(shopID);

            // Assert
            Assert.IsTrue(result);
        }
    }
}