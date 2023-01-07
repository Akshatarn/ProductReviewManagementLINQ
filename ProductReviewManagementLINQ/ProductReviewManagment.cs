using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    public class ProductReviewManagment
    {
        /// <summary>
        /// Retriving Top ThreeRecords by passing object of list of product review
        /// </summary>
        /// <param name="list"></param>
        public static void RetriveTopThreeRecords(List<ProductReviewTable> list)
        {
            var top3Records = list.OrderByDescending(P => P.Rating).Take(3).ToList();       //using lambda expression
            Program.DisplayProducts(top3Records);
        }
        public void RetriveRecordsWithRatingGreaterThan3(List<ProductReviewTable> list)
        {
            var allRecords = list.Where(P => P.Rating > 3 && (P.ProductID == 1) || (P.ProductID == 4) || (P.ProductID == 9)).ToList();      //using lambda expression
            Program.DisplayProducts(allRecords);
        }
        public void CountProductIdUsingGroupBy(List<ProductReviewTable> list)
        {
            Console.WriteLine("\n Count ProductId Using GroupBy ");
            var res = list.GroupBy(p => p.ProductID).Select(p => new { Id = p.Key, count = p.Count() });
            foreach (var p in res)
            {
                Console.WriteLine("ProductID=" + p.Id + " Count=" + p.count);
            }
        }
        public void GetProductIDAndReview(List<ProductReviewTable> list)
        {
            Console.WriteLine("\n ProductId and review are :");
            var res = list.Select(p => new { Id = p.ProductID, Review = p.Review }).ToList();
            foreach (var p in res)
            {
                Console.WriteLine("Product ID=" + p.Id + " Review=" + p.Review);
            }
        }
    }
}
