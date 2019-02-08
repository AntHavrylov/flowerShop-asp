using FlowerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FlowerShop.Controllers
{
    public class UserController : ApiController
    {
        //get users
        [Route("api/getUsers")][HttpGet]
        public IHttpActionResult Get()
        {
            connectionU cU = new connectionU();
            return Ok(cU.getUsers());
        }


        //get maxId
        [Route("api/getMaxId")][HttpGet]
        public IHttpActionResult getMaxId()
        {
            connectionU cU = new connectionU();
            return Ok(cU.getMaxId());
        }

        //add user
        [Route("api/addUser/{userId}/{userLogin}/{userPass}/{userMail}")][HttpGet]
        public IHttpActionResult addUser(int userId, string userLogin, string userPass, string userMail)
        {
            connectionU cU = new connectionU();
            return Ok(cU.addUser(userId, userLogin, userPass, userMail));
        }

        //update user
        [Route("api/upUser/{userId}/{userLogin}/{userPass}/{userMail}")]
        [HttpGet]
        public IHttpActionResult upUser(int userId, string userLogin, string userPass, string userMail)
        {
            connectionU cU = new connectionU();
            return Ok(cU.upUser(userId, userLogin, userPass, userMail));
        }

        //getUserByName user
        [Route("api/getUserByName/{userLogin}")]
        [HttpGet]
        public IHttpActionResult get(string userLogin)
        {
            connectionU cU = new connectionU();
            return Ok(cU.getUserByName(userLogin));
        }

        //remove user
        [Route("api/remUser/{userId}")][HttpGet]
        public IHttpActionResult rem(int userId)
        {
            connectionU cU = new connectionU();
            return Ok(cU.remUser(userId));
        }


    }
}
