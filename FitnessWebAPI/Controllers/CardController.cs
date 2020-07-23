using AutoMapper;
using FitnessWebAPI.Entities;
using FitnessWebAPI.ExternalModels;
using FitnessWebAPI.Services.UnitsOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FitnessWebAPI.Controllers
{
    [Route("card")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardUnitOfWork _cardUnit;
        private readonly IMapper _mapper;

        public CardController(ICardUnitOfWork cardUnit,
            IMapper mapper)
        {
            _cardUnit = cardUnit ?? throw new ArgumentNullException(nameof(cardUnit));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        #region Cards
        [HttpGet]
        [Route("{id}", Name = "GetCard")]
        public IActionResult GetCard(Guid id)
        {
            var cardEntity = _cardUnit.Cards.Get(id);
            if (cardEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CardDTO>(cardEntity));
        }

        [HttpGet]
        [Route("details/{id}", Name = "GetCardDetails")]
        public IActionResult GetBookDetails(Guid id)
        {
            var cardEntity = _cardUnit.Cards.GetCardDetails(id);
            if (cardEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CardDTO>(cardEntity));
        }

        [Route("add", Name = "Add a new card")]
        [HttpPost]
        public IActionResult AddCard([FromBody] CardDTO card)
        {
            var cardEntity = _mapper.Map<Card>(card);
            _cardUnit.Cards.Add(cardEntity);

            _cardUnit.Complete();

            _cardUnit.Cards.Get(cardEntity.ID);

            return CreatedAtRoute("GetCard",
                new { id = cardEntity.ID },
                _mapper.Map<CardDTO>(cardEntity));
        }
        #endregion Cards

        #region Valability
        [HttpGet]
        [Route("valability/{ValabilityID}", Name = "GetValability")]
        public IActionResult GetValability(Guid ValabilityID)
        {
            var valabilityEntity = _cardUnit.Valability.Get(ValabilityID);
            if (valabilityEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ValabilityDTO>(valabilityEntity));
        }

        [HttpGet]
        [Route("valability", Name = "GetAllValability")]
        public IActionResult GetAllValability()
        {
            var valabilityEntities = _cardUnit.Valability.Find(a => a.Deleted == false || a.Deleted == null);
            if (valabilityEntities == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<ValabilityDTO>>(valabilityEntities));
        }

        [Route("valability/add", Name = "Add a new valability")]
        [HttpPost]
        public IActionResult AddValability([FromBody] ValabilityDTO valability)
        {
            var valabilityEntity = _mapper.Map<Valability>(valability);
            _cardUnit.Valability.Add(valabilityEntity);

            _cardUnit.Complete();

            _cardUnit.Valability.Get(valabilityEntity.ID);

            return CreatedAtRoute("GetValability",
                new { valabilityId = valabilityEntity.ID },
                _mapper.Map<ValabilityDTO>(valabilityEntity));
        }

        [Route("valability/{ValabilityID}", Name = "Mark valability as deleted")]
        [HttpPut]
        public IActionResult MarkValabilityAsDeleted(Guid ValabilityID)
        {
            var valability = _cardUnit.Valability.FindDefault(a => a.ID.Equals(ValabilityID) && (a.Deleted == false || a.Deleted == null));
            if (valability != null)
            {
                valability.Deleted = true;
                if (_cardUnit.Complete() > 0)
                {
                    return Ok("Valability " + ValabilityID + " was deleted.");
                }
            }
            return NotFound();
        }
        #endregion Valability
    }
}