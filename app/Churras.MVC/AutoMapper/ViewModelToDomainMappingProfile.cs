using AutoMapper;
using Churras.Domain.Events;
using Churras.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Churras.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EventViewModel, Event>();
            CreateMap<ParticipantViewModel, Participant>();
        }
    }
}