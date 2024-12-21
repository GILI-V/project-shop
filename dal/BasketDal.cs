using dal.models1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class BasketDal : IBasketDal
    {
        //private readonly Angular1Context _context;

        //public async Task<bool> AddOrderItemAsync(Purchase purchase, Customer customer)
        //{

        //        //var o = orderItem;
        //        try
        //        {

        //            var purch = await _context.Customers.FirstOrDefaultAsync(p => p.CustomerCode == purchase.CustomerCode && customer.CustomerCode ==);
        //            //var gift = await _context.Gifts.FirstOrDefaultAsync(g => g.GiftId == PurchaseDetail.GiftId);
        //            var gif = await _context.PurchaseDetails.FirstOrDefaultAsync(gi => gi.GiftId == orderItem.GiftId && gi.OrderId == order.OrderId);


        //            orderItem.OrderId = order.OrderId;


        //            if (order != null && gift != null)
        //                order.OrderSum += gift.GiftTicketCost * orderItem.Quantity;
        //            _dbSale.Orders.Update(order);

        //            if (gif != null)
        //            {
        //                //var qua = await _dbSale.OrderItem.FirstOrDefaultAsync(q => q.OrderId == orderItem.OrderId);
        //                //qua.Quantity += orderItem.Quantity;
        //                gif.Quantity += orderItem.Quantity;


        //                //orderItem.Quantity += o.Quantity;
        //                //await _dbSale.OrderItem.Q
        //                //await _dbSale.SaveChangesAsync();
        //                _dbSale.OrderItem.Update(gif);

        //                await _dbSale.SaveChangesAsync();

        //            }
        //            else
        //            {
        //                await _dbSale.OrderItem.AddAsync(orderItem);

        //                await _dbSale.SaveChangesAsync();

        //            }

        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Logging from Donation , the exception" + ex.Message);
        //        }
        //    }

        //    public async Task<List<object>> GetGiftOrderIdsByIdAsync(User user)
        //    {
        //        var result = from oi in _dbSale.OrderItem
        //                     join g in _dbSale.Gifts on oi.GiftId equals g.GiftId
        //                     join o in _dbSale.Orders on oi.OrderId equals o.OrderId
        //                     where o.UserId == user.UserId
        //                     group new { oi, g } by oi.GiftId into grp
        //                     select new
        //                     {
        //                         GiftId = grp.Key,
        //                         OrderId = string.Join(",", grp.Select(x => x.oi.OrderId)),
        //                         GiftName = string.Join(",", grp.Select(x => x.g.GiftName)),
        //                         GiftUrlimage = string.Join(",", grp.Select(x => x.g.GiftUrlimage)),
        //                         GiftTicketCost = string.Join(",", grp.Select(x => x.g.GiftTicketCost)),
        //                         Quantity = string.Join(",", grp.Select(x => x.oi.Quantity)),

        //                     };

        //        return await result.Cast<object>().ToListAsync();
        //    }
        //}
    }
}
