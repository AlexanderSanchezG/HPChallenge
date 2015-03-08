using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication1.Services;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ChampionshipController : ApiController
    {

        private ChampionshipRepository contactRepository;

        public ChampionshipController()
        {
            this.contactRepository = new ChampionshipRepository();
        }

        public Player[] Get()
        {
            return contactRepository.GetAllPlayers();
        }

        /// <summary>
        /// metodo creado para el post
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public HttpResponseMessage Post(Player player)
        {
            this.contactRepository.SaveContact(player);

            var response = Request.CreateResponse<Player>(System.Net.HttpStatusCode.Created, player);

            return response;
        }


        
        

        //json basic format test 01
        /**public Contact[] Get()
        {
            return new Contact[]
        {
            new Contact
            {
                Id = 1,
                Name = "Glenn Block"
            },
            new Contact
            {
                Id = 2,
                Name = "Dan Roth"
            }
        };
        }*/

    }
}
