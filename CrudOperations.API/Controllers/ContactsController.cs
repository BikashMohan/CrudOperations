using CrudOperations.Interfaces;
using CrudOperations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudOperations.API.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            this._contactService = contactService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Contact contact)
        {
            await _contactService.AddContact(contact);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetContactDetails()
        {
            var contactDetails = await _contactService.GetContactDetails();
            return Ok(contactDetails);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetContact(Guid id)
        {
            var contactDetails = await _contactService.GetContact(id);
            return Ok(contactDetails);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, Contact contact)
        {
            await _contactService.UpdateContact(id,contact);
            return Ok();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteContact([FromRoute] Guid id)
        {
            await _contactService.DeleteContact(id);
            return Ok();
        }
    }
}
