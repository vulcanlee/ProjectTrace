using AutoMapper;
using ProjectTrace.AccessDatas.Models;
using ProjectTrace.Models.AdapterModel;
using ProjectTrace.Models.Others;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectTrace.Models.Systems;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        #region Blazor AdapterModel

        #region Meeting
        CreateMap<Meeting, MeetingAdapterModel>();
        CreateMap<MeetingAdapterModel, Meeting>();
        #endregion

        #region MyTas
        CreateMap<MyTas, MyTasAdapterModel>();
        CreateMap<MyTasAdapterModel, MyTas>();
        #endregion

        #region Project
        CreateMap<Project, ProjectAdapterModel>();
        CreateMap<ProjectAdapterModel, Project>();
        #endregion

        #region RoleView
        CreateMap<RoleView, RoleViewAdapterModel>();
        CreateMap<RoleViewAdapterModel, RoleView>();
        #endregion

        #region MyUser
        CreateMap<MyUser, MyUserAdapterModel>();
        CreateMap<MyUserAdapterModel, MyUser>();
        CreateMap<MyUserAdapterModel, CurrentUser>()
            .ForMember(dest => dest.RoleJson, opt => opt.Ignore())
            .ForMember(dest => dest.RoleList, opt => opt.Ignore())
            .ForMember(dest => dest.IsAuthenticated, opt => opt.Ignore());
        #endregion
        #endregion
    }
}
