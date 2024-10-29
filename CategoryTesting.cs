using ShopeeMe.UnitTests.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeMe.UnitTests
{
    public class CategoryTesting
    {
        private CategoryRepository _categoryRepository;

        [SetUp] 
        public void SetUp() 
        { 
            _categoryRepository = new CategoryRepository();
        }

        [Test]
        public void getParentCategories_Sucessfully()
        {
            // Asign

            // Act
            bool result = _categoryRepository.getParentCategories();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void getCategories_Sucessfully()
        {
            // Asign

            // Act
            bool result = _categoryRepository.getCategories();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void getCategoriesByParentCategoryID_Sucessfully() 
        {
            // Asign
            int parentCategoryID = 1;

            // Act
            bool result = _categoryRepository.getCategoriesByParentCategoryID(parentCategoryID);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void getCategoriesByShopID_Sucessfully()
        {
            // Asign
            int shopID = 1;

            // Act
            bool result = _categoryRepository.getCategoriesByShopID(shopID);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
