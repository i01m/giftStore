﻿using System.Linq;
using GiftsForEveryone.Models;
using Xunit;


namespace GiftsForEveryone.Tests
{
    public class CartTests
    {
        [Fact]
        public void Can_Add_New_Lines()
        {
            //Arrange - create some new products
            Product p1 = new Product { ProductID = 1, Name = "P1"};
            Product p2 = new Product { ProductID = 2, Name = "P2"};

            //Arrange - create a new cart
            Cart target = new Cart();

            //Act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            CartLine[] results = target.Lines.ToArray();

            //Assert 
            Assert.Equal(2, results.Length);
            Assert.Equal(p1, results[0].Product);
            Assert.Equal(p2, results[1].Product);
        }

        [Fact]
        public void Can_Add_Quantity_For_Existing_Lines()
        {
            //Arrange - create some new products
            Product p1 = new Product { ProductID = 1, Name = "P1" };
            Product p2 = new Product { ProductID = 2, Name = "P2" };

            //Arrange - create a new cart
            Cart target = new Cart();

            //Act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 10);
            CartLine[] resuts = target.Lines.OrderBy(c => c.Product.ProductID).ToArray();

            //Assert
            Assert.Equal(2, resuts.Length);
            Assert.Equal(11, resuts[0].Quantity);
            Assert.Equal(1, resuts[1].Quantity);            
        }

        [Fact]
        public void Can_Remove_Line()
        {
            //Arrange - create some new products
            Product p1 = new Product { ProductID = 1, Name = "P1" };
            Product p2 = new Product { ProductID = 2, Name = "P2" };
            Product p3 = new Product { ProductID = 3, Name = "P3" };

            //Arrange
            Cart target = new Cart();

            //Act - add some products to the cart
            target.AddItem(p1, 1);
            target.AddItem(p2, 3);
            target.AddItem(p3, 5);
            target.AddItem(p2, 5);


            //Act
            target.RemoveLine(p2);


            //Assert
            Assert.Equal(0, target.Lines.Where(c => c.Product == p2).Count());
            Assert.Equal(2, target.Lines.Count());
        }
             
        [Fact]
        public void Calculate_Cart_Total()
        {
            //Arrange - create some new products
            Product p1 = new Product { ProductID = 1, Name = "P1", Price = 100M };
            Product p2 = new Product { ProductID = 2, Name = "P2", Price = 50M };

            //Arrange - create a new cart
            Cart target = new Cart();

            //Act - add some products to the cart
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 3);
            decimal result = target.ComputeTotalValue();

            //Assert
            Assert.Equal(450, result);
         }


        [Fact]
        public void Can_Clear_Contents()
        {
            //Arrange - create some new products
            Product p1 = new Product { ProductID = 1, Name = "P1", Price = 100M };
            Product p2 = new Product { ProductID = 2, Name = "P2", Price = 50M };

            //Arrange - create a new cart
            Cart target = new Cart();

            //Act - add some products to the cart
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 3);

            //Act
            target.Clear();

            //Assert
            Assert.Equal(0, target.Lines.Count());
        }
    }
}
