using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Services;

namespace Conferences.Controllers
{
    public class ConferenceController: Controller
    {
        public ConferenceController(IConferenceService conferenceService)
        {

        }
    }
}
