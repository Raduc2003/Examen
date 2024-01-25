
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReactApp1.Server.Contexts;
using ReactApp1.Server.DTOs;
using ReactApp1.Server.Entities;
using ReactApp1.Server.Repositories;

namespace ReactApp1.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _autoMapper;
        private readonly IUserRepository _userRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IProductInOrderRepository _productInOrderRepository;
        private readonly IProductRepository _productRepository;
        public GenericController(ApplicationContext context,IUserRepository userRepository,IMapper autoMapper,IOrderRepository orderRepository,IProductInOrderRepository productInOrderRepository,IProductRepository productRepository)
        {
            _context = context;
            _userRepository = userRepository;
            _autoMapper = autoMapper;
            _orderRepository = orderRepository;
            _productInOrderRepository = productInOrderRepository;
            _productRepository = productRepository;

        }
        [HttpGet("users")]
        public async Task<List<UserDTO>> GetUsers()
        {
            var users = await _userRepository.GetUsersAsync();
            var usersDTO = _autoMapper.Map<List<UserDTO>>(users);
            return usersDTO;
        }
        [HttpGet("orders")]
        public async Task<IEnumerable<OrderDTO>> GetOrders()
        {

            var orders = await _orderRepository.GetOrdersAsync();
            var ordersDTO = _autoMapper.Map<List<OrderDTO>>(orders);
            return ordersDTO;

        }
        [HttpGet("piorders")]
        public async Task<IEnumerable<ProductInOrderDTO>> GetProductInOrder()
        {

            var piorders = await _productInOrderRepository.GetProductInOrdersAsync();
            var piordersDTO = _autoMapper.Map<List<ProductInOrderDTO>>(piorders);

            return piordersDTO;

        }
        [HttpGet("products")]
        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {

            var products = await _productRepository.GetProductsAsync();
            var productsDTO = _autoMapper.Map<List<ProductDTO>>(products);
            return productsDTO;

        }
        //posts

        [HttpPost("users")]
        public async Task<ActionResult<UserDTO>> PostUser(UserDTO userDTO)
        {
            var user = _autoMapper.Map<User>(userDTO);
            await _userRepository.AddUserAsync(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsers), new { id = user.UserId }, userDTO);
        }
        [HttpPost("orders")]

        public async Task<ActionResult<OrderDTO>> PostOrder(OrderDTO orderDTO)
        {
            var order = _autoMapper.Map<Order>(orderDTO);
            await _orderRepository.AddOrderAsync(order);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOrders), new { id = order.OrderId }, orderDTO);
        }    
        [HttpPost("piorders")]

        public async Task<ActionResult<ProductInOrderDTO>> PostProductInOrder(ProductInOrderDTO productInOrderDTO)
        {
            var productInOrder = _autoMapper.Map<ProductInOrder>(productInOrderDTO);
            await _productInOrderRepository.AddProductInOrderAsync(productInOrder);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProductInOrder), new { id = productInOrder.ProductId }, productInOrderDTO);
        }

        [HttpPost("products")]

        public async Task<ActionResult<ProductDTO>> PostProduct(ProductDTO productDTO)
        {
            var productEntity = _autoMapper.Map<Product>(productDTO);
            var createdProduct = await _productRepository.AddProductAsync(productEntity);

            var createdProductDTO = _autoMapper.Map<ProductDTO>(createdProduct);
            await _context.SaveChangesAsync();

            return Ok(createdProductDTO);
        }
    }
    
    
}