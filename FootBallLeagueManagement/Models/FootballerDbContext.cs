using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Runtime.CompilerServices;
//this namespace is used to inherit FootballerDbContext class

//DBContext class is defined under using System.Data.Entity

namespace FootBallLeagueManagement.Models
{
    //FootballerDbContext class is used becaue the class of football league
    // we have made will convert
    //into table
    /// <summary>
    /// /Footballercontext class help to set data inside databases
    /// </summary>
    public class FootballerDbContext :  DbContext
    {
        //here DbSet is defined inside DbContext
        //here DbSet will store all rows of FootBAllLegue table inside 
        //DataBase
        //now we have to make connection string for that we have to 
        //inside web.Config
       //This DbSet<T> here t can be ny type 
        public DbSet<FootBallLeague> FootBallLeagues { get; set; }

    }
}