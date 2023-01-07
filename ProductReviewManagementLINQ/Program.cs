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
            try
            {
                ProductReviewTable ProductReview = new ProductReviewTable();
                while (true)
                {
                    ProductReviewManagment prm = new ProductReviewManagment();
                    Console.WriteLine("\nChoose option\n1: Display all records\n2: Top 3 records by rating\n3: display records whose rating > 3\\n4: CountProductIdUsingGroupBy\\n0: Exit \\n\"");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Displaying all records");
                            DisplayProducts(list);
                            break;
                        case 2:
                            // uc1 display top 3 records by rating
                            Console.WriteLine("\nTop 3 records are :");
                            ProductReviewManagment.RetriveTopThreeRecords(list);
                            break;
                        case 3:
                            Console.WriteLine("\nRecords With Rating Greater Than 3 or id =1 or 4 or 9 :");
                            prm.RetriveRecordsWithRatingGreaterThan3(list);
                            break;
                        case 4:
                            Console.WriteLine("count of review present for each productID :");
                            prm.CountProductIdUsingGroupBy(list);
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void DisplayProducts(List<ProductReviewTable> list)
        {
            try
            {
                foreach (var lists in list)
                {
                    Console.WriteLine("Product id = " + lists.ProductID + "User id = " + lists.UserID + "Rating is = " + lists.Rating + " Review is = " + lists.Review + " isLike = " + lists.IsLike);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
