﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeCademyCapstone.Data;
using CodeCademyCapstone.Models;

namespace CodeCademyCapstone.Models
{
    public class PlayerIndex
    {

        // inject the Entity Framework context

        

        public void onGet(CodeCademyCapstoneContext context)

        {

        

            // create a base query that retrieves all players

            var players = from p in context.Players
                          select p;

            // modify the query is the user is searching

            if (!string.IsNullOrEmpty(SearchString))
            {
                players = players.Where(p => p.Name.Contains(SearchString));
            }

            // modify the query is the user is filtering

            if (!string.IsNullOrEmpty(SelectedTeam))
            {
                players = players.Where(p => p.TeamId == SelectedTeam);
            }

            if (!string.IsNullOrEmpty(SelectedPosition))
            {
                players = players.Where(p => p.Position == SelectedPosition);
            }

            // modify the query is the user is sorting

            switch (SortField)
            {
                case "Number": players = players.OrderBy(p => p.Number).ThenBy(p => p.TeamId); break;
                case "Name": players = players.OrderBy(p => p.Name).ThenBy(p => p.TeamId); break;
                case "Position": players = players.OrderBy(p => p.Position).ThenBy(p => p.TeamId); break;
            }

            // make 2 select lists for the filter dropdowns

            IQueryable<string> teamQuery = from t in context.Teams
                                           orderby t.TeamId
                                           select t.TeamId;

            Teams = new SelectList(teamQuery.ToList());

            IQueryable<string> positionQuery = from p in context.Players
                                               orderby p.Position
                                               select p.Position;

            Positions = new SelectList(positionQuery.Distinct().ToList());


            //Fix Later
            FavoriteTeam = FavoriteTeam;

            // finally retrieve any players according to filter, search, and sort options

            Players = players.ToList();

        }

        public List<Player> Players { get; set; }

        // make a series of variables for the filter and search form

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Teams { get; set; }
        public SelectList Positions { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedTeam { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedPosition { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; } = "Name";

        // read the favorite team cookie into this member variable

        public string FavoriteTeam { get; set; }

      

        // return a string for the class of each player <a> tag, bold for starter, gold for favorite

        public string PlayerClass(Player Player)
        {
            string Class = "d-flex";
            if (Player.Depth == 1)
                Class += " starter";
            if (Player.TeamId == FavoriteTeam)
                Class += " favorite";
            return Class;
        }
    }
}

