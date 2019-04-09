using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSOrderManagementNew.Business;
using CQRSOrderManagementNew.Command;
using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using CQRSOrderManagementNew.Model;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CQRSOrderManagementNew.Controllers
{
    public class OrderController : Controller
    {
        private readonly ISendEndpoint _bus;
        private readonly IConfiguration _configuration;
        private readonly IOrderReadManager _orderReadManager;
        public OrderController(IOrderReadManager orderReadManager, IConfiguration configuration)
        {
            _orderReadManager = orderReadManager;
            _configuration = configuration;

            var busControl = new BusConfigurator(_configuration).ConfigureBus();
            var uriRabbitMq = MqConstants.RabbitMQUri + _configuration["OrderQueueName"];
            var sendToUri = new Uri(uriRabbitMq);

            _bus = busControl.GetSendEndpoint(sendToUri).Result;
        }
        // GET: Order
        public ActionResult Index()
        {
            var list = _orderReadManager.GetOrders();
            var model = list.Select(p => new OrderModel()
            {
                Amount = p.Amount,
                OrderCode = p.OrderCode,
                OrderId = p.Id,
                Status = p.Status.GetDescription()
            }
            ).ToList();
            return View(model);
        }


        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderMain order)
        {
            try
            {
                //IOrderCommand createOrderCommand = new CreateOrder(order);
                IOrderData orderData = new OrderData
                {
                    OrderCode = order.OrderCode,
                    Status =  OrderStatus.Pending.GetDescription(),
                    Amount = order.Amount,
                    CommandType = CommandType.Create
                     
                };
                // TODO: Add insert logic here
                _bus.Send(orderData).Wait();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Create()
        {
            return View();
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            OrderMain order = _orderReadManager.GetOrderById(id);
            var model = new OrderModel()
            {
                OrderId = order.Id,
                Status = order.Status.GetDescription(),
                Amount = order.Amount,
                OrderCode = order.OrderCode
            };
            return View(model);

        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrderMain order)
        {
            try
            {

                IOrderData orderData = new OrderData
                {
                    Amount = order.Amount,
                    OrderCode = order.OrderCode,
                    Status = order.Status.GetDescription(),
                    CommandType = CommandType.Update,
                    Id = id
                };
                // TODO: Add update logic here
                _bus.Send(orderData).Wait();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int orderId)
        {
            OrderMain order = _orderReadManager.GetOrderById(orderId);
            return new JsonResult(order);

        }

        // POST: Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, OrderMain order)
        {
            try
            {
                //IOrderCommand createOrderCommand = new DeleteOrder(id);
                //// TODO: Add delete logic here
                IOrderData orderData = new OrderData
                {
                    Amount = order.Amount,
                    OrderCode = order.OrderCode,
                    Status = order.Status.GetDescription(),
                    CommandType = CommandType.Delete,
                    Id = id
                };
                // TODO: Add update logic here
                _bus.Send(orderData).Wait();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}