using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystemUC_1
{
    public class Management
    {
        public void GetTopRecordsList(List<ProductReview> review)
        {
            var RecordData = (from productreviews in review
                              orderby productreviews.Rating descending
                              select productreviews).Take(3);
            foreach (var record in RecordData)
            {
                Console.WriteLine($"ProductID: {record.ProductID} UserID: {record.UserID} Rating: {record.Rating} " +
                    $"Review: {record.Review} isLike: {record.isLike} ");
            }
        }
        public void SelectedRecords(List<ProductReview> review)
        {
            var recordData = (from productreview in review
                              where (((productreview.ProductID == 1) || (productreview.ProductID == 4) || (productreview.ProductID == 9)) && productreview.Rating > 3)
                              select productreview);
            foreach (var record in recordData)
            {
                Console.WriteLine($"ProductID: {record.ProductID} UserID: {record.UserID} Rating: {record.Rating} " +
                    $"Review: {record.Review} isLike: {record.isLike} ");
            }

        }
        public void CountRecords(List<ProductReview> review)
        {
            var countData = review.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var record in countData)
            {
                Console.WriteLine($"ProductID: {record.ProductID} Count: {record.Count}  ");
            }
        }
        public void RetrieveOnlytwoColumns(List<ProductReview> review)
        {
            var result = (from productreview in review
                          select productreview);
            foreach (var record in result)
            {
                Console.WriteLine($"ProductID: {record.ProductID} Review: {record.Review}  ");
            }
        }
        public void SkipRecords(List<ProductReview> review)
        {
            var recordData = (from productreview in review
                              select productreview).Skip(5);
            foreach (var record in recordData)
            {
                Console.WriteLine($"ProductID: {record.ProductID} UserID: {record.UserID} Rating: {record.Rating} " +
                    $"Review: {record.Review} isLike: {record.isLike} ");
            }

        }
    }
}
