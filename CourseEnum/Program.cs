using CourseEnum.Entities;
using System;
using CourseEnum.Entities.Enums;

namespace CourseEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
        Console.WriteLine(order);
        }
    }
}
