using ShopeeMe.UnitTests.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeMe.UnitTests
{
    public class ProductTesting
    {
        private ProductRepository _productRepository;

        [SetUp]
        public void SetUp()
        {
            _productRepository = new ProductRepository();
        }

        [Test]
        public void getProducts_Sucessfully()
        {
            // Asign

            // Act
            bool result = _productRepository.getProducts();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void getProductsByCategoryID_Sucessfully()
        {
            // Asign
            int categoryID = 1;

            // Act
            bool result = _productRepository.getProductsByCategoryID(categoryID);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void getProductsByParentCategoryID_Sucessfully()
        {
            // Asign
            int parentCategoryID = 1;

            // Act
            bool result = _productRepository.getProductsByParentCategoryID(parentCategoryID);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void getProductsByCategoryIDIfRoleAdmin_Sucessfully()
        {
            // Asign
            int parentCategoryID = 1;

            // Act
            bool result = _productRepository.getProductsByParentCategoryID(parentCategoryID);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
