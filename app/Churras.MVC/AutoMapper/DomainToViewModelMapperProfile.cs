using AutoMapper;
using Churras.Domain.Events;
using Churras.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Churras.MVC.AutoMapper
{
    public class DomainToViewModelMapperProfile : Profile
    {
        public DomainToViewModelMapperProfile()
        {
            CreateMap<Event, EventViewModel>();
            CreateMap<Participant, ParticipantViewModel>();
        }
    }
}