using medicloud.emr.api.DTOs;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderListingController : ControllerBase
    {
        private readonly IOrderListingRepository _orderListRepository;
        private ISetupRepository setup;
        public OrderListingController(IOrderListingRepository orderListRepository, ISetupRepository setup)
        {
            _orderListRepository = orderListRepository;
            this.setup = setup;
        }

        [HttpGet, Route("GetOrdersList")]
        public async Task<IActionResult> GetOrdersList(int accountId)
        {
            try
            {
                var services = await _orderListRepository.GetOrderListing(accountId);
                return Ok(services);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("AllOrderType")]
        [HttpGet]
        public async Task<IActionResult> GetAllOrderType([FromQuery]int accountId)
        {
            return Ok(setup.GetOrderTypeList(accountId).Result);
        }


        [Route("GetAllTypeDetails")]
        [HttpGet]
        public async Task<IActionResult> GetAllOrderTypeDetails([FromQuery]int accountId, [FromQuery] int ordertypeid=0,[FromQuery]string searchWord="")
        {
            return Ok(await setup.FilterOrderDetails(accountId, searchWord, ordertypeid));
        }

        [HttpPost("CreateOrderList")]
        public async Task<IActionResult> CreateOrderList(OrderListDto model)
        {
            try
            {
                await _orderListRepository.AddOrderListing(model.OrderListings);
                var status = true;
                return Ok(status);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }

        [HttpGet("DeleteOrderList")]
        public async Task<IActionResult> DeleteOrderList(int accountId, int orderListId)
        {
            try
            {
                await _orderListRepository.DeleteOrderListingById(accountId, orderListId);
                return Ok();
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }
    }
}
