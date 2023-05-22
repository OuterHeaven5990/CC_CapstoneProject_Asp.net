using System;
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
    public class TeamIndex
    {


        // load all leagues, conferences, and divisions
        public List<Conference> Conferences { get; set; }
        public List<Division> Divisions { get; set; }
        public List<Team> Teams { get; set; }

        //allow storage of a favorite team

        [BindProperty(SupportsGet = true)]
        public string FavoriteTeam { get; set; }

        public SelectList AllTeams { get; set; }

        public ICollection<Player> Players { get; set; }

        public TeamIndex(CodeCademyCapstoneContext context)
        {
            // load all records from 3 tables

            Conferences = context.Conferences.ToList();
            Divisions = context.Divisions.ToList();
            Teams = context.Teams.ToList();

            // make a list of teams for the favorite select dropdown

            IQueryable<string> teamQuery = from t in context.Teams
                                           orderby t.TeamId
                                           select t.TeamId;

            AllTeams = new SelectList(teamQuery.ToList());


        }

        // get all divisions in a conference and sort them

        public List<Division> GetConferenceDivisions(string ConferenceId)
        {
            return Divisions.Where(d => d.ConferenceId.Equals(ConferenceId)).OrderBy(d => d.Name).ToList();
        }

        // get all teams in a division and sort them

        public List<Team> GetDivisionTeams(string DivisionId)
        {
            return Teams.Where(t => t.DivisionId.Equals(DivisionId)).OrderByDescending(t => t.Win).ToList();
        }
    }
}
