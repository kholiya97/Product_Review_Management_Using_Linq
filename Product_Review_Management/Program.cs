using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management_Using_Linq
{
    
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome To Product Review Management********");
            //UC1
            //Creating a List of ProductReview and Adding values into List.
            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Excellent", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Excellent", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4, Review = "Good",     isLike = false },
                new ProductReview() { ProductId = 4, UserId = 3, Rating = 4, Review = "Good",     isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 3, Review = "Average",  isLike = false },
                new ProductReview() { ProductId = 3, UserId = 4, Rating = 5, Review = "Excellent", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 5, Rating = 3, Review = "Average",  isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 2, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 5, UserId = 6, Rating = 2, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 6, UserId = 7, Rating = 1, Review = "Very Bad", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 7, Rating = 3, Review = "Average",  isLike = true },
                new ProductReview() { ProductId = 12, UserId = 4, Rating = 1, Review = "Very Bad", isLike = true }, 
                new ProductReview() { ProductId = 13, UserId = 48, Rating = 0, Review = "Excellent", isLike = false }, 
                new ProductReview() { ProductId = 14, UserId =41, Rating = 3, Review = "Average", isLike = true }, 
                new ProductReview() { ProductId = 15, UserId = 51, Rating = 4, Review = "Nice", isLike = true }, 
                new ProductReview() { ProductId = 16, UserId = 8, Rating = 1, Review = "Very Bad", isLike = false },
                new ProductReview() { ProductId = 17, UserId = 18, Rating = 6, Review = "Excellent", isLike = true },
                new ProductReview() { ProductId = 18, UserId = 9, Rating = 5, Review = "Good", isLike = true }, 
                new ProductReview() { ProductId = 19, UserId = 10, Rating = 4, Review = "Nice", isLike = false },
                new ProductReview() { ProductId = 20, UserId = 7, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 21, UserId = 6, Rating = 2, Review = "Bad", isLike = true },
                new ProductReview() { ProductId = 22, UserId = 5, Rating = 1, Review = "Very Bad", isLike = false },
                new ProductReview() { ProductId = 23, UserId = 10, Rating = 5, Review = "Good", isLike = false },
                new ProductReview() { ProductId = 24, UserId = 8, Rating = 2, Review = "Bad", isLike = true },
                new ProductReview() { ProductId = 25, UserId = 12, Rating = 3, Review = "Average", isLike = false },
            };
            foreach (var list in productReviewlist)
            {
                Console.WriteLine("Product Id :" + list.ProductId + "\t" + "User Id :" + list.UserId + "\t" + "Rating :" + list.Rating + "\t" + "Review :" + list.Review + "\t" + "Is Like :" + list.isLike);
            }
            Console.ReadLine();
        }
    }
}


