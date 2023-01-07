using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product review management");

            ProductReviewTable productReview = new ProductReviewTable();
            List<ProductReviewTable> list = new List<ProductReviewTable>()
            {
            new ProductReviewTable() { ProductID = 1, UserID = 1, Rating = 5.5, Review = "Good", IsLike=true},
            new ProductReviewTable() { ProductID = 1, UserID = 1, Rating = 4.5, Review = "Good", IsLike=true },
            new ProductReviewTable() { ProductID = 2, UserID = 1, Rating = 6, Review = "Good", IsLike=true },
            new ProductReviewTable() { ProductID = 2, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReviewTable() { ProductID = 4, UserID = 1, Rating = 5, Review = "Nice", IsLike=true },
            new ProductReviewTable() { ProductID = 5, UserID = 1, Rating = 5, Review = "Nice", IsLike=true },
            new ProductReviewTable() { ProductID = 6, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReviewTable() { ProductID = 7, UserID = 1, Rating = 7.5, Review = "Good", IsLike=false},
            new ProductReviewTable() { ProductID = 4, UserID = 1, Rating = 1.5, Review = "Good", IsLike=false },
            new ProductReviewTable() { ProductID = 9, UserID = 1, Rating = 6.5, Review = "Bad", IsLike=false },
            new ProductReviewTable() { ProductID = 10, UserID = 1, Rating = 5, Review = "Bad", IsLike=false },
            new ProductReviewTable() { ProductID = 11, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReviewTable() { ProductID = 12, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReviewTable() { ProductID = 13, UserID = 1, Rating = 5, Review = "Bad", IsLike=true },
            new ProductReviewTable() { ProductID = 14, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReviewTable() { ProductID = 15, UserID = 1, Rating = 5, Review = "Good", IsLike=true }
            };
            Console.WriteLine("Rows in the table = ");
            foreach (var lists in list)
            {
                Console.WriteLine("Product id = " + lists.ProductID + "User id = " + lists.UserID + "Rating is = " + lists.Rating + " Review is = " + lists.Review + " isLike = " + lists.IsLike);
            }
        }
    }
}
