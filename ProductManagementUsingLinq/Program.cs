using ProductManagementSystemUsingLinq;

Console.WriteLine("Product Review Management");

List<ProductReview> productreview = new List<ProductReview>()
{
    new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Poor",isLike=true},
    new ProductReview(){ProductID=2,UserID=2,Rating=3,Review="OK",isLike=true},
    new ProductReview(){ProductID=3,UserID=3,Rating=4,Review="Good",isLike=true},
    new ProductReview(){ProductID=4,UserID=4,Rating=4,Review="Avg",isLike=true},
    new ProductReview(){ProductID=5,UserID=5,Rating=2,Review="Poor",isLike=false},
    new ProductReview(){ProductID=6,UserID=6,Rating=3,Review="OK",isLike=true},
    new ProductReview(){ProductID=7,UserID=7,Rating=4,Review="Good",isLike=true},
    new ProductReview(){ProductID=8,UserID=8,Rating=3,Review="Avg",isLike=true},
    new ProductReview(){ProductID=9,UserID=1,Rating=2,Review="Poor",isLike=true},
    new ProductReview(){ProductID=10,UserID=2,Rating=3,Review="OK",isLike=true},
    new ProductReview(){ProductID=11,UserID=3,Rating=4,Review="Good",isLike=true},
    new ProductReview(){ProductID=12,UserID=4,Rating=3,Review="Avg",isLike=true},
    new ProductReview(){ProductID=13,UserID=5,Rating=2,Review="Poor",isLike=false},
    new ProductReview(){ProductID=14,UserID=6,Rating=3,Review="OK",isLike=true},
    new ProductReview(){ProductID=15,UserID=7,Rating=4,Review="Good",isLike=true},
    new ProductReview(){ProductID=16,UserID=8,Rating=3,Review="Avg",isLike=true},
    new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Poor",isLike=true},
    new ProductReview(){ProductID=2,UserID=2,Rating=3,Review="OK",isLike=true},
    new ProductReview(){ProductID=3,UserID=3,Rating=4,Review="Good",isLike=true},
    new ProductReview(){ProductID=4,UserID=4,Rating=3,Review="Avg",isLike=true},
    new ProductReview(){ProductID=5,UserID=5,Rating=2,Review="Poor",isLike=false},
    new ProductReview(){ProductID=6,UserID=6,Rating=3,Review="OK",isLike=true},
    new ProductReview(){ProductID=7,UserID=7,Rating=4,Review="Good",isLike=true},
    new ProductReview(){ProductID=8,UserID=8,Rating=3,Review="Avg",isLike=true},
    new ProductReview(){ProductID=9,UserID=1,Rating=2,Review="Poor",isLike=true},

};
productreview.Add(new ProductReview() { ProductID = 10, UserID = 2, Rating = 3, Review = "OK", isLike = true });

Management management = new Management();
//UC-2 Get Top Records
//management.GetTopRecordsList(productreview);

//UC-3 Get Selected Records
//management.SelectedRecords(productreview);

//UC-4 Count Records 
//management.CountRecords(productreview);

//UC-5 Retrieve Selected Columns
management.RetrieveOnlytwoColumns(productreview);

//UC-6 Skip Top 5 Records
//management.SkipRecords(productreview);