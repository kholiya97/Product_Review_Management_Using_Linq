﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management_Using_Linq
{
    class ReviewTable
    {

        public static DataTable table = new DataTable();

        /// UC8: Add data into data table.

        public static void AddDataIntoDataTable()
        {

            ///Adding column in DataTable
            table.Columns.Add("ProductId", typeof(Int32));
            table.Columns.Add("UserId", typeof(Int32));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));
            ///Adding rows in DataTable
            table.Rows.Add(101, 1, 1, "Low", true);
            table.Rows.Add(102, 2, 1, "Low", false);
            table.Rows.Add(103, 3, 4, "Good", true);
            table.Rows.Add(104, 4, 5, "Nice", true);
            table.Rows.Add(105, 5, 4, "Good", true);
            table.Rows.Add(106, 6, 3, "Average", true);
            table.Rows.Add(104, 7, 5, "Nice", true);
            table.Rows.Add(105, 8, 3, "Average", true);
            //Printing data
            Console.WriteLine("\nDataTable contents:");
            foreach (var list in table.AsEnumerable())
            {
                Console.WriteLine("Product Id :" + list.Field<int>("ProductId") + "\t" + "User Id :" + list.Field<int>("UserId") + "\t" + "Rating ;" + list.Field<double>("Rating") + "\t" + "Review :" + list.Field<string>("Review") + "\t" + "Is Like :" + list.Field<bool>("IsLike"));
            }
        }
        // UC10 Finds the average rating for each productId.
        public static void FindAverageRatingOfTheEachProductId()
        {
            var records = table.AsEnumerable().GroupBy(r => r.Field<int>("ProductId")).Select(r => new { ProductId = r.Key, Average = r.Average(z => (z.Field<double>("Rating"))) });
            Console.WriteLine("\nProductId and its average rating");
            foreach (var v in records)
            {
                Console.WriteLine($"ProductID:{v.ProductId},AverageRating:{v.Average}");
            }
        }
    }
}