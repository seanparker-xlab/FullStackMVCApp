﻿using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using FullStackMVCAPP.Models;
using FullStackMVCAPP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullStackMVCAPP.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult HouseCharactersIndex(int id)
        {
            GOTContext context = new DataContext.GOTContext();
            CharacterRepository characterRepository = new CharacterRepository();

            CharacterService characterService = new CharacterService(context, characterRepository);

            return View(characterService.GetCharacterByHouseId(id));
        }
    }
}