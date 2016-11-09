/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Products
 * API Version: 2011-10-01
 * Library Version: 2015-09-01
 * Generated: Thu Sep 10 06:52:19 PDT 2015
 */

using MarketplaceWebServiceProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace MarketplaceWebServiceProducts
{

    /// <summary>
    /// Runnable sample code to demonstrate usage of the C# client.
    ///
    /// To use, import the client source as a console application,
    /// and mark this class as the startup object. Then, replace
    /// parameters below with sensible values and run.
    /// </summary>
    public class MarketplaceWebServiceProductsSample
    {
        string mswAuth = "amzn.mws.a6a6c2d9-6772-4770-feb6-6f980a690e29";
        string seller = "A2Z4SMPGO6SQTC";
        string marketplace = "ATVPDKIKX0DER";
        public static void Main(string[] args)
        {
            // TODO: Set the below configuration variables before attempting to run

            // Developer AWS access key
            string accessKey = "AKIAI6BSCXQFMX4KESMQ";

            // Developer AWS secret key
            string secretKey = "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";

            // The client application name
            string appName = "Vialinker";

            // The client application version
            string appVersion = "1.0";

            // The endpoint for region service and version (see developer guide)
            // ex: https://mws.amazonservices.com
            string serviceURL = "https://mws.amazonservices.com";

            // Create a configuration object
            MarketplaceWebServiceProductsConfig config = new MarketplaceWebServiceProductsConfig();
            config.ServiceURL = serviceURL;
            // Set other client connection configurations here if needed
            // Create the client itself
            MarketplaceWebServiceProducts client = new MarketplaceWebServiceProductsClient(appName, appVersion, accessKey, secretKey, config);

            MarketplaceWebServiceProductsSample sample = new MarketplaceWebServiceProductsSample(client);

            // Uncomment the operation you'd like to test here
            // TODO: Modify the request created in the Invoke method to be valid

            try
            {
                IMWSResponse response = null;
                // response = sample.InvokeGetCompetitivePricingForASIN();
                // response = sample.InvokeGetCompetitivePricingForSKU();
                // response = sample.InvokeGetLowestOfferListingsForASIN();
                // response = sample.InvokeGetLowestOfferListingsForSKU();
                // response = sample.InvokeGetLowestPricedOffersForASIN();
                // response = sample.InvokeGetLowestPricedOffersForSKU();
                // response = sample.InvokeGetMatchingProduct();
                // response = sample.InvokeGetMatchingProductForId();
                // response = sample.InvokeGetMyPriceForASIN();
                // response = sample.InvokeGetMyPriceForSKU();
                // response = sample.InvokeGetProductCategoriesForASIN();
                // response = sample.InvokeGetProductCategoriesForSKU();
                // response = sample.InvokeGetServiceStatus();
                response = sample.InvokeListMatchingProducts();
                Console.WriteLine("Response:");
                ResponseHeaderMetadata rhmd = response.ResponseHeaderMetadata;
                // We recommend logging the request id and timestamp of every call.
                Console.WriteLine("RequestId: " + rhmd.RequestId);
                Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                string responseXml = response.ToXML();
                responseXml = responseXml.Replace(" xmlns=\"http://mws.amazonservices.com/schema/Products/2011-10-01\"", "");
                WriteToTextFile(responseXml);

                Console.WriteLine(responseXml);
                Console.ReadKey();
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                // Exception properties are important for diagnostics.
                ResponseHeaderMetadata rhmd = ex.ResponseHeaderMetadata;
                Console.WriteLine("Service Exception:");
                if (rhmd != null)
                {
                    Console.WriteLine("RequestId: " + rhmd.RequestId);
                    Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                }
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("StatusCode: " + ex.StatusCode);
                Console.WriteLine("ErrorCode: " + ex.ErrorCode);
                Console.WriteLine("ErrorType: " + ex.ErrorType);
                throw ex;
            }
        }

        private static string GetAmazonItemListLINQ(string responseData)
        {
            XElement xmlDoc = XElement.Parse(responseData);
            return "Working";
        }

        private static void WriteToTextFile(string responseData)
        {
            string aa = "";
            int i = 1;
            List<AmazonItem> GetAmazonItemLists = new List<AmazonItem>();
            foreach (AmazonItem ai in GetAmazonItemLists)
            {
                aa += i + ". Product Information";
                aa += "ASIN: " + ai.ASIN;
                foreach (AmazonItemInfo aii in ai.AII)
                {
                    aa += "\r\nTitle: " + aii.Title;
                    aa += "\r\nManufacturer: " + aii.Manufacturer;
                    aa += "\r\nModel: " + aii.Model;
                    aa += "\r\nPublisher: " + aii.Publisher;
                    aa += "\r\nProduct Type: " + aii.ProductType;
                    aa += "\r\nProduct Group: " + aii.ProductGroup;
                    aa += "\r\nPart Number: " + aii.PartNumber;
                    aa += "\r\nQuantity: " + aii.Quantity;
                    aa += "\r\nSample Image: " + aii.SampleImage;
                    aa += "\r\nList Price: " + aii.ListPrice + "  " + aii.CurrencyCode;
                    aa += "\r\n----------------------------------------------------------------------------------\r\n\r\n";
                }
                i++;
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter("d:\\xml_data.txt");
            file.WriteLine(aa);
            file.Close();
            //End
        }

        private readonly MarketplaceWebServiceProducts client;

        public MarketplaceWebServiceProductsSample(MarketplaceWebServiceProducts client)
        {
            this.client = client;
        }

        public GetCompetitivePricingForASINResponse InvokeGetCompetitivePricingForASIN()
        {
            // Create a request.
            GetCompetitivePricingForASINRequest request = new GetCompetitivePricingForASINRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            ASINListType asinList = new ASINListType();
            request.ASINList = asinList;
            return this.client.GetCompetitivePricingForASIN(request);
        }

        public GetCompetitivePricingForSKUResponse InvokeGetCompetitivePricingForSKU()
        {
            // Create a request.
            GetCompetitivePricingForSKURequest request = new GetCompetitivePricingForSKURequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            SellerSKUListType sellerSKUList = new SellerSKUListType();
            request.SellerSKUList = sellerSKUList;
            return this.client.GetCompetitivePricingForSKU(request);
        }

        public GetLowestOfferListingsForASINResponse InvokeGetLowestOfferListingsForASIN()
        {
            // Create a request.
            GetLowestOfferListingsForASINRequest request = new GetLowestOfferListingsForASINRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            ASINListType asinList = new ASINListType();
            request.ASINList = asinList;
            string itemCondition = "example";
            request.ItemCondition = itemCondition;
            bool excludeMe = true;
            request.ExcludeMe = excludeMe;
            return this.client.GetLowestOfferListingsForASIN(request);
        }

        public GetLowestOfferListingsForSKUResponse InvokeGetLowestOfferListingsForSKU()
        {
            // Create a request.
            GetLowestOfferListingsForSKURequest request = new GetLowestOfferListingsForSKURequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            SellerSKUListType sellerSKUList = new SellerSKUListType();
            request.SellerSKUList = sellerSKUList;
            string itemCondition = "example";
            request.ItemCondition = itemCondition;
            bool excludeMe = true;
            request.ExcludeMe = excludeMe;
            return this.client.GetLowestOfferListingsForSKU(request);
        }

        public GetLowestPricedOffersForASINResponse InvokeGetLowestPricedOffersForASIN()
        {
            // Create a request.
            GetLowestPricedOffersForASINRequest request = new GetLowestPricedOffersForASINRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string asin = "example";
            request.ASIN = asin;
            string itemCondition = "example";
            request.ItemCondition = itemCondition;
            return this.client.GetLowestPricedOffersForASIN(request);
        }

        public GetLowestPricedOffersForSKUResponse InvokeGetLowestPricedOffersForSKU()
        {
            // Create a request.
            GetLowestPricedOffersForSKURequest request = new GetLowestPricedOffersForSKURequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string sellerSKU = "example";
            request.SellerSKU = sellerSKU;
            string itemCondition = "example";
            request.ItemCondition = itemCondition;
            return this.client.GetLowestPricedOffersForSKU(request);
        }

        public GetMatchingProductResponse InvokeGetMatchingProduct()
        {
            // Create a request.
            GetMatchingProductRequest request = new GetMatchingProductRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            ASINListType asinList = new ASINListType();
            request.ASINList = asinList;
            return this.client.GetMatchingProduct(request);
        }

        public GetMatchingProductForIdResponse InvokeGetMatchingProductForId()
        {
            // Create a request.
            GetMatchingProductForIdRequest request = new GetMatchingProductForIdRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string idType = "example";
            request.IdType = idType;
            IdListType idList = new IdListType();
            request.IdList = idList;
            return this.client.GetMatchingProductForId(request);
        }

        public GetMyPriceForASINResponse InvokeGetMyPriceForASIN()
        {
            // Create a request.
            GetMyPriceForASINRequest request = new GetMyPriceForASINRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            ASINListType asinList = new ASINListType();
            request.ASINList = asinList;
            return this.client.GetMyPriceForASIN(request);
        }

        public GetMyPriceForSKUResponse InvokeGetMyPriceForSKU()
        {
            // Create a request.
            GetMyPriceForSKURequest request = new GetMyPriceForSKURequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            SellerSKUListType sellerSKUList = new SellerSKUListType();
            request.SellerSKUList = sellerSKUList;
            return this.client.GetMyPriceForSKU(request);
        }

        public GetProductCategoriesForASINResponse InvokeGetProductCategoriesForASIN()
        {
            // Create a request.
            GetProductCategoriesForASINRequest request = new GetProductCategoriesForASINRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string asin = "example";
            request.ASIN = asin;
            return this.client.GetProductCategoriesForASIN(request);
        }

        public GetProductCategoriesForSKUResponse InvokeGetProductCategoriesForSKU()
        {
            // Create a request.
            GetProductCategoriesForSKURequest request = new GetProductCategoriesForSKURequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string sellerSKU = "example";
            request.SellerSKU = sellerSKU;
            return this.client.GetProductCategoriesForSKU(request);
        }

        public GetServiceStatusResponse InvokeGetServiceStatus()
        {
            // Create a request.
            GetServiceStatusRequest request = new GetServiceStatusRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            return this.client.GetServiceStatus(request);
        }

        public ListMatchingProductsResponse InvokeListMatchingProducts()
        {
            // Create a request.
            ListMatchingProductsRequest request = new ListMatchingProductsRequest();
            //string sellerId = "example";
            request.SellerId = seller;
            //string mwsAuthToken = "example";
            request.MWSAuthToken = mswAuth;
            //string marketplaceId = "example";
            request.MarketplaceId = marketplace;
            string query = "mobile";
            request.Query = query;
            //string queryContextId = "example";
            //request.QueryContextId = queryContextId;
            return this.client.ListMatchingProducts(request);
        }
    }

    public class AmazonItem
    {
        public string ASIN { get; set; }
        public List<AmazonItemInfo> AII { get; set; }
    }

    public class AmazonItemInfo
    {
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Publisher { get; set; }
        public string ProductType { get; set; }
        public string ProductGroup { get; set; }
        public string PartNumber { get; set; }
        public string Quantity { get; set; }
        public string SampleImage { get; set; }
        public string ListPrice { get; set; }
        public string CurrencyCode { get; set; }
    }
}
