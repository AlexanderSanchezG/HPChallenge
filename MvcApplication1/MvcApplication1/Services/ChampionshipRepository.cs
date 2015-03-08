using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.Services
{
    public class ChampionshipRepository
    {
        #region definitions

        private const string CacheKey = "ChampionshipStore";

        #endregion

        #region Methods

        /// <summary>
        /// constructor
        /// </summary>
        public ChampionshipRepository()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                if (ctx.Cache[CacheKey] == null)
                {
                    var contacts = new Player[]
                    {
                        new Player
                        {
                             strategy = "P", Name = "Glenn Block"
                        },
                        new Player
                        {
                            strategy = "R", Name = "Dan Roth"
                        }
                    };

                    ctx.Cache[CacheKey] = contacts;
                }
            }
        }

        /// <summary>
        /// get all the elements of an object
        /// </summary>
        /// <returns></returns>
        public Player[] GetAllPlayers()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                return (Player[])ctx.Cache[CacheKey];
            }

            return new Player[]
            {
                new Player
                {
                    strategy = "P",
                    Name = "Placeholder"
                }   
            };
        }


       
        /// <summary>
        /// the game logic
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>the winner name and strategy</returns>
        public string game(Player first, Player second) {

            string ganador = "";

            switch (first.strategy) {
                case "P":
                    if (second.strategy.Equals("P")) {
                        ganador += "[''"+ first.Name + ", ''"+first.strategy+"''] wins since "+first.strategy+"=="+second.strategy;
                        break;
                    }
                    else if (second.strategy.Equals("S"))
                    {
                        ganador += "[''" + second.Name + ", ''" + second.strategy + "''] wins since " + first.strategy + "<" + second.strategy;
                        break;
                    }
                    else {
                        ganador += "[''" + first.Name + ", ''" + first.strategy + "''] wins since " + first.strategy + ">" + second.strategy;
                        break;
                    }
                case "S":
                    if (second.strategy.Equals("P"))
                    {
                        ganador += "[''" + first.Name + ", ''" + first.strategy + "''] wins since " + first.strategy + ">" + second.strategy;
                        break;
                    }
                    else if (second.strategy.Equals("R"))
                    {
                        ganador += "[''" + second.Name + ", ''" + second.strategy + "''] wins since " + first.strategy + "<" + second.strategy;
                        break;
                    }
                    else
                    {
                        ganador += "[''" + first.Name + ", ''" + first.strategy + "''] wins since " + first.strategy + "==" + second.strategy;
                        break;
                    }
                case "R":
                    if (second.strategy.Equals("R"))
                    {
                        ganador += "[''" + first.Name + ", ''" + first.strategy + "''] wins since " + first.strategy + "==" + second.strategy;
                        break;
                    }
                    else if (second.strategy.Equals("P"))
                    {
                        ganador += "[''" + second.Name + ", ''" + second.strategy + "''] wins since " + first.strategy + "<" + second.strategy;
                        break;
                    }
                    else
                    {
                        ganador += "[''" + first.Name + ", ''" + first.strategy + "''] wins since " + first.strategy + ">" + second.strategy;
                        break;
                    }
                default:
                    return "";
            }
            return ganador;
        }

        /// <summary>
        /// save the first and the second place
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public bool SaveFirstAndSecond(string first, string second){
            var ctx = HttpContext.Current;
            if (ctx != null)
            {
                try
                {

                    var currentData = ((Player[])ctx.Cache[CacheKey]).ToList();
                    //currentData.Add(player);
                    ctx.Cache[CacheKey] = currentData.ToArray();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// save a player
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool SaveContact(Player player)
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                try
                {
                    var currentData = ((Player[])ctx.Cache[CacheKey]).ToList();
                    currentData.Add(player);
                    ctx.Cache[CacheKey] = currentData.ToArray();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }

            return false;
        }
       /** /// <summary>
        /// get all the elements of an object
        /// </summary>
        /// <returns></returns>
        public Contact[] GetAllContacts()
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
        #endregion


    }
}