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
    }
}
