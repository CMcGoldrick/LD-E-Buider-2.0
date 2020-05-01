using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lethal.Developer.ViewModels;
using Lethal.Developer.ViewProviders.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lethal.Developer.Controllers
{
    public class RootController : Controller
    {
        private static ITopicProvider _topicProvider;

        public RootController(ITopicProvider topicProvider)
        {
            _topicProvider = topicProvider;
        }

        public Guid UserId => GetUserId();
        public Task<BaseViewModel> BaseViewModel => GetBaseViewModelAsync();

        private async Task<BaseViewModel> GetBaseViewModelAsync()
        {
            try
            {
                var vm = new BaseViewModel();
                var topics = await _topicProvider.GetAllTopicsAsync(UserId);
                vm.Topics = topics;

                return vm;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Guid GetUserId()
        {
            //if (Misc.IsLocal(HttpContext.Connection))
            //    //Do NOT CHANGE THIS.
            //    return "4303387A-23BD-47ED-AE8C-08808BE0785C";

            ////TODO: Move this to config file
            //const string oidClaim = "http://schemas.microsoft.com/identity/claims/objectidentifier";

            ////could not find user id
            //if (!(User.Identity is ClaimsIdentity claimsIdentity))
            //    throw new ArgumentException("Error - Could not find UserId");

            //string userId = null;
            //if (claimsIdentity.Claims.Any())
            //    userId = claimsIdentity.FindFirst(oidClaim).Value;

            //return string.IsNullOrEmpty(userId) ? null : userId;

            //Do NOT CHANGE THIS.
            return Guid.Parse("9776506B-8CFE-448F-1BF5-08D7DCE61A3B");
        }

    }
}