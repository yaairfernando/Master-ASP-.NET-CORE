﻿using Spice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Utility
{
    public class SD
    {
        public const string DefaultFoodImage = "default_food.png";

        public const string ManagerUser = "Manager";

        public const string KitchenUser = "Kitchen";

        public const string FrontDeskUser = "FrontDesk";

        public const string CustomerEndUser = "Customer";

        public const string ssShoppingCartCount = "ssCartCount";
        public const string ssCouponCode = "ssCouponCode";

        public const string StatusSubmitted = "Submitted";
        public const string StatusInProcess = "Being Prepared";
        public const string StatusReady = "Ready for Pickup";
        public const string StatusCompleted = "Completed";
        public const string StatusCancelled = "Cancelled";

        public const string PaymentStatusPendeing = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusRejected = "Rejected";

















        public static string ConvertToRawHtml(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }

        public static double DicountedPrice(Cupon couponFromDB, double OriginalOrderTotal)
        {
            if (couponFromDB == null)
            {
                return OriginalOrderTotal;
            }
            else
            {
                if (couponFromDB.MinimumAmount > OriginalOrderTotal)
                {
                    return OriginalOrderTotal;
                }
                else
                {
                    //everything is valid
                    if (Convert.ToInt32(couponFromDB.CupontType) == (int)Cupon.ECuponType.Dollar)
                    {
                        //$10 off $100
                        return Math.Round(OriginalOrderTotal - couponFromDB.Discount, 2);
                    }
                        if (Convert.ToInt32(couponFromDB.CupontType) == (int)Cupon.ECuponType.Percent)
                        {
                            //10% off $100
                            return Math.Round(OriginalOrderTotal - (OriginalOrderTotal * couponFromDB.Discount/100), 2);
                        }
                }
            }
            return OriginalOrderTotal;
        }
    }
}