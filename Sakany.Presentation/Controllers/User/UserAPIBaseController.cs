using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sakany.Presentation.Controllers.Base;

namespace Sakany.Presentation.Controllers.User
{
    [Route("Api/V{version:apiVersion}/User/[controller]")]
    public class UserAPIBaseController : APIBaseController
    {
        #region Constructors

        public UserAPIBaseController(IMediator mediator) : base(mediator)
        {
        }

        #endregion Constructors
    }
}