using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlowerShop.Models;

namespace FlowerShop.Controllers
{
    public class FlowerController : ApiController
    {

        // GET: api/Flowers
        [Route("api/getFlowers")][HttpGet]
        public IHttpActionResult Get()
        {
            connectionF cf = new connectionF();
            return Ok(cf.getFlowers());
        }

        //get flower by Name
        [Route("api/getFlower/{name}")][HttpGet]
        public IHttpActionResult Get(string name)
        {
            connectionF cf = new connectionF();
            return Ok(cf.getFlower(name));
        }

        //setAmount
        [Route("api/setAmount/{nameF}/{amountF}")]
        [HttpGet]
        public IHttpActionResult Get(string nameF, int amountF)
        {
            connectionF cf = new connectionF();
            return Ok(cf.setAmount(nameF, amountF));
        }
        //setPrice_Amount(string nameFlower,int amount)
        [Route("api/setPrice_Amount/{nameF}/{priceF}/{amountF}")][HttpGet]
        public IHttpActionResult Get(string nameF,int priceF,int amountF)
        {
            connectionF cf = new connectionF();
            return Ok(cf.setPrice_Amount(nameF,priceF, amountF)); 
        }


        //addflower(id,name,price,amount)
        [Route("api/addFlower/{idF}/{nameF}/{priceF}/{amountF}")]
        [HttpGet]
        public IHttpActionResult addFlower(int idF, string nameF, int priceF, int amountF)
        {
            connectionF cf = new connectionF();
            return Ok(cf.addFlower(idF,nameF, priceF, amountF));
        }

        //remFlower(nameF)
        [Route("api/remFlower/{nameF}")]
        [HttpGet]
        public IHttpActionResult remFlower(string nameF)
        {
            connectionF cf = new connectionF();
            return Ok(cf.remFlower(nameF));
        }




    }
}
