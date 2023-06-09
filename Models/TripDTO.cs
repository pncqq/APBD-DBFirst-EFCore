﻿using WebApplication1.DAL;

namespace WebApplication1.Models;

public class TripModel
{
    public int IdTrip { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public int MaxPeople { get; set; }

    public virtual ICollection<ClientTrip> Clients { get; set; } = new List<ClientTrip>();

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}