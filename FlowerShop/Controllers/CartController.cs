using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlowerShop.Models;

namespace FlowerShop.Controllers
{
    public class CartController : ApiController
    {
        //get user by id
        [Route("api/getUserCart/{cId}")]
        [HttpGet]
        public IHttpActionResult Get(int cId)
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.getUserCart(cId));
        }


        //clear  user cart by id
        [Route("api/clearUserCart/{cId}")]
        [HttpGet]
        public IHttpActionResult clear(int cId)
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.clearUserCart(cId));
        }


        
        //deleteUser_clearCart  user cart by id
        [Route("api/deleteUser_clearCart/{cId}")]
        [HttpGet]
        public IHttpActionResult deleteUser_clearCart(int cId)
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.deleteUser_clearCart(cId));
        }


        //setCartProductAmount
        [Route("api/setCartProductAmount/{clietnId}/{productId}/{Amount}")]
        [HttpGet]
        public IHttpActionResult Get(int clietnId, int productId, int Amount)
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.SetCartProductAmount(clietnId, productId, Amount));
        }


        //AdminSetCartProductAmount
        [Route("api/AdminSetCartProductAmount/{clietnId}/{productId}/{Amount}")]
        [HttpGet]
        public IHttpActionResult AdminSetCartProductAmount(int clietnId, int productId, int Amount)
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.AdminSetCartProductAmount(clietnId, productId, Amount));
        }

        //addCartProduct
        [Route("api/addCartProduct/{clietnId}/{productId}/{Amount}")]
        [HttpGet]
        public IHttpActionResult Get2(int clietnId, int productId, int Amount)
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.addCartProduct(clietnId, productId, Amount));
        }


        
        //adminAddCartProduct (add item and get all table)
        [Route("api/adminAddCartProduct/{clietnId}/{productId}/{Amount}")]
        [HttpGet]
        public IHttpActionResult adminAddCartProduct(int clietnId, int productId, int Amount)
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.adminAddCartProduct(clietnId, productId, Amount));
        }



        //getAllTable
        [Route("api/getAllTable")]
        [HttpGet]
        public IHttpActionResult Get3()
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.getAllTable());
        }

        //removeCartItem
        [Route("api/removeCartItem/{clietnId}/{productId}")]
        [HttpGet]
        public IHttpActionResult Get4(int clietnId, int productId)
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.removeCartItem(clietnId, productId));
        }


        //AdminRemoveCartItem
        [Route("api/AdminRemoveCartItem/{clietnId}/{productId}")][HttpGet]
        public IHttpActionResult AdminRemoveCartItem(int clietnId, int productId)
        {
            ConnectionCart cU = new ConnectionCart();
            return Ok(cU.AdminRemoveCartItem(clietnId, productId));
        }
    }
}
