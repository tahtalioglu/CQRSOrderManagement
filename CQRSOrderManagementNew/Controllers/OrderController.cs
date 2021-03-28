using System.Collections.Generic;
using System.Linq;
using CQRSOrderManagementNew.Command;
using CQRSOrderManagementNew.Core;
using CQRSOrderManagementNew.Data;
using CQRSOrderManagementNew.Model;
using CQRSOrderManagementNew.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSOrderManagementNew.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: Order
        public ActionResult Index()
        {
            IList<OrderMain> list = _mediator.Send(new GetAllOrdersQuery()).Result;

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
        public ActionResult Create(CreateOrder order)
        {
            try
            {
                _mediator.Send(order);
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            OrderMain order = _mediator.Send(new GetOrderByIdQuery(id)).Result; 

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
        public ActionResult Edit(int id, UpdateOrder order)
        {
            try
            {
                _mediator.Send(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        [HttpGet]
        public ActionResult Delete(int orderId)
        {
            OrderMain order = _mediator.Send(new GetOrderByIdQuery(orderId)).Result;

            return new JsonResult(order);

        }

        // POST: Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, DeleteOrder order)
        {
            try
            {
                _mediator.Send(order);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}