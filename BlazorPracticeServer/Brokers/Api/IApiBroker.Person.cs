﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial interface IApiBroker
    {
        ValueTask<IEnumerable<Person>> GetAllPersonAsync();

        ValueTask<Person> GetPersonByIdAsync(int id);

        ValueTask<IEnumerable<Person>> GetAllPeopleByName(string searchText);

        ValueTask<Person> PostPersonAsync(Person movie);

        ValueTask<Person> PutPersonAsync(Person movie, int id);

        ValueTask<Person> DeletePersonAsync(int id);
    }
}
