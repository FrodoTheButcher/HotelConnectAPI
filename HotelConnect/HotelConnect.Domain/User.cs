﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.Domain
{
  public class User
  {
    public string Id { get; set; }

    public string Email { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public int Age { get; set; }

    public int WorkExperience { get; set; }
  }
}
