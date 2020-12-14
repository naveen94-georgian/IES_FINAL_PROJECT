using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnoutDbAPI.Models;

namespace TurnoutDbAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TurnoutController : ControllerBase
    {
        TurnoutDbContext _dBcontext;

        public TurnoutController(TurnoutDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        [Authorize]
        [HttpGet]
        [Produces("application/json")]
        public IActionResult Get()
        {
            var model = new TurnoutViewModel();
            TurnoutData sqlData = new TurnoutData(_dBcontext);
            return Ok(sqlData.GetAll());
        }

        [Authorize]
        [HttpGet("{Id}")]
        [Produces("application/json")]
        public IActionResult Get(String Id)
        {
            var model = new TurnoutViewModel();
            TurnoutData sqlData = new TurnoutData(_dBcontext);

            return Ok(sqlData.Get(Id));
        }



        public class TurnoutData
        {
            private TurnoutDbContext _dBcontext { get; set; }
            public TurnoutData(TurnoutDbContext context)
            {
                _dBcontext = context;
            }

            public Turnout Get(string ID)
            {
                return _dBcontext.Turnouts.FirstOrDefault(e => e.state_id == ID);
            }

            public IEnumerable<Turnout> GetAll()
            {
                return _dBcontext.Turnouts.ToList<Turnout>();
            }
        }

        public class TurnoutViewModel
        {
            public IEnumerable<Turnout> Turnouts { get; set; }
        }
    }
}
