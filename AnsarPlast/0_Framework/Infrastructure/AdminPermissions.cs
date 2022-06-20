using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Infrastructure
{
    public class AdminPermissions
    {
        //Product
        public const int ListProducts = 10;
        public const int SearchProducts = 11;
        public const int CreateProduct = 12;
        public const int EditProduct = 13;


        //ProductCategory
        public const int ListProductCategories = 20;
        public const int SearchProductCategories = 21;
        public const int CreateProductCategory = 22;
        public const int EditProductCategory = 23;

        //Slider
        public const int ListSlider = 30;
        public const int SearchSlider = 31;
        public const int CreateSlider = 32;
        public const int EditSlider = 33;
        public const int DeleteSlider = 34;


        //ProductPicture
        public const int ListProductPicture = 40;
        public const int SearchProductPicture = 41;
        public const int CreateProductPicture = 42;
        public const int EditProductPicture = 43;
        public const int DeleteProductPicture = 44;


        //Inventory
        public const int ListInventory = 50;
        public const int SearchInventory = 51;
        public const int CreateInventory = 52;
        public const int EditInventory = 53;
        public const int IncreaseInventory = 54;
        public const int ReduceInventory = 55;
        public const int InventoryOperationLog = 56;

        //Order
        public const int ListOrder = 60;
        public const int SearchOrder = 61;
        public const int ItemOrder = 62;
        public const int SubmitOrder = 63;
        public const int CancelOrder = 64;


        //Customer Discount
        public const int ListCustomerDiscount = 70;
        public const int SearchCustomerDiscount = 71;
        public const int DefineCustomerDiscount = 72;
        public const int EditCustomerDiscount = 73;


        //Colleague Discount
        public const int ListColleagueDiscount = 80;
        public const int SearchColleagueDiscount = 81;
        public const int DefineColleagueDiscount = 82;
        public const int EditColleagueDiscount = 83;


        //Comment
        public const int ListComment = 90;
        public const int ConfirmComment = 91;
        public const int CancelComment = 92;
        public const int SearchComment = 93;


        //Article
        public const int ListArticles = 100;
        public const int SearchArticles = 101;
        public const int CreateArticle = 102;
        public const int EditArticle = 103;


        //ArticleCategory
        public const int ListArticleCategories = 110;
        public const int SearchArticleCategories = 111;
        public const int CreateArticleCategory = 112;
        public const int EditArticleCategory = 113;


        //Account Role 
        public const int ListRole = 120;
        public const int SearchRole = 121;
        public const int CreateRole = 122;
        public const int EditRole = 123;

        //Account 
        public const int ListAccount = 130;
        public const int SearchAccount = 131;
        public const int CreateAccount = 132;
        public const int EditAccount = 133;
        public const int ChangePasswordAccount = 134;


        //Banner
        public const int ListBanner = 140;
        public const int SearchBanner = 141;
        public const int CreateBanner = 142;
        public const int EditBanner = 143;
        public const int DeleteBanner = 144;

        //DiscountCode
        public const int ListDiscountCode = 150;
        public const int SearchDiscountCode = 151;
        public const int DefineDiscountCode = 152;
        public const int EditDiscountCode = 153;

        //OfferBanner
        public const int ListOfferBanner = 160;
        public const int SearchOfferBanner = 161;
        public const int CreateOfferBanner = 162;
        public const int EditOfferBanner = 163;
        public const int DeleteOfferBanner = 164;
        
        //ProductFeatures
        public const int ListProductFeatures = 170;
        public const int CreateProductFeatures = 172;
        public const int EditProductFeatures = 173;
        public const int DeleteProductFeatures = 174;
    }
}
