﻿using System.Collections.Generic;
using _0_Framework.Domain;

namespace ShopManagement.Domain.OrderAgg
{
    public class Order : EntityBase
    {
        public long AccountId { get; private set; }
        public int PaymentMethod { get; private set; }
        public double TotalAmount { get; private set; }
        public double DiscountAmount { get; private set; }
        public double PayAmount { get; private set; }
        public bool IsPaied { get; private set; }
        public bool IsCanceled { get; private set; }
        public string IssueTrackingNo { get; private set; }
        public long RefId { get; private set; }
        public List<OrderItem> Items { get; private set; }

        public Order(long accountId,int paymentMethod, double totalAmount, double discountAmount, double payAmount)
        {
            AccountId = accountId;
            PaymentMethod = paymentMethod;
            TotalAmount = totalAmount;
            DiscountAmount = discountAmount;
            PayAmount = payAmount;
            IsCanceled = false;
            IsPaied = false;
            RefId = 0;
            Items = new List<OrderItem>();
        }

        public void PaymentSucceded(long refId)
        {
            IsPaied = true;
            if (refId != 0)
            {
                RefId = refId;

            }
        }

        public void SetIssueTrackingNo(string number)
        {
            this.IssueTrackingNo = number;
        }

        public void Cancel()
        {
            IsCanceled = true;
        }

        public void AddItem(OrderItem item)
        {
            this.Items.Add(item);
        }
    }
}
