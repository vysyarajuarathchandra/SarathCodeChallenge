using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SarathCodeChallenge.DTOs;
using SarathCodeChallenge.Entites;
using SarathCodeChallenge.Services;

namespace SarathCodeChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        public OrderController(IOrderService orderService, IMapper mapper, IConfiguration configuration)
        {
            this.orderService = orderService;
            this.mapper = mapper;
            this.configuration = configuration;
        }
    }
  

    }
